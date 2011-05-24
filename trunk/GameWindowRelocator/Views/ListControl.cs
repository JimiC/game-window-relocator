using System;
using System.Linq;
using System.Windows.Forms;
using GameWindowRelocator.Controllers;

namespace GameWindowRelocator.Views
{
    public partial class ListControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ListControl"/> class.
        /// </summary>
        internal ListControl()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            VisibleChanged += ListControl_VisibleChanged;
            
            GamesList.Import();
        }

        /// <summary>
        /// Gets or sets the selected item.
        /// </summary>
        /// <value>The selected item.</value>
        public static ListViewItem SelectedItem { get; private set; }

        /// <summary>
        /// Populates the list.
        /// </summary>
        private void PopulateList()
        {
            listView.Items.Clear();

            foreach (var game in GamesList.ListOfGames.OrderBy(x => x.Key))
            {
                var listItem = new ListViewItem(game.Key);
                listItem.SubItems.Add(game.Value);
                listView.Items.Add(listItem);
            }

            listView_SelectedIndexChanged(null, EventArgs.Empty);
        }

        /// <summary>
        /// Shows the add edit control.
        /// </summary>
        private void ShowAddEditControl()
        {
            Visible = false;
            Parent.Controls["addEditControl"].Visible = true;
            Parent.Controls["removeControl"].Visible = false;
        }

        /// <summary>
        /// Handles the VisibleChanged event of the ListControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void ListControl_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
                return;

            PopulateList();
        }

        /// <summary>
        /// Handles the Click event of the addButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void addButton_Click(object sender, EventArgs e)
        {
            AddEditControl.Edit = false;
            ShowAddEditControl();
        }

        /// <summary>
        /// Handles the Click event of the editButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void editButton_Click(object sender, EventArgs e)
        {
            AddEditControl.Edit = true;
            ShowAddEditControl();
        }

        /// <summary>
        /// Handles the Click event of the removeButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void removeButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            Parent.Controls["addEditControl"].Visible = false;
            Parent.Controls["removeControl"].Visible = true;
        }

        /// <summary>
        /// Handles the SelectedIndexChanged event of the listView control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = (listView.SelectedItems.Count > 0 ? listView.SelectedItems[0] : null);

            editButton.Enabled = removeButton.Enabled = (SelectedItem != null);
        }
    }
}
