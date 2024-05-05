using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvionicsInstrumentControlDemo
{
    public partial class UgvInf : Form
    {
        private int panelHeight;
        private int panelWidth;
        private int thisFormHeight;
        private int thisFormWidth;
        LedStates previousLedState = LedStates.LEDS_OFF;
        GpsState previousGpsState = GpsState.NO_CONNECTION;
        int previousSatelliteNumber = 0;

        public UgvInf()
        {
            InitializeComponent();
        }

        public void formResize(int aPanelHeight, int aPanelWidth, bool firstInit = false)
        {
            thisFormHeight = this.Height;
            thisFormWidth = this.Width;

            panelHeight = aPanelHeight;
            panelWidth = aPanelWidth;

            this.AutoScroll = false;
            this.AutoSize = false;

            this.Height = panelHeight;
            this.Width = panelWidth;

            if (firstInit == true)
            {
                /*
                 * ilk başta bütün objelerin boyutlarını al, bunları kalibrasyon yaparken kullan
                 */
            }

            foreach (Control control in this.Controls)
            {
                resize(control);
            }
        }

        private void resize(Control formObject)
        {
            float heightRatio = (float)panelHeight / (float)thisFormHeight;
            float widthRatio = (float)panelWidth / (float)thisFormWidth;

            int comboboxHeight = (int)(formObject.Height * heightRatio);
            formObject.Height = (int)(formObject.Height * heightRatio);
            formObject.Width = (int)(formObject.Width * widthRatio);

            //if (formObject is ComboBox)
            //{
            //    SendMessage(((ComboBox)formObject).Handle, CB_SETITEMHEIGHT, -1, comboboxHeight);
            //}

            int xLocation = (int)(formObject.Location.X * widthRatio);
            int yLocation = (int)(formObject.Location.Y * heightRatio);

            formObject.Location = new Point(xLocation, yLocation);
        }

        public void updateLedStatus(LedStates ledStates)
        {
            if (ledStates != previousLedState)
            {
                string path = @"C:\Users\Mehmet Dincer\Desktop\Bitirme\Kodlar\arayuz\AvionicsInstrumentControlDemo_Source\AvionicsInstrumentControlDemo\Images\Picture";
                path += ((int)ledStates).ToString() + ".png";
                pictureBoxLedStatus.Image = Image.FromFile(path);

                previousLedState = ledStates;
            }
        }

        public void updateGpsStatus(GpsState gpsState)
        {
            if(gpsState != previousGpsState)
            {
                string path = string.Empty;

                if (gpsState != GpsState.POSITION_FIXED)
                {
                    path = @"C:\Users\Mehmet Dincer\Desktop\Bitirme\Kodlar\arayuz\AvionicsInstrumentControlDemo_Source\AvionicsInstrumentControlDemo\Images\Gps0.png";
                }
                else
                {
                    path = @"C:\Users\Mehmet Dincer\Desktop\Bitirme\Kodlar\arayuz\AvionicsInstrumentControlDemo_Source\AvionicsInstrumentControlDemo\Images\Gps1.png";
                }

                pictureBoxGpsStatus.Image = Image.FromFile(path);
                previousGpsState = gpsState;
            }
        }

        public void updateSatelliteNumber(int  satelliteNumber)
        {

            if (satelliteNumber != previousSatelliteNumber)
            {
                labelGpsNumber.Text = $"Satellite Number: {satelliteNumber}";

                previousSatelliteNumber = satelliteNumber;
            }
        }
    }
}
