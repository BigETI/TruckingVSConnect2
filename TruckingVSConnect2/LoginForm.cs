using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Login form class
    /// </summary>
    public partial class LoginForm : MaterialForm
    {
        /// <summary>
        /// Default constructor
        /// </summary>
        public LoginForm()
        {
            InitializeComponent();
            Translator.LoadTranslation(this);
            emailUsernameSingleLineTextField.Hint = Translator.GetTranslation("EMAIL_USERNAME_HINT");
            passwordSingleLineTextField.Hint = Translator.GetTranslation("PASSWORD_HINT");
            if (Configuration.EmailUsername.Length > 0)
            {
                emailUsernameSingleLineTextField.Text = Configuration.EmailUsername;
                saveEmailUsernameCheckBox.Checked = true;
            }
            Translator.EnumerableToComboBox(languagesComboBox, Translator.TranslatorInterface.Languages);
            int i = 0;
            foreach (Language language in Translator.TranslatorInterface.Languages)
            {
                if (language.Culture == Configuration.Language)
                {
                    languagesComboBox.SelectedIndex = i;
                    break;
                }
                ++i;
            }
            assemblyVersionLabel.Text += ": " + Assembly.GetExecutingAssembly().GetName().Version;
            fileVersionLabel.Text += ": " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion;
            productVersionLabel.Text += ": " + FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).ProductVersion;
        }

        /// <summary>
        /// Log in button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void logInButton_Click(object sender, EventArgs e)
        {
            string email_username = emailUsernameSingleLineTextField.Text.Trim();
            string password = passwordSingleLineTextField.Text;
            TruckingVSAPI auth = TruckingVSAPI.Authenticate(email_username, password, true);
            if (auth == null)
            {
                // Login failed
                MessageBox.Show("Email, Benutzername oder Passwort ist falsch!", "Anmeldefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MainForm.Auth = auth;
                Configuration.EmailUsername = saveEmailUsernameCheckBox.Checked ? email_username : "";
                Configuration.Password = autoLogInCheckBox.Checked ? TruckingVSAPI.SHA256String(password) : "";
                Configuration.Save();
                Close();
            }
        }

        /// <summary>
        /// Forgot password link label click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Link label link clicked event arguments</param>
        private void forgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.Execute("https://trucking-vs.de/account/forgot-password");
        }

        /// <summary>
        /// Save email or username checked changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void saveEmailUsernameCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            bool c = saveEmailUsernameCheckBox.Checked;
            if (!c)
            {
                autoLogInCheckBox.Checked = false;
            }
            autoLogInCheckBox.Enabled = c;
        }

        /// <summary>
        /// Languages combo box selected index changes event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void languagesComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = languagesComboBox.SelectedIndex;
            if (i >= 0)
            {
                List<Language> langs = new List<Language>(Translator.TranslatorInterface.Languages);
                if (Translator.ChangeLanguage(langs[i]))
                {
                    Application.Restart();
                }
            }
        }

        /// <summary>
        /// GitHub project large picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void gitHubProjectLargePictureBox_Click(object sender, EventArgs e)
        {
            Utils.Execute("https://github.com/BigETI/TruckingVSConnect2");
        }

        /// <summary>
        /// GitHub link label link clicked event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Link label clicked event arguments</param>
        private void gitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Utils.Execute("https://github.com/BigETI/TruckingVSConnect2");
        }
    }
}
