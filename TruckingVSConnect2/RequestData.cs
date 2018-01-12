using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Request data class
    /// </summary>
    [DataContract]
    public class RequestData
    {
        /// <summary>
        /// Key
        /// </summary>
        [DataMember]
        private string key;

        /// <summary>
        /// Arguments
        /// </summary>
        [DataMember]
        private string args;

        /// <summary>
        /// Serializer
        /// </summary>
        private DataContractJsonSerializer serializer;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="key">Key</param>
        /// <param name="args">Arguments</param>
        public RequestData(string key, object args)
        {
            this.key = key;
            this.args = "{}";
            if (args != null)
            {
                serializer = new DataContractJsonSerializer(args.GetType());
                try
                {
                    using (MemoryStream stream = new MemoryStream())
                    {
                        serializer.WriteObject(stream, args);
                        stream.Seek(0, SeekOrigin.Begin);
                        this.args = Encoding.UTF8.GetString(stream.ToArray());
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.Message);
                }
            }
        }
    }
}
