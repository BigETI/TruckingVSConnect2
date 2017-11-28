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
    }
}
