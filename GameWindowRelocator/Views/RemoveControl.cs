using System;
using System.Windows.Forms;
using GameWindowRelocator.Controllers;

namespace GameWindowRelocator.Views
{
    public partial class RemoveControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RemoveControl"/> class.
        /// </summary>
        internal RemoveControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles the Click event of the yesButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void yesButton_Click(object sender, EventArgs e)
        {
            GamesList.ListOfGames.Remove(ListControl.SelectedItem.Text);
            GamesList.Export();

            ShowListControl();
        }

        /// <summary>
        /// Handles the Click event of the noButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void noButton_Click(object sender, EventArgs e)
        {
            ShowListControl();
        }

        /// <summary>
        /// Shows the list control.
        /// </summary>
        private void ShowListControl()
        {
            Visible = false;
            Parent.Controls["listControl"].Visible = true;
            Parent.Controls["addEditControl"].Visible = false;
        }
   }
}
