using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AvionicsInstrumentControlDemo
{
    public partial class SerialCom : Form
    {
        DemoWinow demWin;
        private int panelHeight;
        private int panelWidth;
        private int thisFormHeight;
        private int thisFormWidth;
        int portNumber;
        string[] portNames;
        private UgvDatas ugvDatas;

        [DllImport("user32.dll")]
        static extern IntPtr SendMessage(IntPtr hWnd, UInt32 Msg, Int32 wParam, Int32 lParam);
        private const Int32 CB_SETITEMHEIGHT = 0x153;

        public SerialCom(DemoWinow form)
        {
            InitializeComponent();

            demWin = form; 
            buttonConnect.Location = new Point(145, 175);
            buttonDisconnect.Visible = false;
            //buttonConnect.Location = new Point(90, 175
            //buttonDisconnect.Location = new Point(200, 175);

            portNames = SerialPort.GetPortNames();
            portNumber = portNames.Length;
            foreach (string portName in portNames)
            {
                comboBoxPortName.Items.Add(portName);
            }

            comboBoxPortName.SelectedIndex = 0;
            comboBoxPortName.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxBaudRate.SelectedIndex = 13;
            comboBoxBaudRate.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxDataBits.SelectedIndex = 3;
            comboBoxDataBits.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxParity.SelectedIndex = 0;
            comboBoxParity.DropDownStyle = ComboBoxStyle.DropDownList;

            comboBoxStopBits.SelectedIndex = 1;
            comboBoxStopBits.DropDownStyle= ComboBoxStyle.DropDownList;

            timerPortCheck.Start();
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

            if(firstInit == true)
            {
                /*
                 * ilk başta bütün objelerin boyutlarını al, bunları kalibrasyon yaparken kullan
                 */
            }

            foreach (Control control in this.Controls)
            {
                resize(control);
            }

            for(int i = 0; i < this.Controls.Count; i++)
            {
                foreach (Control control in this.Controls[i].Controls)
                {
                    resize(control);
                }
            }
        }

        private void resize(Control formObject)
        {
            float heightRatio = (float)panelHeight / (float)thisFormHeight;
            float widthRatio = (float)panelWidth / (float)thisFormWidth;

            int comboboxHeight = (int)(formObject.Height * heightRatio);
            formObject.Height = (int)(formObject.Height * heightRatio);
            formObject.Width  = (int)(formObject.Width * widthRatio);

            //if (formObject is ComboBox)
            //{
            //    SendMessage(((ComboBox)formObject).Handle, CB_SETITEMHEIGHT, -1, comboboxHeight);
            //}

            int xLocation = (int)(formObject.Location.X * widthRatio);
            int yLocation = (int)(formObject.Location.Y * heightRatio);

            formObject.Location = new Point(xLocation, yLocation);
        }

        private void buttonConnect_Click(object sender, EventArgs e)
        {
            SerialConnection serialConnect = new SerialConnection();

            try
            {
                serialConnect.portName = comboBoxPortName.Text;
                serialConnect.baudrate = int.Parse(comboBoxBaudRate.Text);
                serialConnect.dataBits = int.Parse(comboBoxDataBits.Text);
                serialConnect.parity = (Parity)(comboBoxParity.SelectedIndex);
                serialConnect.stopBit = (StopBits)(comboBoxStopBits.SelectedIndex);



                if (demWin.serialPortConnect(serialConnect))
                {
                    buttonConnect.Location = new Point(130, 150);
                    buttonConnect.Enabled = false;
                    buttonConnect.BackColor = Color.Green;

                    buttonDisconnect.Visible = true;
                    buttonDisconnect.Location = new Point(300, 150);

                    //buttonConnect.BackColor = Color.FromArgb(253, 253, 253);
                    //buttonConnect.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Check The Configurations","Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void updataPacketNum(int count)
        {
            labelPacketNum.Invoke(new Action(() => labelPacketNum.Text = ($"Total Packet Number : {count.ToString()}")));
        }
        private void buttonDisconnect_Click(object sender, EventArgs e)
        {
            if(demWin.closeSerialPort())
            {
                buttonConnect.Location = new Point(220, 150);
                buttonConnect.Enabled = true;
                buttonConnect.BackColor = Color.FromArgb(253, 253, 253);

                buttonDisconnect.Visible = false;
            }
        }

        private void timerPortCheck_Tick(object sender, EventArgs e)
        {
            string[] scanPortNames = SerialPort.GetPortNames();

            if(portNumber != scanPortNames.Length)
            {
                comboBoxPortName.Items.Clear();

                Array.Sort(scanPortNames);

                foreach(string scanPortName in scanPortNames)
                {
                    comboBoxPortName.Items.Add(scanPortName);
                }

                portNumber = scanPortNames.Length;
                comboBoxPortName.SelectedIndex = 0;
            }
        }

        private void roundPictureBoxReset_Click(object sender, EventArgs e)
        {
            demWin.resetPacketCounter();
            labelPacketNum.Text = "Total Packet Number : 0";
        }
    }
}
