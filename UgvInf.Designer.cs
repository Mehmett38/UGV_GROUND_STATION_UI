namespace AvionicsInstrumentControlDemo
{
    partial class UgvInf
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.pictureBoxGpsStatus = new System.Windows.Forms.PictureBox();
            this.pictureBoxLedStatus = new System.Windows.Forms.PictureBox();
            this.labelGpsNumber = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGpsStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLedStatus)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxGpsStatus
            // 
            this.pictureBoxGpsStatus.Image = global::AvionicsInstrumentControlDemo.Properties.Resources.Icons8_Windows_8_Maps_Gps_Disconnected_512;
            this.pictureBoxGpsStatus.Location = new System.Drawing.Point(44, 22);
            this.pictureBoxGpsStatus.Name = "pictureBoxGpsStatus";
            this.pictureBoxGpsStatus.Size = new System.Drawing.Size(88, 77);
            this.pictureBoxGpsStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxGpsStatus.TabIndex = 2;
            this.pictureBoxGpsStatus.TabStop = false;
            // 
            // pictureBoxLedStatus
            // 
            this.pictureBoxLedStatus.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBoxLedStatus.Image = global::AvionicsInstrumentControlDemo.Properties.Resources.Picture0;
            this.pictureBoxLedStatus.Location = new System.Drawing.Point(0, 120);
            this.pictureBoxLedStatus.Name = "pictureBoxLedStatus";
            this.pictureBoxLedStatus.Size = new System.Drawing.Size(656, 389);
            this.pictureBoxLedStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxLedStatus.TabIndex = 1;
            this.pictureBoxLedStatus.TabStop = false;
            // 
            // labelGpsNumber
            // 
            this.labelGpsNumber.AutoSize = true;
            this.labelGpsNumber.Location = new System.Drawing.Point(138, 83);
            this.labelGpsNumber.Name = "labelGpsNumber";
            this.labelGpsNumber.Size = new System.Drawing.Size(122, 16);
            this.labelGpsNumber.TabIndex = 3;
            this.labelGpsNumber.Text = "Satellite Number : 0";
            // 
            // UgvInf
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 509);
            this.Controls.Add(this.labelGpsNumber);
            this.Controls.Add(this.pictureBoxGpsStatus);
            this.Controls.Add(this.pictureBoxLedStatus);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UgvInf";
            this.Text = "UgvInf";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxGpsStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLedStatus)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLedStatus;
        private System.Windows.Forms.PictureBox pictureBoxGpsStatus;
        private System.Windows.Forms.Label labelGpsNumber;
    }
}