using MaterialSkin.Controls;
using System;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Text edit form class
    /// </summary>
    public partial class TextEditForm : MaterialForm
    {
        /// <summary>
        /// Value
        /// </summary>
        public string Value
        {
            get
            {
                return valueTextField.Text;
            }
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="value">Value</param>
        /// <param name="title">Title</param>
        public TextEditForm(string value, string title, string hint)
        {
            InitializeComponent();
            Translator.LoadTranslation(this);
            valueTextField.Text = value;
            Text = title;
            valueTextField.Hint = hint;
        }

        /// <summary>
        /// OK button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void okButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }

        /// <summary>
        /// Cancel button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Value text field key up event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Key event arguments</param>
        private void valueTextField_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Escape:
                    Close();
                    break;
                case Keys.Enter:
                    DialogResult = DialogResult.OK;
                    Close();
                    break;
            }
        }
    }
}
