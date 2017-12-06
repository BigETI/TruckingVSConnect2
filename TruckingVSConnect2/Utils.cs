using System;
using System.Diagnostics;
using System.IO;
using System.Security.Cryptography;

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
        /// Convert meters to kilometers or miles
        /// </summary>
        /// <param name="length">Length in meters</param>
        /// <returns>Length in kilometers or miles</returns>
        public static float ConvertLength(float length)
        {
            return (length * (Configuration.UseMetricUnit ? 0.001f : 0.0006213712f));
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
