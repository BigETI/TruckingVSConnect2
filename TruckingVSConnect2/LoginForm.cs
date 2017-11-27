using MaterialSkin.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsTranslator;

namespace TruckingVSConnect2
{
    public partial class LoginForm : MaterialForm
    {
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

        private void loginButton_Click(object sender, EventArgs e)
        {
            string email_username = emailUsernameSingleLineTextField.Text.Trim();
            string password = passwordSingleLineTextField.Text;
            TruckingVSAuth auth = TruckingVSAuth.Authenticate(email_username, password, true);
            if (auth == null)
            {
                // Login failed
                MessageBox.Show("Email, Benutzername oder Passwort ist falsch!", "Anmeldefehler", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MainForm.Auth = auth;
                Configuration.EmailUsername = saveEmailUsernameCheckBox.Checked ? email_username : "";
                Configuration.Password = autoLogInCheckBox.Checked ? TruckingVSAuth.SHA256(password) : "";
                Configuration.Save();
                Close();
            }
        }

        private void forgotPasswordLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://trucking-vs.de/account/forgot-password");
            }
            catch (Exception _e)
            {
                Console.Error.WriteLine(_e.Message);
            }
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

        private void gitHubProjectLargePictureBox_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start("https://github.com/BigETI/TruckingVSConnect2");
            }
            catch (Exception _e)
            {
                Console.Error.WriteLine(_e.Message);
            }
        }

        private void gitHubLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                Process.Start("https://github.com/BigETI/TruckingVSConnect2");
            }
            catch (Exception _e)
            {
                Console.Error.WriteLine(_e.Message);
            }
        }
    }
}
