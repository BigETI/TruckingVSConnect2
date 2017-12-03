using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
using UpdaterNET;
using WinFormsTranslator;

/// <summary>
/// Trucking VS Connect² Updater namespace
/// </summary>
namespace TruckingVSConnect2Updater
{
    /// <summary>
    /// Main form class
    /// </summary>
    public partial class MainForm : MaterialForm
    {
        /// <summary>
        /// Animation state
        /// </summary>
        private uint animationState;

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            Translator.TranslatorInterface = new TranslatorInterface();
            Translator.LoadTranslation(this);
            MaterialSkinManager material_skin_manager = MaterialSkinManager.Instance;
            material_skin_manager.AddFormToManage(this);
            material_skin_manager.Theme = MaterialSkinManager.Themes.DARK;
            material_skin_manager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            TaskbarProgress.SetState(this, TaskbarProgress.TaskbarStates.Normal);
        }

        /// <summary>
        /// Close application
        /// </summary>
        private static void CloseApp()
        {
            try
            {
                Process.Start("TruckingVSConnect2.exe");
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, Translator.GetTranslation("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Application.Exit();
        }

        /// <summary>
        /// Main form load event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void MainForm_Load(object sender, EventArgs e)
        {
            UpdateTask update = new UpdateTask("https://raw.githubusercontent.com/BigETI/TruckingVSConnect2/master/update.json", Directory.GetCurrentDirectory() + "\\TruckingVSConnect2.exe");
            update.DownloadProgressChanged += OnDownloadProgressChanged;
            update.UpdateTaskFinished += OnUpdateTaskFinished;
            if (update.IsUpdateAvailable)
            {
                update.InstallUpdates();
            }
            else
            {
                CloseApp();
            }
        }

        /// <summary>
        /// On download progress changed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Download progress changed event arguments</param>
        private void OnDownloadProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            downloadProgressBar.Maximum = (int)(e.TotalBytesToReceive);
            downloadProgressBar.Value = (int)(e.BytesReceived);
            TaskbarProgress.SetValue(this, e.BytesReceived, e.TotalBytesToReceive);
        }

        /// <summary>
        /// On updates installed
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Update task finished event arguments</param>
        private void OnUpdateTaskFinished(object sender, UpdateTaskFinishedEventArgs e)
        {
            if (e.IsError)
            {
                MessageBox.Show(e.Error, Translator.GetTranslation("ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            CloseApp();
        }

        /// <summary>
        /// Animation timer tick event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void animationTimer_Tick(object sender, EventArgs e)
        {
            animationState++;
            if (animationState > 3U)
            {
                animationState = 0U;
            }
            progressLabel.Text = Translator.GetTranslation("UPDATING") + new string('.', (int)animationState);
        }

        /// <summary>
        /// Main form form closing event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Form closing event arguments</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool cancel = false;
            if (e.CloseReason == CloseReason.UserClosing)
            {
                cancel = (MessageBox.Show(Translator.GetTranslation("CANCEL_UPDATE_QUESTION"), Translator.GetTranslation("CANCEL_UPDATE"), MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes);
            }
            e.Cancel = cancel;
        }
    }
}
