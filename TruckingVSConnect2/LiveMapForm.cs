using Ets2SdkClient;
using System;
using System.Drawing;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;
using TruckingVSConnect2.Properties;
using WinFormsTranslator;

/// <summary>
/// Trucking VS Connect² namespace
/// </summary>
namespace TruckingVSConnect2
{
    /// <summary>
    /// Live map form
    /// </summary>
    public partial class LiveMapForm : Form
    {
        /// <summary>
        /// Points of interests serializer
        /// </summary>
        private DataContractJsonSerializer pointsOfInterestsSerializer = new DataContractJsonSerializer(typeof(PointOfInterestData[]));

        /// <summary>
        /// Points of interests
        /// </summary>
        private PointOfInterestData[] pointsOfInterests;

        /// <summary>
        /// Map size X
        /// </summary>
        private int mapSizeX = 104500;

        /// <summary>
        /// Map size Y
        /// </summary>
        private int mapSizeY = 102500;

        /// <summary>
        /// Map start X
        /// </summary>
        private int mapStartX = -60250;

        /// <summary>
        /// Map start Y
        /// </summary>
        private int mapStartY = -61250;

        /// <summary>
        /// X size
        /// </summary>
        private int xSize;

        /// <summary>
        /// Y size
        /// </summary>
        private int ySize;

        /// <summary>
        /// X offset
        /// </summary>
        private int xOffset;

        /// <summary>
        /// Y offset
        /// </summary>
        private int yOffset;

        /// <summary>
        /// Title font
        /// </summary>
        private Font titleFont;

        /// <summary>
        /// Point of interest font
        /// </summary>
        private Font pointOfInterestFont;

        /// <summary>
        /// User font
        /// </summary>
        private Font userFont;

        /// <summary>
        /// Centered string format
        /// </summary>
        private StringFormat centeredStringFormat;

        /// <summary>
        /// Bottom centered string format
        /// </summary>
        private StringFormat bottomCenteredStringFormat;

        /// <summary>
        /// Window size too small translated
        /// </summary>
        private string windowSizeTooSmallTranslated;

        /// <summary>
        /// No game running translated
        /// </summary>
        private string noGameIsRunningTranslated;

        /// <summary>
        /// No live map for game translated
        /// </summary>
        private string noLiveMapForGameTranslated;

        /// <summary>
        /// Constructor
        /// </summary>
        public LiveMapForm()
        {
            InitializeComponent();
            Translator.LoadTranslation(this);

            titleFont = new Font("Segoe UI", 24.0f);
            pointOfInterestFont = new Font("Segoe UI", 18.0f);
            userFont = new Font("Segoe UI", 8.0f);

            centeredStringFormat = new StringFormat();
            centeredStringFormat.LineAlignment = StringAlignment.Center;
            centeredStringFormat.Alignment = StringAlignment.Center;

            bottomCenteredStringFormat = new StringFormat();
            bottomCenteredStringFormat.Alignment = StringAlignment.Center;

            if (File.Exists("./ETS2PointsOfInterests.json"))
            {
                try
                {
                    using (FileStream stream = File.Open("./ETS2PointsOfInterests.json", FileMode.Open))
                    {
                        pointsOfInterests = pointsOfInterestsSerializer.ReadObject(stream) as PointOfInterestData[];
                    }
                }
                catch (Exception e)
                {
                    Console.Error.WriteLine(e.Message);
                }
            }
            if (pointsOfInterests == null)
            {
                pointsOfInterests = new PointOfInterestData[0];
            }

            windowSizeTooSmallTranslated = Translator.GetTranslation("WINDOW_SIZE_TOO_SMALL");
            noGameIsRunningTranslated = Translator.GetTranslation("NO_GAME_IS_RUNNING");
            noLiveMapForGameTranslated = Translator.GetTranslation("NO_LIVE_MAP_FOR_GAME");
        }

        /// <summary>
        /// Calculate position
        /// </summary>
        /// <param name="x">X</param>
        /// <param name="y">Y</param>
        /// <param name="xResult">X result</param>
        /// <param name="yResult">Y Result</param>
        private void CalculatePosition(int x, int y, out int xResult, out int yResult)
        {
            xResult = (((x - mapStartX) * xSize) / mapSizeX) + xOffset;
            yResult = (((y - mapStartY) * ySize) / mapSizeY) + yOffset;
        }

