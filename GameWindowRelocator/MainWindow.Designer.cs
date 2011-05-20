namespace GameWindowRelocator
{
    partial class MainWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.relocateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssRelocate = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSettings = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpGameList = new System.Windows.Forms.TabPage();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.listControl = new GameWindowRelocator.Views.ListControl();
            this.addEditControl = new GameWindowRelocator.Views.AddEditControl();
            this.removeControl = new GameWindowRelocator.Views.RemoveControl();
            this.aboutControl = new GameWindowRelocator.Views.AboutControl();
            this.settingsControl = new GameWindowRelocator.Views.SettingsControl();
            this.trayIconCMS.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.SuspendLayout();
            // 
            // notifyIcon
            // 
            this.notifyIcon.ContextMenuStrip = this.trayIconCMS;
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Game Window Relocator";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // trayIconCMS
            // 
            this.trayIconCMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.relocateToolStripMenuItem,
            this.tssRelocate,
            this.settingsToolStripMenuItem,
            this.tssSettings,
            this.exitToolStripMenuItem});
            this.trayIconCMS.Name = "trayIconCMS";
            this.trayIconCMS.Size = new System.Drawing.Size(120, 82);
            // 
            // relocateToolStripMenuItem
            // 
            this.relocateToolStripMenuItem.Name = "relocateToolStripMenuItem";
            this.relocateToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.relocateToolStripMenuItem.Text = "Relocate";
            this.relocateToolStripMenuItem.DropDownOpening += new System.EventHandler(this.relocationMenu_DropDownOpening);
            // 
            // tssRelocate
            // 
            this.tssRelocate.Name = "tssRelocate";
            this.tssRelocate.Size = new System.Drawing.Size(116, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // tssSettings
            // 
            this.tssSettings.Name = "tssSettings";
            this.tssSettings.Size = new System.Drawing.Size(116, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpGameList);
            this.tabControl.Controls.Add(this.tpSettings);
            this.tabControl.Controls.Add(this.tpAbout);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(284, 262);
            this.tabControl.TabIndex = 1;
            // 
            // tpGameList
            // 
            this.tpGameList.Controls.Add(this.listControl);
            this.tpGameList.Controls.Add(this.addEditControl);
            this.tpGameList.Controls.Add(this.removeControl);
            this.tpGameList.Location = new System.Drawing.Point(4, 22);
            this.tpGameList.Name = "tpGameList";
            this.tpGameList.Padding = new System.Windows.Forms.Padding(3);
            this.tpGameList.Size = new System.Drawing.Size(276, 236);
            this.tpGameList.TabIndex = 0;
            this.tpGameList.Text = "Game List";
            this.tpGameList.UseVisualStyleBackColor = true;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.settingsControl);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(276, 236);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.aboutControl);
            this.tpAbout.Location = new System.Drawing.Point(4, 22);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(276, 236);
            this.tpAbout.TabIndex = 2;
            this.tpAbout.Text = "About";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // aboutControl
            // 
            this.aboutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.aboutControl.Location = new System.Drawing.Point(0, 0);
            this.aboutControl.Name = "aboutControl";
            this.aboutControl.Size = new System.Drawing.Size(276, 236);
            this.aboutControl.TabIndex = 0;
            // 
            // settingsControl
            // 
            this.settingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsControl.Location = new System.Drawing.Point(3, 3);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(270, 230);
            this.settingsControl.TabIndex = 0;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Window Relocator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.trayIconCMS.ResumeLayout(false);
            this.tabControl.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tpAbout.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconCMS;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tssSettings;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpGameList;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.ToolStripMenuItem relocateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tssRelocate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabPage tpAbout;
        private Views.ListControl listControl;
        private Views.AddEditControl addEditControl;
        private Views.RemoveControl removeControl;
        private Views.SettingsControl settingsControl;
        private Views.AboutControl aboutControl;

    }
}

