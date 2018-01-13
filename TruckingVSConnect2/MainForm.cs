using Ets2SdkClient;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using WinFormsTranslator;
using System;
using System.Collections.Generic;
using System.Drawing;
using TruckingVSConnect2.Properties;
using System.Drawing.Imaging;
using System.IO;
using System.Threading;

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
        private DateTime lastUpdateTimestamp;

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
        /// Total route
        /// </summary>
        private float totalRoute;

        /// <summary>
        /// Total weight
        /// </summary>
        private float totalWeight;

        /// <summary>
        /// Total yield
        /// </summary>
        private int totalYield;

        /// <summary>
        /// Drivetrain images
        /// </summary>
        private Image[] drivetrainImages;

        /// <summary>
        /// CargoImaghes
        /// </summary>
        private Image[] cargoImages;

        /// <summary>
        /// Group form
        /// </summary>
        private GroupForm groupForm;

        /// <summary>
        /// Start game now translated
        /// </summary>
        private string startGameNowTranslated;

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
        /// In translated
        /// </summary>
        private string inTranslated;

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
        /// Remaining time translated
        /// </summary>
        private string remainingTimeTranslated;

        /// <summary>
        /// Of translated
        /// </summary>
        private string ofTranslated;

        /// <summary>
        /// Yield translated
        /// </summary>
        private string yieldTranslated;

        /// <summary>
        /// Weight translated
        /// </summary>
        private string weightTranslated;

        /// <summary>
        /// Deadline translated
        /// </summary>
        private string deadlineTranslated;

        /// <summary>
        /// Deadline available translated
        /// </summary>
        private string deadlineAvailableTranslated;

        /// <summary>
        /// Idle translated
        /// </summary>
        private string idleTranslated;

        /// <summary>
        /// Unlimited translated
        /// </summary>
        private string unlimitedTranslated;

        /// <summary>
        /// Total route translated
        /// </summary>
        private string totalRouteTranslated;

        /// <summary>
        /// Total weight translated
        /// </summary>
        private string totalWeightTranslated;

        /// <summary>
        /// Total yield translated
        /// </summary>
        private string totalYieldTranslated;

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
        /// Average translated
        /// </summary>
        private string averageTranslated;

        /// <summary>
        /// Fuel translated
        /// </summary>
        private string fuelTranslated;

        /// <summary>
        /// Fuel distance translated
        /// </summary>
        private string fuelRemainingDistanceTranslated;

        /// <summary>
        /// Fuel status translated
        /// </summary>
        private string fuelStatusTranslated;

        /// <summary>
        /// Please refill fuel translated
        /// </summary>
        private string pleaseRefillFuelTranslated;

        /// <summary>
        /// Low fuel translated
        /// </summary>
        private string lowFuelTranslated;

        /// <summary>
        /// Enough fuel translated
        /// </summary>
        private string enoughFuelTranslated;

        /// <summary>
        /// Refill later translated
        /// </summary>
        private string refillLaterTranslated;

        /// <summary>
        /// Fuel gauge needle offset
        /// </summary>
        private static readonly int fuelGaugeNeedleOffset = 7;

        /// <summary>
        /// Fuel gauge needle range
        /// </summary>
        private static readonly int fuelGaugeNeedleRange = 108;

        /// <summary>
        /// Chart update tick counter
        /// </summary>
        private int chartUpdateTickCounter;

        /// <summary>
        /// Live map form
        /// </summary>
        private LiveMapForm liveMapForm;

        /// <summary>
        /// Find users form
        /// </summary>
        private FindUsersForm findUsersForm;

        /// <summary>
        /// Users
        /// </summary>
        private UserData[] users = new UserData[0];

        /// <summary>
        /// Take screenshot
        /// </summary>
        private bool takeScreenshot = false;

        /// <summary>
        /// Thread
        /// </summary>
        private Thread thread;

        /// <summary>
        /// Is thread running
        /// </summary>
        private bool isThreadRunning = true;

        /// <summary>
        /// Instance
        /// </summary>
        private static MainForm instance;

        /// <summary>
        /// API
        /// </summary>
        public static TruckingVSAPI API
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
        /// Telemetry data
        /// </summary>
        public Ets2Telemetry TelemetryData
        {
            get
            {
                return telemetryData;
            }
        }

        /// <summary>
        /// Users
        /// </summary>
        public UserData[] Users
        {
            get
            {
                return users;
            }
        }

        /// <summary>
        /// Instance
        /// </summary>
        public static MainForm Instance
        {
            get
            {
                return instance;
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            instance = this;
            InitializeComponent();
            Translator.TranslatorInterface = new TranslatorInterface();
            Translator.LoadTranslation(this);
            startGameNowTranslated = Translator.GetTranslation("START_GAME_NOW");
            cruiseControlTranslated = Translator.GetTranslation("CRUISE_CONTROL");
            speedLimitTranslated = Translator.GetTranslation("SPEED_LIMIT");
            vehicleTranslated = Translator.GetTranslation("VEHICLE");
            inTranslated = Translator.GetTranslation("IN");
            statusTranslated = Translator.GetTranslation("STATUS");
            deliverCargoTranslated = Translator.GetTranslation("DELIVER_CARGO");
            cargoTranslated = Translator.GetTranslation("CARGO");
            sourceTranslated = Translator.GetTranslation("SOURCE");
            destinationTranslated = Translator.GetTranslation("DESTINATION");
            routeTranslated = Translator.GetTranslation("ROUTE");
            remainingTimeTranslated = Translator.GetTranslation("REMAINING_TIME");
            ofTranslated = Translator.GetTranslation("OF");
            yieldTranslated = Translator.GetTranslation("YIELD");
            weightTranslated = Translator.GetTranslation("WEIGHT");
            deadlineTranslated = Translator.GetTranslation("DEADLINE");
            deadlineAvailableTranslated = Translator.GetTranslation("DEADLINE_AVAILABLE");
            idleTranslated = Translator.GetTranslation("IDLE");
            unlimitedTranslated = Translator.GetTranslation("UNLIMITED");
            totalRouteTranslated = Translator.GetTranslation("TOTAL_ROUTE");
            totalWeightTranslated = Translator.GetTranslation("TOTAL_WEIGHT");
            totalYieldTranslated = Translator.GetTranslation("TOTAL_YIELD");
            cabinTranslated = Translator.GetTranslation("CABIN");
            chassisTranslated = Translator.GetTranslation("CHASSIS");
            engineTranslated = Translator.GetTranslation("ENGINE");
            transmissionTranslated = Translator.GetTranslation("TRANSMISSION");
            wheelsTranslated = Translator.GetTranslation("WHEELS");
            trailerTranslated = Translator.GetTranslation("TRAILER");
            averageTranslated = Translator.GetTranslation("AVERAGE");
            fuelTranslated = Translator.GetTranslation("FUEL");
            fuelRemainingDistanceTranslated = Translator.GetTranslation("FUEL_REMAINING_DISTANCE");
            fuelStatusTranslated = Translator.GetTranslation("FUEL_STATUS");
            pleaseRefillFuelTranslated = Translator.GetTranslation("PLEASE_REFILL_FUEL");
            lowFuelTranslated = Translator.GetTranslation("LOW_FUEL");
            enoughFuelTranslated = Translator.GetTranslation("ENOUGH_FUEL");
            refillLaterTranslated = Translator.GetTranslation("REFILL_LATER");

            MaterialSkinManager material_skin_manager = MaterialSkinManager.Instance;
            material_skin_manager.AddFormToManage(this);
            material_skin_manager.Theme = MaterialSkinManager.Themes.DARK;
            material_skin_manager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);

            PluginManager.InstallPlugins();

            telemetry = new Ets2SdkTelemetry();
            telemetry.Data += Telemetry_Data;

            speedChart.Legends[0].Title = Translator.GetTranslation(Configuration.UseMetricUnit ? "SPEED_IN_KMH" : "SPEED_IN_MPH");
            speedChart.Series[0].Name = Translator.GetTranslation("CURRENT");
            speedChart.Series[1].Name = Translator.GetTranslation("LIMIT");

            drivetrainImages = new Image[]
            {
                Resources.Drivetrain,
                Resources.DrivetrainSlightlyDamaged,
                Resources.DrivetrainDamaged,
                Resources.DrivetrainHeavilyDamaged,
                Resources.DrivetrainFullyDamaged
            };
            cargoImages = new Image[]
            {
                Resources.NoCargo,
                Resources.Cargo,
                Resources.CargoSlightlyDamaged,
                Resources.CargoDamaged,
                Resources.CargoHeavilyDamaged,
                Resources.CargoFullyDamaged
            };
            thread = new Thread(() =>
            {
                while (isThreadRunning)
                {
                    users = Truckers2ConnectAPI.GetUsers();
                    GroupForm.UpdateUsers();
                    Thread.Sleep(500);
                }
            });
            thread.Start();
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
        /// Open live map
        /// </summary>
        private void OpenLiveMap()
        {
            CloseLiveMap();
            liveMapForm = new LiveMapForm();
            liveMapForm.Show();
        }

        /// <summary>
        /// Close live map
        /// </summary>
        private void CloseLiveMap()
        {
            if (liveMapForm != null)
            {
                liveMapForm.Close();
                liveMapForm = null;
            }
        }

        /// <summary>
        /// Toggle live map
        /// </summary>
        public void ToggleLiveMap()
        {
            if (liveMapForm != null)
            {
                bool visible = liveMapForm.Visible;
                liveMapForm.Close();
                liveMapForm = null;
                if (!visible)
                {
                    liveMapForm = new LiveMapForm();
                    liveMapForm.Show();
                }
            }
            else
            {
                liveMapForm = new LiveMapForm();
                liveMapForm.Show();
            }
        }

        /// <summary>
        /// Show group
        /// </summary>
        public void ShowGroup()
        {
            if (groupForm != null)
            {
                if (!(groupForm.Visible))
                {
                    groupForm.Close();
                    groupForm = new GroupForm();
                    groupForm.Show();
                }
            }
            else
            {
                groupForm = new GroupForm();
                groupForm.Show();
            }
        }

        /// <summary>
        /// Close group
        /// </summary>
        public void CloseGroup()
        {
            if (groupForm != null)
            {
                groupForm.Close();
                groupForm = null;
            }
        }

        /// <summary>
        /// Toggle group
        /// </summary>
        public void ToggleGroup()
        {
            if (groupForm == null)
            {
                groupForm = new GroupForm();
                groupForm.Show();
            }
            else
            {
                if (groupForm.Visible)
                {
                    groupForm.Close();
                    groupForm = null;
                }
                else
                {
                    groupForm.Close();
                    groupForm = new GroupForm();
                    groupForm.Show();
                }
            }
        }

        /// <summary>
        /// Close find users
        /// </summary>
        public void CloseFindUsers()
        {
            if (findUsersForm != null)
            {
                findUsersForm.Close();
                findUsersForm = null;
            }
        }

        /// <summary>
        /// Toggle find users
        /// </summary>
        public void ToggleFindUsers()
        {
            if (findUsersForm == null)
            {
                findUsersForm = new FindUsersForm();
                findUsersForm.Show();
            }
            else
            {
                if (findUsersForm.Visible)
                {
                    findUsersForm.Close();
                    findUsersForm = null;
                }
                else
                {
                    findUsersForm.Close();
                    findUsersForm = new FindUsersForm();
                    findUsersForm.Show();
                }
            }
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
        /// Clear charts
        /// </summary>
        private void ClearCharts()
        {
            lock (currentSpeedData)
            {
                currentSpeedData.Clear();
            }
            lock (speedLimitData)
            {
                speedLimitData.Clear();
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
        /// Take screenshot
        /// </summary>
        public void TakeScreenshot()
        {
            try
            {
                using (Bitmap bitmap = new Bitmap(Size.Width, Size.Height, PixelFormat.Format32bppArgb))
                {
                    DrawToBitmap(bitmap, DisplayRectangle);
                    if (!(Directory.Exists("./jobs")))
                    {
                        try
                        {
                            Directory.CreateDirectory("./jobs");
                        }
                        catch (Exception e)
                        {
                            Console.Error.WriteLine(e.Message);
                        }
                    }
                    for (int i = 0; ; i++)
                    {
                        string file_name = "./jobs/job_" + i + ".png";
                        if (!(File.Exists(file_name)))
                        {
                            try
                            {
                                bitmap.Save(file_name, ImageFormat.Png);
                            }
                            catch (Exception e)
                            {
                                Console.Error.WriteLine(e.Message);
                            }
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }

        /// <summary>
        /// Main form form closed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            CloseLiveMap();
            CloseGroup();
            CloseFindUsers();
            Configuration.Save();
            if (api != null)
            {
                api.Dispose();
                api = null;
            }
            currentSpeedData.Clear();
            speedLimitData.Clear();
            if (thread != null)
            {
                isThreadRunning = false;
                try
                {
                    thread.Join();
                }
                catch (Exception ex)
                {
                    Console.Error.WriteLine(ex.Message);
                }
            }
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
                                takeScreenshot = true;
                                ETruckingVSAPIJobDataType api_data_type = ((lastJobDistance <= 2000.0f) ? ETruckingVSAPIJobDataType.Finished : ETruckingVSAPIJobDataType.Canceled);
                                if (api_data_type == ETruckingVSAPIJobDataType.Canceled)
                                {
                                    totalRoute -= api.Distance;
                                    totalWeight -= api.Weight;
                                    totalYield -= api.Yield;
                                }
                                api.QueueJobData(new TruckingVSAPIJobData(data, api_data_type));
                                lastUpdateTimestamp = now;
                                jobData = job_data;
                                ClearCharts();
                                totalRoute += data.Job.NavigationDistanceLeft;
                                totalWeight += data.Job.Mass;
                                totalYield += data.Job.Income;
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
                            ClearCharts();
                            totalRoute += data.Job.NavigationDistanceLeft;
                            totalWeight += data.Job.Mass;
                            totalYield += data.Job.Income;
                            api.QueueJobData(new TruckingVSAPIJobData(data, ETruckingVSAPIJobDataType.New));
                        }
                    }
                    lastJobDistance = data.Job.NavigationDistanceLeft;
                }
                else if (isJobRunning)
                {
                    isJobRunning = false;
                    takeScreenshot = true;
                    ETruckingVSAPIJobDataType api_data_type = ((lastJobDistance <= 2000.0f) ? ETruckingVSAPIJobDataType.Finished : ETruckingVSAPIJobDataType.Canceled);
                    if (api_data_type == ETruckingVSAPIJobDataType.Canceled)
                    {
                        totalRoute -= api.Distance;
                        totalWeight -= api.Weight;
                        totalYield -= api.Yield;
                    }
                    api.QueueJobData(new TruckingVSAPIJobData(data, (lastJobDistance <= 2000.0f) ? ETruckingVSAPIJobDataType.Finished : ETruckingVSAPIJobDataType.Canceled));
                }
            }
            updateTelemetryData = true;
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
        /// Update timer tick event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void updateTimer_Tick(object sender, EventArgs e)
        {
            if (takeScreenshot)
            {
                takeScreenshot = false;
                TakeScreenshot();
            }
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
                    gameNameLabel.Text = Utils.IsAGameRunning ? Utils.RunningGameName : startGameNowTranslated;
                    if (game_running)
                    {
                        speedLabel.Text = (Configuration.UseMetricUnit ? (Math.Round(Math.Abs(data.Drivetrain.SpeedKmh)) + " km/h") : (Math.Round(Math.Abs(data.Drivetrain.SpeedMph)) + " mph")) + (data.Drivetrain.CruiseControl ? ("; " + cruiseControlTranslated + ": " + (Configuration.UseMetricUnit ? (Math.Round(data.Drivetrain.CruiseControlSpeedKmh) + " km/h") : (Math.Round(data.Drivetrain.CruiseControlSpeedMph) + " mph"))) : "");
                        float delta_speed_limit = data.Drivetrain.Speed - data.Job.SpeedLimit;
                        speedLabel.ForeColor = ((data.Job.SpeedLimit <= 0.0f) ? Color.White : Utils.ColorGradient(Color.White, Color.Red, delta_speed_limit / 1.4f));
                        speedLimitLabel.Text = speedLimitTranslated + ": " + ((data.Job.SpeedLimit == -1.0f) ? unlimitedTranslated : Math.Round(Utils.ConvertSpeed(data.Job.SpeedLimit)) + (Configuration.UseMetricUnit ? " km/h" : " mph"));
                        vehicleLabel.Text = vehicleTranslated + ": " + data.Manufacturer + " " + data.Truck;
                        if (data.Job.OnJob)
                        {
                            statusLabel.Text = statusTranslated + ": " + deliverCargoTranslated;
                            cargoLabel.Text = cargoTranslated + ": " + data.Job.Cargo;
                            sourceLabel.Text = sourceTranslated + ": " + data.Job.CompanySource + " " + inTranslated + " " + Cities.GetFullCityName(data.Job.CitySource);
                            destinationLabel.Text = destinationTranslated + ": " + data.Job.CompanyDestination + " " + inTranslated + " " + Cities.GetFullCityName(data.Job.CityDestination);
                            routeLabel.Text = routeTranslated + ": " + Utils.HumanReadableLength(Utils.Clamp(api.Distance - data.Job.NavigationDistanceLeft, 0.0f, api.Distance)) + " " + ofTranslated + " " + Utils.HumanReadableLength(api.Distance) + " (" + ((api.Distance > float.Epsilon) ? Math.Round((data.Job.NavigationDistanceLeft * 100.0f) / api.Distance) : 100.0f) + "%)";
                            remainingTimeLabel.Text = remainingTimeTranslated + ": " + Utils.HumanReadableTime(data.Job.NavigationTimeLeft);
                            //timeLabel.Text = timeTranslated + ": " + Utils.HumanReadableTime(data.Job.NavigationTimeLeft) + " " + ofTranslated + " " + Utils.HumanReadableTime(api.Time);
                            yieldLabel.Text = yieldTranslated + ": " + data.Job.Income.ToString("N0") + "€";
                            weightLabel.Text = weightTranslated + ": " + Utils.HumanReadableWeight(data.Job.Mass);
                            deadlineLabel.Text = deadlineTranslated + ": " + ((data.Job.Deadline == -1) ? unlimitedTranslated : deadlineAvailableTranslated);
                        }
                        else
                        {
                            statusLabel.Text = statusTranslated + ": " + idleTranslated;
                            cargoLabel.Text = "";
                            sourceLabel.Text = "";
                            destinationLabel.Text = "";
                            routeLabel.Text = "";
                            remainingTimeLabel.Text = "";
                            yieldLabel.Text = "";
                            weightLabel.Text = "";
                            deadlineLabel.Text = "";
                        }
                        totalRouteLabel.Text = totalRouteTranslated + ": " + Utils.HumanReadableLength(totalRoute);
                        totalWeightLabel.Text = totalWeightTranslated + ": " + Utils.HumanReadableWeight(totalWeight);
                        totalYieldLabel.Text = totalYieldTranslated + ": " + totalYield + "€";
                        cabinLabel.Text = cabinTranslated + ": " + Math.Round(data.Damage.WearCabin * 100.0f) + "%";
                        chassisLabel.Text = chassisTranslated + ": " + Math.Round(data.Damage.WearChassis * 100.0f) + "%";
                        engineLabel.Text = engineTranslated + ": " + Math.Round(data.Damage.WearEnigne * 100.0f) + "%";
                        transmissionLabel.Text = transmissionTranslated + ": " + Math.Round(data.Damage.WearTransmission * 100.0f) + "%";
                        wheelsLabel.Text = wheelsTranslated + ": " + Math.Round(data.Damage.WearWheels * 100.0f) + "%";
                        trailerLabel.Text = (data.Job.TrailerAttached) ? (trailerTranslated + ": " + Math.Round(data.Damage.WearTrailer * 100.0f) + "%") : "";
                        averageLabel.Text = averageTranslated + ": " + Math.Round((data.Damage.WearCabin + data.Damage.WearChassis + data.Damage.WearEnigne + data.Damage.WearTransmission + data.Damage.WearWheels) * 20.0f) + "%";
                        float max_damage = Math.Max(data.Damage.WearCabin, Math.Max(data.Damage.WearChassis, Math.Max(data.Damage.WearEnigne, Math.Max(data.Damage.WearTransmission, data.Damage.WearWheels))));
                        int image_id = 0;
                        if (max_damage >= 0.9f)
                        {
                            image_id = 4;
                        }
                        else if (max_damage >= 0.7f)
                        {
                            image_id = 3;
                        }
                        else if (max_damage >= 0.5f)
                        {
                            image_id = 2;
                        }
                        else if (max_damage >= 0.3f)
                        {
                            image_id = 1;
                        }
                        else if (max_damage >= 0.0f)
                        {
                            image_id = 0;
                        }
                        drivetrainPanel.BackgroundImage = drivetrainImages[image_id];
                        max_damage = data.Damage.WearTrailer;
                        if (data.Job.TrailerAttached)
                        {
                            if (max_damage >= 0.9f)
                            {
                                image_id = 5;
                            }
                            else if (max_damage >= 0.7f)
                            {
                                image_id = 4;
                            }
                            else if (max_damage >= 0.5f)
                            {
                                image_id = 3;
                            }
                            else if (max_damage >= 0.3f)
                            {
                                image_id = 2;
                            }
                            else if (max_damage >= 0.0f)
                            {
                                image_id = 1;
                            }
                        }
                        else
                        {
                            image_id = 0;
                        }
                        cargoPictureBox.Image = cargoImages[image_id];
                        double fuel_part = data.Drivetrain.Fuel / (double)(data.Drivetrain.FuelMax);
                        double fuel_percentage = Math.Round(fuel_part * 100.0);
                        fuelLabel.Text = fuelTranslated + ": " + Math.Round(data.Drivetrain.Fuel) + " l " + ofTranslated + " " + Math.Round(data.Drivetrain.FuelMax) + " l (" + Math.Round(data.Drivetrain.FuelAvgConsumption * 100.0f, 2) + " l / 100 km); " + fuel_percentage + "%";
                        fuelRemainingDistanceLabel.Text = fuelRemainingDistanceTranslated + ": " + Math.Round(data.Drivetrain.FuelRange) + (Configuration.UseMetricUnit ? " km" : " ml");
                        fuelStatusLabel.Text = fuelStatusTranslated + ": " + ((fuel_percentage <= 15.0) ? pleaseRefillFuelTranslated : (data.Job.OnJob ? ((data.Drivetrain.FuelRange < (data.Job.NavigationDistanceLeft * 0.001f)) ? refillLaterTranslated : enoughFuelTranslated) : ((fuel_percentage < 30.0) ? lowFuelTranslated : enoughFuelTranslated)));
                        fuelStatusLabel.ForeColor = ((fuel_percentage <= 15.0) ? Color.Red : Color.White);
                        if ((currentGameTime != data.Time) && isJobRunning)
                        {
                            currentGameTime = data.Time;
                            ++chartUpdateTickCounter;
                            if ((chartUpdateTickCounter % 400) == 0)
                            {
                                chartUpdateTickCounter = 0;
                                lock (currentSpeedData)
                                {
                                    currentSpeedData.Add(Math.Round(Configuration.UseMetricUnit ? data.Drivetrain.SpeedKmh : data.Drivetrain.SpeedMph, 2));
                                    speedChart.Series[0].Points.DataBindY(currentSpeedData);
                                }
                                lock (speedLimitData)
                                {
                                    speedLimitData.Add(Math.Abs(Utils.ConvertSpeed((data.Job.SpeedLimit == -1.0f) ? 0.0f : data.Job.SpeedLimit)));
                                    speedChart.Series[1].Points.DataBindY(speedLimitData);
                                }
                            }
                        }
                        fuelGaugeNeedlePictureBox.Location = new Point(fuelGaugeNeedleOffset + (int)(fuelGaugeNeedleRange * fuel_part), fuelGaugeNeedlePictureBox.Location.Y);
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
            CloseLiveMap();
            CloseGroup();
            CloseFindUsers();
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

        /// <summary>
        /// Map picture box mouse enter event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void genericPictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }

        /// <summary>
        /// Map picture box mouse leave event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void genericPictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.Default;
        }

        /// <summary>
        /// Live map picture box mouse click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void liveMapPictureBox_Click(object sender, EventArgs e)
        {
            ToggleLiveMap();
        }

        /// <summary>
        /// Group picture box click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void groupPictureBox_Click(object sender, EventArgs e)
        {
            ToggleGroup();
        }
    }
}
