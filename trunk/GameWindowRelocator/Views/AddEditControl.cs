using System;
using System.Windows.Forms;
using GameWindowRelocator.Controllers;

namespace GameWindowRelocator.Views
{
    public partial class AddEditControl : UserControl
    {
        internal AddEditControl()
        {
            InitializeComponent();

            VisibleChanged += AddEditControl_VisibleChanged;
        }

        internal static bool Edit
        { get; set; }

        private void AddEditControl_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
                return;

            tbGameClientName.ResetText();
            tbProcessName.ResetText();

            if (Edit)
                EditEntry();
        }

        private void EditEntry()
        {
            tbGameClientName.Text = ListControl.SelectedItem.Text;
            tbProcessName.Text = ListControl.SelectedItem.SubItems[1].Text;
            GamesList.ListOfGames.Remove(ListControl.SelectedItem.Text);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(tbGameClientName.Text) ||
                String.IsNullOrEmpty(tbProcessName.Text))
                return;

            if (GamesList.ListOfGames.ContainsKey(tbGameClientName.Text) ||
                GamesList.ListOfGames.ContainsValue(tbProcessName.Text))
                return;

            GamesList.ListOfGames.Add(tbGameClientName.Text, tbProcessName.Text);
            GamesList.Export();

            ShowListControl();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            ShowListControl();
        }

        private void ShowListControl()
        {
            Visible = false;
            Parent.Controls["listControl"].Visible = true;
            Parent.Controls["removeControl"].Visible = false;
        }
    }
}
