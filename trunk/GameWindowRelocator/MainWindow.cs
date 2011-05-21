using System;
using System.Windows.Forms;

namespace GameWindowRelocator
{
    public partial class MainWindow : Form
    {

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

            MinimizeMainWindow();
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            Visible = false;
            addEditControl.Visible = false;
            removeControl.Visible = false;

            timer.Start();
        }

        private void MinimizeMainWindow()
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = ShowInTaskbar;
        }

        private void RestoreMainWindow()
        {
            Visible = true;
            ShowInTaskbar = Visible;
            WindowState = FormWindowState.Normal;
            Activate();
        }

        private void actionToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            int screenCount = Screen.AllScreens.Length;
            var rootMenu = (ToolStripDropDownItem)sender;
            rootMenu.DropDownItems.Clear();

            Action action = Action.None;
            if (Enum.IsDefined(typeof(Action), rootMenu.Text))
                action = (Action)Enum.Parse(typeof(Action), rootMenu.Text, true);

            // Add one menu entry per game client 
            bool foundAny = false;
            var gameWindows = Relocator.FindGameWindows();
            foreach (IntPtr gameInstance in gameWindows)
            {
                // Skip if null ptr 
                if (gameInstance == IntPtr.Zero)
                    continue;

                // Action menu disabled when autorelocate is active or client is minimized 
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

                    var screenMenu = new ToolStripMenuItem(screenCopy.GetScreenDescription());
                    screenMenu.Enabled = (action == Action.Relocate ? !gameInstance.IsRelocated() : gameInstance.IsRelocated());

                    // Handles the selection press 
                    if (action == Action.Relocate)
                    {
                        screenMenu.Click += (senders, args) =>
                        {
                            Relocator.Relocate(instanceCopy, screenCopy);
                            m_relocatedMonitor = screenCopy;
                        };
                    }
                    else if (action == Action.Release)
                    {
                        screenMenu.Click += (senders, args) =>
                        {
                            Relocator.Release(instanceCopy, screenCopy);
                        };
                    }

                    // Adds the submenu 
                    instanceMenu.DropDownItems.Add(screenMenu);
                }

                // Add to the root menu. 
                rootMenu.DropDownItems.Add(instanceMenu);
                foundAny = true;
            }

            // Displays a message when there were no windows found
            if (!foundAny)
            {
                string text = String.Format("No listed game is {0}",
                                action == Action.Relocate ? "running." : "relocated.");

                var menu = new ToolStripMenuItem(text)
                {
                    Enabled = false
                };
                rootMenu.DropDownItems.Add(menu);
            }
        }

        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return;

            RestoreMainWindow();
            tabControl.SelectedTab = tpGamesList;
        }

        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall ||
                e.CloseReason == CloseReason.WindowsShutDown ||
                e.CloseReason == CloseReason.TaskManagerClosing)
                return;

            e.Cancel = true;
            MinimizeMainWindow();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            timer.Stop();
            Application.Exit();
        }

        private void gamesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreMainWindow();
            tabControl.SelectedTab = tpGamesList;
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreMainWindow();
            tabControl.SelectedTab = tpSettings;
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            Relocator.TimerTick();
        }

        private enum Action
        {
            None = -1,
            Relocate = 0,
            Release = 1
        }
    }
}