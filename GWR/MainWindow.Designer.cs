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
            this.listControl = new Views.ListControl();
            this.addEditControl = new Views.AddEditControl();
            this.removeControl = new Views.RemoveControl();
            this.relocateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssRelocate = new System.Windows.Forms.ToolStripSeparator();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tssSettings = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tpGameList = new System.Windows.Forms.TabPage();
            this.tpSettings = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeIntervalNUD = new System.Windows.Forms.NumericUpDown();
            this.enableAutoRelacationChechBox = new System.Windows.Forms.CheckBox();
            this.startWithWindowsCheckBox = new System.Windows.Forms.CheckBox();
            this.tpAbout = new System.Windows.Forms.TabPage();
            this.aboutLabel = new System.Windows.Forms.Label();
            this.trayIconCMS.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.tpGameList.SuspendLayout();
            this.tpSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeIntervalNUD)).BeginInit();
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
            // listControl
            // 
            this.listControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listControl.Location = new System.Drawing.Point(3, 3);
            this.listControl.Name = "listControl";
            this.listControl.Size = new System.Drawing.Size(270, 230);
            this.listControl.TabIndex = 0;
            // 
            // addEditControl
            // 
            this.addEditControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEditControl.Location = new System.Drawing.Point(3, 3);
            this.addEditControl.Name = "addEditControl";
            this.addEditControl.Size = new System.Drawing.Size(270, 230);
            this.addEditControl.TabIndex = 0;
            // 
            // removeControl
            // 
            this.removeControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.removeControl.Location = new System.Drawing.Point(3, 3);
            this.removeControl.Name = "removeControl";
            this.removeControl.Size = new System.Drawing.Size(270, 230);
            this.removeControl.TabIndex = 0;
            // 
            // tpSettings
            // 
            this.tpSettings.Controls.Add(this.label2);
            this.tpSettings.Controls.Add(this.label1);
            this.tpSettings.Controls.Add(this.timeIntervalNUD);
            this.tpSettings.Controls.Add(this.enableAutoRelacationChechBox);
            this.tpSettings.Controls.Add(this.startWithWindowsCheckBox);
            this.tpSettings.Location = new System.Drawing.Point(4, 22);
            this.tpSettings.Name = "tpSettings";
            this.tpSettings.Padding = new System.Windows.Forms.Padding(3);
            this.tpSettings.Size = new System.Drawing.Size(276, 236);
            this.tpSettings.TabIndex = 1;
            this.tpSettings.Text = "Settings";
            this.tpSettings.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(166, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Check every";
            // 
            // timeIntervalNUD
            // 
            this.timeIntervalNUD.Location = new System.Drawing.Point(112, 112);
            this.timeIntervalNUD.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.timeIntervalNUD.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.timeIntervalNUD.Name = "timeIntervalNUD";
            this.timeIntervalNUD.Size = new System.Drawing.Size(47, 20);
            this.timeIntervalNUD.TabIndex = 2;
            this.timeIntervalNUD.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.timeIntervalNUD.ValueChanged += new System.EventHandler(this.timeIntervalNUD_ValueChanged);
            // 
            // enableAutoRelacationChechBox
            // 
            this.enableAutoRelacationChechBox.AutoSize = true;
            this.enableAutoRelacationChechBox.Location = new System.Drawing.Point(22, 89);
            this.enableAutoRelacationChechBox.Name = "enableAutoRelacationChechBox";
            this.enableAutoRelacationChechBox.Size = new System.Drawing.Size(138, 17);
            this.enableAutoRelacationChechBox.TabIndex = 1;
            this.enableAutoRelacationChechBox.Text = "Enable Auto Relocation";
            this.enableAutoRelacationChechBox.UseVisualStyleBackColor = true;
            this.enableAutoRelacationChechBox.CheckedChanged += new System.EventHandler(this.enableAutoRelacationChechBox_CheckedChanged);
            // 
            // startWithWindowsCheckBox
            // 
            this.startWithWindowsCheckBox.AutoSize = true;
            this.startWithWindowsCheckBox.Location = new System.Drawing.Point(22, 35);
            this.startWithWindowsCheckBox.Name = "startWithWindowsCheckBox";
            this.startWithWindowsCheckBox.Size = new System.Drawing.Size(117, 17);
            this.startWithWindowsCheckBox.TabIndex = 0;
            this.startWithWindowsCheckBox.Text = "Start with Windows";
            this.startWithWindowsCheckBox.UseVisualStyleBackColor = true;
            this.startWithWindowsCheckBox.CheckedChanged += new System.EventHandler(this.startWithWindowsCheckBox_CheckedChanged);
            // 
            // tpAbout
            // 
            this.tpAbout.Controls.Add(this.aboutLabel);
            this.tpAbout.Location = new System.Drawing.Point(4, 22);
            this.tpAbout.Name = "tpAbout";
            this.tpAbout.Size = new System.Drawing.Size(276, 236);
            this.tpAbout.TabIndex = 2;
            this.tpAbout.Text = "About";
            this.tpAbout.UseVisualStyleBackColor = true;
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.aboutLabel.Location = new System.Drawing.Point(49, 38);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(179, 160);
            this.aboutLabel.TabIndex = 0;
            this.aboutLabel.Text = "Game Window Relocator\r\n\r\n v1.0.0\r\n\r\n\r\n\r\n\r\nCreated by Jimi C\r\n\r\nMay 2011\r\n";
            this.aboutLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
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
            this.tpGameList.ResumeLayout(false);
            this.tpSettings.ResumeLayout(false);
            this.tpSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.timeIntervalNUD)).EndInit();
            this.tpAbout.ResumeLayout(false);
            this.tpAbout.PerformLayout();
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown timeIntervalNUD;
        private System.Windows.Forms.CheckBox enableAutoRelacationChechBox;
        private System.Windows.Forms.CheckBox startWithWindowsCheckBox;
        private System.Windows.Forms.ToolStripMenuItem relocateToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator tssRelocate;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.TabPage tpAbout;
        private System.Windows.Forms.Label aboutLabel;
        private Views.ListControl listControl;
        private Views.AddEditControl addEditControl;
        private Views.RemoveControl removeControl;

    }
}

