using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;

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
        /// Euro Truck SImulator 2 directory
        /// </summary>
        [DataMember]
        private string ets2Directory = "";

        /// <summary>
        /// American Truck Simulator directory
        /// </summary>
        [DataMember]
        private string atsDirectory = "";

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
                return (Instance == null) ? "" : Instance.language;
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
                return (Instance == null) ? "" : Instance.emailUsername;
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
                return (instance == null) ? "" : Instance.password;
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
                return (instance == null) ? "" : Instance.ets2Directory;
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
