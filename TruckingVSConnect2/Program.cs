using System;
using System.Diagnostics;
using System.Windows.Forms;
using UpdaterNET;
using WinFormsTranslator;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    static class Program
    {
        /// <summary>
        /// Main entry point
        /// </summary>
        [STAThread]
        static void Main()
        {
            Translator.TranslatorInterface = new TranslatorInterface();
            Translator.InitLanguage();
            try
            {
                UpdateTask update = new UpdateTask("https://raw.githubusercontent.com/BigETI/TruckingVSConnect2/master/update.json", Application.ExecutablePath);
                bool start_update = false;
                if (update.IsUpdateAvailable)
                {
                    start_update = (MessageBox.Show(string.Format(Translator.GetTranslation("UPDATE_MESSAGE"), update.Version), Translator.GetTranslation("UPDATE_AVAILABLE"), MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes);
                }
                if (start_update)
                {
                    try
                    {
                        Process.Start("TruckingVSConnect2Updater.exe");
                        Application.Exit();
                    }
                    catch (Exception e)
                    {
                        MessageBox.Show(e.Message, Translator.GetTranslation("ERROR"), MessageBoxButtons.YesNo, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    Application.EnableVisualStyles();
                    Application.SetCompatibleTextRenderingDefault(false);
                    Application.Run(new MainForm());
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(Translator.GetTranslation("FATAL_ERROR_MESSAGE") + ":\r\n\r\n" + e.Message, Translator.GetTranslation("FATAL_ERROR"), MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
