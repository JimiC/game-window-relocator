using System;
using System.Globalization;
using System.Security;
using System.Windows.Forms;
using Microsoft.Win32;

namespace GameWindowRelocator
{
    public partial class MainWindow : Form
    {
        private const string StartupRegistryKey = @"SOFTWARE\Microsoft\Windows\CurrentVersion\Run";

        private int m_relocatedMonitor = -1;


        public MainWindow()
        {
            InitializeComponent();
        }

        public MainWindow(bool startMinimized)
            : this()
        {
            if (!startMinimized)
                return;

            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            addEditControl.Visible = false;
            removeControl.Visible = false;

            timer.Start();

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

        private void RestoreMainWindow()
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            Activate();
        }

        /// <summary> 
        /// 
        /// </summary> 
        /// <param name="sender"></param> 
        /// <param name="e"></param> 
        private void relocationMenu_DropDownOpening(object sender, EventArgs e)
        {
            int screenCount = Screen.AllScreens.Length;
            var rootMenu = (ToolStripDropDownItem)sender;
            rootMenu.DropDownItems.Clear();

            // Add one menu entry per eve client 
            bool foundAny = false;
            var gameWindows = Relocator.FindGameWindows();
            foreach (IntPtr gameInstance in gameWindows)
            {
                // Skip if null ptr 
                if (gameInstance == IntPtr.Zero)
                    continue;

                // Relocator menu disabled when autorelocate is active or client is minimized 
                var instanceMenu = new ToolStripMenuItem(gameInstance.GetWindowDescription())
                {
                    Enabled = !gameInstance.IsMinimized() && !Relocator.AutoRelocationEnabled
                };

                var instanceCopy = gameInstance;

                // Let's add submenus 
                for (int i = 0; i < screenCount; i++)
                {
                    var screenCopy = i;

                    // Skip if client doesn't fit in screen 
                    if (gameInstance.GetClientRectInScreenCoords().Width > Screen.AllScreens[screenCopy].Bounds.Width)
                        continue;

                    var screenMenu = new ToolStripMenuItem(screenCopy.GetScreenDescription())
                    {
                        // When a client is relocated to a monitor we disable its selection option 
                        Enabled = !(gameInstance.IsRelocated() && m_relocatedMonitor == screenCopy)
                    };

                    // Handles the selection press 
                    screenMenu.Click += (senders, args) =>
                    {
                        Relocator.Relocate(instanceCopy, screenCopy);
                        m_relocatedMonitor = screenCopy;
                    };

                    // Adds the submenu 
                    instanceMenu.DropDownItems.Add(screenMenu);
                }

                // Add to the root menu. 
                rootMenu.DropDownItems.Add(instanceMenu);
                foundAny = true;
            }

            // Displays a "no window" message when there were no windows opened 
            if (!foundAny)
            {
                var menu = new ToolStripMenuItem("No listed game is running.")
                {
                    Enabled = false
                };
                rootMenu.DropDownItems.Add(menu);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                trayIconCMS.Visible = true;
                return;
            }

            RestoreMainWindow();
            tabControl.SelectedTab = tpGameList;
        }

        private void MainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall ||
                e.CloseReason == CloseReason.WindowsShutDown ||
                e.CloseReason == CloseReason.TaskManagerClosing)
                return;

            e.Cancel = true;
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            timer.Stop();
            Application.Exit();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreMainWindow();
            tabControl.SelectedTab = tpSettings;
        }

        private void startWithWindowsCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            // Run at startup
            RegistryKey rk = Registry.CurrentUser.OpenSubKey(StartupRegistryKey, true);
            if (startWithWindowsCheckBox.Checked)
            {
                rk.SetValue("GameWindowRelocator", String.Format(CultureInfo.CurrentCulture, "\"{0}\" {1}", Application.ExecutablePath.ToString(), "-startMinimized"));
            }
            else
            {
                rk.DeleteValue("GameWindowRelocator", false);
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Relocator.TimerTick();
        }

        private void enableAutoRelacationChechBox_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.EnableAutomaticRelocation = enableAutoRelacationChechBox.Checked;
            Properties.Settings.Default.Save();
        }

        private void timeIntervalNUD_ValueChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.AutomaticRelocationInterval = (byte)timeIntervalNUD.Value;
            Properties.Settings.Default.Save();
        }
    }
}