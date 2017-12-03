using Ets2SdkClient;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using WinFormsTranslator;
using System;
using System.Collections.Generic;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Main form class
    /// </summary>
    public partial class MainForm : MaterialForm
    {
        /// <summary>
        /// Trucking VS API
        /// </summary>
        private static TruckingVSAPI api;

        /// <summary>
        /// Telemetry
        /// </summary>
        private Ets2SdkTelemetry telemetry;

        /// <summary>
        /// Telemetry data
        /// </summary>
        private Ets2Telemetry telemetryData;

        /// <summary>
        /// Current game time
        /// </summary>
        private uint currentGameTime;

        /// <summary>
        /// Last job data update timestamp
        /// </summary>
        DateTime lastUpdateTimestamp;

        /// <summary>
        /// Last job distance
        /// </summary>
        private float lastJobDistance;

        /// <summary>
        /// Update telemetry data
        /// </summary>
        private bool updateTelemetryData;

        /// <summary>
        /// Is job running
        /// </summary>
        private bool isJobRunning;

        /// <summary>
        /// Job data
        /// </summary>
        private string jobData;

        /// <summary>
        /// Current speed data
        /// </summary>
        private List<double> currentSpeedData = new List<double>();

        /// <summary>
        /// Speed limit data
        /// </summary>
        private List<double> speedLimitData = new List<double>();

        /// <summary>
        /// Cruise control translated
        /// </summary>
        private string cruiseControlTranslated;

        /// <summary>
        /// Speed limit translated
        /// </summary>
        private string speedLimitTranslated;

        /// <summary>
        /// Vehicle translated
        /// </summary>
        private string vehicleTranslated;

        /// <summary>
        /// Status translated
        /// </summary>
        private string statusTranslated;

        /// <summary>
        /// Deliver cargo translated
        /// </summary>
        private string deliverCargoTranslated;

        /// <summary>
        /// Cargo translated
        /// </summary>
        private string cargoTranslated;

        /// <summary>
        /// Source translated
        /// </summary>
        private string sourceTranslated;

        /// <summary>
        /// Destination translated
        /// </summary>
        private string destinationTranslated;

        /// <summary>
        /// Route translated
        /// </summary>
        private string routeTranslated;

        /// <summary>
        /// Minutes translated
        /// </summary>
        private string milesTranslated;

        /// <summary>
        /// Miles translated
        /// </summary>
        private string minutesTranslated;

        /// <summary>
        /// Of translated
        /// </summary>
        private string ofTranslated;

        /// <summary>
        /// Yield translated
        /// </summary>
        private string yieldTranslated;

        /// <summary>
        /// Deadline translated
        /// </summary>
        private string deadlineTranslated;

        /// <summary>
        /// Idle translated
        /// </summary>
        private string idleTranslated;

        /// <summary>
        /// Unlimited translated
        /// </summary>
        private string unlimitedTranslated;

        /// <summary>
        /// Cabin translated
        /// </summary>
        private string cabinTranslated;

        /// <summary>
        /// Chassis translated
        /// </summary>
        private string chassisTranslated;

        /// <summary>
        /// Engine translated
        /// </summary>
        private string engineTranslated;

        /// <summary>
        /// Transmission translated
        /// </summary>
        private string transmissionTranslated;

        /// <summary>
        /// Wheels translated
        /// </summary>
        private string wheelsTranslated;

        /// <summary>
        /// Trailer translated
        /// </summary>
        private string trailerTranslated;

        /// <summary>
        /// Chart point count limit
        /// </summary>
        private static readonly uint chartPointCountLimit = 200U;

        /// <summary>
        /// Chart update tick counter
        /// </summary>
        private int chartUpdateTickCounter;

        /// <summary>
        /// Authenticator
        /// </summary>
        public static TruckingVSAPI Auth
        {
            get
            {
                return api;
            }
            set
            {
                if (value != null)
                {
                    api = value;
                }
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();

            Translator.TranslatorInterface = new TranslatorInterface();
            Translator.LoadTranslation(this);
            cruiseControlTranslated = Translator.GetTranslation("CRUISE_CONTROL");
            speedLimitTranslated = Translator.GetTranslation("SPEED_LIMIT");
            vehicleTranslated = Translator.GetTranslation("VEHICLE");
            statusTranslated = Translator.GetTranslation("STATUS");
            deliverCargoTranslated = Translator.GetTranslation("DELIVER_CARGO");
            cargoTranslated = Translator.GetTranslation("CARGO");
            sourceTranslated = Translator.GetTranslation("SOURCE");
            destinationTranslated = Translator.GetTranslation("DESTINATION");
            routeTranslated = Translator.GetTranslation("ROUTE");
            milesTranslated = Translator.GetTranslation("MILES");
            minutesTranslated = Translator.GetTranslation("MINUTES");
            ofTranslated = Translator.GetTranslation("OF");
            yieldTranslated = Translator.GetTranslation("YIELD");
            deadlineTranslated = Translator.GetTranslation("DEADLINE");
            idleTranslated = Translator.GetTranslation("IDLE");
            unlimitedTranslated = Translator.GetTranslation("UNLIMITED");
            cabinTranslated = Translator.GetTranslation("CABIN");
            chassisTranslated = Translator.GetTranslation("CHASSIS");
            engineTranslated = Translator.GetTranslation("ENGINE");
            transmissionTranslated = Translator.GetTranslation("TRANSMISSION");
            wheelsTranslated = Translator.GetTranslation("WHEELS");
            trailerTranslated = Translator.GetTranslation("TRAILER");

            MaterialSkinManager material_skin_manager = MaterialSkinManager.Instance;
            material_skin_manager.AddFormToManage(this);
            material_skin_manager.Theme = MaterialSkinManager.Themes.DARK;
            material_skin_manager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            telemetry = new Ets2SdkTelemetry();
            telemetry.Data += Telemetry_Data;

            speedChart.Legends[0].Title = Translator.GetTranslation(Configuration.UseMetricUnit ? "SPEED_IN_KMH" : "SPEED_IN_MPH");
            speedChart.Series[0].Name = Translator.GetTranslation("CURRENT");
            speedChart.Series[1].Name = Translator.GetTranslation("LIMIT");
        }

        /// <summary>
        /// Show login
        /// </summary>
        private void ShowLogin()
        {
            LoginForm lf = new LoginForm();
            lf.ShowDialog();
            DialogResult = DialogResult.None;
        }

        /// <summary>
        /// Main form form closed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Configuration.Save();
            if (api != null)
            {
                api.Dispose();
                api = null;
            }
            currentSpeedData.Clear();
            speedLimitData.Clear();
        }

        /// <summary>
        /// Load login data
        /// </summary>
        private void LoadLoginData()
        {
            loggedInAsLabel.Text = api.Username;
            gravatarPictureBox.ImageLocation = api.GravatarURI.ToString();
        }

        /// <summary>
        /// Main form activated event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void MainForm_Activated(object sender, EventArgs e)
        {
            if (api == null)
            {
                Hide();
                if ((Configuration.EmailUsername.Length > 0) && (Configuration.Password.Length > 0))
                {
                    api = TruckingVSAPI.Authenticate(Configuration.EmailUsername, Configuration.Password, false);
                    if (api == null)
                    {
                        ShowLogin();
                    }
                }
                else
                {
                    ShowLogin();
                }
                if (api == null)
                {
                    Close();
                }
                else
                {
                    LoadLoginData();
                    Show();
                }
            }
        }

        /// <summary>
        /// Get job data
        /// </summary>
        /// <param name="telemetryData">Telemetry data</param>
        /// <returns>Job data</returns>
        private string GetJobData(Ets2Telemetry telemetryData)
        {
            return telemetryData.Job.Cargo + ";" + telemetryData.Job.CitySource + ";" + telemetryData.Job.CityDestination + ";" + telemetryData.Job.Mass;
        }

        /// <summary>
        /// Telemetry data event
        /// </summary>
        /// <param name="data">Data</param>
        /// <param name="newTimestamp">New timestamp</param>
        private void Telemetry_Data(Ets2Telemetry data, bool newTimestamp)
        {
            telemetryData = data;
            if (api != null)
            {
                if (data.Job.OnJob)
                {
                    DateTime now = DateTime.Now;
                    if (isJobRunning)
                    {
                        if ((now - lastUpdateTimestamp).TotalSeconds >= 60.0)
                        {
                            lastUpdateTimestamp = now;
                            string job_data = GetJobData(data);
                            if (jobData == job_data)
                            {
                                api.QueueJobData(new TruckingVSAPIJobData(data, ETruckingVSAPIJobDataType.DataUpdated));
                            }
                            else
                            {
                                api.QueueJobData(new TruckingVSAPIJobData(data, (lastJobDistance <= 2000.0f) ? ETruckingVSAPIJobDataType.Finished : ETruckingVSAPIJobDataType.Canceled));
                                lastUpdateTimestamp = now;
                                jobData = job_data;
                                api.QueueJobData(new TruckingVSAPIJobData(data, ETruckingVSAPIJobDataType.New));
                            }
                        }
                    }
                    else
                    {
                        if (data.Job.NavigationDistanceLeft > float.Epsilon)
                        {
                            isJobRunning = true;
                            lastUpdateTimestamp = now;
                            jobData = GetJobData(data);
                            api.QueueJobData(new TruckingVSAPIJobData(data, ETruckingVSAPIJobDataType.New));
                        }
                    }
                    lastJobDistance = data.Job.NavigationDistanceLeft;
                }
                else if (isJobRunning)
                {
                    isJobRunning = false;
                    api.QueueJobData(new TruckingVSAPIJobData(data, (lastJobDistance <= 2000.0f) ? ETruckingVSAPIJobDataType.Finished : ETruckingVSAPIJobDataType.Canceled));
                }
            }
            updateTelemetryData = true;
        }

        /// <summary>
        /// Update timer tick event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (api != null)
            {
                Ets2Telemetry data = telemetryData;
                if ((data != null) && updateTelemetryData)
                {
                    bool game_running = Utils.IsAGameRunning && (data.TruckId.Length > 0);
                    dataPanel.Visible = game_running;
                    healthPanel.Visible = game_running;
                    speedPanel.Visible = game_running;
                    speedChart.Visible = game_running;
                    if (game_running)
                    {
                        speedLabel.Text = (Configuration.UseMetricUnit ? (Math.Round(data.Drivetrain.SpeedKmh, 1) + " km/h") : (Math.Round(data.Drivetrain.SpeedMph, 1) + " " + milesTranslated + "/h")) + (data.Drivetrain.CruiseControl ? ("; " + cruiseControlTranslated + ": " + (Configuration.UseMetricUnit ? (Math.Round(data.Drivetrain.CruiseControlSpeedKmh, 1) + " km/h") : (Math.Round(data.Drivetrain.CruiseControlSpeedMph, 1) + " " + milesTranslated + "/h"))) : "");
                        speedLimitLabel.Text = speedLimitTranslated + ": " + ((data.Job.SpeedLimit == -1.0f) ? unlimitedTranslated : Math.Round(Utils.ConvertSpeed(data.Job.SpeedLimit), 1) +  (Configuration.UseMetricUnit ? " km/h" : (" " + milesTranslated + "/h")));
                        vehicleLabel.Text = vehicleTranslated + ": " + data.Truck + ", " + data.Manufacturer;
                        if (data.Job.OnJob)
                        {
                            statusLabel.Text = statusTranslated + ": " + deliverCargoTranslated;
                            cargoLabel.Text = cargoTranslated + ": " + data.Job.Cargo;
                            sourceLabel.Text = sourceTranslated + ": " + data.Job.CompanySource + ", " + Cities.GetFullCityName(data.Job.CitySource);
                            destinationLabel.Text = destinationTranslated + ": " + data.Job.CompanyDestination + ", " + Cities.GetFullCityName(data.Job.CityDestination);
                            string distance_unit = (Configuration.UseMetricUnit ? " km" : " " + milesTranslated);
                            routeLabel.Text = routeTranslated + ": " + Math.Round(Utils.ConvertLength(data.Job.NavigationDistanceLeft), 1) + distance_unit + " " + ofTranslated + " " + Math.Round(Utils.ConvertLength(api.Distance), 1) + distance_unit + "; " + Math.Ceiling(data.Job.NavigationTimeLeft / 60.0f) + " " + minutesTranslated + " " + ofTranslated + " " + Math.Ceiling(api.Time / 60.0f) + " " + minutesTranslated;
                            yieldLabel.Text = yieldTranslated + ": " + data.Job.Income + "€; " + Math.Round(data.Job.Mass, 1) + " kg";
                            deadlineLabel.Text = deadlineTranslated + ": " + ((data.Job.Deadline == -1) ? unlimitedTranslated : data.Job.Deadline.ToString());
                        }
                        else
                        {
                            statusLabel.Text = statusTranslated + ": " + idleTranslated;
                            cargoLabel.Text = "";
                            sourceLabel.Text = "";
                            destinationLabel.Text = "";
                            routeLabel.Text = "";
                            yieldLabel.Text = "";
                            deadlineLabel.Text = "";
                        }
                        cabinLabel.Text = cabinTranslated + ": " + Math.Round(100.0f - (data.Damage.WearCabin * 100.0f), 1) + "%";
                        chassisLabel.Text = chassisTranslated + ": " + Math.Round(100.0f - (data.Damage.WearChassis * 100.0f), 1) + "%";
                        engineLabel.Text = engineTranslated + ": " + Math.Round(100.0f - (data.Damage.WearEnigne * 100.0f), 1) + "%";
                        transmissionLabel.Text = transmissionTranslated + ": " + Math.Round(100.0f - (data.Damage.WearTransmission * 100.0f), 1) + "%";
                        wheelsLabel.Text = wheelsTranslated + ": " + Math.Round(100.0f - (data.Damage.WearWheels * 100.0f), 1) + "%";
                        trailerLabel.Text = (data.Job.TrailerAttached) ? (trailerTranslated + ": " + Math.Round(100.0f - (data.Damage.WearTrailer * 100.0f), 1) + "%") : "";
                        float damage = Math.Max(data.Damage.WearCabin, Math.Max(data.Damage.WearChassis, Math.Max(data.Damage.WearEnigne, Math.Max(data.Damage.WearTransmission, data.Damage.WearWheels))));
                        int image_id = 0;
                        if (damage >= 0.9f)
                        {
                            image_id = 4;
                        }
                        else if (damage >= 0.7f)
                        {
                            image_id = 3;
                        }
                        else if (damage >= 0.5f)
                        {
                            image_id = 2;
                        }
                        else if (damage >= 0.3f)
                        {
                            image_id = 1;
                        }
                        else if (damage >= 0.0f)
                        {
                            image_id = 0;
                        }
                        drivetrainPictureBox.Image = drivetrainImageList.Images[image_id];
                        damage = data.Damage.WearTrailer;
                        if (data.Job.TrailerAttached)
                        {
                            if (damage >= 0.9f)
                            {
                                image_id = 5;
                            }
                            else if (damage >= 0.7f)
                            {
                                image_id = 4;
                            }
                            else if (damage >= 0.5f)
                            {
                                image_id = 3;
                            }
                            else if (damage >= 0.3f)
                            {
                                image_id = 2;
                            }
                            else if (damage >= 0.0f)
                            {
                                image_id = 1;
                            }
                        }
                        else
                        {
                            image_id = 0;
                        }
                        cargoPictureBox.Image = cargoImageList.Images[image_id];
                        while (currentSpeedData.Count >= chartPointCountLimit)
                        {
                            currentSpeedData.RemoveAt(0);
                        }
                        while (speedLimitData.Count >= chartPointCountLimit)
                        {
                            speedLimitData.RemoveAt(0);
                        }
                        if (currentGameTime != data.Time)
                        {
                            currentGameTime = data.Time;
                            ++chartUpdateTickCounter;
                            if ((chartUpdateTickCounter % 2) == 0)
                            {
                                chartUpdateTickCounter = 0;
                                currentSpeedData.Add(Configuration.UseMetricUnit ? data.Drivetrain.SpeedKmh : data.Drivetrain.SpeedMph);
                                speedLimitData.Add(Utils.ConvertSpeed((data.Job.SpeedLimit == -1.0f) ? 0.0f : data.Job.SpeedLimit));
                                speedChart.Series[0].Points.DataBindY(currentSpeedData);
                                speedChart.Series[1].Points.DataBindY(speedLimitData);
                            }
                        }
                        updateTelemetryData = false;
                    }
                }
            }
        }

        /// <summary>
        /// Log out
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void logOutButton_Click(object sender, EventArgs e)
        {
            Configuration.Password = "";
            Configuration.Save();
            if (api != null)
            {
                api.Dispose();
                api = null;
            }
            Hide();
            ShowLogin();
            if (api == null)
            {
                Close();
            }
            else
            {
                LoadLoginData();
                Show();
            }
        }

        /// <summary>
        /// Switch length unit button click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void switchLengthUnitButton_Click(object sender, EventArgs e)
        {
            Configuration.UseMetricUnit = !(Configuration.UseMetricUnit);
            currentSpeedData.Clear();
            speedLimitData.Clear();
            speedChart.Legends[0].Title = Translator.GetTranslation(Configuration.UseMetricUnit ? "SPEED_IN_KMH" : "SPEED_IN_MPH");
        }
    }
}
