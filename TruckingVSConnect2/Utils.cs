using System;
using System.Diagnostics;

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
    }
}
