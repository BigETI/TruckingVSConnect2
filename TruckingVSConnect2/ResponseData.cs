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
    /// Response data class
    /// </summary>
    [DataContract]
    public class ResponseData
    {
        /// <summary>
        /// Response
        /// </summary>
        [DataMember]
        private string response;

        /// <summary>
        /// Content as string
        /// </summary>
        [DataMember]
        private string content;

        /// <summary>
        /// Response
        /// </summary>
        public string Response
        {
            get
            {
                return response;
            }
        }

        /// <summary>
        /// Content as string
        /// </summary>
        public string Content
        {
            get
            {
                return content;
            }
        }

        /// <summary>
        /// Get content
        /// </summary>
        /// <typeparam name="T">Type</typeparam>
        /// <returns>Content</returns>
        public T GetContent<T>() where T : class
        {
            T ret = default(T);
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(T));
            byte[] bytes = Encoding.UTF8.GetBytes(content);
            using (MemoryStream stream = new MemoryStream())
            {
                stream.Write(bytes, 0, bytes.Length);
                stream.Seek(0, SeekOrigin.Begin);
                object obj = serializer.ReadObject(stream);
                ret = obj as T;
            }
            return ret;
        }
    }
}
