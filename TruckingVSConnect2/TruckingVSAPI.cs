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
    /// Trucking VS API class
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
        /// User ID
        /// </summary>
        private int userID;

        /// <summary>
        /// User company ID
        /// </summary>
        private int userCompanyID;

        /// <summary>
        /// Job ID
        /// </summary>
        private string jobID;

        /// <summary>
        /// Distance
        /// </summary>
        private float distance;

        /// <summary>
        /// Weight
        /// </summary>
        private float weight;

        /// <summary>
        /// Yield
        /// </summary>
        private int yield;

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
        /// User ID
        /// </summary>
        public int UserID
        {
            get
            {
                return userID;
            }
        }

        /// <summary>
        /// User company ID
        /// </summary>
        public int UserCompanyID
        {
            get
            {
                return userCompanyID;
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
        /// Weight
        /// </summary>
        public float Weight
        {
            get
            {
                return weight;
            }
        }

        /// <summary>
        /// Yield
        /// </summary>
        public int Yield
        {
            get
            {
                return yield;
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
        /// <param name="userID">User ID</param>
        /// <param name="userCompanyID">User company ID</param>
        /// <param name="authCode">Auth codee</param>
        /// <param name="username">Username</param>
        /// <param name="gravatarURI">Gravatar URL</param>
        private TruckingVSAPI(int userID, int userCompanyID, string authCode, string username, Uri gravatarURI)
        {
            this.userID = userID;
            this.userCompanyID = userCompanyID;
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
                                case ETruckingVSAPIJobDataType.New:
                                    NewJob(job_data.TelemetryData);
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
                    { "event", "authUser" },
                    { "auth", "0" },
                    { "email", email },
                    { "password", hashPassword ? SHA256String(password) : password }
                });
            if (auth_code != "false")
            {
                string[] result = HTTPPostRequest(new Dictionary<string, string>()
                    {
                        { "event", "getUserData" },
                        { "auth", auth_code }
                    }).Split(',');
                if (result != null)
                {
                    if (result.Length == 4)
                    {
                        int user_id = 0;
                        int user_company_id = 0;
                        Uri gravatar_uri = new Uri(result[3]);
                        int.TryParse(result[0], out user_id);
                        int.TryParse(result[1], out user_company_id);
                        if (gravatar_uri != null)
                        {
                            NameValueCollection query = HttpUtility.ParseQueryString(gravatar_uri.Query);
                            query.Clear();
                            query["s"] = "64";
                            gravatar_uri = new Uri((query.Count > 0) ? (gravatar_uri.GetLeftPart(UriPartial.Path) + "?" + query) : gravatar_uri.GetLeftPart(UriPartial.Path));
                            ret = new TruckingVSAPI(user_id, user_company_id, auth_code, result[2], gravatar_uri);
                        }
                    }
                }
            }
            return ret;
        }

        /// <summary>
        /// New job
        /// </summary>
        /// <param name="telemetryData">Telemetry data</param>
        private void NewJob(Ets2Telemetry telemetryData)
        {
            CancelJob();
            distance = telemetryData.Job.NavigationDistanceLeft;
            weight = telemetryData.Job.Mass;
            yield = telemetryData.Job.Income;
            time = telemetryData.Job.NavigationTimeLeft;
            if (distance > float.Epsilon)
            {
                jobID = HTTPPostRequest(new Dictionary<string, string>()
                    {
                        { "event", "newJob" },
                        { "auth", authCode },
                        { "cargo", telemetryData.Job.Cargo },
                        { "weight", Math.Round(telemetryData.Job.Mass * 0.001).ToString() },
                        { "source", telemetryData.Job.CitySource },
                        { "destination", telemetryData.Job.CityDestination },
                        { "truck_manufacturer", telemetryData.Manufacturer },
                        { "truck_model", telemetryData.Truck },
                        { "fuel", telemetryData.Drivetrain.Fuel.ToString() },
                        { "distance", telemetryData.Job.NavigationDistanceLeft.ToString() },
                        { "trailer_damage", "0" }
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
                int percentage = (int)(Math.Round(((distance - telemetryData.Job.NavigationDistanceLeft) * 100.0f) / distance));
                if (percentage > 0)
                {
                    HTTPPostRequest(new Dictionary<string, string>()
                        {
                            { "event", "updateJob" },
                            { "auth", authCode },
                            { "job_id", jobID },
                            { "percentage", percentage.ToString() }
                        });
                }
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
                HTTPPostRequest(new Dictionary<string, string>()
                    {
                        { "event", "finishJob" },
                        { "auth", authCode },
                        { "job_id", jobID },
                        { "fuel_average", telemetryData.Drivetrain.FuelAvgConsumption.ToString() },
                        { "trailer_damage", Math.Round(telemetryData.Damage.WearTrailer * 100.0f).ToString() },
                        { "income", telemetryData.Job.Income.ToString() }
                    });
                jobID = null;
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
                        { "event", "cancelJob" },
                        { "auth", authCode },
                        { "job_id", jobID }
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
                lock (jobDataQueue)
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
