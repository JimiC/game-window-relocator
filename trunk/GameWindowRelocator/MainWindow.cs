using System;
using System.Windows.Forms;
using GameWindowRelocator.Controllers;

namespace GameWindowRelocator
{
    public partial class MainWindow : Form
    {

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MainWindow"/> class.
        /// </summary>
        /// <param name="startMinimized">if set to <c>true</c> start minimized.</param>
        public MainWindow(bool startMinimized)
            : this()
        {
            if (!startMinimized)
                return;

            MinimizeMainWindow();
        }

        /// <summary>
        /// Handles the Load event of the MainWindow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void MainWindow_Load(object sender, EventArgs e)
        {
            if (DesignMode)
                return;

            Visible = false;
            addEditControl.Visible = false;
            removeControl.Visible = false;

            timer.Start();
        }

        /// <summary>
        /// Minimizes the main window.
        /// </summary>
        private void MinimizeMainWindow()
        {
            WindowState = FormWindowState.Minimized;
            ShowInTaskbar = false;
            Visible = ShowInTaskbar;
        }

        /// <summary>
        /// Restores the main window.
        /// </summary>
        private void RestoreMainWindow()
        {
            Visible = true;
            ShowInTaskbar = Visible;
            WindowState = FormWindowState.Normal;
            Activate();
        }

        /// <summary>
        /// Handles the DropDownOpening event of the actionToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void actionToolStripMenuItem_DropDownOpening(object sender, EventArgs e)
        {
            int screenCount = Screen.AllScreens.Length;
            var rootMenu = (ToolStripDropDownItem)sender;
            rootMenu.DropDownItems.Clear();

            PositioningAction action = PositioningAction.None;
            if (Enum.IsDefined(typeof(PositioningAction), rootMenu.Text))
                action = (PositioningAction)Enum.Parse(typeof(PositioningAction), rootMenu.Text, true);

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
                    screenMenu.Enabled = (action == PositioningAction.Relocate ? !gameInstance.IsRelocated() : gameInstance.IsRelocated());

                    // Handles the selection press 
                    screenMenu.Click += (senders, args) =>
                    {
                        Relocator.PositionWindow(instanceCopy, screenCopy, action);
                    };

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
                                action == PositioningAction.Relocate ? "running." : "relocated.");

                var menu = new ToolStripMenuItem(text)
                {
                    Enabled = false
                };
                rootMenu.DropDownItems.Add(menu);
            }
        }

        /// <summary>
        /// Handles the MouseDoubleClick event of the notifyIcon control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.MouseEventArgs"/> instance containing the event data.</param>
        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
                return;

            RestoreMainWindow();
            tabControl.SelectedTab = tpGamesList;
        }

        /// <summary>
        /// Handles the FormClosing event of the mainWindow control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.Windows.Forms.FormClosingEventArgs"/> instance containing the event data.</param>
        private void mainWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.ApplicationExitCall ||
                e.CloseReason == CloseReason.WindowsShutDown ||
                e.CloseReason == CloseReason.TaskManagerClosing)
                return;

            e.Cancel = true;
            MinimizeMainWindow();
        }

        /// <summary>
        /// Handles the Click event of the exitToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.Save();
            timer.Stop();
            Application.Exit();
        }

        /// <summary>
        /// Handles the Click event of the gamesListToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void gamesListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreMainWindow();
            tabControl.SelectedTab = tpGamesList;
        }

        /// <summary>
        /// Handles the Click event of the settingsToolStripMenuItem control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RestoreMainWindow();
            tabControl.SelectedTab = tpSettings;
        }

        /// <summary>
        /// Handles the Tick event of the timer control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void timer_Tick(object sender, EventArgs e)
        {
            Relocator.TimerTick();
        }
    }
}