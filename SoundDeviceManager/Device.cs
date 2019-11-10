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
        public MMDevice device;
        private Timer Update;
        public Device(MMDevice device)
        {
            InitializeComponent();
            if (device.State != DeviceState.NotPresent)
                labelDeviceName.Text = device.FriendlyName;
            switch (device.State)
            {
                case DeviceState.Active:
                    checkBoxEnabled.Checked = true;
                    checkBoxEnabled.Text = "Active";
                    break;
                case DeviceState.Disabled:
                    checkBoxEnabled.Checked = false;
                    checkBoxEnabled.Text = "Disabled";
                    break;
                case DeviceState.Unplugged:
                    checkBoxEnabled.Checked = false;
                    checkBoxEnabled.Text = "Unplugged";
                    checkBoxEnabled.Enabled = false;
                    break;
                default:
                    checkBoxEnabled.Checked = false;
                    break;
            }



            this.device = device;
            if (device.State == DeviceState.Active)
                StartTimer();

        }

        private void StartTimer()
        {
            this.Update = new Timer();
            Update.Interval = 1;
            Update.Tick += UpdateTick;
            Update.Start();
        }

        ~Device()
        {
            Update?.Stop();
        }

        private void UpdateTick(object sender, EventArgs e)
        {
            try
            {
                var value = device.AudioMeterInformation.MasterPeakValue;
                volumeSliderDevice.Volume = value;
                waveformPainter.AddMax(value);
            }
            catch (Exception) { }
        }

        private void checkBoxEnabled_CheckedChanged(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}
