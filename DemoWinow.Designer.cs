namespace AvionicsInstrumentControlDemo
{
    partial class DemoWinow
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DemoWinow));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.serialPortUgv = new System.IO.Ports.SerialPort(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.tabPageSerialPort = new System.Windows.Forms.TabPage();
            this.tabUgv = new System.Windows.Forms.TabPage();
            this.tabControlUgv = new System.Windows.Forms.TabControl();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxScale = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.panelUp = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.airSpeedIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.AirSpeedIndicatorInstrumentControl();
            this.headingIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl();
            this.turnCoordinatorInstrumentControl1 = new AvionicsInstrumentControlDemo.TurnCoordinatorInstrumentControl();
            this.attitudeIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl();
            this.panel1.SuspendLayout();
            this.tabControlUgv.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            this.panelUp.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.airSpeedIndicatorInstrumentControl1);
            this.panel1.Controls.Add(this.headingIndicatorInstrumentControl1);
            this.panel1.Controls.Add(this.turnCoordinatorInstrumentControl1);
            this.panel1.Controls.Add(this.attitudeIndicatorInstrumentControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 49);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 782);
            this.panel1.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.SizeAll;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(267, 513);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 22);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            // 
            // serialPortUgv
            // 
            this.serialPortUgv.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortUgv_DataReceived);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 25;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
            // 
            // tabPageSerialPort
            // 
            this.tabPageSerialPort.Location = new System.Drawing.Point(4, 25);
            this.tabPageSerialPort.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSerialPort.Name = "tabPageSerialPort";
            this.tabPageSerialPort.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSerialPort.Size = new System.Drawing.Size(550, 213);
            this.tabPageSerialPort.TabIndex = 1;
            this.tabPageSerialPort.Text = "Serial Port";
            this.tabPageSerialPort.UseVisualStyleBackColor = true;
            // 
            // tabUgv
            // 
            this.tabUgv.BackColor = System.Drawing.SystemColors.Control;
            this.tabUgv.Location = new System.Drawing.Point(4, 25);
            this.tabUgv.Margin = new System.Windows.Forms.Padding(4);
            this.tabUgv.Name = "tabUgv";
            this.tabUgv.Padding = new System.Windows.Forms.Padding(4);
            this.tabUgv.Size = new System.Drawing.Size(760, 181);
            this.tabUgv.TabIndex = 0;
            this.tabUgv.Text = "UGV";
            // 
            // tabControlUgv
            // 
            this.tabControlUgv.Controls.Add(this.tabUgv);
            this.tabControlUgv.Controls.Add(this.tabPageSerialPort);
            this.tabControlUgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUgv.Location = new System.Drawing.Point(0, 0);
            this.tabControlUgv.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlUgv.Name = "tabControlUgv";
            this.tabControlUgv.SelectedIndex = 0;
            this.tabControlUgv.Size = new System.Drawing.Size(768, 210);
            this.tabControlUgv.TabIndex = 7;
            this.tabControlUgv.SelectedIndexChanged += new System.EventHandler(this.tabControlUgv_SelectedIndexChanged);
            // 
            // gMapControl
            // 
            this.gMapControl.Bearing = 0F;
            this.gMapControl.CanDragMap = true;
            this.gMapControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gMapControl.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl.GrayScaleMode = false;
            this.gMapControl.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl.LevelsKeepInMemmory = 5;
            this.gMapControl.Location = new System.Drawing.Point(0, 210);
            this.gMapControl.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gMapControl.MarkersEnabled = true;
            this.gMapControl.MaxZoom = 2;
            this.gMapControl.MinZoom = 2;
            this.gMapControl.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl.Name = "gMapControl";
            this.gMapControl.NegativeMode = false;
            this.gMapControl.PolygonsEnabled = true;
            this.gMapControl.RetryLoadTile = 0;
            this.gMapControl.RoutesEnabled = true;
            this.gMapControl.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl.ShowTileGridLines = false;
            this.gMapControl.Size = new System.Drawing.Size(1418, 572);
            this.gMapControl.TabIndex = 0;
            this.gMapControl.Zoom = 0D;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.gMapControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(325, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1418, 782);
            this.panel3.TabIndex = 6;
            // 
            // pictureBoxClose
            // 
            this.pictureBoxClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxClose.Image")));
            this.pictureBoxClose.Location = new System.Drawing.Point(1707, 2);
            this.pictureBoxClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxClose.Name = "pictureBoxClose";
            this.pictureBoxClose.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxClose.TabIndex = 5;
            this.pictureBoxClose.TabStop = false;
            this.pictureBoxClose.Click += new System.EventHandler(this.clickEvent);
            this.pictureBoxClose.MouseLeave += new System.EventHandler(this.mauseLeaveEvent);
            this.pictureBoxClose.MouseHover += new System.EventHandler(this.mauseHoverEvent);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(249, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "UGV GROUND CONTROL";
            // 
            // pictureBoxScale
            // 
            this.pictureBoxScale.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxScale.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxScale.Image")));
            this.pictureBoxScale.Location = new System.Drawing.Point(1664, 2);
            this.pictureBoxScale.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxScale.Name = "pictureBoxScale";
            this.pictureBoxScale.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxScale.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxScale.TabIndex = 5;
            this.pictureBoxScale.TabStop = false;
            this.pictureBoxScale.Click += new System.EventHandler(this.clickEvent);
            this.pictureBoxScale.MouseLeave += new System.EventHandler(this.mauseLeaveEvent);
            this.pictureBoxScale.MouseHover += new System.EventHandler(this.mauseHoverEvent);
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinimize.BackColor = System.Drawing.Color.Black;
            this.pictureBoxMinimize.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMinimize.Image")));
            this.pictureBoxMinimize.Location = new System.Drawing.Point(1619, 4);
            this.pictureBoxMinimize.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(32, 32);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinimize.TabIndex = 5;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.clickEvent);
            this.pictureBoxMinimize.MouseLeave += new System.EventHandler(this.mauseLeaveEvent);
            this.pictureBoxMinimize.MouseHover += new System.EventHandler(this.mauseHoverEvent);
            // 
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.Black;
            this.panelUp.Controls.Add(this.panel2);
            this.panelUp.Controls.Add(this.pictureBoxMinimize);
            this.panelUp.Controls.Add(this.pictureBoxScale);
            this.panelUp.Controls.Add(this.label1);
            this.panelUp.Controls.Add(this.pictureBoxClose);
            this.panelUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelUp.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panelUp.Location = new System.Drawing.Point(0, 0);
            this.panelUp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelUp.Name = "panelUp";
            this.panelUp.Size = new System.Drawing.Size(1743, 49);
            this.panelUp.TabIndex = 2;
            this.panelUp.DoubleClick += new System.EventHandler(this.panelUp_DoubleClick);
            this.panelUp.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mauseDownEvent);
            this.panelUp.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mauseMoveEvent);
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(283, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(344, 244);
            this.panel2.TabIndex = 1;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.tabControlUgv);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(650, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(768, 210);
            this.panel4.TabIndex = 8;
            // 
            // airSpeedIndicatorInstrumentControl1
            // 
            this.airSpeedIndicatorInstrumentControl1.Location = new System.Drawing.Point(37, 774);
            this.airSpeedIndicatorInstrumentControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.airSpeedIndicatorInstrumentControl1.Name = "airSpeedIndicatorInstrumentControl1";
            this.airSpeedIndicatorInstrumentControl1.Size = new System.Drawing.Size(267, 255);
            this.airSpeedIndicatorInstrumentControl1.TabIndex = 0;
            this.airSpeedIndicatorInstrumentControl1.Text = "airSpeedIndicatorInstrumentControl1";
            // 
            // headingIndicatorInstrumentControl1
            // 
            this.headingIndicatorInstrumentControl1.Location = new System.Drawing.Point(37, 516);
            this.headingIndicatorInstrumentControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.headingIndicatorInstrumentControl1.Name = "headingIndicatorInstrumentControl1";
            this.headingIndicatorInstrumentControl1.Size = new System.Drawing.Size(267, 255);
            this.headingIndicatorInstrumentControl1.TabIndex = 0;
            this.headingIndicatorInstrumentControl1.Text = "headingIndicatorInstrumentControl1";
            // 
            // turnCoordinatorInstrumentControl1
            // 
            this.turnCoordinatorInstrumentControl1.Location = new System.Drawing.Point(37, 258);
            this.turnCoordinatorInstrumentControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.turnCoordinatorInstrumentControl1.Name = "turnCoordinatorInstrumentControl1";
            this.turnCoordinatorInstrumentControl1.Size = new System.Drawing.Size(267, 255);
            this.turnCoordinatorInstrumentControl1.TabIndex = 6;
            this.turnCoordinatorInstrumentControl1.Text = "turnCoordinatorInstrumentControl1";
            // 
            // attitudeIndicatorInstrumentControl1
            // 
            this.attitudeIndicatorInstrumentControl1.Location = new System.Drawing.Point(37, 0);
            this.attitudeIndicatorInstrumentControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.attitudeIndicatorInstrumentControl1.Name = "attitudeIndicatorInstrumentControl1";
            this.attitudeIndicatorInstrumentControl1.Size = new System.Drawing.Size(267, 255);
            this.attitudeIndicatorInstrumentControl1.TabIndex = 6;
            this.attitudeIndicatorInstrumentControl1.Text = "attitudeIndicatorInstrumentControl1";
            // 
            // DemoWinow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1743, 831);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "DemoWinow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Avionics Controls Demo";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControlUgv.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }


        #endregion
        private System.Windows.Forms.Panel panel1;
        private AttitudeIndicatorInstrumentControl attitudeIndicatorInstrumentControl1;
        private TurnCoordinatorInstrumentControl turnCoordinatorInstrumentControl1;
        private HeadingIndicatorInstrumentControl headingIndicatorInstrumentControl1;
        private AirSpeedIndicatorInstrumentControl airSpeedIndicatorInstrumentControl1;
        private System.IO.Ports.SerialPort serialPortUgv;
        private System.Windows.Forms.Timer timerUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TabPage tabPageSerialPort;
        private System.Windows.Forms.TabPage tabUgv;
        private System.Windows.Forms.TabControl tabControlUgv;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxScale;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.Panel panelUp;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}

