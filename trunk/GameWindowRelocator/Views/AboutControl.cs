using System;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;

namespace GameWindowRelocator.Views
{
    public partial class AboutControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AboutControl"/> class.
        /// </summary>
        public AboutControl()
        {
            InitializeComponent();
        }

        private void AboutControl_Load(object sender, System.EventArgs e)
        {
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            versionLabel.Text = String.Format("Version {0}.{1}.{2}",
                version.Major, version.Minor, version.Build);
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://code.google.com/p/game-window-relocator/");
        }
    }
}
