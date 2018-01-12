using MaterialSkin.Controls;
using System;
using System.Data;
using WinFormsTranslator;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Group form class
    /// </summary>
    public partial class GroupForm : MaterialForm
    {
        /// <summary>
        /// Live map form
        /// </summary>
        //private LiveMapForm liveMap;

        /// <summary>
        /// Update users
        /// </summary>
        private static bool updateUsers = false;

        /// <summary>
        /// In translated
        /// </summary>
        private string inTranslated;

        /// <summary>
        /// Of translated
        /// </summary>
        private string ofTranslated;

        /// <summary>
        /// Unlimited translated
        /// </summary>
        private string unlimitedTranslated;

        /// <summary>
        /// Not available translated
        /// </summary>
        private string notAvailableTranslated;

        /// <summary>
        /// Default constructor
        /// </summary>
        public GroupForm()
        {
            InitializeComponent();
            Translator.LoadTranslation(this);

            usersGridView.Columns[0].HeaderText = Translator.GetTranslation("NAME");
            usersGridView.Columns[1].HeaderText = Translator.GetTranslation("SPEED");
            usersGridView.Columns[2].HeaderText = Translator.GetTranslation("SPEED_LIMIT");
            usersGridView.Columns[3].HeaderText = Translator.GetTranslation("VEHICLE");
            usersGridView.Columns[4].HeaderText = Translator.GetTranslation("CARGO");
            usersGridView.Columns[5].HeaderText = Translator.GetTranslation("SOURCE");
            usersGridView.Columns[6].HeaderText = Translator.GetTranslation("DESTINATION");
            usersGridView.Columns[7].HeaderText = Translator.GetTranslation("ROUTE");
            usersGridView.Columns[8].HeaderText = Translator.GetTranslation("REMAINING_TIME");
            usersGridView.Columns[9].HeaderText = Translator.GetTranslation("YIELD");
            usersGridView.Columns[10].HeaderText = Translator.GetTranslation("WEIGHT");

            inTranslated = Translator.GetTranslation("IN");
            ofTranslated = Translator.GetTranslation("OF");
            unlimitedTranslated = Translator.GetTranslation("UNLIMITED");
            notAvailableTranslated = Translator.GetTranslation("NOT_AVAILABLE");

            UpdateRows();
        }

        /// <summary>
        /// Update users
        /// </summary>
        public static void UpdateUsers()
        {
            updateUsers = true;
        }

        /// <summary>
        /// Update rows
        /// </summary>
        private void UpdateRows()
        {
            UserData[] users = MainForm.Instance.Users;
            usersDataTable.Rows.Clear();
            foreach (UserData user in users)
            {
                DataRow row = usersDataTable.NewRow();
                object[] data = new object[11];
                data[0] = user.Name;
                data[1] = Math.Round(Math.Abs(Utils.ConvertSpeed(user.Speed))) + (Configuration.UseMetricUnit ? " km/h" : " mph");
                data[2] = (user.SpeedLimit < 0.0f) ? unlimitedTranslated : (Math.Round(Math.Abs(Utils.ConvertSpeed(user.SpeedLimit))) + (Configuration.UseMetricUnit ? " km/h" : " mph"));
                data[3] = user.Manufacturer + " " + user.Truck;
                data[4] = user.OnJob ? user.Cargo : notAvailableTranslated;
                data[5] = user.OnJob ? (user.CompanySource + " " + inTranslated + " " + Cities.GetFullCityName(user.CitySource)) : notAvailableTranslated;
                data[6] = user.OnJob ? (user.CompanyDestination + " " + inTranslated + " " + Cities.GetFullCityName(user.CityDestination)) : notAvailableTranslated;
                data[7] = user.OnJob ? (Utils.HumanReadableLength(Utils.Clamp(user.Distance - user.NavigationDistanceLeft, 0.0f, user.Distance)) + " " + ofTranslated + " " + Utils.HumanReadableLength(user.Distance) + " (" + ((user.Distance > float.Epsilon) ? 100.0f : ((user.NavigationDistanceLeft * 100.0f) / user.Distance)) + "%)") : notAvailableTranslated;
                data[8] = user.OnJob ? (Utils.HumanReadableTime(user.NavigationTimeLeft)) : notAvailableTranslated;
                data[9] = user.OnJob ? (user.Income + "€") : notAvailableTranslated;
                data[10] = user.OnJob ? (Math.Round(user.Mass).ToString("N0") + " kg") : notAvailableTranslated;
                row.ItemArray = data;
                usersDataTable.Rows.Add(row);
            }
        }

        /// <summary>
        /// Thread timer tick event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void threadTimer_Tick(object sender, EventArgs e)
        {
            if (updateUsers)
            {
                updateUsers = false;
                UpdateRows();
            }
        }

        private void genericPictureBox_MouseEnter(object sender, EventArgs e)
        {

        }

        private void genericPictureBox_MouseLeave(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Add user picture box mouse click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void addUserPictureBox_Click(object sender, EventArgs e)
        {
            Utils.ShowAddUserDialog();
        }

        /// <summary>
        /// Live map picture box mouse click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void liveMapPictureBox_Click(object sender, EventArgs e)
        {
            if (MainForm.Instance != null)
            {
                MainForm.Instance.ToggleLiveMap();
            }
        }
    }
}
