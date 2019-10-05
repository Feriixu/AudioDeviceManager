using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.CoreAudioApi;

namespace AudioDeviceManager
{
    public partial class Device : UserControl
    {
        private MMDevice device;
        private Timer Update;
        public Device(string name, MMDevice device)
        {
            InitializeComponent();
            labelDeviceName.Text = name;
            this.device = device;
            this.Update = new Timer();
            Update.Interval = 1;
            Update.Tick += UpdateTick;
            Update.Start();

        }

        ~Device()
        {
            Update.Stop();
        }

        private void UpdateTick(object sender, EventArgs e)
        {
            var value = device.AudioMeterInformation.MasterPeakValue;
            volumeSliderDevice.Volume = value;
            waveformPainter1.AddMax(value);
        }
    }
}
