using System;
using System.IO;
using System.Net;
using System.Runtime.Serialization.Json;
using System.Text;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Truckers 2 Connect API class
    /// </summary>
    public static class Truckers2ConnectAPI
    {
        /// <summary>
        /// URI
        /// </summary>
        private static readonly string uri = "http://truckers2connect.de/api/";

        /// <summary>
        /// API timeout
        /// </summary>
        private static readonly int timeout = 3000;

        /// <summary>
        /// Request GetUsers serializer
        /// </summary>
        private static readonly DataContractJsonSerializer requestDataSerializer = new DataContractJsonSerializer(typeof(RequestData));

        /// <summary>
        /// Users serializer
        /// </summary>
        private static readonly DataContractJsonSerializer responseDataSerializer = new DataContractJsonSerializer(typeof(ResponseData));

        /// <summary>
        /// Get users
        /// </summary>
        /// <returns>Users</returns>
        public static UserData[] GetUsers()
        {
            UserData[] ret = null;
            if ((MainForm.Instance != null) && (MainForm.API != null))
            {
                StringBuilder body = new StringBuilder();
                using (MemoryStream stream = new MemoryStream())
                {
                    requestDataSerializer.WriteObject(stream, new RequestData("JWYWlyv2rfc83TsduB0NrwlD707lCzNuCTBnq7bQGZNXJ7ngYWtMtiIzIskmPLOq", new RequestGetUsersData(new UserData(MainForm.API.Username, MainForm.Instance.TelemetryData, MainForm.API), Configuration.GetUserConfigData(MainForm.API.Username).Following)));
                    stream.Seek(0L, SeekOrigin.Begin);
                    body.Append(Encoding.UTF8.GetString(stream.ToArray()));
                }
                byte[] bytes = Encoding.UTF8.GetBytes(body.ToString());
                try
                {
                    HttpWebRequest http_web_request = (HttpWebRequest)WebRequest.Create(uri);
                    http_web_request.Timeout = timeout;
                    http_web_request.Method = "POST";
                    http_web_request.ContentType = "application/json; charset=utf-8";
                    http_web_request.ContentLength = bytes.Length;
                    using (Stream request_stream = http_web_request.GetRequestStream())
                    {
                        request_stream.Write(bytes, 0, bytes.Length);
                    }
                    using (HttpWebResponse http_web_response = (HttpWebResponse)(http_web_request.GetResponse()))
                    {
                        using (StreamReader stream = new StreamReader(http_web_response.GetResponseStream()))
                        {
                            //Debug.WriteLine(stream.ReadToEnd());
                            ResponseData response = responseDataSerializer.ReadObject(stream.BaseStream) as ResponseData;
                            if (response != null)
                            {
                                UsersData users = response.GetContent<UsersData>();
                                if (users != null)
                                {
                                    ret = users.Result;
                                }
                            }
                        }
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.Message);
                }
            }
            if (ret == null)
            {
                ret = new UserData[0];
            }
            return ret;
        }
    }
}
