using Ets2SdkClient;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Net;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Web;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Trucking VS authenticator
    /// </summary>
    public class TruckingVSAPI : IDisposable
    {
        /// <summary>
        /// API URL
        /// </summary>
        private static readonly Uri uri = new Uri("https://trucking-vs.de/app/connect-api.php");

        /// <summary>
        /// API timeout
        /// </summary>
        private static readonly int timeout = 3000;

        /// <summary>
        /// Authentication code
        /// </summary>
        private string authCode;

        /// <summary>
        /// Username
        /// </summary>
        private string username;

        /// <summary>
        /// Gravatar URI
        /// </summary>
        private Uri gravatarURI;

        /// <summary>
        /// Job ID
        /// </summary>
        private string jobID;

        /// <summary>
        /// Distance
        /// </summary>
        private float distance;

        /// <summary>
        /// Time
        /// </summary>
        private float time;

        /// <summary>
        /// Job data queue
        /// </summary>
        private Queue<TruckingVSAPIJobData> jobDataQueue = new Queue<TruckingVSAPIJobData>();

        /// <summary>
        /// Job data thread
        /// </summary>
        private Thread jobDataThread;

        /// <summary>
        /// Is job data thread running
        /// </summary>
        private bool isJobDataThreadRunning = true;

        /// <summary>
        /// Username
        /// </summary>
        public string Username
        {
            get
            {
                return username;
            }
        }

        /// <summary>
        /// Gravatar URI
        /// </summary>
        public Uri GravatarURI
        {
            get
            {
                return gravatarURI;
            }
        }

        /// <summary>
        /// Distance
        /// </summary>
        public float Distance
        {
            get
            {
                return distance;
            }
        }

        /// <summary>
        /// Time
        /// </summary>
        public float Time
        {
            get
            {
                return time;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        private TruckingVSAPI()
        {
            //
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="authCode">Auth codee</param>
        /// <param name="username">Username</param>
        /// <param name="gravatarURI">Gravatar URL</param>
        private TruckingVSAPI(string authCode, string username, Uri gravatarURI)
        {
            this.authCode = authCode;
            this.username = username;
            this.gravatarURI = gravatarURI;
            jobDataThread = new Thread(() =>
            {
                while (isJobDataThreadRunning)
                {
                    lock (jobDataQueue)
                    {
                        while (jobDataQueue.Count > 0)
                        {
                            TruckingVSAPIJobData job_data = jobDataQueue.Dequeue();
                            switch (job_data.Type)
                            {
                                case ETruckingVSAPIJobDataType.Started:
                                    StartJob(job_data.TelemetryData);
                                    break;

                                case ETruckingVSAPIJobDataType.DataUpdated:
                                    UpdateJobData(job_data.TelemetryData);
                                    break;

                                case ETruckingVSAPIJobDataType.Finished:
                                    FinishJob(job_data.TelemetryData);
                                    break;

                                case ETruckingVSAPIJobDataType.Canceled:
                                    CancelJob();
                                    break;
                            }
                        }
                    }
                    Thread.Sleep(500);
                }
            });
            jobDataThread.Start();
        }

        /// <summary>
        /// HTTP post request
        /// </summary>
        /// <param name="postParams">Post parameters</param>
        /// <returns>HTTP response</returns>
        private static string HTTPPostRequest(Dictionary<string, string> postParams)
        {
            string ret = "error";
            StringBuilder post = new StringBuilder();
            bool first = true;
            foreach (string key in postParams.Keys)
            {
                if (first)
                {
                    first = false;
                }
                else
                {
                    post.Append("&");
                }
                post.Append(HttpUtility.UrlEncode(key) + "=" + HttpUtility.UrlEncode(postParams[key]));
            }
            try
            {
                HttpWebRequest http_web_request = (HttpWebRequest)WebRequest.Create(uri);
                http_web_request.Timeout = timeout;
                http_web_request.Method = "POST";
                byte[] bytes = Encoding.ASCII.GetBytes(post.ToString());
                http_web_request.ContentType = "application/x-www-form-urlencoded";
                http_web_request.ContentLength = bytes.Length;
                using (Stream request_stream = http_web_request.GetRequestStream())
                {
                    request_stream.Write(bytes, 0, bytes.Length);
                }
                using (HttpWebResponse http_web_response = (HttpWebResponse)http_web_request.GetResponse())
                {
                    using (Stream response_stream = http_web_response.GetResponseStream())
                    {
                        using (StreamReader reader = new StreamReader(response_stream, Encoding.Default))
                        {
                            ret = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
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
        public static TruckingVSAPI Authenticate(string email, string password, bool hashPassword)
        {
            TruckingVSAPI ret = null;
            string auth_code = HTTPPostRequest(new Dictionary<string, string>()
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
                        hashPassword ? SHA256String(password) : password
                    }
                });
            if (auth_code != "false")
            {
                string[] result = HTTPPostRequest(new Dictionary<string, string>()
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
                        Uri gravatar_uri = new Uri(result[1]);
                        if (gravatar_uri != null)
                        {
                            NameValueCollection query = HttpUtility.ParseQueryString(gravatar_uri.Query);
                            query.Clear();
                            query["s"] = "64";
                            gravatar_uri = new Uri((query.Count > 0) ? (gravatar_uri.GetLeftPart(UriPartial.Path) + "?" + query) : gravatar_uri.GetLeftPart(UriPartial.Path));
                            ret = new TruckingVSAPI(auth_code, result[0], gravatar_uri);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// Start job
        /// </summary>
        /// <param name="telemetryData">Telemetry data</param>
        private void StartJob(Ets2Telemetry telemetryData)
        {
            CancelJob();
            distance = telemetryData.Job.NavigationDistanceLeft;
            time = telemetryData.Job.NavigationTimeLeft;
            if (Math.Abs(distance) >= float.Epsilon)
            {
                jobID = HTTPPostRequest(new Dictionary<string, string>()
                    {
                        {
                            "event",
                            "newJob"
                        },
                        {
                            "auth",
                            authCode
                        },
                        {
                            "cargo",
                            telemetryData.Job.Cargo
                        },
                        {
                            "weight",
                            ((int)(Math.Round(telemetryData.Job.Mass * 0.001))).ToString()
                        },
                        {
                            "source",
                            telemetryData.Job.CitySource
                        },
                        {
                            "destination",
                            telemetryData.Job.CityDestination
                        },
                        {
                            "truck_manufacturer",
                            telemetryData.Manufacturer
                        },
                        {
                            "truck_model",
                            telemetryData.Truck
                        },
                        {
                            "fuel",
                            telemetryData.Drivetrain.Fuel.ToString()
                        },
                        {
                            "distance",
                            telemetryData.Job.NavigationDistanceLeft.ToString()
                        },
                        {
                            "trailer_damage",
                            "0"
                        }
                    });
            }
        }

        /// <summary>
        /// Update job data
        /// </summary>
        /// <param name="telemetryData">Telemetry data</param>
        private void UpdateJobData(Ets2Telemetry telemetryData)
        {
            if (jobID != null)
            {
                float delta_neg = distance - telemetryData.Job.NavigationDistanceLeft;
                HTTPPostRequest(new Dictionary<string, string>()
                    {
                        {
                            "event",
                            "updateJob"
                        },
                        {
                            "auth",
                            authCode
                        },
                        {
                            "job_id",
                            jobID
                        },
                        {
                            "percentage",
                            ((int)(Math.Round((100.0f * delta_neg) / distance))).ToString()
                        }
                    });
            }
        }

        /// <summary>
        /// Finish job
        /// </summary>
        /// <param name="telemetryData">Telemetry data</param>
        private void FinishJob(Ets2Telemetry telemetryData)
        {
            if (jobID != null)
            {
                string wear_trailer = string.Format("{0:0.00}", telemetryData.Damage.WearTrailer);
                string wear_trailer_replaced = wear_trailer.Replace("0.", "");
                HTTPPostRequest(new Dictionary<string, string>()
                    {
                        { "event", "finishJob" },
                        { "auth", authCode },
                        { "job_id", jobID },
                        { "fuel_average", telemetryData.Drivetrain.FuelAvgConsumption.ToString() },
                        { "trailer_damage", (wear_trailer.StartsWith("1.") ? "100" : (wear_trailer_replaced.StartsWith("0") ? wear_trailer_replaced.Replace("0", "") : wear_trailer_replaced)).Replace(",", "") },
                        { "income", telemetryData.Job.Income.ToString() }
                    });
            }
        }

        /// <summary>
        /// Cancel job
        /// </summary>
        private void CancelJob()
        {
            if (jobID != null)
            {
                HTTPPostRequest(new Dictionary<string, string>()
                    {
                        {
                            "event",
                            "cancelJob"
                        },
                        {
                            "auth",
                            authCode
                        },
                        {
                            "job_id",
                            jobID
                        }
                    });
                jobID = null;
            }
        }

        /// <summary>
        /// Queue job data
        /// </summary>
        /// <param name="jobData">Job data</param>
        public void QueueJobData(TruckingVSAPIJobData jobData)
        {
            if (jobData != null)
            {
                lock (jobData)
                {
                    jobDataQueue.Enqueue(jobData);
                }
            }
        }

        /// <summary>
        /// SHA256 string
        /// </summary>
        /// <param name="inputString">Input string</param>
        /// <returns>SHA256 string of inputString</returns>
        public static string SHA256String(string inputString)
        {
            StringBuilder ret = new StringBuilder();
            SHA256Managed sha256_managed = new SHA256Managed();
            foreach (byte n in sha256_managed.ComputeHash(Encoding.UTF8.GetBytes(inputString), 0, Encoding.UTF8.GetByteCount(inputString)))
            {
                ret.Append(n.ToString("x2"));
            }
            return ret.ToString();
        }

        /// <summary>
        /// Dispose
        /// </summary>
        public void Dispose()
        {
            isJobDataThreadRunning = false;
            if (jobDataThread != null)
            {
                jobDataThread.Join();
                jobDataThread = null;
            }
        }
    }
}
