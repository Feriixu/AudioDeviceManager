namespace AudioDeviceManager
{
    partial class Device
    {
        /// <summary> 
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Komponenten-Designer generierter Code

        /// <summary> 
        /// Erforderliche Methode für die Designerunterstützung. 
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelDeviceName = new System.Windows.Forms.Label();
            this.volumeSliderDevice = new NAudio.Gui.VolumeSlider();
            this.waveformPainter1 = new NAudio.Gui.WaveformPainter();
            this.SuspendLayout();
            // 
            // labelDeviceName
            // 
            this.labelDeviceName.AutoSize = true;
            this.labelDeviceName.Location = new System.Drawing.Point(4, 4);
            this.labelDeviceName.Name = "labelDeviceName";
            this.labelDeviceName.Size = new System.Drawing.Size(127, 13);
            this.labelDeviceName.TabIndex = 0;
            this.labelDeviceName.Text = "lorem ipsum dolor sit amet";
            // 
            // volumeSliderDevice
            // 
            this.volumeSliderDevice.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.volumeSliderDevice.Location = new System.Drawing.Point(3, 21);
            this.volumeSliderDevice.Name = "volumeSliderDevice";
            this.volumeSliderDevice.Size = new System.Drawing.Size(402, 31);
            this.volumeSliderDevice.TabIndex = 1;
            // 
            // waveformPainter1
            // 
            this.waveformPainter1.Location = new System.Drawing.Point(3, 58);
            this.waveformPainter1.Name = "waveformPainter1";
            this.waveformPainter1.Size = new System.Drawing.Size(402, 46);
            this.waveformPainter1.TabIndex = 2;
            this.waveformPainter1.Text = "waveformPainter1";
            // 
            // Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.waveformPainter1);
            this.Controls.Add(this.volumeSliderDevice);
            this.Controls.Add(this.labelDeviceName);
            this.Name = "Device";
            this.Size = new System.Drawing.Size(408, 107);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeviceName;
        private NAudio.Gui.VolumeSlider volumeSliderDevice;
        private NAudio.Gui.WaveformPainter waveformPainter1;
    }
}
