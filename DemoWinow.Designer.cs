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
            this.serialPortUgv = new System.IO.Ports.SerialPort(this.components);
            this.timerUpdate = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.panelUp = new System.Windows.Forms.Panel();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxScale = new System.Windows.Forms.PictureBox();
            this.pictureBoxClose = new System.Windows.Forms.PictureBox();
            this.gMapControl = new GMap.NET.WindowsForms.GMapControl();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tabControlUgv = new System.Windows.Forms.TabControl();
            this.tabUgv = new System.Windows.Forms.TabPage();
            this.tabPageSerialPort = new System.Windows.Forms.TabPage();
            this.panel3 = new System.Windows.Forms.Panel();
            this.labelPosition = new System.Windows.Forms.Label();
            this.pictureBoxMinus = new System.Windows.Forms.PictureBox();
            this.pictureBoxPlus = new System.Windows.Forms.PictureBox();
            this.airSpeedIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.AirSpeedIndicatorInstrumentControl();
            this.headingIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.HeadingIndicatorInstrumentControl();
            this.turnCoordinatorInstrumentControl1 = new AvionicsInstrumentControlDemo.TurnCoordinatorInstrumentControl();
            this.attitudeIndicatorInstrumentControl1 = new AvionicsInstrumentControlDemo.AttitudeIndicatorInstrumentControl();
            this.panel1.SuspendLayout();
            this.panelUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScale)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).BeginInit();
            this.panel4.SuspendLayout();
            this.tabControlUgv.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlus)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(74)))), ((int)(((byte)(74)))));
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
            // serialPortUgv
            // 
            this.serialPortUgv.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPortUgv_DataReceived);
            // 
            // timerUpdate
            // 
            this.timerUpdate.Interval = 25;
            this.timerUpdate.Tick += new System.EventHandler(this.timerUpdate_Tick);
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
            // panelUp
            // 
            this.panelUp.BackColor = System.Drawing.Color.Black;
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
            this.gMapControl.OnMapZoomChanged += new GMap.NET.MapZoomChanged(this.gMapControl_OnMapZoomChanged);
            this.gMapControl.DoubleClick += new System.EventHandler(this.gMapControl_DoubleClick);
            this.gMapControl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.gMapControl_MouseMove);
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
            // tabControlUgv
            // 
            this.tabControlUgv.Controls.Add(this.tabUgv);
            this.tabControlUgv.Controls.Add(this.tabPageSerialPort);
            this.tabControlUgv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlUgv.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tabControlUgv.Location = new System.Drawing.Point(0, 0);
            this.tabControlUgv.Margin = new System.Windows.Forms.Padding(4);
            this.tabControlUgv.Name = "tabControlUgv";
            this.tabControlUgv.SelectedIndex = 0;
            this.tabControlUgv.Size = new System.Drawing.Size(768, 210);
            this.tabControlUgv.TabIndex = 7;
            this.tabControlUgv.SelectedIndexChanged += new System.EventHandler(this.tabControlUgv_SelectedIndexChanged);
            // 
            // tabUgv
            // 
            this.tabUgv.BackColor = System.Drawing.SystemColors.Control;
            this.tabUgv.Location = new System.Drawing.Point(4, 31);
            this.tabUgv.Margin = new System.Windows.Forms.Padding(4);
            this.tabUgv.Name = "tabUgv";
            this.tabUgv.Padding = new System.Windows.Forms.Padding(4);
            this.tabUgv.Size = new System.Drawing.Size(760, 175);
            this.tabUgv.TabIndex = 0;
            this.tabUgv.Text = "UGV";
            // 
            // tabPageSerialPort
            // 
            this.tabPageSerialPort.Location = new System.Drawing.Point(4, 31);
            this.tabPageSerialPort.Margin = new System.Windows.Forms.Padding(4);
            this.tabPageSerialPort.Name = "tabPageSerialPort";
            this.tabPageSerialPort.Padding = new System.Windows.Forms.Padding(4);
            this.tabPageSerialPort.Size = new System.Drawing.Size(760, 175);
            this.tabPageSerialPort.TabIndex = 1;
            this.tabPageSerialPort.Text = "Serial Port";
            this.tabPageSerialPort.UseVisualStyleBackColor = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel3.Controls.Add(this.labelPosition);
            this.panel3.Controls.Add(this.pictureBoxMinus);
            this.panel3.Controls.Add(this.pictureBoxPlus);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.gMapControl);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(325, 49);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1418, 782);
            this.panel3.TabIndex = 6;
            this.panel3.Click += new System.EventHandler(this.pictureBox1_Click);
            this.panel3.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.panel3.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // labelPosition
            // 
            this.labelPosition.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPosition.AutoSize = true;
            this.labelPosition.BackColor = System.Drawing.Color.White;
            this.labelPosition.Font = new System.Drawing.Font("Arial Narrow", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelPosition.Location = new System.Drawing.Point(1132, 749);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(48, 22);
            this.labelPosition.TabIndex = 10;
            this.labelPosition.Text = "label2";
            // 
            // pictureBoxMinus
            // 
            this.pictureBoxMinus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxMinus.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxMinus.Image = global::AvionicsInstrumentControlDemo.Properties.Resources.Amitjakhu_Drip_Minus_512;
            this.pictureBoxMinus.Location = new System.Drawing.Point(1321, 685);
            this.pictureBoxMinus.Name = "pictureBoxMinus";
            this.pictureBoxMinus.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxMinus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxMinus.TabIndex = 9;
            this.pictureBoxMinus.TabStop = false;
            this.pictureBoxMinus.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxMinus.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBoxMinus.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
            // 
            // pictureBoxPlus
            // 
            this.pictureBoxPlus.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBoxPlus.BackColor = System.Drawing.Color.LightGray;
            this.pictureBoxPlus.Image = global::AvionicsInstrumentControlDemo.Properties.Resources.Colebemis_Feather_Plus_512;
            this.pictureBoxPlus.Location = new System.Drawing.Point(1321, 624);
            this.pictureBoxPlus.Name = "pictureBoxPlus";
            this.pictureBoxPlus.Size = new System.Drawing.Size(50, 50);
            this.pictureBoxPlus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPlus.TabIndex = 9;
            this.pictureBoxPlus.TabStop = false;
            this.pictureBoxPlus.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBoxPlus.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            this.pictureBoxPlus.MouseHover += new System.EventHandler(this.pictureBox1_MouseHover);
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
            this.panelUp.ResumeLayout(false);
            this.panelUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxScale)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxClose)).EndInit();
            this.panel4.ResumeLayout(false);
            this.tabControlUgv.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPlus)).EndInit();
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
        private System.Windows.Forms.PictureBox pictureBoxClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBoxScale;
        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.Panel panelUp;
        private GMap.NET.WindowsForms.GMapControl gMapControl;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TabControl tabControlUgv;
        private System.Windows.Forms.TabPage tabUgv;
        private System.Windows.Forms.TabPage tabPageSerialPort;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBoxPlus;
        private System.Windows.Forms.PictureBox pictureBoxMinus;
        private System.Windows.Forms.Label labelPosition;
    }
}

