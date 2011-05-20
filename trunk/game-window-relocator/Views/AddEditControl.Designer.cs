namespace GameWindowRelocator.Views
{
    partial class AddEditControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddEditControl));
            this.addEditPanel = new System.Windows.Forms.Panel();
            this.infoLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.okButton = new System.Windows.Forms.Button();
            this.processNameLabel = new System.Windows.Forms.Label();
            this.tbProcessName = new System.Windows.Forms.TextBox();
            this.gameClientNameLabel = new System.Windows.Forms.Label();
            this.tbGameClientName = new System.Windows.Forms.TextBox();
            this.addEditPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // addEditPanel
            // 
            this.addEditPanel.Controls.Add(this.infoLabel);
            this.addEditPanel.Controls.Add(this.cancelButton);
            this.addEditPanel.Controls.Add(this.okButton);
            this.addEditPanel.Controls.Add(this.processNameLabel);
            this.addEditPanel.Controls.Add(this.tbProcessName);
            this.addEditPanel.Controls.Add(this.gameClientNameLabel);
            this.addEditPanel.Controls.Add(this.tbGameClientName);
            this.addEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addEditPanel.Location = new System.Drawing.Point(0, 0);
            this.addEditPanel.Name = "addEditPanel";
            this.addEditPanel.Size = new System.Drawing.Size(270, 208);
            this.addEditPanel.TabIndex = 6;
            // 
            // infoLabel
            // 
            this.infoLabel.AutoSize = true;
            this.infoLabel.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.infoLabel.Location = new System.Drawing.Point(23, 3);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(224, 78);
            this.infoLabel.TabIndex = 6;
            this.infoLabel.Text = resources.GetString("infoLabel.Text");
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cancelButton
            // 
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Location = new System.Drawing.Point(139, 172);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 5;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.okButton.Location = new System.Drawing.Point(57, 172);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(75, 23);
            this.okButton.TabIndex = 4;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // processNameLabel
            // 
            this.processNameLabel.AutoSize = true;
            this.processNameLabel.Location = new System.Drawing.Point(7, 128);
            this.processNameLabel.Name = "processNameLabel";
            this.processNameLabel.Size = new System.Drawing.Size(82, 13);
            this.processNameLabel.TabIndex = 3;
            this.processNameLabel.Text = "Process Name :";
            // 
            // tbProcessName
            // 
            this.tbProcessName.Location = new System.Drawing.Point(108, 125);
            this.tbProcessName.Name = "tbProcessName";
            this.tbProcessName.Size = new System.Drawing.Size(145, 20);
            this.tbProcessName.TabIndex = 2;
            // 
            // gameClientNameLabel
            // 
            this.gameClientNameLabel.AutoSize = true;
            this.gameClientNameLabel.Location = new System.Drawing.Point(7, 98);
            this.gameClientNameLabel.Name = "gameClientNameLabel";
            this.gameClientNameLabel.Size = new System.Drawing.Size(101, 13);
            this.gameClientNameLabel.TabIndex = 1;
            this.gameClientNameLabel.Text = "Game Client Name :";
            // 
            // tbGameClientName
            // 
            this.tbGameClientName.Location = new System.Drawing.Point(108, 95);
            this.tbGameClientName.Name = "tbGameClientName";
            this.tbGameClientName.Size = new System.Drawing.Size(145, 20);
            this.tbGameClientName.TabIndex = 0;
            // 
            // AddEditControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.addEditPanel);
            this.Name = "AddEditControl";
            this.Size = new System.Drawing.Size(270, 208);
            this.addEditPanel.ResumeLayout(false);
            this.addEditPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel addEditPanel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label processNameLabel;
        private System.Windows.Forms.Label gameClientNameLabel;
        internal System.Windows.Forms.Button cancelButton;
        internal System.Windows.Forms.Button okButton;
        internal System.Windows.Forms.TextBox tbProcessName;
        internal System.Windows.Forms.TextBox tbGameClientName;
    }
}