        /// <summary>
        /// Draw player
        /// </summary>
        /// <param name="graphics">Graphics</param>
        /// <param name="userData">User data</param>
        private void DrawUser(Graphics graphics, UserData userData)
        {
            if ((userData.PosX != 0.0f) && (userData.PosY != 0.0f) && (userData.PosZ != 0.0f))
            {
                int x;
                int y;
                Bitmap map_pointer = userData.OnJob ? Resources.MapPointer : Resources.MapPointerIdle;
                CalculatePosition((int)(Math.Round(userData.PosX)), (int)(Math.Round(userData.PosZ)), out x, out y);
                graphics.DrawString(userData.Name, userFont, Brushes.White, x, y, bottomCenteredStringFormat);
                graphics.DrawImage(map_pointer, x - (map_pointer.Width / 2), y - map_pointer.Height, map_pointer.Width, map_pointer.Height);
            }
        }

        /// <summary>
        /// Draw point of interest
        /// </summary>
        /// <param name="graphics"></param>
        /// <param name="pointOfInterest"></param>
        private void DrawPointOfInterest(Graphics graphics, PointOfInterestData pointOfInterest)
        {
            int x;
            int y;
            CalculatePosition(pointOfInterest.X, pointOfInterest.Y, out x, out y);
            graphics.DrawString(pointOfInterest.TranslatedName, pointOfInterestFont, Brushes.White, x, y, centeredStringFormat);
        }

        /// <summary>
        /// Live map form paint event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Paint event arguments</param>
        private void LiveMapForm_Paint(object sender, PaintEventArgs e)
        {
            Image live_map = Resources.ETS2LiveMap;//Utils.RunningGameLiveMapImage;
            xSize = 0;
            ySize = 0;
            xOffset = 0;
            yOffset = 0;
            if (live_map == null)
            {
                e.Graphics.DrawString((Utils.RunningGame == EGame.Nothing) ? noGameIsRunningTranslated : string.Format(noLiveMapForGameTranslated, Utils.RunningGameName), titleFont, Brushes.White, ClientRectangle.Width * 0.5f, ClientRectangle.Height * 0.5f, centeredStringFormat);
            }
            else
            {
                if ((ClientRectangle.Width < live_map.Size.Width) || (ClientRectangle.Height < live_map.Size.Height))
                {
                    Size = new Size((ClientRectangle.Width < live_map.Size.Width) ? ((Size.Width - ClientRectangle.Width) + live_map.Size.Width) : Size.Width, (ClientRectangle.Height < live_map.Size.Height) ? ((Size.Height - ClientRectangle.Height) + live_map.Size.Height) : Size.Height);
                    live_map = null;
                    e.Graphics.DrawString(windowSizeTooSmallTranslated, titleFont, Brushes.White, ClientRectangle.Width * 0.5f, ClientRectangle.Height * 0.5f, centeredStringFormat);
                }
                else
                {
                    xSize = live_map.Size.Width;
                    ySize = live_map.Size.Height;
                    xOffset = (ClientRectangle.Width - xSize) / 2;
                    yOffset = (ClientRectangle.Height - ySize) / 2;
                    e.Graphics.DrawImage(Resources.ETS2LiveMap, xOffset, yOffset, xSize, ySize);
                }
            }
            if ((live_map != null) && (MainForm.Instance != null))
            {
                if (pointsOfInterests != null)
                {
                    foreach (PointOfInterestData point_of_interest in pointsOfInterests)
                    {
                        DrawPointOfInterest(e.Graphics, point_of_interest);
                    }
                }
                Ets2Telemetry telemetry_data = MainForm.Instance.TelemetryData;
                TruckingVSAPI api = MainForm.API;
                if ((telemetry_data != null) && (api != null))
                {
                    DrawUser(e.Graphics, new UserData(MainForm.API.Username, telemetry_data, api));
                }
                UserData[] users = MainForm.Instance.Users;
                foreach (UserData user in users)
                {
                    DrawUser(e.Graphics, user);
                }
            }
        }

        /// <summary>
        /// Frame update timer tick event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void frameUpdateTimer_Tick(object sender, EventArgs e)
        {
            Refresh();
        }

        /// <summary>
        /// Add user tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void addUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Utils.ShowAddUserDialog();
        }

        /// <summary>
        /// Show group tool strip menu item click event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void showGroupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MainForm.Instance != null)
            {
                MainForm.Instance.ShowGroup();
            }
        }

        /// <summary>
        /// Live map form resize event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void LiveMapForm_Resize(object sender, EventArgs e)
        {
            Refresh();
        }
    }
}
