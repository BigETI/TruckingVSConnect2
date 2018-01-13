using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
using System.Windows.Forms;
using TruckingVSConnect2.Properties;
using WinFormsTranslator;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Utilities class
    /// </summary>
    public static class Utils
    {
        /// <summary>
        /// Last game check timestamp
        /// </summary>
        private static DateTime lastGameCheckTimestamp;

        /// <summary>
        /// Running game
        /// </summary>
        private static EGame runningGame;

        /// <summary>
        /// And translated
        /// </summary>
        //private static string andTranslated;

        /// <summary>
        /// Backwards translated
        /// </summary>
        private static string backwardsTranslated;

        /// <summary>
        /// Clamp
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="val"></param>
        /// <param name="min"></param>
        /// <param name="max"></param>
        /// <returns></returns>
        public static T Clamp<T>(this T val, T min, T max) where T : IComparable<T>
        {
            return (val.CompareTo(min) < 0) ? min : ((val.CompareTo(max) > 0) ? max : val);
        }

        /// <summary>
        /// Color gradient
        /// </summary>
        /// <param name="fromColor">From color</param>
        /// <param name="toColor">To color</param>
        /// <param name="time">Time from 0 to 1</param>
        /// <returns>Result color</returns>
        public static Color ColorGradient(Color fromColor, Color toColor, float time)
        {
            float t = ((time < 0.0f) ? 0.0f : ((time > 1.0f) ? 1.0f : time));
            return Color.FromArgb((int)((fromColor.A * (1.0f - t)) + (toColor.A * t)),
                (int)((fromColor.R * (1.0f - t)) + (toColor.R * t)),
                (int)((fromColor.G * (1.0f - t)) + (toColor.G * t)),
                (int)((fromColor.B * (1.0f - t)) + (toColor.B * t)));
        }

        /// <summary>
        /// SHA512 from file
        /// </summary>
        /// <param name="path">Path</param>
        /// <returns>SHA512 in Base64</returns>
        public static string SHA512FromFile(string path)
        {
            string ret = "";
            try
            {
                if (File.Exists(path))
                {
                    using (SHA512 sha512 = System.Security.Cryptography.SHA512.Create())
                    {
                        if (File.Exists(path))
                        {
                            using (StreamReader reader = new StreamReader(path))
                            {
                                ret = Convert.ToBase64String(sha512.ComputeHash(reader.BaseStream));
                            }
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
            return ret;
        }

        /// <summary>
        /// Execute command
        /// </summary>
        /// <param name="command">Command</param>
        public static void Execute(string command)
        {
            try
            {
                Process.Start(command);
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Convert m/s to km/h or mph
        /// </summary>
        /// <param name="speed">Speed</param>
        /// <returns>Converted speed as km/h or mph</returns>
        public static float ConvertSpeed(float speed)
        {
            return (speed * (Configuration.UseMetricUnit ? 3.6f : 2.2369362920544f));
        }

        /// <summary>
        /// Human readable length
        /// </summary>
        /// <param name="length">Length in meters</param>
        /// <returns>Human readable length in "km or m" or "ml or yd"</returns>
        public static string HumanReadableLength(float length)
        {
            if (backwardsTranslated == null)
            {
                backwardsTranslated = Translator.GetTranslation("BACKWARDS");
            }
            int l = (int)(Math.Ceiling(Math.Abs(length) * (Configuration.UseMetricUnit ? 1.0f : 1.093613f)));
            int ngu = (Configuration.UseMetricUnit ? 1000 : 1760);
            int gl = (l / ngu);
            return (((gl > 0) ? (gl + (Configuration.UseMetricUnit ? " km" : " ml")) : ((l % ngu) + (Configuration.UseMetricUnit ? " m" : " yd"))) + ((length < 0.0f) ? (" (" + backwardsTranslated + ")") : ""));
        }

        /// <summary>
        /// Human readable weight
        /// </summary>
        /// <param name="weight">Weight in kg</param>
        /// <returns>Human readable weight in "t" or "kg"</returns>
        public static string HumanReadableWeight(float weight)
        {
            return Math.Round(weight * 0.001f, 2).ToString() + " t";

            /*int w = (int)weight;
            int t = w / 1000;
            int kg = w % 1000;
            return ((t > 0) ? (Math.Round(t + (kg / 1000.0), 2) + " t") : (Math.Round(kg + (weight - w), 2) + " kg"));*/
        }

        /// <summary>
        /// Human readable time
        /// </summary>
        /// <param name="time">Time in seconds</param>
        /// <returns>Human readable time in "d", "h", "min" or "s"</returns>
        public static string HumanReadableTime(float time)
        {
            int s = (int)(Math.Ceiling(time));
            int min = (s / 60) % 60;
            int h = (s / 3600);
            return string.Format((h < 100) ? "{0:00}:{1:00}h" : "{0}:{1:00}h", h, min);

            /*int s = (int)(Math.Ceiling(time));
            int min = (s / 60) % 60;
            int h = (s / 3600) % 24;
            int d = (s / 86400);
            return ((d > 0) ? (d + " d") : ((h > 0) ? (h + " h") : ((min > 0) ? (min + " min") : (s + " s"))));*/
        }

        /// <summary>
        /// Running game
        /// </summary>
        public static EGame RunningGame
        {
            get
            {
                if ((DateTime.Now - lastGameCheckTimestamp).TotalSeconds > 2)
                {
                    EGame game = EGame.Nothing;
                    lastGameCheckTimestamp = DateTime.Now;
                    foreach (Process process in Process.GetProcesses())
                    {
                        try
                        {
                            if (process.ProcessName == "eurotrucks2")
                            {
                                game = EGame.ETS2;
                                break;
                            }
                            else if (process.ProcessName == "amtrucks")
                            {
                                game = EGame.ATS;
                                break;
                            }
                        }
                        catch (Exception e)
                        {
                            Console.Error.WriteLine(e.Message);
                        }
                    }
                    runningGame = game;
                }
                return runningGame;
            }
        }

        /// <summary>
        /// Running game name
        /// </summary>
        public static string RunningGameName
        {
            get
            {
                string ret = null;
                switch (RunningGame)
                {
                    case EGame.ETS2:
                        ret = "Euro Truck Simulator 2";
                        break;
                    case EGame.ATS:
                        ret = "American Truck Simulator";
                        break;
                    default:
                        ret = "";
                        break;
                }
                return ret;
            }
        }

        /// <summary>
        /// Running game live map image
        /// </summary>
        public static Image RunningGameLiveMapImage
        {
            get
            {
                Image ret = null;
                switch (RunningGame)
                {
                    case EGame.ETS2:
                        ret = Resources.ETS2LiveMap;
                        break;
                }
                return ret;
            }
        }

        /// <summary>
        /// Is a game running
        /// </summary>
        public static bool IsAGameRunning
        {
            get
            {
                return (RunningGame != EGame.Nothing);
            }
        }

        /// <summary>
        /// Get game name
        /// </summary>
        /// <param name="game">Game</param>
        /// <returns>Game name</returns>
        public static string GetGameName(EGame game)
        {
            string ret = "";
            switch (game)
            {
                case EGame.ETS2:
                    ret = "Euro Truck Simulator 2";
                    break;
                case EGame.ATS:
                    ret = "American Truck Simulator";
                    break;
            }
            return ret;
        }

        /// <summary>
        /// Show add user dialog
        /// </summary>
        public static void ShowAddUserDialog(string defaultName = "")
        {
            if (MainForm.API != null)
            {
                TextEditForm tef = new TextEditForm(defaultName, Translator.GetTranslation("ADD_USER"), Translator.GetTranslation("USERNAME_HINT"));
                if (tef.ShowDialog() == DialogResult.OK)
                {
                    string value = tef.Value;
                    UserConfigData user_config = Configuration.GetUserConfigData(MainForm.API.Username);
                    string[] users = user_config.Following;
                    bool success = true;
                    if (value.ToLower() == MainForm.API.Username.ToLower())
                    {
                        MessageBox.Show(Translator.GetTranslation("YOU_CAN_NOT_ADD_YOURSELF_MESSAGE"), Translator.GetTranslation("YOU_CAN_NOT_ADD_YOURSELF"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        success = false;
                    }
                    foreach (string user in users)
                    {
                        if (user.ToLower() == value.ToLower())
                        {
                            MessageBox.Show(Translator.GetTranslation("USERNAME_ALREADY_EXISTS_MESSAGE"), Translator.GetTranslation("USERNAME_ALREADY_EXISTS"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                            success = false;
                            break;
                        }
                    }
                    if (success)
                    {
                        string[] found_users = Truckers2ConnectAPI.FindUsers(value);
                        success = false;
                        foreach (string found_user in found_users)
                        {
                            if (found_user.ToLower() == value.ToLower())
                            {
                                success = true;
                                break;
                            }
                        }
                        if (success)
                        {
                            List<string> u = new List<string>(users);
                            u.Add(value);
                            user_config.Following = u.ToArray();
                            u.Clear();
                            Configuration.Save();
                        }
                        else
                        {
                            MessageBox.Show(string.Format(Translator.GetTranslation("USER_NOT_FOUND_MESSAGE"), value), Translator.GetTranslation("USER_NOT_FOUND"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }
    }
}
