/*****************************************************************************/
/* Project  : AvionicsInstrumentControlDemo                                  */
/* File     : DemoWondow.cs                                                  */
/* Version  : 1                                                              */
/* Language : C#                                                             */
/* Summary  : Start window of the project, use to test the instruments       */
/* Creation : 30/06/2008                                                     */
/* Autor    : Guillaume CHOUTEAU                                             */
/* History  :                                                                */
/*****************************************************************************/

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO.Ports;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace AvionicsInstrumentControlDemo
{
    public partial class DemoWinow : Form
    {
        SerialCom serialComForm;
        UgvInf ugvInfForm;
        MouseEventArgs mouseDownLocation;
        bool serialPortConnectionFlag = false;
        bool updateFlag = false;
        Crc crc;
        int receiverBufferCleanLen = 1000;
        int receiverBufferCounter = 0;
        int packetCounter;
        Stack<UgvDatas> ugvDatasList;

        //1. create a overlay
        GMapOverlay markers = new GMapOverlay("markers");
        PointLatLng previousLatLon;

        public DemoWinow()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            gmapSetting();

            crc = new Crc();
            serialComForm = new SerialCom(this);
            ugvInfForm = new UgvInf();
            serialPortUgv.ReadBufferSize = 8198;
            ugvDatasList = new Stack<UgvDatas>();
            timerUpdate.Start();

            this.Load += DemoWinow_Load;
        }

        private void DemoWinow_Load(object sender, EventArgs e)
        {
            ugvInfForm.TopLevel = false;
            //serialCom.Dock = DockStyle.Fill;
            ugvInfForm.AutoScroll = false;
            tabUgv.Controls.Add(ugvInfForm);
            ugvInfForm.Show();
            ugvInfForm.formResize(tabControlUgv.Height, tabControlUgv.Width, true);
        }

        private void gmapSetting()
        {
            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.MinZoom = 3;
            gMapControl.MaxZoom = 100;
            gMapControl.Zoom = 20;
            gMapControl.DragButton = MouseButtons.Left;
            gMapControl.Position = new PointLatLng(39.77968587, 32.8170593);

            previousLatLon = gMapControl.Position;

            ///*create marker*/
            //PointLatLng location = new PointLatLng(38.64998025, 35.62260165);
            ////Bitmap bmpMarker = (Bitmap)Image.FromFile(@"C:\Users\Mehmet Dincer\Desktop\Bitirme\Kodlar\arayuz\AvionicsInstrumentControlDemo_Source\AvionicsInstrumentControlDemo\Images\Picture3.jpg");
            //GMapMarker gMapMarker = new GMarkerGoogle(location, GMarkerGoogleType.red_big_stop);
            ////GMapMarker gMapMarker = new GMarkerGoogle(location, bmpMarker);

            ////1. create a overlay
            ////GMapOverlay markers = new GMapOverlay("markers");
            ////2. add all available markers to that overlay
            //markers.Markers.Add(gMapMarker);
            ////3. Cover map with Overlay
            //gMapControl.Overlays.Add(markers);
        }
            
        private void clickEvent(object sender, EventArgs e)
        {
            if (sender == pictureBoxClose)
            {
                this.Close();
            }
            else if (sender == pictureBoxScale)
            {
                if (this.WindowState == FormWindowState.Maximized)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.Location = new Point(100, 50);
                    serialComForm.formResize(tabPageSerialPort.Height, tabPageSerialPort.Width);
                    ugvInfForm.formResize(tabUgv.Height, tabUgv.Width, true);
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    serialComForm.formResize(tabPageSerialPort.Height, tabPageSerialPort.Width);
                    ugvInfForm.formResize(tabUgv.Height, tabUgv.Width, true);
                }
            }
            else if (sender == pictureBoxMinimize)
            {
                this.WindowState = FormWindowState.Minimized;
            }
        }

        private void mauseHoverEvent(object sender, EventArgs e)
        {
            if (sender == pictureBoxClose)
            {
                pictureBoxClose.BackColor = Color.Red;
            }
            else if (sender == pictureBoxScale)
            {
                pictureBoxScale.BackColor = Color.Blue;
            }
            else if (sender == pictureBoxMinimize)
            {
                pictureBoxMinimize.BackColor = Color.Green;
            }
        }

        private void mauseLeaveEvent(object sender, EventArgs e)
        {
            if (sender == pictureBoxClose)
            {
                pictureBoxClose.BackColor = Color.Black;
            }
            else if (sender == pictureBoxScale)
            {
                pictureBoxScale.BackColor = Color.Black;
            }
            else if (sender == pictureBoxMinimize)
            {
                pictureBoxMinimize.BackColor = Color.Black;
            }
        }

        private void mauseDownEvent(object sender, MouseEventArgs e)
        {
            if (sender == panelUp)
            {
                mouseDownLocation = e;
            }
        }
        private void mauseMoveEvent(object sender, MouseEventArgs e)
        {
            if (sender == panelUp)
            {
                if (this.WindowState == FormWindowState.Normal)
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        this.Left = e.X + this.Left - mouseDownLocation.X;
                        this.Top = ((e.Y + this.Top - mouseDownLocation.Y) < 0) ? 0 : (e.Y + this.Top - mouseDownLocation.Y);
                    }
                }
            }
        }

        private void panelUp_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
                this.Location = new Point(100, 50);
                serialComForm.formResize(tabPageSerialPort.Height, tabPageSerialPort.Width);
                ugvInfForm.formResize(tabUgv.Height, tabUgv.Width, true);
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                serialComForm.formResize(tabPageSerialPort.Height, tabPageSerialPort.Width);
                ugvInfForm.formResize(tabUgv.Height, tabUgv.Width, true);
            }
        }

        private void tabControlUgv_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (tabControlUgv.SelectedTab == tabPageSerialPort)
            {
                serialComForm.TopLevel = false;
                //serialCom.Dock = DockStyle.Fill;
                serialComForm.AutoScroll = false;
                tabPageSerialPort.Controls.Add(serialComForm);
                serialComForm.Show();

                serialComForm.formResize(tabPageSerialPort.Height, tabPageSerialPort.Width, true);
            }
        }

        public bool serialPortConnect(SerialConnection serialPort)
        {
            try
            {
                serialPortUgv.PortName = serialPort.portName;
                serialPortUgv.BaudRate = serialPort.baudrate;
                serialPortUgv.DataBits = serialPort.dataBits;
                serialPortUgv.Parity = serialPort.parity;
                serialPortUgv.StopBits = serialPort.stopBit;

                serialPortUgv.Open();
                serialPortUgv.DiscardInBuffer();
                serialPortConnectionFlag = true;
                return true;
            }
            catch (Exception)
            {
                serialPortConnectionFlag = false;
                return false;
                throw;
            }
        }

        public void resetPacketCounter()
        {
            packetCounter = 0;
        }

        public bool closeSerialPort()
        {
            try
            {
                serialPortUgv.Close();
                serialPortConnectionFlag = false;
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
                throw;
            }
        }

        private void serialPortUgv_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            int bitNum = serialPortUgv.BytesToRead;
            byte[] buffer = new byte[bitNum];
            serialPortUgv.Read(buffer, 0, buffer.Length);

            CircularBuffer.pushData(buffer, buffer.Length);

            if (CircularBuffer.isDataReady())
            {
                ugvDatasList.Push(CircularBuffer.getParsedDatas());
                serialComForm.updataPacketNum(packetCounter++);
                updateFlag = true;
            }

            serialPortUgv.DiscardInBuffer();
        }

        private void timerUpdate_Tick(object sender, EventArgs e)
        {
            if (updateFlag)
            {
                UgvDatas ugv = ugvDatasList.Pop();

                /*change the led status*/
                ugvInfForm.updateLedStatus(ugv.ledState);

                /*change the azimuth*/
                headingIndicatorInstrumentControl1.SetHeadingIndicatorParameters(ugv.azimuth);

                if(ugv.gpsState == GpsState.POSITION_FIXED)
                {
                    /*set the postion*/
                    double posLat = ugv.latitudeDegree + ugv.latitudeMinute / 60.0d + ugv.latitudeSecond / 3600.0d;
                    double poslon = ugv.longitudeDegree + ugv.longitudeMinute / 60.0d + ugv.longitudeSecond / 3600.0d;

                    gMapControl.Position = new PointLatLng(posLat, poslon);


                    /*set the speed*/
                    if (ugv.speed < 0.5f)
                    {
                        ugv.speed = 0;
                    }
                    airSpeedIndicatorInstrumentControl1.SetAirSpeedIndicatorParameters((int)(ugv.speed * 100));

                    /*set the connection state*/
                    ugvInfForm.updateGpsStatus(ugv.gpsState);

                    /*set the satellite number*/
                    ugvInfForm.updateSatelliteNumber(ugv.numberOfSatellite);
                }
                else
                {

                    airSpeedIndicatorInstrumentControl1.SetAirSpeedIndicatorParameters(0);

                    /*set the connection state*/
                    ugvInfForm.updateGpsStatus(GpsState.NO_CONNECTION);

                    /*set the satellite number*/
                    ugvInfForm.updateSatelliteNumber(0);
                }

                updateFlag = false;
            }
        }

        private void pictureBox1_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void pictureBox1_MouseLeave(object sender, EventArgs e)
        {
            Cursor= Cursors.Default;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(sender ==  pictureBoxPlus)
            {
                gMapControl.Zoom += 1;
            }
            else if(sender == pictureBoxMinus) 
            {
                gMapControl.Zoom -= 1;
            }
        }

        private void gMapControl_MouseMove(object sender, MouseEventArgs e)
        {
            double latPos = gMapControl.Position.Lat;
            double lonPos = gMapControl.Position.Lng;

            labelPosition.Text = latPos + "  --  " + lonPos;

            previousLatLon = ((GMapControl)sender).Position;
        }

        private void gMapControl_DoubleClick(object sender, EventArgs e)
        {
            GMapControl map = (GMapControl)sender;

            /*create marker*/
            PointLatLng location = map.Position;
            GMapMarker gMapMarker = new GMarkerGoogle(location, GMarkerGoogleType.red_big_stop);

            //2. add all available markers to that overlay
            markers.Markers.Add(gMapMarker);
            //3. Cover map with Overlay
            gMapControl.Overlays.Add(markers);
        }

        private void gMapControl_OnMapZoomChanged()
        {
            gMapControl.Position = previousLatLon;
            previousLatLon =  gMapControl.Position;
        }
    }
}