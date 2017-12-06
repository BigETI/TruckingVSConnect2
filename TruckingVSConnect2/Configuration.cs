using Microsoft.Win32;
using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;
using VDF;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Configuration class
    /// </summary>
    [DataContract]
    public class Configuration
    {
        /// <summary>
        /// Language
        /// </summary>
        [DataMember]
        private string language = "";

        /// <summary>
        /// Email or username
        /// </summary>
        [DataMember]
        private string emailUsername = "";

        /// <summary>
        /// Password
        /// </summary>
        [DataMember]
        private string password = "";

        /// <summary>
        /// Euro Truck Simulator 2 directory
        /// </summary>
        [DataMember]
        private string ets2Directory = "";

        /// <summary>
        /// Ask for directory if Euro Truck Simulator 2 directory is not found
        /// </summary>
        [DataMember(EmitDefaultValue = true)]
        private bool askForDirectoryIfETS2DirectoryNotFound = true;

        /// <summary>
        /// American Truck Simulator directory
        /// </summary>
        [DataMember]
        private string atsDirectory = "";

        /// <summary>
        /// Ask for directory if American Truck Simulator directory is not found
        /// </summary>
        [DataMember(EmitDefaultValue = true)]
        private bool askForDirectoryIfATSDirectoryNotFound = true;

        /// <summary>
        /// Use metric
        /// </summary>
        [DataMember(EmitDefaultValue = true)]
        private bool useMetricUnit = true;

        /// <summary>
        /// Instance
        /// </summary>
        private static Configuration instance;

        /// <summary>
        /// Serializer
        /// </summary>
        private static DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Configuration));

        /// <summary>
        /// Configuration path
        /// </summary>
        private static readonly string configPath = "./config.json";

        /// <summary>
        /// Language
        /// </summary>
        public static string Language
        {
            get
            {
                return ((Instance == null) ? "" : Instance.language);
            }
            set
            {
                if ((Instance != null) && (value != null))
                {
                    Instance.language = value;
                }
            }
        }

        /// <summary>
        /// Email username
        /// </summary>
        public static string EmailUsername
        {
            get
            {
                return ((Instance == null) ? "" : Instance.emailUsername);
            }
            set
            {
                if ((Instance != null) && (value != null))
                {
                    Instance.emailUsername = value;
                }
            }
        }

        /// <summary>
        /// Password
        /// </summary>
        public static string Password
        {
            get
            {
                return ((Instance == null) ? "" : Instance.password);
            }
            set
            {
                if ((Instance != null) && (value != null))
                {
                    Instance.password = value;
                }
            }
        }

        /// <summary>
        /// Euro Truck Simulator directory
        /// </summary>
        public static string ETS2Directory
        {
            get
            {
                return ((instance == null) ? "" : Instance.ets2Directory);
            }
            set
            {
                if ((Instance != null) && (value != null))
                {
                    Instance.ets2Directory = value;
                }
            }
        }

        /// <summary>
        /// Ask for directory if Euro Truck Simulator 2 directory is not found
        /// </summary>
        public static bool AskForDirectoryIfETS2DirectoryNotFound
        {
            get
            {
                return ((Instance == null) ? false : Instance.askForDirectoryIfETS2DirectoryNotFound);
            }
            set
            {
                if (Instance != null)
                {
                    Instance.askForDirectoryIfETS2DirectoryNotFound = value;
                }
            }
        }

        /// <summary>
        /// American Truck Simulator directory
        /// </summary>
        public static string ATSDirectory
        {
            get
            {
                return (instance == null) ? "" : Instance.atsDirectory;
            }
            set
            {
                if ((Instance != null) && (value != null))
                {
                    Instance.atsDirectory = value;
                }
            }
        }

        /// <summary>
        /// Ask for directory if American Truck Simulator directory is not found
        /// </summary>
        public static bool AskForDirectoryIfATSDirectoryNotFound
        {
            get
            {
                return ((Instance == null) ? false : Instance.askForDirectoryIfATSDirectoryNotFound);
            }
            set
            {
                if (Instance != null)
                {
                    Instance.askForDirectoryIfATSDirectoryNotFound = value;
                }
            }
        }

        /// <summary>
        /// Is Euro Truck Simulator 2 directory specified
        /// </summary>
        public static bool IsETS2DirectorySpecified
        {
            get
            {
                return (ETS2Directory.Trim().Length > 0);
            }
        }

        /// <summary>
        /// Is American Truck Simulator directory specified
        /// </summary>
        public static bool IsATSDirectorySpecified
        {
            get
            {
                return (ATSDirectory.Trim().Length > 0);
            }
        }

        /// <summary>
        /// Use metric unit
        /// </summary>
        public static bool UseMetricUnit
        {
            get
            {
                return (instance == null) ? true : Instance.useMetricUnit;
            }
            set
            {
                if (Instance != null)
                {
                    Instance.useMetricUnit = value;
                }
            }
        }

        /// <summary>
        /// Instance
        /// </summary>
        private static Configuration Instance
        {
            get
            {
                if (instance == null)
                {
                    if (File.Exists(configPath))
                    {
                        try
                        {
                            using (FileStream stream = new FileStream(configPath, FileMode.Open))
                            {
                                instance = (Configuration)(serializer.ReadObject(stream));
                            }
                        }
                        catch (Exception e)
                        {
                            Debug.Print(e.Message);
                        }
                    }
                    if (instance == null)
                    {
                        instance = new Configuration();
                    }
                }
                return instance;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        private Configuration()
        {
            language = Thread.CurrentThread.CurrentUICulture.Name;
        }

        /// <summary>
        /// Get ask for directory if game directory is not found
        /// </summary>
        /// <param name="game">Game</param>
        /// <returns>"true" if correct, otherwise "false"</returns>
        public static bool GetAskForDirectoryIfGameDirectoryNotFound(EGame game)
        {
            return ((game == EGame.ETS2) ? AskForDirectoryIfETS2DirectoryNotFound : ((game == EGame.ATS) ? AskForDirectoryIfATSDirectoryNotFound : false));
        }

        /// <summary>
        /// Set ask for directory if game directory is not found
        /// </summary>
        /// <param name="game">Game</param>
        /// <param name="value">Value</param>
        public static void SetAskForDirectoryIfGameDirectoryNotFound(EGame game, bool value)
        {
            switch (game)
            {
                case EGame.ETS2:
                    AskForDirectoryIfETS2DirectoryNotFound = value;
                    break;
                case EGame.ATS:
                    AskForDirectoryIfATSDirectoryNotFound = value;
                    break;
            }
        }

        /// <summary>
        /// Is game directory specified
        /// </summary>
        /// <param name="game">Game</param>
        /// <returns>"true" if correct, otherwise "false"</returns>
        public static bool IsGameDirectorySpecified(EGame game)
        {
            bool ret = false;
            switch (game)
            {
                case EGame.ETS2:
                    ret = IsETS2DirectorySpecified;
                    break;
                case EGame.ATS:
                    ret = IsATSDirectorySpecified;
                    break;
            }
            return ret;
        }

        /// <summary>
        /// Get game directory
        /// </summary>
        /// <param name="game">Game</param>
        /// <returns>Game directory</returns>
        public static string GetGameDirectory(EGame game)
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
        /// Get game directory
        /// </summary>
        /// <param name="game">Game</param>
        /// <param name="gameDirectory">Game directory</param>
        public static void SetGameDirectory(EGame game, string gameDirectory)
        {
            if (gameDirectory != null)
            {
                switch (game)
                {
                    case EGame.ETS2:
                        ETS2Directory = gameDirectory;
                        break;
                    case EGame.ATS:
                        ATSDirectory = gameDirectory;
                        break;
                }
            }
        }

        /// <summary>
        /// Save configuration
        /// </summary>
        public static void Save()
        {
            if (instance == null)
            {
                instance = new Configuration();
            }
            try
            {
                using (FileStream stream = new FileStream(configPath, FileMode.Create))
                {
                    serializer.WriteObject(stream, instance);
                }
            }
            catch (Exception e)
            {
                Debug.Print(e.Message);
            }
        }
    }
}
