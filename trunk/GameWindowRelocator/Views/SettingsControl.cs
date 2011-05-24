using System;
using System.Globalization;
using System.Security;
using System.Windows.Forms;
using Microsoft.Win32;

namespace GameWindowRelocator.Views
{
    public partial class SettingsControl : UserControl
    {
        private const string StartupRegistryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        /// <summary>
        /// Initializes a new instance of the <see cref="SettingsControl"/> class.
        /// </summary>
        public SettingsControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Load event of the Settings control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void Settings_Load(object sender, EventArgs e)
        {
            // Run at system startup
            RegistryKey rk = null;
            try
            {
                rk = Registry.CurrentUser.OpenSubKey(StartupRegistryKey, true);
            }
            catch (SecurityException ex)
            {
                throw new SecurityException(ex.Message);
            }
            catch (UnauthorizedAccessException ex)
            {
                throw new UnauthorizedAccessException(ex.Message);
            }

            if (rk == null)
            {
                // No writing rights
                startWithWindowsCheckBox.Checked = false;
                startWithWindowsCheckBox.Enabled = false;
            }
            else
            {
                // Run at startup ?
                startWithWindowsCheckBox.Checked = (rk.GetValue("GameWindowRelocator") != null);
            }

            enableAutoRelacationChechBox.Checked = Properties.Settings.Default.EnableAutomaticRelocation;

            timeIntervalNUD.Value = Properties.Settings.Default.AutomaticRelocationInterval;
        }

        /// <summary>
        /// Handles the CheckedChanged event of the startWithWindowsCheckBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void startWithWindowsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Run at startup
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(StartupRegistryKey, true);
            if (startWithWindowsCheckBox.Checked)
            {
                rk.SetValue("GameWindowRelocator",
                    String.Format(CultureInfo.CurrentCulture, "\"{0}\" {1}",
                    Application.ExecutablePath.ToString(), "-startMinimized"));
            }
            else
            {
                rk.DeleteValue("GameWindowRelocator", false);
            }
        }

        /// <summary>
        /// Handles the CheckedChanged event of the enableAutoRelacationChechBox control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void enableAutoRelacationChechBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EnableAutomaticRelocation = enableAutoRelacationChechBox.Checked;
            Properties.Settings.Default.Save();
        }

        /// <summary>
        /// Handles the ValueChanged event of the timeIntervalNUD control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void timeIntervalNUD_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutomaticRelocationInterval = (byte)timeIntervalNUD.Value;
            Properties.Settings.Default.Save();
        }
    }
}
