using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using WinFormsTranslator;

/// <summary>
/// Trucking VS Connect 2 namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Main form class
    /// </summary>
    public partial class MainForm : MaterialForm
    {
        /// <summary>
        /// Authenticator
        /// </summary>
        private static TruckingVSAuth auth;

        /// <summary>
        /// Authenticator
        /// </summary>
        public static TruckingVSAuth Auth
        {
            get
            {
                return auth;
            }
            set
            {
                if (value != null)
                {
                    auth = value;
                }
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            Translator.TranslatorInterface = new TranslatorInterface();
            Translator.LoadTranslation(this);
            //Translator.EnumerableToComboBox(languagesComboBox, Translator.TranslatorInterface.Languages);

            MaterialSkinManager material_skin_manager = MaterialSkinManager.Instance;
            material_skin_manager.AddFormToManage(this);
            material_skin_manager.Theme = MaterialSkinManager.Themes.DARK;
            material_skin_manager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
        }

        /// <summary>
        /// Main form form closed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Configuration.Save();
        }

        /// <summary>
        /// Show login
        /// </summary>
        private void ShowLogin()
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            DialogResult = DialogResult.None;
        }

        /// <summary>
        /// Main form activated event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void MainForm_Activated(object sender, System.EventArgs e)
        {
            if (auth == null)
            {
                Hide();
                if ((Configuration.EmailUsername.Length > 0) && (Configuration.Password.Length > 0))
                {
                    // Auto log in
                    auth = TruckingVSAuth.Authenticate(Configuration.EmailUsername, Configuration.Password, false);
                    if (auth == null)
                    {
                        ShowLogin();
                    }
                }
                else
                {
                    ShowLogin();
                }
                if (auth == null)
                {
                    Close();
                }
                else
                {
                    // Load data
                    Show();
                }
            }
        }
    }
}
