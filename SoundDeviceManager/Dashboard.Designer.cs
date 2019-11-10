namespace AudioDeviceManager
{
    partial class Dashboard
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

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.flowLayoutPanelInput = new System.Windows.Forms.FlowLayoutPanel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.flowLayoutPanelOutput = new System.Windows.Forms.FlowLayoutPanel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.rescanDevicesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.filterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFilterStateActive = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFilterStateDisabled = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemFilterStateUnplugged = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanelInput
            // 
            this.flowLayoutPanelInput.AutoScroll = true;
            this.flowLayoutPanelInput.AutoSize = true;
            this.flowLayoutPanelInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelInput.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelInput.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelInput.Name = "flowLayoutPanelInput";
            this.flowLayoutPanelInput.Size = new System.Drawing.Size(415, 87);
            this.flowLayoutPanelInput.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.AutoSize = true;
            this.groupBox1.Controls.Add(this.flowLayoutPanelInput);
            this.groupBox1.Location = new System.Drawing.Point(12, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(421, 106);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Input";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.flowLayoutPanelOutput);
            this.groupBox2.Location = new System.Drawing.Point(439, 28);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(421, 106);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Output";
            // 
            // flowLayoutPanelOutput
            // 
            this.flowLayoutPanelOutput.AutoScroll = true;
            this.flowLayoutPanelOutput.AutoSize = true;
            this.flowLayoutPanelOutput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanelOutput.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanelOutput.Location = new System.Drawing.Point(3, 16);
            this.flowLayoutPanelOutput.Name = "flowLayoutPanelOutput";
            this.flowLayoutPanelOutput.Size = new System.Drawing.Size(415, 87);
            this.flowLayoutPanelOutput.TabIndex = 5;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rescanDevicesToolStripMenuItem,
            this.filterToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(872, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // rescanDevicesToolStripMenuItem
            // 
            this.rescanDevicesToolStripMenuItem.Name = "rescanDevicesToolStripMenuItem";
            this.rescanDevicesToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.rescanDevicesToolStripMenuItem.Text = "Rescan Devices";
            this.rescanDevicesToolStripMenuItem.Click += new System.EventHandler(this.RescanDevicesToolStripMenuItem_Click);
            // 
            // filterToolStripMenuItem
            // 
            this.filterToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItemFilterStateActive,
            this.toolStripMenuItemFilterStateDisabled,
            this.toolStripMenuItemFilterStateUnplugged});
            this.filterToolStripMenuItem.Name = "filterToolStripMenuItem";
            this.filterToolStripMenuItem.Size = new System.Drawing.Size(45, 20);
            this.filterToolStripMenuItem.Text = "Filter";
            // 
            // toolStripMenuItemFilterStateActive
            // 
            this.toolStripMenuItemFilterStateActive.Checked = true;
            this.toolStripMenuItemFilterStateActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemFilterStateActive.Name = "toolStripMenuItemFilterStateActive";
            this.toolStripMenuItemFilterStateActive.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemFilterStateActive.Text = "Active";
            this.toolStripMenuItemFilterStateActive.Click += new System.EventHandler(this.toolStripMenuItemFilterStateActive_Click);
            // 
            // toolStripMenuItemFilterStateDisabled
            // 
            this.toolStripMenuItemFilterStateDisabled.Checked = true;
            this.toolStripMenuItemFilterStateDisabled.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolStripMenuItemFilterStateDisabled.Name = "toolStripMenuItemFilterStateDisabled";
            this.toolStripMenuItemFilterStateDisabled.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemFilterStateDisabled.Text = "Disabled";
            this.toolStripMenuItemFilterStateDisabled.Click += new System.EventHandler(this.disabledToolStripMenuItemFilterStateDisabled_Click);
            // 
            // toolStripMenuItemFilterStateUnplugged
            // 
            this.toolStripMenuItemFilterStateUnplugged.Name = "toolStripMenuItemFilterStateUnplugged";
            this.toolStripMenuItemFilterStateUnplugged.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItemFilterStateUnplugged.Text = "Unplugged";
            this.toolStripMenuItemFilterStateUnplugged.Click += new System.EventHandler(this.unpluggedToolStripMenuItemFilterStateUnplugged_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(872, 146);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Dashboard";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Audio Device Manager";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelInput;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem rescanDevicesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem filterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFilterStateActive;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFilterStateDisabled;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemFilterStateUnplugged;
    }
}

