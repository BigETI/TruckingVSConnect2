using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;
using VDF;
using WinFormsTranslator;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Plugin manager class
    /// </summary>
    public static class PluginManager
    {
        /// <summary>
        /// Source x86 plugin
        /// </summary>
        private static readonly string sourceX86Plugin = "./plugins/Win32/ets2-telemetry.dll";

        /// <summary>
        /// Source x64 plugin
        /// </summary>
        private static readonly string sourceX64Plugin = "./plugins/Win64/ets2-telemetry.dll";

        /// <summary>
        /// Source x86 plugin
        /// </summary>
        private static string sourceX86PluginHash;

        /// <summary>
        /// Source x64 plugin
        /// </summary>
        private static string sourceX64PluginHash;

        /// <summary>
        /// Euro Truck Simulator 2 directory
        /// </summary>
        private static string ets2Directory;

        /// <summary>
        /// American Truck Simulator directory
        /// </summary>
        private static string atsDirectory;

        /// <summary>
        /// Steam games paths
        /// </summary>
        private static List<string> steamGamesPaths;

        /// <summary>
        /// Source x86 plugin
        /// </summary>
        private static string SourceX86PluginHash
        {
            get
            {
                if (sourceX86PluginHash == null)
                {
                    sourceX86PluginHash = Utils.SHA512FromFile(sourceX86Plugin);
                }
                return sourceX86PluginHash;
            }
        }

        /// <summary>
        /// Source x64 plugin
        /// </summary>
        private static string SourceX64PluginHash
        {
            get
            {
                if (sourceX64PluginHash == null)
                {
                    sourceX64PluginHash = Utils.SHA512FromFile(sourceX64Plugin);
                }
                return sourceX64PluginHash;
            }
        }

        /// <summary>
        /// Euro Truck Simulator 2 directory
        /// </summary>
        private static string ETS2Directory
        {
            get
            {
                if (ets2Directory != null)
                {
                    if (!(Directory.Exists(ets2Directory)))
                    {
                        ets2Directory = null;
                    }
                }
                return ((ets2Directory == null) ? FindGamePath(EGame.ETS2) : ets2Directory);
            }
        }

        /// <summary>
        /// American Truck Simulator directory
        /// </summary>
        private static string ATSDirectory
        {
            get
            {
                if (atsDirectory != null)
                {
                    if (!(Directory.Exists(atsDirectory)))
                    {
                        atsDirectory = null;
                    }
                }
                return ((atsDirectory == null) ? FindGamePath(EGame.ATS) : atsDirectory);
            }
        }

        /// <summary>
        /// Steam games paths
        /// </summary>
        private static IEnumerable<string> SteamGamesPaths
        {
            get
            {
                if (steamGamesPaths == null)
                {
                    steamGamesPaths = new List<string>();
                    try
                    {
                        string config_file = Path.Combine(Registry.GetValue("HKEY_CURRENT_USER\\Software\\Valve\\Steam", "SteamPath", "").ToString(), "config\\config.vdf");
                        if (File.Exists(config_file))
                        {
                            SteamConfigFile cfg = new SteamConfigFile(config_file);
                            NestedElement element = cfg.SteamElement;
                            if (element != null)
                            {
                                string n = "BaseInstallFolder_";
                                int v = 1;
                                string nv = n + v;
                                while (element.Children.ContainsKey(nv))
                                {
                                    string steam_games_path = element.Children[nv].Value;
                                    if (Directory.Exists(steam_games_path))
                                    {
                                        steamGamesPaths.Add(steam_games_path);
                                    }
                                    ++v;
                                    nv = n + v;
                                }
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Debug.Print(e.Message);
                    }
                }
                return steamGamesPaths;
            }
        }

        /// <summary>
        /// Is Euro Truck Simulator installed
        /// </summary>
        private static bool IsETS2Installed
        {
            get
            {
                return (ETS2Directory.Length > 0);
            }
        }

        /// <summary>
        /// Is American Truck Simulator installed
        /// </summary>
        private static bool IsATSInstalled
        {
            get
            {
                return (ATSDirectory.Length > 0);
            }
        }

        /// <summary>
        /// Find game path
        /// </summary>
        /// <param name="game">Game</param>
        /// <returns>Game path</returns>
        private static string FindGamePath(EGame game)
        {
            string ret = null;
            if (Configuration.IsGameDirectorySpecified(game))
            {
                ret = Configuration.GetGameDirectory(game);
            }
            else
            {
                string game_name = Utils.GetGameName(game);
                foreach (string steam_games_path in SteamGamesPaths)
                {
                    ret = Path.Combine(steam_games_path, "steamapps\\common\\", game_name, "bin");
                    if (Directory.Exists(ret))
                    {
                        Configuration.SetGameDirectory(game, ret);
                        break;
                    }
                    else
                    {
                        ret = null;
                    }
                }
                if (ret == null)
                {
                    if (Configuration.GetAskForDirectoryIfGameDirectoryNotFound(game))
                    {
                        DialogResult result = MessageBox.Show(string.Format(Translator.GetTranslation("GAME_DIRECTORY_NOT_FOUND_MESSAGE"), game_name), Translator.GetTranslation("GAME_DIRECTORY_NOT_FOUND"), MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning);
                        switch (result)
                        {
                            case DialogResult.Yes:
                                using (FolderBrowserDialog dialog = new FolderBrowserDialog())
                                {
                                    if (dialog.ShowDialog() == DialogResult.OK)
                                    {
                                        ret = dialog.SelectedPath;
                                    }
                                }
                                break;
                            case DialogResult.No:
                                Configuration.SetAskForDirectoryIfGameDirectoryNotFound(game, false);
                                break;
                        }
                    }
                }
            }
            return ((ret == null) ? "" : ret);
        }

        /// <summary>
        /// Install plugins
        /// </summary>
        public static void InstallPlugins()
        {
            if (File.Exists(sourceX86Plugin) && File.Exists(sourceX64Plugin))
            {
                InstallPlugin(EGame.ETS2);
                InstallPlugin(EGame.ATS);
                Configuration.Save();
            }
        }

        /// <summary>
        /// Is game installed
        /// </summary>
        /// <param name="game">Game</param>
        /// <returns>"true" if installed, otherwise "false"</returns>
        private static bool IsGameInstalled(EGame game)
        {
            bool ret = false;
            switch (game)
            {
                case EGame.ETS2:
                    ret = IsETS2Installed;
                    break;
                case EGame.ATS:
                    ret = IsATSInstalled;
                    break;
            }
            return ret;
        }

        /// <summary>
        /// Get game directory
        /// </summary>
        /// <param name="game">Game</param>
        /// <returns>Game directory</returns>
        private static string GetGameDirectory(EGame game)
        {
            string ret = "";
            switch (game)
            {
                case EGame.ETS2:
                    ret = ETS2Directory;
                    break;
                case EGame.ATS:
                    ret = ATSDirectory;
                    break;
            }
            return ret;
        }

        /// <summary>
        /// Install plugin
        /// </summary>
        /// <param name="game">Game</param>
        private static void InstallPlugin(EGame game)
        {
            if (IsGameInstalled(game))
            {
                string game_directory = GetGameDirectory(game);
                string x86_plugins_path = Path.Combine(game_directory, "win_x86\\plugins");
                string x64_plugins_path = Path.Combine(game_directory, "win_x64\\plugins");
                bool success = true;
                if (!(Directory.Exists(x86_plugins_path)))
                {
                    try
                    {
                        Directory.CreateDirectory(x86_plugins_path);
                    }
                    catch (Exception e)
                    {
                        success = false;
                        Debug.Print(e.Message);
                    }
                }
                if (success && (!(Directory.Exists(x64_plugins_path))))
                {
                    try
                    {
                        Directory.CreateDirectory(x64_plugins_path);
                    }
                    catch (Exception e)
                    {
                        success = false;
                        Debug.Print(e.Message);
                    }
                }
                if (success)
                {
                    TryInstall(sourceX86Plugin, Path.Combine(x86_plugins_path, "ets2-telemetry.dll"), SourceX86PluginHash);
                    TryInstall(sourceX64Plugin, Path.Combine(x64_plugins_path, "ets2-telemetry.dll"), SourceX64PluginHash);
                }
            }
        }

        /// <summary>
        /// Try install
        /// </summary>
        /// <param name="source">Source</param>
        /// <param name="destination">Destination</param>
        /// <param name="source_hash">Source hash</param>
        private static void TryInstall(string source, string destination, string source_hash)
        {
            if (File.Exists(destination))
            {
                string hash = Utils.SHA512FromFile(destination);
                if (hash != source_hash)
                {
                    if (TellToCloseGame())
                    {
                        try
                        {
                            File.Delete(destination);
                            File.Copy(source, destination);
                        }
                        catch (Exception e)
                        {
                            Debug.Print(e.Message);
                        }
                    }
                }
            }
            else
            {
                if (TellToCloseGame())
                {
                    try
                    {
                        File.Copy(source, destination);
                    }
                    catch (Exception e)
                    {
                        Debug.Print(e.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Tell to close the game
        /// </summary>
        /// <returns>"true" if action should be performed, otherwise "false"</returns>
        private static bool TellToCloseGame()
        {
            bool ret = true;
            while (Utils.IsAGameRunning)
            {
                if (MessageBox.Show(string.Format(Translator.GetTranslation("CLOSE_GAME_MESSAGE"), Utils.RunningGameName), Translator.GetTranslation("CLOSE_GAME"), MessageBoxButtons.RetryCancel, MessageBoxIcon.Warning) == DialogResult.Cancel)
                {
                    ret = false;
                    break;
                }
            }
            return ret;
        }
    }
}
