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
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AvionicsInstrumentControlDemo
{
    public partial class DemoWinow : Form
    {
        MouseEventArgs mouseDownLocation;

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
                }
                else
                    this.WindowState = FormWindowState.Maximized;
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
            if(this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else if(this.WindowState == FormWindowState.Normal)
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }
    }
}