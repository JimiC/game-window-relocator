using System;
using System.Windows.Forms;
using GameWindowRelocator.Controllers;

namespace GameWindowRelocator.Views
{
    public partial class RemoveControl : UserControl
    {
        internal RemoveControl()
        {
            InitializeComponent();
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            GamesList.ListOfGames.Remove(ListControl.SelectedItem.Text);
            GamesList.Export();

            ShowListControl();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            ShowListControl();
        }

        private void ShowListControl()
        {
            Visible = false;
            Parent.Controls["listControl"].Visible = true;
            Parent.Controls["addEditControl"].Visible = false;
        }
   }
}
