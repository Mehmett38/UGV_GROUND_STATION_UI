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
        MouseEventArgs mouseDownLocation;
        bool serialPortConnectionFlag = false;
        Crc crc;
        int receiverBufferCleanLen = 1000;
        int receiverBufferCounter = 0;
        int packetCounter;

        public DemoWinow()
        {
            InitializeComponent();
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;

            gMapControl.MapProvider = GMapProviders.GoogleMap;
            gMapControl.MinZoom = 3;
            gMapControl.MaxZoom = 100;
            gMapControl.Zoom = 8;
            gMapControl.Position = new PointLatLng(38.7, 35.55);
            
            crc = new Crc();
            serialComForm = new SerialCom(this);
            serialPortUgv.ReadBufferSize = 8198;
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
                }
                else
                {
                    this.WindowState = FormWindowState.Maximized;
                    serialComForm.formResize(tabPageSerialPort.Height, tabPageSerialPort.Width);
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
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
                serialComForm.formResize(tabPageSerialPort.Height, tabPageSerialPort.Width);
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
        
        private void serialPortUgv_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            //int rxByte = serialPortUgv.ReadByte();
            //CircularBuffer.pushData((byte)rxByte);

            //if (CircularBuffer.isDataReady((byte)rxByte))
            //{
            //    //label2.Invoke(new Action(() => label2.Text = (counter++).ToString()));

            //}

            //byte[] rxByte = new byte[25];
            //serialPortUgv.Read(rxByte, 0, 25);

            //string str = serialPortUgv.ReadExisting();
            //byte [] line = Encoding.UTF8.GetBytes(serialPortUgv.ReadExisting());


            //if (line.Length == 24)
            //{
            //    byte[] bytes = Encoding.UTF8.GetBytes(line);

            //    CircularBuffer.pushData(bytes);
            //}

            //if (CircularBuffer.isDataReady())
            //{
            //    label2.Invoke(new Action(() => label2.Text = (counter++).ToString()));

            //}

            //packetCounter += line.Length;

            int bitNum = serialPortUgv.BytesToRead;
            byte[] buffer = new byte[bitNum];
            serialPortUgv.Read(buffer, 0, buffer.Length);

            CircularBuffer.pushData(buffer, buffer.Length);

            if(CircularBuffer.isDataReady())
            {
                serialComForm.updataPacketNum(packetCounter++);
            }

            serialPortUgv.DiscardInBuffer();
        }
    }
}