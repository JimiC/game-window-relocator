namespace GameWindowRelocator.Views
{
    partial class AboutControl
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
            this.aboutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // aboutLabel
            // 
            this.aboutLabel.AutoSize = true;
            this.aboutLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.aboutLabel.Location = new System.Drawing.Point(22, 30);
            this.aboutLabel.Name = "aboutLabel";
            this.aboutLabel.Size = new System.Drawing.Size(232, 176);
            this.aboutLabel.TabIndex = 1;
            this.aboutLabel.Text = "Game Window Relocator\r\n\r\n v1.0.0\r\n\r\nLicenced under GPL v2\r\n\r\nBased on code create" +
                "d by\r\nthe EVEMon Development Team\r\n\r\nCreated by Jimi C\r\nMay 2011\r\n";
            this.aboutLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AboutControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.aboutLabel);
            this.Name = "AboutControl";
            this.Size = new System.Drawing.Size(276, 236);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label aboutLabel;
    }
}
