using System;
using System.Linq;
using System.Windows.Forms;
using GameWindowRelocator.Controllers;

namespace GameWindowRelocator.Views
{
    public partial class ListControl : UserControl
    {
        internal ListControl()
        {
            InitializeComponent();

            VisibleChanged += ListControl_VisibleChanged;

            GamesList.Import();
        }

        public static ListViewItem SelectedItem
        { get; private set; }

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

        private void ShowAddEditControl()
        {
            Visible = false;
            Parent.Controls["addEditControl"].Visible = true;
            Parent.Controls["removeControl"].Visible = false;
        }

        private void ListControl_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
                return;

            PopulateList();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddEditControl.Edit = false;
            ShowAddEditControl();
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            AddEditControl.Edit = true;
            ShowAddEditControl();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            Visible = false;
            Parent.Controls["addEditControl"].Visible = false;
            Parent.Controls["removeControl"].Visible = true;
        }

        private void listView_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = (listView.SelectedItems.Count > 0 ? listView.SelectedItems[0] : null);

            editButton.Enabled = removeButton.Enabled = (SelectedItem != null);
        }
    }
}
