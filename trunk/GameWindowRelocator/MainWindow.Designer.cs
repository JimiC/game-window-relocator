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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpGamesList = new System.Windows.Forms.TabPage();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.settingsControl = new GameWindowRelocator.Views.SettingsControl();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.aboutControl = new GameWindowRelocator.Views.AboutControl();
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.trayIconCMS = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.relocateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClientsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.releaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showClientsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tssRelocate = new System.Windows.Forms.ToolStripSeparator();
            this.gamesListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssRestore = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSettings = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.listControl = new GameWindowRelocator.Views.ListControl();
            this.addEditControl = new GameWindowRelocator.Views.AddEditControl();
            this.removeControl = new GameWindowRelocator.Views.RemoveControl();
            this.tabControl.SuspendLayout();
            this.tpGamesList.SuspendLayout();
            this.tpSettings.SuspendLayout();
            this.tpAbout.SuspendLayout();
            this.trayIconCMS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tpGamesList);
            this.tabControl.Controls.Add(this.tpSettings);
            this.tabControl.Controls.Add(this.tpAbout);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(284, 262);
            this.tabControl.TabIndex = 1;
            // 
            // tpGamesList
            // 
            this.tpGamesList.Controls.Add(this.listControl);
            this.tpGamesList.Controls.Add(this.addEditControl);
            this.tpGamesList.Controls.Add(this.removeControl);
            this.tpGamesList.Location = new System.Drawing.Point(4, 22);
            this.tpGamesList.Name = "tpGamesList";
            this.tpGamesList.Padding = new System.Windows.Forms.Padding(3);
            this.tpGamesList.Size = new System.Drawing.Size(276, 236);
            this.tpGamesList.TabIndex = 0;
            this.tpGamesList.Text = "Games List";
            this.tpGamesList.UseVisualStyleBackColor = true;
            // 
            // listControl
            // 
            this.listControl.Location = new System.Drawing.Point(0, 0);
            this.listControl.Name = "listControl";
            this.listControl.Size = new System.Drawing.Size(270, 232);
            this.listControl.TabIndex = 0;
            // 
            // addEditControl
            // 
            this.addEditControl.Location = new System.Drawing.Point(0, 0);
            this.addEditControl.Name = "addEditControl";
            this.addEditControl.Size = new System.Drawing.Size(270, 208);
            this.addEditControl.TabIndex = 1;
            // 
            // removeControl
            // 
            this.removeControl.Location = new System.Drawing.Point(0, 0);
            this.removeControl.Name = "removeControl";
            this.removeControl.Size = new System.Drawing.Size(270, 202);
            this.removeControl.TabIndex = 2;
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
            // settingsControl
            // 
            this.settingsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsControl.Location = new System.Drawing.Point(3, 3);
            this.settingsControl.Name = "settingsControl";
            this.settingsControl.Size = new System.Drawing.Size(270, 230);
            this.settingsControl.TabIndex = 0;
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
            this.releaseToolStripMenuItem,
            this.tssRelocate,
            this.gamesListToolStripMenuItem,
            this.tssRestore,
            this.settingsToolStripMenuItem,
            this.tssSettings,
            this.exitToolStripMenuItem});
            this.trayIconCMS.Name = "trayIconCMS";
            this.trayIconCMS.Size = new System.Drawing.Size(132, 132);
            // 
            // relocateToolStripMenuItem
            // 
            this.relocateToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showClientsToolStripMenuItem});
            this.relocateToolStripMenuItem.Name = "relocateToolStripMenuItem";
            this.relocateToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.relocateToolStripMenuItem.Text = "Relocate";
            this.relocateToolStripMenuItem.DropDownOpening += new System.EventHandler(this.actionToolStripMenuItem_DropDownOpening);
            // 
            // showClientsToolStripMenuItem
            // 
            this.showClientsToolStripMenuItem.Name = "showClientsToolStripMenuItem";
            this.showClientsToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
            this.showClientsToolStripMenuItem.Text = "show clients";
            // 
            // releaseToolStripMenuItem
            // 
            this.releaseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showClientsToolStripMenuItem1});
            this.releaseToolStripMenuItem.Name = "releaseToolStripMenuItem";
            this.releaseToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.releaseToolStripMenuItem.Text = "Release";
            this.releaseToolStripMenuItem.DropDownOpening += new System.EventHandler(this.actionToolStripMenuItem_DropDownOpening);
            // 
            // showClientsToolStripMenuItem1
            // 
            this.showClientsToolStripMenuItem1.Name = "showClientsToolStripMenuItem1";
            this.showClientsToolStripMenuItem1.Size = new System.Drawing.Size(139, 22);
            this.showClientsToolStripMenuItem1.Text = "show clients";
            // 
            // tssRelocate
            // 
            this.tssRelocate.Name = "tssRelocate";
            this.tssRelocate.Size = new System.Drawing.Size(128, 6);
            // 
            // gamesListToolStripMenuItem
            // 
            this.gamesListToolStripMenuItem.Name = "gamesListToolStripMenuItem";
            this.gamesListToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.gamesListToolStripMenuItem.Text = "Games List";
            this.gamesListToolStripMenuItem.Click += new System.EventHandler(this.gamesListToolStripMenuItem_Click);
            // 
            // tssRestore
            // 
            this.tssRestore.Name = "tssRestore";
            this.tssRestore.Size = new System.Drawing.Size(128, 6);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // tssSettings
            // 
            this.tssSettings.Name = "tssSettings";
            this.tssSettings.Size = new System.Drawing.Size(128, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Window Relocator";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.mainWindow_FormClosing);
            this.Load += new System.EventHandler(this.MainWindow_Load);
            this.tabControl.ResumeLayout(false);
            this.tpGamesList.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tpAbout.ResumeLayout(false);
            this.trayIconCMS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tpGamesList;
        private System.Windows.Forms.TabPage tpSettings;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.ContextMenuStrip trayIconCMS;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tssSettings;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem relocateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tssRelocate;
        private System.Windows.Forms.ToolStripMenuItem releaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gamesListToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tssRestore;
        private System.Windows.Forms.Timer timer;
        private Views.SettingsControl settingsControl;
        private Views.AboutControl aboutControl;
        private System.Windows.Forms.ToolStripMenuItem showClientsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showClientsToolStripMenuItem1;
        private Views.ListControl listControl;
        private Views.AddEditControl addEditControl;
        private Views.RemoveControl removeControl;

    }
}

