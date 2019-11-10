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
            this.waveformPainter = new NAudio.Gui.WaveformPainter();
            this.checkBoxEnabled = new System.Windows.Forms.CheckBox();
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
            this.volumeSliderDevice.Enabled = false;
            this.volumeSliderDevice.Location = new System.Drawing.Point(3, 21);
            this.volumeSliderDevice.Name = "volumeSliderDevice";
            this.volumeSliderDevice.Size = new System.Drawing.Size(318, 18);
            this.volumeSliderDevice.TabIndex = 1;
            // 
            // waveformPainter
            // 
            this.waveformPainter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.waveformPainter.Location = new System.Drawing.Point(3, 45);
            this.waveformPainter.Name = "waveformPainter";
            this.waveformPainter.Size = new System.Drawing.Size(402, 16);
            this.waveformPainter.TabIndex = 2;
            this.waveformPainter.Text = "waveformPainter1";
            // 
            // checkBoxEnabled
            // 
            this.checkBoxEnabled.AutoSize = true;
            this.checkBoxEnabled.Location = new System.Drawing.Point(327, 22);
            this.checkBoxEnabled.Name = "checkBoxEnabled";
            this.checkBoxEnabled.Size = new System.Drawing.Size(78, 17);
            this.checkBoxEnabled.TabIndex = 3;
            this.checkBoxEnabled.Text = "Unplugged";
            this.checkBoxEnabled.UseVisualStyleBackColor = true;
            this.checkBoxEnabled.CheckedChanged += new System.EventHandler(this.checkBoxEnabled_CheckedChanged);
            // 
            // Device
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.checkBoxEnabled);
            this.Controls.Add(this.waveformPainter);
            this.Controls.Add(this.volumeSliderDevice);
            this.Controls.Add(this.labelDeviceName);
            this.Name = "Device";
            this.Size = new System.Drawing.Size(408, 64);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelDeviceName;
        private NAudio.Gui.VolumeSlider volumeSliderDevice;
        private NAudio.Gui.WaveformPainter waveformPainter;
        private System.Windows.Forms.CheckBox checkBoxEnabled;
    }
}
