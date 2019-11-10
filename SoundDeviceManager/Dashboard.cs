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
            flowLayoutPanelInput.Controls.Clear();
            flowLayoutPanelOutput.Controls.Clear();
            flowLayoutPanelInput.SuspendLayout();
            flowLayoutPanelOutput.SuspendLayout();

            var devices = enumerator.EnumerateAudioEndPoints(DataFlow.All, DeviceState.All);
            var sorted = devices.OrderBy(device => device.State);
            foreach (var device in sorted)
            {
                if (device.State == DeviceState.NotPresent) // Skip these devices
                    continue;
                if (!toolStripMenuItemFilterStateActive.Checked && device.State == DeviceState.Active)
                    continue;
                if (!toolStripMenuItemFilterStateDisabled.Checked && device.State == DeviceState.Disabled)
                    continue;
                if (!toolStripMenuItemFilterStateUnplugged.Checked && device.State == DeviceState.Unplugged)
                    continue;

                var name = device.FriendlyName;
                name = name.PadRight(80, '-');
                name += "| " + device.State;
                name = name.PadRight(95);
                name += "| " + device.DataFlow;
                Console.WriteLine($"{name}");

                switch (device.DataFlow)
                {
                    case DataFlow.Render:
                        flowLayoutPanelOutput.Controls.Add(new Device(device));
                        break;
                    case DataFlow.Capture:
                        flowLayoutPanelInput.Controls.Add(new Device(device));
                        break;
                    default:
                        break;
                }
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

        private void toolStripMenuItemFilterStateActive_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;
            RescanDevices();
        }

        private void disabledToolStripMenuItemFilterStateDisabled_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;
            RescanDevices();
        }

        private void unpluggedToolStripMenuItemFilterStateUnplugged_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;
            RescanDevices();
        }

        private void iNToolStripMenuItemDataFlowInput_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;
            RescanDevices();
        }

        private void oUTToolStripMenuItemFilterDataFlowOutput_Click(object sender, EventArgs e)
        {
            var item = (ToolStripMenuItem)sender;
            item.Checked = !item.Checked;
            RescanDevices();
        }
    }
}
