using System;
using System.Windows.Forms;
using GameWindowRelocator.Controllers;

namespace GameWindowRelocator.Views
{
    public partial class AddEditControl : UserControl
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AddEditControl"/> class.
        /// </summary>
        internal AddEditControl()
        {
            InitializeComponent();

            if (DesignMode)
                return;

            VisibleChanged += AddEditControl_VisibleChanged;
        }

        /// <summary>
        /// Gets or sets a value indicating whether this <see cref="AddEditControl"/> is edit.
        /// </summary>
        /// <value><c>true</c> if edit; otherwise, <c>false</c>.</value>
        internal static bool Edit { get; set; }

        /// <summary>
        /// Handles the VisibleChanged event of the AddEditControl control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void AddEditControl_VisibleChanged(object sender, EventArgs e)
        {
            if (!Visible)
                return;

            tbGameClientName.ResetText();
            tbProcessName.ResetText();

            if (Edit)
                EditEntry();
        }

        /// <summary>
        /// Edits the entry.
        /// </summary>
        private void EditEntry()
        {
            tbGameClientName.Text = ListControl.SelectedItem.Text;
            tbProcessName.Text = ListControl.SelectedItem.SubItems[1].Text;
            GamesList.ListOfGames.Remove(ListControl.SelectedItem.Text);
        }

        /// <summary>
        /// Handles the Click event of the okButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
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

        /// <summary>
        /// Handles the Click event of the cancelButton control.
        /// </summary>
        /// <param name="sender">The source of the event.</param>
        /// <param name="e">The <see cref="System.EventArgs"/> instance containing the event data.</param>
        private void cancelButton_Click(object sender, EventArgs e)
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
            Parent.Controls["removeControl"].Visible = false;
        }
    }
}
