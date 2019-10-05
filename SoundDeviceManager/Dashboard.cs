using NAudio.CoreAudioApi;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AudioDeviceManager
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void RescanDevices()
        {
            var enumerator = new MMDeviceEnumerator();
            var inputdevices = enumerator.EnumerateAudioEndPoints(DataFlow.Capture, DeviceState.Active);
            flowLayoutPanelInput.Controls.Clear();
            flowLayoutPanelOutput.Controls.Clear();
            flowLayoutPanelInput.SuspendLayout();
            flowLayoutPanelOutput.SuspendLayout();
            foreach (var item in inputdevices)
            {
                flowLayoutPanelInput.Controls.Add(new Device(item.FriendlyName, item));
            }
            var outputdevices = enumerator.EnumerateAudioEndPoints(DataFlow.Render, DeviceState.Active);
            foreach (var item in outputdevices)
            {
                flowLayoutPanelOutput.Controls.Add(new Device(item.FriendlyName, item));
            }
            flowLayoutPanelInput.ResumeLayout();
            flowLayoutPanelOutput.ResumeLayout();
            flowLayoutPanelInput.PerformLayout();
            flowLayoutPanelOutput.PerformLayout();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
        }

        private void RescanDevicesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RescanDevices();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            RescanDevices();
        }
    }
}
