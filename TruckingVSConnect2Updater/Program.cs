using System;
using System.Diagnostics;
using System.Windows.Forms;
using UpdaterNET;
using WinFormsTranslator;

/// <summary>
/// Trucking VS Connect² Updater namespace
/// </summary>
namespace TruckingVSConnect2Updater
{
    /// <summary>
    /// Program class
    /// </summary>
    static class Program
    {
        /// <summary>
        /// Main entry point
        /// </summary>
        [STAThread]
        static void Main()
        {
            Translator.TranslatorInterface = new TranslatorInterface();
            UpdateTask update = new UpdateTask("https://raw.githubusercontent.com/BigETI/TruckingVSConnect2/master/update.json", Application.ExecutablePath);
            bool start_update = false;
            if (update.IsUpdateAvailable)
            {
                start_update = (MessageBox.Show(Translator.GetTranslation("UPDATE_MESSAGE"), Translator.GetTranslation("UPDATE_AVAILABLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes);
            }
            if (start_update)
            {
                try
                {
                    Process.Start("TruckingVSConnect2Updater.exe");
                }
                catch (Exception e)
                {
                    MessageBox.Show(e.Message, Translator.GetTranslation("ERROR"), MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                }
            }
            else
            {
                try
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
                catch (Exception e)
                {
                    MessageBox.Show(Translator.GetTranslation("FATAL_ERROR_MESSAGE") + ":\r\n\r\n" + e.Message, Translator.GetTranslation("FATAL_ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            Application.Exit();
        }
    }
}
