namespace TruckingVSConnect2
{
    partial class MainForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.updateTimer = new System.Windows.Forms.Timer(this.components);
            this.mainTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.bodyTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.headPanel = new System.Windows.Forms.Panel();
            this.gameNameLabel = new MaterialSkin.Controls.MaterialLabel();
            this.loggedInAsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.loggedInAsTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.speedPanel = new System.Windows.Forms.Panel();
            this.statusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.speedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.speedLimitLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.totalYieldLabel = new MaterialSkin.Controls.MaterialLabel();
            this.totalWeightLabel = new MaterialSkin.Controls.MaterialLabel();
            this.totalRouteLabel = new MaterialSkin.Controls.MaterialLabel();
            this.remainingTimeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.weightLabel = new MaterialSkin.Controls.MaterialLabel();
            this.deadlineLabel = new MaterialSkin.Controls.MaterialLabel();
            this.yieldLabel = new MaterialSkin.Controls.MaterialLabel();
            this.routeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.destinationLabel = new MaterialSkin.Controls.MaterialLabel();
            this.sourceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.cargoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.vehicleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.healthPanel = new System.Windows.Forms.Panel();
            this.averageLabel = new MaterialSkin.Controls.MaterialLabel();
            this.fuelRemainingDistanceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.fuelLabel = new MaterialSkin.Controls.MaterialLabel();
            this.fuelStatusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.trailerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.wheelsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.transmissionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.engineLabel = new MaterialSkin.Controls.MaterialLabel();
            this.chassisLabel = new MaterialSkin.Controls.MaterialLabel();
            this.cabinLabel = new MaterialSkin.Controls.MaterialLabel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.logOutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.switchLengthUnitButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.speedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.groupPictureBox = new System.Windows.Forms.PictureBox();
            this.liveMapPictureBox = new System.Windows.Forms.PictureBox();
            this.gravatarPictureBox = new System.Windows.Forms.PictureBox();
            this.fuelGaugePanel = new System.Windows.Forms.Panel();
            this.fuelGaugeNeedlePictureBox = new System.Windows.Forms.PictureBox();
            this.drivetrainPanel = new System.Windows.Forms.Panel();
            this.cargoPictureBox = new System.Windows.Forms.PictureBox();
            this.mainTableLayoutPanel.SuspendLayout();
            this.bodyTableLayoutPanel.SuspendLayout();
            this.headPanel.SuspendLayout();
            this.dataTableLayoutPanel.SuspendLayout();
            this.speedPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.healthPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveMapPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravatarPictureBox)).BeginInit();
            this.fuelGaugePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fuelGaugeNeedlePictureBox)).BeginInit();
            this.drivetrainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // updateTimer
            // 
            this.updateTimer.Enabled = true;
            this.updateTimer.Interval = 20;
            this.updateTimer.Tick += new System.EventHandler(this.updateTimer_Tick);
            // 
            // mainTableLayoutPanel
            // 
            this.mainTableLayoutPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainTableLayoutPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mainTableLayoutPanel.ColumnCount = 1;
            this.mainTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.Controls.Add(this.bodyTableLayoutPanel, 0, 0);
            this.mainTableLayoutPanel.Controls.Add(this.speedChart, 0, 1);
            this.mainTableLayoutPanel.Location = new System.Drawing.Point(12, 64);
            this.mainTableLayoutPanel.Name = "mainTableLayoutPanel";
            this.mainTableLayoutPanel.RowCount = 2;
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 120F));
            this.mainTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.mainTableLayoutPanel.Size = new System.Drawing.Size(889, 620);
            this.mainTableLayoutPanel.TabIndex = 0;
            // 
            // bodyTableLayoutPanel
            // 
            this.bodyTableLayoutPanel.ColumnCount = 2;
            this.bodyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bodyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 400F));
            this.bodyTableLayoutPanel.Controls.Add(this.headPanel, 0, 0);
            this.bodyTableLayoutPanel.Controls.Add(this.dataTableLayoutPanel, 0, 1);
            this.bodyTableLayoutPanel.Controls.Add(this.healthPanel, 1, 1);
            this.bodyTableLayoutPanel.Controls.Add(this.flowLayoutPanel1, 1, 0);
            this.bodyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.bodyTableLayoutPanel.Name = "bodyTableLayoutPanel";
            this.bodyTableLayoutPanel.RowCount = 2;
            this.bodyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.bodyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bodyTableLayoutPanel.Size = new System.Drawing.Size(883, 494);
            this.bodyTableLayoutPanel.TabIndex = 1;
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.groupPictureBox);
            this.headPanel.Controls.Add(this.liveMapPictureBox);
            this.headPanel.Controls.Add(this.gameNameLabel);
            this.headPanel.Controls.Add(this.loggedInAsLabel);
            this.headPanel.Controls.Add(this.loggedInAsTitleLabel);
            this.headPanel.Controls.Add(this.gravatarPictureBox);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headPanel.Location = new System.Drawing.Point(3, 3);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(477, 70);
            this.headPanel.TabIndex = 1;
            // 
            // gameNameLabel
            // 
            this.gameNameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.gameNameLabel.AutoSize = true;
            this.gameNameLabel.Depth = 0;
            this.gameNameLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.gameNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.gameNameLabel.Location = new System.Drawing.Point(73, 48);
            this.gameNameLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.gameNameLabel.Name = "gameNameLabel";
            this.gameNameLabel.Size = new System.Drawing.Size(171, 19);
            this.gameNameLabel.TabIndex = 3;
            this.gameNameLabel.Text = "{$START_GAME_NOW$}";
            // 
            // loggedInAsLabel
            // 
            this.loggedInAsLabel.AutoSize = true;
            this.loggedInAsLabel.Depth = 0;
            this.loggedInAsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.loggedInAsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loggedInAsLabel.Location = new System.Drawing.Point(73, 22);
            this.loggedInAsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.loggedInAsLabel.Name = "loggedInAsLabel";
            this.loggedInAsLabel.Size = new System.Drawing.Size(110, 19);
            this.loggedInAsLabel.TabIndex = 2;
            this.loggedInAsLabel.Text = "{$UNKNOWN$}";
            // 
            // loggedInAsTitleLabel
            // 
            this.loggedInAsTitleLabel.AutoSize = true;
            this.loggedInAsTitleLabel.Depth = 0;
            this.loggedInAsTitleLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.loggedInAsTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loggedInAsTitleLabel.Location = new System.Drawing.Point(73, 3);
            this.loggedInAsTitleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.loggedInAsTitleLabel.Name = "loggedInAsTitleLabel";
            this.loggedInAsTitleLabel.Size = new System.Drawing.Size(140, 19);
            this.loggedInAsTitleLabel.TabIndex = 1;
            this.loggedInAsTitleLabel.Text = "{$LOGGED_IN_AS$}";
            // 
            // dataTableLayoutPanel
            // 
            this.dataTableLayoutPanel.ColumnCount = 1;
            this.dataTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataTableLayoutPanel.Controls.Add(this.speedPanel, 0, 0);
            this.dataTableLayoutPanel.Controls.Add(this.dataPanel, 0, 1);
            this.dataTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataTableLayoutPanel.Location = new System.Drawing.Point(3, 79);
            this.dataTableLayoutPanel.Name = "dataTableLayoutPanel";
            this.dataTableLayoutPanel.RowCount = 2;
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 96F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataTableLayoutPanel.Size = new System.Drawing.Size(477, 412);
            this.dataTableLayoutPanel.TabIndex = 4;
            // 
            // speedPanel
            // 
            this.speedPanel.Controls.Add(this.statusLabel);
            this.speedPanel.Controls.Add(this.speedLabel);
            this.speedPanel.Controls.Add(this.speedLimitLabel);
            this.speedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedPanel.Location = new System.Drawing.Point(3, 3);
            this.speedPanel.Name = "speedPanel";
            this.speedPanel.Size = new System.Drawing.Size(471, 90);
            this.speedPanel.TabIndex = 2;
            this.speedPanel.Visible = false;
            // 
            // statusLabel
            // 
            this.statusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.statusLabel.Depth = 0;
            this.statusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.statusLabel.Location = new System.Drawing.Point(3, 66);
            this.statusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(465, 24);
            this.statusLabel.TabIndex = 4;
            this.statusLabel.Text = "STATUS";
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // speedLabel
            // 
            this.speedLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedLabel.Depth = 0;
            this.speedLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.speedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.speedLabel.Location = new System.Drawing.Point(3, 3);
            this.speedLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.speedLabel.Name = "speedLabel";
            this.speedLabel.Size = new System.Drawing.Size(465, 39);
            this.speedLabel.TabIndex = 2;
            this.speedLabel.Text = "SPEED";
            this.speedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedLimitLabel
            // 
            this.speedLimitLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.speedLimitLabel.Depth = 0;
            this.speedLimitLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.speedLimitLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.speedLimitLabel.Location = new System.Drawing.Point(3, 42);
            this.speedLimitLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.speedLimitLabel.Name = "speedLimitLabel";
            this.speedLimitLabel.Size = new System.Drawing.Size(465, 24);
            this.speedLimitLabel.TabIndex = 3;
            this.speedLimitLabel.Text = "SPEED_LIMIT";
            this.speedLimitLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.totalYieldLabel);
            this.dataPanel.Controls.Add(this.totalWeightLabel);
            this.dataPanel.Controls.Add(this.totalRouteLabel);
            this.dataPanel.Controls.Add(this.remainingTimeLabel);
            this.dataPanel.Controls.Add(this.weightLabel);
            this.dataPanel.Controls.Add(this.deadlineLabel);
            this.dataPanel.Controls.Add(this.yieldLabel);
            this.dataPanel.Controls.Add(this.routeLabel);
            this.dataPanel.Controls.Add(this.destinationLabel);
            this.dataPanel.Controls.Add(this.sourceLabel);
            this.dataPanel.Controls.Add(this.cargoLabel);
            this.dataPanel.Controls.Add(this.vehicleLabel);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(3, 99);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(471, 310);
            this.dataPanel.TabIndex = 3;
            this.dataPanel.Visible = false;
            // 
            // totalYieldLabel
            // 
            this.totalYieldLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalYieldLabel.AutoSize = true;
            this.totalYieldLabel.Depth = 0;
            this.totalYieldLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.totalYieldLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalYieldLabel.Location = new System.Drawing.Point(3, 291);
            this.totalYieldLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalYieldLabel.Name = "totalYieldLabel";
            this.totalYieldLabel.Size = new System.Drawing.Size(102, 19);
            this.totalYieldLabel.TabIndex = 11;
            this.totalYieldLabel.Text = "TOTAL_YIELD";
            // 
            // totalWeightLabel
            // 
            this.totalWeightLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalWeightLabel.AutoSize = true;
            this.totalWeightLabel.Depth = 0;
            this.totalWeightLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.totalWeightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalWeightLabel.Location = new System.Drawing.Point(3, 272);
            this.totalWeightLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalWeightLabel.Name = "totalWeightLabel";
            this.totalWeightLabel.Size = new System.Drawing.Size(118, 19);
            this.totalWeightLabel.TabIndex = 10;
            this.totalWeightLabel.Text = "TOTAL_WEIGHT";
            // 
            // totalRouteLabel
            // 
            this.totalRouteLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.totalRouteLabel.AutoSize = true;
            this.totalRouteLabel.Depth = 0;
            this.totalRouteLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.totalRouteLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalRouteLabel.Location = new System.Drawing.Point(3, 253);
            this.totalRouteLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.totalRouteLabel.Name = "totalRouteLabel";
            this.totalRouteLabel.Size = new System.Drawing.Size(109, 19);
            this.totalRouteLabel.TabIndex = 9;
            this.totalRouteLabel.Text = "TOTAL_ROUTE";
            // 
            // remainingTimeLabel
            // 
            this.remainingTimeLabel.AutoSize = true;
            this.remainingTimeLabel.Depth = 0;
            this.remainingTimeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.remainingTimeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.remainingTimeLabel.Location = new System.Drawing.Point(3, 95);
            this.remainingTimeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.remainingTimeLabel.Name = "remainingTimeLabel";
            this.remainingTimeLabel.Size = new System.Drawing.Size(132, 19);
            this.remainingTimeLabel.TabIndex = 8;
            this.remainingTimeLabel.Text = "REMAINING_TIME";
            // 
            // weightLabel
            // 
            this.weightLabel.AutoSize = true;
            this.weightLabel.Depth = 0;
            this.weightLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.weightLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.weightLabel.Location = new System.Drawing.Point(3, 133);
            this.weightLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.weightLabel.Name = "weightLabel";
            this.weightLabel.Size = new System.Drawing.Size(65, 19);
            this.weightLabel.TabIndex = 7;
            this.weightLabel.Text = "WEIGHT";
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.Depth = 0;
            this.deadlineLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.deadlineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deadlineLabel.Location = new System.Drawing.Point(3, 152);
            this.deadlineLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.deadlineLabel.Name = "deadlineLabel";
            this.deadlineLabel.Size = new System.Drawing.Size(80, 19);
            this.deadlineLabel.TabIndex = 6;
            this.deadlineLabel.Text = "DEADLINE";
            // 
            // yieldLabel
            // 
            this.yieldLabel.AutoSize = true;
            this.yieldLabel.Depth = 0;
            this.yieldLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.yieldLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yieldLabel.Location = new System.Drawing.Point(3, 114);
            this.yieldLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.yieldLabel.Name = "yieldLabel";
            this.yieldLabel.Size = new System.Drawing.Size(49, 19);
            this.yieldLabel.TabIndex = 5;
            this.yieldLabel.Text = "YIELD";
            // 
            // routeLabel
            // 
            this.routeLabel.AutoSize = true;
            this.routeLabel.Depth = 0;
            this.routeLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.routeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.routeLabel.Location = new System.Drawing.Point(3, 76);
            this.routeLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.routeLabel.Name = "routeLabel";
            this.routeLabel.Size = new System.Drawing.Size(56, 19);
            this.routeLabel.TabIndex = 4;
            this.routeLabel.Text = "ROUTE";
            // 
            // destinationLabel
            // 
            this.destinationLabel.AutoSize = true;
            this.destinationLabel.Depth = 0;
            this.destinationLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.destinationLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.destinationLabel.Location = new System.Drawing.Point(3, 57);
            this.destinationLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.destinationLabel.Name = "destinationLabel";
            this.destinationLabel.Size = new System.Drawing.Size(105, 19);
            this.destinationLabel.TabIndex = 3;
            this.destinationLabel.Text = "DESTINATION";
            // 
            // sourceLabel
            // 
            this.sourceLabel.AutoSize = true;
            this.sourceLabel.Depth = 0;
            this.sourceLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.sourceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sourceLabel.Location = new System.Drawing.Point(3, 38);
            this.sourceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.sourceLabel.Name = "sourceLabel";
            this.sourceLabel.Size = new System.Drawing.Size(66, 19);
            this.sourceLabel.TabIndex = 2;
            this.sourceLabel.Text = "SOURCE";
            // 
            // cargoLabel
            // 
            this.cargoLabel.AutoSize = true;
            this.cargoLabel.Depth = 0;
            this.cargoLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.cargoLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cargoLabel.Location = new System.Drawing.Point(3, 19);
            this.cargoLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.cargoLabel.Name = "cargoLabel";
            this.cargoLabel.Size = new System.Drawing.Size(58, 19);
            this.cargoLabel.TabIndex = 1;
            this.cargoLabel.Text = "CARGO";
            // 
            // vehicleLabel
            // 
            this.vehicleLabel.AutoSize = true;
            this.vehicleLabel.Depth = 0;
            this.vehicleLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.vehicleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.vehicleLabel.Location = new System.Drawing.Point(3, 0);
            this.vehicleLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.vehicleLabel.Name = "vehicleLabel";
            this.vehicleLabel.Size = new System.Drawing.Size(70, 19);
            this.vehicleLabel.TabIndex = 0;
            this.vehicleLabel.Text = "VEHICLE";
            // 
            // healthPanel
            // 
            this.healthPanel.Controls.Add(this.fuelGaugePanel);
            this.healthPanel.Controls.Add(this.averageLabel);
            this.healthPanel.Controls.Add(this.drivetrainPanel);
            this.healthPanel.Controls.Add(this.fuelRemainingDistanceLabel);
            this.healthPanel.Controls.Add(this.fuelLabel);
            this.healthPanel.Controls.Add(this.fuelStatusLabel);
            this.healthPanel.Controls.Add(this.trailerLabel);
            this.healthPanel.Controls.Add(this.wheelsLabel);
            this.healthPanel.Controls.Add(this.transmissionLabel);
            this.healthPanel.Controls.Add(this.engineLabel);
            this.healthPanel.Controls.Add(this.chassisLabel);
            this.healthPanel.Controls.Add(this.cabinLabel);
            this.healthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.healthPanel.Location = new System.Drawing.Point(486, 79);
            this.healthPanel.Name = "healthPanel";
            this.healthPanel.Size = new System.Drawing.Size(394, 412);
            this.healthPanel.TabIndex = 5;
            this.healthPanel.Visible = false;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Depth = 0;
            this.averageLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.averageLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.averageLabel.Location = new System.Drawing.Point(3, 200);
            this.averageLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(76, 19);
            this.averageLabel.TabIndex = 11;
            this.averageLabel.Text = "AVERAGE";
            // 
            // fuelRemainingDistanceLabel
            // 
            this.fuelRemainingDistanceLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fuelRemainingDistanceLabel.AutoSize = true;
            this.fuelRemainingDistanceLabel.Depth = 0;
            this.fuelRemainingDistanceLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fuelRemainingDistanceLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fuelRemainingDistanceLabel.Location = new System.Drawing.Point(3, 371);
            this.fuelRemainingDistanceLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fuelRemainingDistanceLabel.Name = "fuelRemainingDistanceLabel";
            this.fuelRemainingDistanceLabel.Size = new System.Drawing.Size(211, 19);
            this.fuelRemainingDistanceLabel.TabIndex = 10;
            this.fuelRemainingDistanceLabel.Text = "FUEL_REMAINING_DISTANCE";
            // 
            // fuelLabel
            // 
            this.fuelLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fuelLabel.AutoSize = true;
            this.fuelLabel.Depth = 0;
            this.fuelLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fuelLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fuelLabel.Location = new System.Drawing.Point(3, 352);
            this.fuelLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fuelLabel.Name = "fuelLabel";
            this.fuelLabel.Size = new System.Drawing.Size(44, 19);
            this.fuelLabel.TabIndex = 9;
            this.fuelLabel.Text = "FUEL";
            // 
            // fuelStatusLabel
            // 
            this.fuelStatusLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.fuelStatusLabel.AutoSize = true;
            this.fuelStatusLabel.Depth = 0;
            this.fuelStatusLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.fuelStatusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fuelStatusLabel.Location = new System.Drawing.Point(3, 390);
            this.fuelStatusLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.fuelStatusLabel.Name = "fuelStatusLabel";
            this.fuelStatusLabel.Size = new System.Drawing.Size(107, 19);
            this.fuelStatusLabel.TabIndex = 8;
            this.fuelStatusLabel.Text = "FUEL_STATUS";
            // 
            // trailerLabel
            // 
            this.trailerLabel.AutoSize = true;
            this.trailerLabel.Depth = 0;
            this.trailerLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.trailerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trailerLabel.Location = new System.Drawing.Point(150, 200);
            this.trailerLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.trailerLabel.Name = "trailerLabel";
            this.trailerLabel.Size = new System.Drawing.Size(67, 19);
            this.trailerLabel.TabIndex = 7;
            this.trailerLabel.Text = "TRAILER";
            // 
            // wheelsLabel
            // 
            this.wheelsLabel.AutoSize = true;
            this.wheelsLabel.Depth = 0;
            this.wheelsLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.wheelsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.wheelsLabel.Location = new System.Drawing.Point(3, 79);
            this.wheelsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.wheelsLabel.Name = "wheelsLabel";
            this.wheelsLabel.Size = new System.Drawing.Size(68, 19);
            this.wheelsLabel.TabIndex = 6;
            this.wheelsLabel.Text = "WHEELS";
            // 
            // transmissionLabel
            // 
            this.transmissionLabel.AutoSize = true;
            this.transmissionLabel.Depth = 0;
            this.transmissionLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.transmissionLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.transmissionLabel.Location = new System.Drawing.Point(3, 60);
            this.transmissionLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.transmissionLabel.Name = "transmissionLabel";
            this.transmissionLabel.Size = new System.Drawing.Size(117, 19);
            this.transmissionLabel.TabIndex = 5;
            this.transmissionLabel.Text = "TRANSMISSION";
            // 
            // engineLabel
            // 
            this.engineLabel.AutoSize = true;
            this.engineLabel.Depth = 0;
            this.engineLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.engineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.engineLabel.Location = new System.Drawing.Point(3, 41);
            this.engineLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.engineLabel.Name = "engineLabel";
            this.engineLabel.Size = new System.Drawing.Size(63, 19);
            this.engineLabel.TabIndex = 4;
            this.engineLabel.Text = "ENGINE";
            // 
            // chassisLabel
            // 
            this.chassisLabel.AutoSize = true;
            this.chassisLabel.Depth = 0;
            this.chassisLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.chassisLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.chassisLabel.Location = new System.Drawing.Point(3, 22);
            this.chassisLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.chassisLabel.Name = "chassisLabel";
            this.chassisLabel.Size = new System.Drawing.Size(71, 19);
            this.chassisLabel.TabIndex = 3;
            this.chassisLabel.Text = "CHASSIS";
            // 
            // cabinLabel
            // 
            this.cabinLabel.AutoSize = true;
            this.cabinLabel.Depth = 0;
            this.cabinLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.cabinLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cabinLabel.Location = new System.Drawing.Point(3, 3);
            this.cabinLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.cabinLabel.Name = "cabinLabel";
            this.cabinLabel.Size = new System.Drawing.Size(53, 19);
            this.cabinLabel.TabIndex = 2;
            this.cabinLabel.Text = "CABIN";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.logOutButton);
            this.flowLayoutPanel1.Controls.Add(this.switchLengthUnitButton);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(486, 3);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(394, 70);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.AutoSize = true;
            this.logOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logOutButton.Depth = 0;
            this.logOutButton.Icon = null;
            this.logOutButton.Location = new System.Drawing.Point(286, 3);
            this.logOutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Primary = true;
            this.logOutButton.Size = new System.Drawing.Size(105, 36);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "{$LOG_OUT$}";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // switchLengthUnitButton
            // 
            this.switchLengthUnitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.switchLengthUnitButton.AutoSize = true;
            this.switchLengthUnitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.switchLengthUnitButton.Depth = 0;
            this.switchLengthUnitButton.Icon = null;
            this.switchLengthUnitButton.Location = new System.Drawing.Point(86, 6);
            this.switchLengthUnitButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.switchLengthUnitButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.switchLengthUnitButton.Name = "switchLengthUnitButton";
            this.switchLengthUnitButton.Primary = false;
            this.switchLengthUnitButton.Size = new System.Drawing.Size(193, 36);
            this.switchLengthUnitButton.TabIndex = 5;
            this.switchLengthUnitButton.Text = "{$SWITCH_LENGTH_UNIT$}";
            this.switchLengthUnitButton.UseVisualStyleBackColor = true;
            this.switchLengthUnitButton.Click += new System.EventHandler(this.switchLengthUnitButton_Click);
            // 
            // speedChart
            // 
            this.speedChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.speedChart.BorderlineColor = System.Drawing.Color.Black;
            chartArea1.AxisX.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisX.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisX.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisX2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisX2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LabelStyle.ForeColor = System.Drawing.Color.White;
            chartArea1.AxisY.LineColor = System.Drawing.Color.Gray;
            chartArea1.AxisY.MajorGrid.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.MajorTickMark.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY.TitleForeColor = System.Drawing.Color.White;
            chartArea1.AxisY2.LineColor = System.Drawing.Color.DimGray;
            chartArea1.AxisY2.TitleForeColor = System.Drawing.Color.White;
            chartArea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            chartArea1.Name = "ChartArea";
            this.speedChart.ChartAreas.Add(chartArea1);
            this.speedChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            legend1.ForeColor = System.Drawing.Color.White;
            legend1.Name = "Legend";
            legend1.Title = "SPEED";
            legend1.TitleForeColor = System.Drawing.Color.White;
            this.speedChart.Legends.Add(legend1);
            this.speedChart.Location = new System.Drawing.Point(3, 503);
            this.speedChart.Name = "speedChart";
            this.speedChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            this.speedChart.PaletteCustomColors = new System.Drawing.Color[] {
        System.Drawing.Color.DeepSkyBlue,
        System.Drawing.Color.DarkRed};
            series1.BorderWidth = 5;
            series1.ChartArea = "ChartArea";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series1.Legend = "Legend";
            series1.Name = "CURRENT";
            series2.BorderWidth = 5;
            series2.ChartArea = "ChartArea";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.FastLine;
            series2.Legend = "Legend";
            series2.Name = "LIMIT";
            this.speedChart.Series.Add(series1);
            this.speedChart.Series.Add(series2);
            this.speedChart.Size = new System.Drawing.Size(883, 114);
            this.speedChart.TabIndex = 2;
            this.speedChart.Visible = false;
            // 
            // groupPictureBox
            // 
            this.groupPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupPictureBox.Image = global::TruckingVSConnect2.Properties.Resources.GroupIcon;
            this.groupPictureBox.Location = new System.Drawing.Point(337, 3);
            this.groupPictureBox.Name = "groupPictureBox";
            this.groupPictureBox.Size = new System.Drawing.Size(64, 64);
            this.groupPictureBox.TabIndex = 5;
            this.groupPictureBox.TabStop = false;
            this.groupPictureBox.Click += new System.EventHandler(this.groupPictureBox_Click);
            this.groupPictureBox.MouseEnter += new System.EventHandler(this.genericPictureBox_MouseEnter);
            this.groupPictureBox.MouseLeave += new System.EventHandler(this.genericPictureBox_MouseLeave);
            // 
            // liveMapPictureBox
            // 
            this.liveMapPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.liveMapPictureBox.Image = global::TruckingVSConnect2.Properties.Resources.MapIcon;
            this.liveMapPictureBox.Location = new System.Drawing.Point(407, 3);
            this.liveMapPictureBox.Name = "liveMapPictureBox";
            this.liveMapPictureBox.Size = new System.Drawing.Size(64, 64);
            this.liveMapPictureBox.TabIndex = 4;
            this.liveMapPictureBox.TabStop = false;
            this.liveMapPictureBox.Click += new System.EventHandler(this.liveMapPictureBox_Click);
            this.liveMapPictureBox.MouseEnter += new System.EventHandler(this.genericPictureBox_MouseEnter);
            this.liveMapPictureBox.MouseLeave += new System.EventHandler(this.genericPictureBox_MouseLeave);
            // 
            // gravatarPictureBox
            // 
            this.gravatarPictureBox.Location = new System.Drawing.Point(3, 3);
            this.gravatarPictureBox.Name = "gravatarPictureBox";
            this.gravatarPictureBox.Size = new System.Drawing.Size(64, 64);
            this.gravatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gravatarPictureBox.TabIndex = 0;
            this.gravatarPictureBox.TabStop = false;
            // 
            // fuelGaugePanel
            // 
            this.fuelGaugePanel.BackgroundImage = global::TruckingVSConnect2.Properties.Resources.FuelGauge;
            this.fuelGaugePanel.Controls.Add(this.fuelGaugeNeedlePictureBox);
            this.fuelGaugePanel.Location = new System.Drawing.Point(7, 295);
            this.fuelGaugePanel.Name = "fuelGaugePanel";
            this.fuelGaugePanel.Size = new System.Drawing.Size(129, 54);
            this.fuelGaugePanel.TabIndex = 13;
            // 
            // fuelGaugeNeedlePictureBox
            // 
            this.fuelGaugeNeedlePictureBox.Image = global::TruckingVSConnect2.Properties.Resources.FuelGaugeNeedle;
            this.fuelGaugeNeedlePictureBox.Location = new System.Drawing.Point(7, 16);
            this.fuelGaugeNeedlePictureBox.Name = "fuelGaugeNeedlePictureBox";
            this.fuelGaugeNeedlePictureBox.Size = new System.Drawing.Size(5, 23);
            this.fuelGaugeNeedlePictureBox.TabIndex = 0;
            this.fuelGaugeNeedlePictureBox.TabStop = false;
            // 
            // drivetrainPanel
            // 
            this.drivetrainPanel.BackgroundImage = global::TruckingVSConnect2.Properties.Resources.Drivetrain;
            this.drivetrainPanel.Controls.Add(this.cargoPictureBox);
            this.drivetrainPanel.Location = new System.Drawing.Point(7, 101);
            this.drivetrainPanel.Name = "drivetrainPanel";
            this.drivetrainPanel.Size = new System.Drawing.Size(352, 96);
            this.drivetrainPanel.TabIndex = 12;
            // 
            // cargoPictureBox
            // 
            this.cargoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cargoPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.cargoPictureBox.Image = global::TruckingVSConnect2.Properties.Resources.NoCargo;
            this.cargoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.cargoPictureBox.Name = "cargoPictureBox";
            this.cargoPictureBox.Size = new System.Drawing.Size(352, 96);
            this.cargoPictureBox.TabIndex = 1;
            this.cargoPictureBox.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(913, 696);
            this.Controls.Add(this.mainTableLayoutPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.Text = "{$TRUCKING_VS_CONNECT_2$}";
            this.Activated += new System.EventHandler(this.MainForm_Activated);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainForm_FormClosed);
            this.mainTableLayoutPanel.ResumeLayout(false);
            this.bodyTableLayoutPanel.ResumeLayout(false);
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            this.dataTableLayoutPanel.ResumeLayout(false);
            this.speedPanel.ResumeLayout(false);
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.healthPanel.ResumeLayout(false);
            this.healthPanel.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveMapPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gravatarPictureBox)).EndInit();
            this.fuelGaugePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.fuelGaugeNeedlePictureBox)).EndInit();
            this.drivetrainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.cargoPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer updateTimer;
        private System.Windows.Forms.TableLayoutPanel mainTableLayoutPanel;
        private System.Windows.Forms.TableLayoutPanel bodyTableLayoutPanel;
        private MaterialSkin.Controls.MaterialRaisedButton logOutButton;
        private System.Windows.Forms.Panel headPanel;
        private MaterialSkin.Controls.MaterialLabel loggedInAsLabel;
        private MaterialSkin.Controls.MaterialLabel loggedInAsTitleLabel;
        private System.Windows.Forms.PictureBox gravatarPictureBox;
        private System.Windows.Forms.TableLayoutPanel dataTableLayoutPanel;
        private System.Windows.Forms.Panel speedPanel;
        private MaterialSkin.Controls.MaterialFlatButton switchLengthUnitButton;
        private MaterialSkin.Controls.MaterialLabel statusLabel;
        private MaterialSkin.Controls.MaterialLabel speedLabel;
        private MaterialSkin.Controls.MaterialLabel speedLimitLabel;
        private System.Windows.Forms.Panel dataPanel;
        private MaterialSkin.Controls.MaterialLabel vehicleLabel;
        private MaterialSkin.Controls.MaterialLabel deadlineLabel;
        private MaterialSkin.Controls.MaterialLabel yieldLabel;
        private MaterialSkin.Controls.MaterialLabel routeLabel;
        private MaterialSkin.Controls.MaterialLabel destinationLabel;
        private MaterialSkin.Controls.MaterialLabel sourceLabel;
        private MaterialSkin.Controls.MaterialLabel cargoLabel;
        private System.Windows.Forms.Panel healthPanel;
        private System.Windows.Forms.PictureBox cargoPictureBox;
        private MaterialSkin.Controls.MaterialLabel cabinLabel;
        private MaterialSkin.Controls.MaterialLabel chassisLabel;
        private MaterialSkin.Controls.MaterialLabel engineLabel;
        private MaterialSkin.Controls.MaterialLabel transmissionLabel;
        private MaterialSkin.Controls.MaterialLabel wheelsLabel;
        private MaterialSkin.Controls.MaterialLabel trailerLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart speedChart;
        private MaterialSkin.Controls.MaterialLabel fuelLabel;
        private MaterialSkin.Controls.MaterialLabel fuelStatusLabel;
        private MaterialSkin.Controls.MaterialLabel gameNameLabel;
        private MaterialSkin.Controls.MaterialLabel fuelRemainingDistanceLabel;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MaterialSkin.Controls.MaterialLabel weightLabel;
        private MaterialSkin.Controls.MaterialLabel remainingTimeLabel;
        private MaterialSkin.Controls.MaterialLabel averageLabel;
        private System.Windows.Forms.Panel drivetrainPanel;
        private System.Windows.Forms.Panel fuelGaugePanel;
        private System.Windows.Forms.PictureBox fuelGaugeNeedlePictureBox;
        private MaterialSkin.Controls.MaterialLabel totalYieldLabel;
        private MaterialSkin.Controls.MaterialLabel totalWeightLabel;
        private MaterialSkin.Controls.MaterialLabel totalRouteLabel;
        private System.Windows.Forms.PictureBox liveMapPictureBox;
        private System.Windows.Forms.PictureBox groupPictureBox;
    }
}

