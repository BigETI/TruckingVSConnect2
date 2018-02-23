using MaterialSkin.Controls;
using System;
using System.Data;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Find users form
    /// </summary>
    public partial class FindUsersForm : MaterialForm
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FindUsersForm()
        {
            InitializeComponent();
            Translator.LoadTranslation(this);
            filterTextField.Hint = Translator.GetTranslation("USERNAME_HINT");
            foundUsersGridView.Columns[0].HeaderText = Translator.GetTranslation("NAME");
            FindUsers();
        }

        /// <summary>
        /// Find users
        /// </summary>
        private void FindUsers()
        {
            string[] found_users = Truckers2ConnectAPI.FindUsers(filterTextField.Text.Trim());
            foundUsersDataTable.Rows.Clear();
            foreach (string found_user in found_users)
            {
                DataRow row = foundUsersDataTable.NewRow();
                object[] data = new object[1];
                data[0] = found_user;
                row.ItemArray = data;
                foundUsersDataTable.Rows.Add(row);
            }
        }

        /// <summary>
        /// Filter text field key up event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Key event arguments</param>
        private void filterTextField_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    FindUsers();
                    break;
                case Keys.Escape:
                    Close();
                    break;
            }
        }

        /// <summary>
        /// Add user picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void addUserPictureBox_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in foundUsersGridView.SelectedRows)
            {
                Utils.ShowAddUserDialog(row.Cells[0].Value.ToString());
                break;
            }
        }
    }
}
