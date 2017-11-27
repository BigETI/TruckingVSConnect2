using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Windows.Forms;

/// <summary>
/// Trucking VS Connect 2 namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Trucking VS authenticator
    /// </summary>
    public class TruckingVSAuth
    {
        /// <summary>
        /// Auth server
        /// </summary>
        private static readonly string authServer = "https://trucking-vs.de";

        /// <summary>
        /// Auth path
        /// </summary>
        private static readonly string authPath = "/app/connect-api.php";

        /// <summary>
        /// Authentication code
        /// </summary>
        private string authCode;

        /// <summary>
        /// Username
        /// </summary>
        private string username;

        /// <summary>
        /// Gravatar URL
        /// </summary>
        private string gravatarURL;

        /// <summary>
        /// Default constructor
        /// </summary>
        private TruckingVSAuth()
        {
            //
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="authCode">Auth codee</param>
        /// <param name="username">Username</param>
        /// <param name="gravatarURL">Gravatar URL</param>
        private TruckingVSAuth(string authCode, string username, string gravatarURL)
        {
            this.authCode = authCode;
            this.username = username;
            this.gravatarURL = gravatarURL;
        }

        /// <summary>
        /// Http post request
        /// </summary>
        /// <param name="postParams">Post parameters</param>
        /// <returns>HTTP response</returns>
        private static string HttpPostRequest(Dictionary<string, string> postParams)
        {
            string ret = "error";
            string s = "";
            foreach (string key in postParams.Keys)
            {
                s += HttpUtility.UrlEncode(key) + "=" + HttpUtility.UrlEncode(postParams[key]) + "&";
            }
            try
            {
                HttpWebRequest httpWebRequest = (HttpWebRequest)WebRequest.Create(authServer + authPath);
                httpWebRequest.Method = "POST";
                byte[] bytes = Encoding.ASCII.GetBytes(s);
                httpWebRequest.ContentType = "application/x-www-form-urlencoded";
                httpWebRequest.ContentLength = bytes.Length;
                using (Stream requestStream = httpWebRequest.GetRequestStream())
                {
                    requestStream.Write(bytes, 0, bytes.Length);
                }
                using (HttpWebResponse response = (HttpWebResponse)httpWebRequest.GetResponse())
                {
                    using (Stream responseStream = response.GetResponseStream())
                    {
                        using (StreamReader streamReader = new StreamReader(responseStream, Encoding.Default))
                        {
                            ret = streamReader.ReadToEnd();
                        }
                    }
                }
            }
            catch (WebException e)
            {
                int num = (int)MessageBox.Show("Es ist ein Fehler aufgetreten: \r\n" + (object)((HttpWebResponse)e.Response).StatusCode);
            }
            return ret;
        }

        /// <summary>
        /// Auhtenticate
        /// </summary>
        /// <param name="email">Email</param>
        /// <param name="password">Password</param>
        /// <param name="hashPassword">Hash password</param>
        /// <returns></returns>
        public static TruckingVSAuth Authenticate(string email, string password, bool hashPassword)
        {
            TruckingVSAuth ret = null;
            string auth_code = HttpPostRequest(new Dictionary<string, string>()
            {
                {
                    "event",
                    "authUser"
                },
                {
                    "auth",
                    "0"
                },
                {
                    "email",
                    email
                },
                {
                    "password",
                    hashPassword ? SHA256(password) : password
                }
            });
            if (auth_code != "false")
            {
                string[] result = HttpPostRequest(new Dictionary<string, string>()
                {
                    {
                        "event",
                        "getUserData"
                    },
                    {
                        "auth",
                        auth_code
                    }
                }).Split(',');
                if (result != null)
                {
                    if (result.Length == 2)
                    {
                        ret = new TruckingVSAuth(auth_code, result[0], result[1]);
                    }
                }
            }
            return ret;
        }

        public void CreateJob()
        {
            /*this.jobID = this.api.HttpPostRequest(this.api.api_server + this.api.api_path, new Dictionary<string, string>()
                {
                  {
                    "event",
                    "newJob"
                  },
                  {
                    "auth",
                    this.authCode
                  },
                  {
                    "cargo",
                    data.Job.Cargo
                  },
                  {
                    "weight",
                    ((int) Math.Round((double) data.Job.Mass, 0) / 1000).ToString()
                  },
                  {
                    "source",
                    data.Job.CitySource
                  },
                  {
                    "destination",
                    data.Job.CityDestination
                  },
                  {
                    "truck_manufacturer",
                    data.Manufacturer
                  },
                  {
                    "truck_model",
                    data.Truck
                  },
                  {
                    "fuel",
                    data.Drivetrain.Fuel.ToString()
                  },
                  {
                    "distance",
                    data.Job.NavigationDistanceLeft.ToString()
                  },
                  {
                    "trailer_damage",
                    "0"
                  }
                }).ToString();*/
        }

        /// <summary>
        /// SHA256
        /// </summary>
        /// <param name="inputString">Input string</param>
        /// <returns>SHA256 of inputString</returns>
        public static string SHA256(string inputString)
        {
            StringBuilder ret = new StringBuilder();
            SHA256Managed shA256Managed = new SHA256Managed();
            foreach (byte num in shA256Managed.ComputeHash(Encoding.UTF8.GetBytes(inputString), 0, Encoding.UTF8.GetByteCount(inputString)))
            {
                ret.Append(num.ToString("x2"));
            }
            return ret.ToString();
        }
    }
}
