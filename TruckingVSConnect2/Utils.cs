using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Security.Cryptography;
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
        /// Running game name
        /// </summary>
        private static string runningGameName;

        /// <summary>
        /// And translated
        /// </summary>
        //private static string andTranslated;

        /// <summary>
        /// Backwards translated
        /// </summary>
        private static string backwardsTranslated;

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
                Debug.Print(e.Message);
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
                Debug.Print(e.Message);
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
            int w = (int)weight;
            int t = w / 1000;
            int kg = w % 1000;
            return ((t > 0) ? (Math.Round(t + (kg / 1000.0), 2) + " t") : (Math.Round(kg + (weight - w), 2) + " kg"));
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
            int h = (s / 3600) % 24;
            int d = (s / 86400);
            return ((d > 0) ? (d + " d") : ((h > 0) ? (h + " h") : ((min > 0) ? (min + " min") : (s + " s"))));
            //return ((d > 0) ? (d + " d") : "") + ((h > 0) ? (((d > 0) ? " " : "") + h + " h") : "") + ((min > 0) ? ((((d > 0) || (h > 0)) ? " " : "") + min + " min") : "") + ((s > 0) ? ((((d > 0) || (h > 0) || (min > 0)) ? " " : "") + s + " s") : "");
        }

        /// <summary>
        /// Running game name
        /// </summary>
        public static string RunningGameName
        {
            get
            {
                if ((DateTime.Now - lastGameCheckTimestamp).TotalSeconds > 2)
                {
                    string game_name = null;
                    lastGameCheckTimestamp = DateTime.Now;
                    foreach (Process process in Process.GetProcesses())
                    {
                        try
                        {
                            if (process.ProcessName == "eurotrucks2")
                            {
                                game_name = "Euro Truck Simulator 2";
                                break;
                            }
                            else if (process.ProcessName == "amtrucks")
                            {
                                game_name = "American Truck Simulator";
                                break;
                            }
                        }
                        catch (Exception e)
                        {
                            Debug.Print(e.Message);
                        }
                    }
                    runningGameName = game_name;
                }
                return runningGameName;
            }
        }

        /// <summary>
        /// Is a game running
        /// </summary>
        public static bool IsAGameRunning
        {
            get
            {
                return (RunningGameName != null);
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
    }
}
