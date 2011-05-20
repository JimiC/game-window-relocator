namespace GameWindowRelocator.Views
{
    partial class SettingsControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timeIntervalNUD = new System.Windows.Forms.NumericUpDown();
            this.enableAutoRelacationChechBox = new System.Windows.Forms.CheckBox();
            this.startWithWindowsCheckBox = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.timeIntervalNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(187, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "seconds";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(60, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Check every";
            // 
            // timeIntervalNUD
            // 
            this.timeIntervalNUD.Location = new System.Drawing.Point(133, 147);
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
            this.timeIntervalNUD.TabIndex = 7;
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
            this.enableAutoRelacationChechBox.Location = new System.Drawing.Point(43, 124);
            this.enableAutoRelacationChechBox.Name = "enableAutoRelacationChechBox";
            this.enableAutoRelacationChechBox.Size = new System.Drawing.Size(138, 17);
            this.enableAutoRelacationChechBox.TabIndex = 6;
            this.enableAutoRelacationChechBox.Text = "Enable Auto Relocation";
            this.enableAutoRelacationChechBox.UseVisualStyleBackColor = true;
            this.enableAutoRelacationChechBox.CheckedChanged += new System.EventHandler(this.enableAutoRelacationChechBox_CheckedChanged);
            // 
            // startWithWindowsCheckBox
            // 
            this.startWithWindowsCheckBox.AutoSize = true;
            this.startWithWindowsCheckBox.Location = new System.Drawing.Point(43, 70);
            this.startWithWindowsCheckBox.Name = "startWithWindowsCheckBox";
            this.startWithWindowsCheckBox.Size = new System.Drawing.Size(117, 17);
            this.startWithWindowsCheckBox.TabIndex = 5;
            this.startWithWindowsCheckBox.Text = "Start with Windows";
            this.startWithWindowsCheckBox.UseVisualStyleBackColor = true;
            this.startWithWindowsCheckBox.CheckedChanged += new System.EventHandler(this.startWithWindowsCheckBox_CheckedChanged);
            // 
            // SettingsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.timeIntervalNUD);
            this.Controls.Add(this.enableAutoRelacationChechBox);
            this.Controls.Add(this.startWithWindowsCheckBox);
            this.Name = "SettingsControl";
            this.Size = new System.Drawing.Size(276, 236);
            this.Load += new System.EventHandler(this.Settings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timeIntervalNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown timeIntervalNUD;
        private System.Windows.Forms.CheckBox enableAutoRelacationChechBox;
        private System.Windows.Forms.CheckBox startWithWindowsCheckBox;
    }
}
