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
    public partial class SerialCom : Form
    {
        private int panelHeight;
        private int panelWidth;
        private int thisFormHeight;
        private int thisFormWidth;
        public SerialCom()
        {
            InitializeComponent();

        }

        public void formResize(int panelHeight, int panelWidth)
        {
            thisFormHeight = this.Height;
            thisFormWidth = this.Width;

            this.panelHeight = panelHeight;
            this.panelWidth = panelWidth;

            this.Height = panelHeight;
            this.Width = panelWidth;

            foreach (Control control in this.Controls)
            {
                resize(control);
            }
        }

        private void resize(Control formObject)
        {
            float heightRatio = (float)panelHeight / (float)thisFormHeight;
            float widthRatio = (float)panelWidth / (float)thisFormWidth;

            formObject.Height = (int)(formObject.Height * heightRatio);
            formObject.Width  = (int)(formObject.Width * widthRatio);

            int xLocation = (int)(formObject.Location.X * widthRatio);
            int yLocation = (int)(formObject.Location.Y * heightRatio);

            formObject.Location = new Point(xLocation, yLocation);
        }
    }
}
