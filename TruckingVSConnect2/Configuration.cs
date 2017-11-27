using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;

/// <summary>
/// Trucking VS Connect 2 namespace
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
                            Console.Error.WriteLine(e.Message);
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
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}
