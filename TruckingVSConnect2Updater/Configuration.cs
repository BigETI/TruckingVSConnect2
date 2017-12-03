using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Threading;

/// <summary>
/// Trucking VS Connect² Updater namespace
/// </summary>
namespace TruckingVSConnect2Updater
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
    }
}
