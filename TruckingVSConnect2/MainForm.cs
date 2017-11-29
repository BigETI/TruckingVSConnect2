using Ets2SdkClient;
using MaterialSkin;
using MaterialSkin.Controls;
using System.Windows.Forms;
using WinFormsTranslator;
using System;

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
        /// Is read or writing telemetry data
        /// </summary>
        private bool isReadWritingTelemetryData;

        /// <summary>
        /// Update telemetry data
        /// </summary>
        private bool updateTelemetryData;

        /// <summary>
        /// Is job running
        /// </summary>
        private bool isJobRunning;

        /// <summary>
        /// Start job
        /// </summary>
        private bool startJob;

        /// <summary>
        /// Finish job
        /// </summary>
        private bool finishJob;

        /// <summary>
        /// Finish job
        /// </summary>
        private bool cancelJob;

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
            telemetry.JobStarted += Telemetry_JobStarted;
            telemetry.JobFinished += Telemetry_JobFinished;
            telemetry.Data += Telemetry_Data;
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
                    // Auto log in
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
        /// Telemetry job started event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void Telemetry_JobStarted(object sender, EventArgs e)
        {
            isJobRunning = true;
            startJob = true;
        }

        /// <summary>
        /// Telemetry job finished event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Evenet arguments</param>
        private void Telemetry_JobFinished(object sender, EventArgs e)
        {
            isJobRunning = false;
        }

        /// <summary>
        /// Telemetry data event
        /// </summary>
        /// <param name="data">Data</param>
        /// <param name="newTimestamp">New timestamp</param>
        private void Telemetry_Data(Ets2Telemetry data, bool newTimestamp)
        {
            while (isReadWritingTelemetryData) ;
            isReadWritingTelemetryData = true;
            telemetryData = data;
            if (api != null)
            {
                if (startJob)
                {
                    startJob = false;
                    api.QueueJobData(new TruckingVSAPIJobData(data, ETruckingVSAPIJobDataType.Started));
                }
                else if (finishJob)
                {
                    finishJob = false;
                    cancelJob = false;
                    api.QueueJobData(new TruckingVSAPIJobData(data, ETruckingVSAPIJobDataType.Finished));
                }
                else if (cancelJob)
                {
                    cancelJob = false;
                    api.QueueJobData(new TruckingVSAPIJobData(data, ETruckingVSAPIJobDataType.Canceled));
                }
                else if (isJobRunning)
                {
                    api.QueueJobData(new TruckingVSAPIJobData(data, ETruckingVSAPIJobDataType.DataUpdated));
                }
            }
            isReadWritingTelemetryData = false;
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
                while (isReadWritingTelemetryData) ;
                isReadWritingTelemetryData = true;
                if ((telemetryData != null) && updateTelemetryData)
                {
                    speedLabel.Text = (Configuration.UseMetricUnit ? (Math.Round(telemetryData.Drivetrain.SpeedKmh, 1) + " km/h") : (Math.Round(telemetryData.Drivetrain.SpeedMph, 1) + " " + milesTranslated  + "/h")) + (telemetryData.Drivetrain.CruiseControl ? ("; " + cruiseControlTranslated + ": " + (Configuration.UseMetricUnit ? (Math.Round(telemetryData.Drivetrain.CruiseControlSpeedKmh, 1) + " km/h") : (Math.Round(telemetryData.Drivetrain.CruiseControlSpeedMph, 1) + " " + milesTranslated + "/h"))) : "");
                    speedLimitLabel.Text = speedLimitTranslated + ": " + (Configuration.UseMetricUnit ? (Math.Round((telemetryData.Job.SpeedLimit * 3.6f), 1) + " km/h") : (Math.Round(telemetryData.Job.SpeedLimit * 2.2369362920544f, 1) + " " + milesTranslated + "/h"));
                    vehicleLabel.Text = vehicleTranslated + ": " + telemetryData.Truck + ", " + telemetryData.Manufacturer;
                    if (telemetryData.Job.OnJob)
                    {
                        statusLabel.Text = statusTranslated + ": " + deliverCargoTranslated;
                        cargoLabel.Text = cargoTranslated + ": " + telemetryData.Job.Cargo;
                        sourceLabel.Text = sourceTranslated + ": " + telemetryData.Job.CompanySource + ", " + Cities.GetFullCityName(telemetryData.Job.CitySource);
                        destinationLabel.Text = destinationTranslated + ": " + telemetryData.Job.CompanyDestination + ", " + Cities.GetFullCityName(telemetryData.Job.CityDestination);
                        routeLabel.Text = routeTranslated + ": " + (Configuration.UseMetricUnit ? (Math.Round(telemetryData.Job.NavigationDistanceLeft * 0.001f) + " km") : (Math.Round(telemetryData.Job.NavigationDistanceLeft * 0.0006213712f) + " " + milesTranslated)) + " " + ofTranslated + " " + api.Distance + "; " + Math.Ceiling(telemetryData.Job.NavigationTimeLeft / 60.0f) + " " + minutesTranslated + " " + ofTranslated + " " + Math.Ceiling(api.Time / 60.0f) + " " + minutesTranslated;
                        yieldLabel.Text = yieldTranslated + ": " + telemetryData.Job.Income + "€; " + Math.Round(telemetryData.Job.Mass, 1) + " kg";
                        deadlineLabel.Text = deadlineTranslated + ": " + ((telemetryData.Job.Deadline == -1) ? unlimitedTranslated : telemetryData.Job.Deadline.ToString());
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
                    cabinLabel.Text = cabinTranslated + ": " + Math.Round(100.0f - (telemetryData.Damage.WearCabin * 100.0f), 1) + "%";
                    chassisLabel.Text = chassisTranslated + ": " + Math.Round(100.0f - (telemetryData.Damage.WearChassis * 100.0f), 1) + "%";
                    engineLabel.Text = engineTranslated + ": " + Math.Round(100.0f - (telemetryData.Damage.WearEnigne * 100.0f), 1) + "%";
                    transmissionLabel.Text = transmissionTranslated + ": " + Math.Round(100.0f - (telemetryData.Damage.WearTransmission * 100.0f), 1) + "%";
                    wheelsLabel.Text = wheelsTranslated + ": " + Math.Round(100.0f - (telemetryData.Damage.WearWheels * 100.0f), 1) + "%";
                    trailerLabel.Text = (telemetryData.Job.TrailerAttached) ? (trailerTranslated + ": " + Math.Round(100.0f - (telemetryData.Damage.WearTrailer * 100.0f), 1) + "%") : "";
                    float damage = Math.Max(telemetryData.Damage.WearCabin, Math.Max(telemetryData.Damage.WearChassis, Math.Max(telemetryData.Damage.WearEnigne, Math.Max(telemetryData.Damage.WearTransmission, telemetryData.Damage.WearWheels))));
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
                    damage = telemetryData.Damage.WearTrailer;
                    if (telemetryData.Job.TrailerAttached)
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
                    updateTelemetryData = false;
                }
                isReadWritingTelemetryData = false;
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

        private void switchLengthUnitButton_Click(object sender, EventArgs e)
        {
            Configuration.UseMetricUnit = !(Configuration.UseMetricUnit);
        }
    }
}
