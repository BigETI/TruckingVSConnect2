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
            this.logOutButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.headPanel = new System.Windows.Forms.Panel();
            this.loggedInAsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.loggedInAsTitleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.gravatarPictureBox = new System.Windows.Forms.PictureBox();
            this.dataTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.speedPanel = new System.Windows.Forms.Panel();
            this.switchLengthUnitButton = new MaterialSkin.Controls.MaterialFlatButton();
            this.statusLabel = new MaterialSkin.Controls.MaterialLabel();
            this.speedLabel = new MaterialSkin.Controls.MaterialLabel();
            this.speedLimitLabel = new MaterialSkin.Controls.MaterialLabel();
            this.dataPanel = new System.Windows.Forms.Panel();
            this.deadlineLabel = new MaterialSkin.Controls.MaterialLabel();
            this.yieldLabel = new MaterialSkin.Controls.MaterialLabel();
            this.routeLabel = new MaterialSkin.Controls.MaterialLabel();
            this.destinationLabel = new MaterialSkin.Controls.MaterialLabel();
            this.sourceLabel = new MaterialSkin.Controls.MaterialLabel();
            this.cargoLabel = new MaterialSkin.Controls.MaterialLabel();
            this.vehicleLabel = new MaterialSkin.Controls.MaterialLabel();
            this.healthPanel = new System.Windows.Forms.Panel();
            this.trailerLabel = new MaterialSkin.Controls.MaterialLabel();
            this.wheelsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.transmissionLabel = new MaterialSkin.Controls.MaterialLabel();
            this.engineLabel = new MaterialSkin.Controls.MaterialLabel();
            this.chassisLabel = new MaterialSkin.Controls.MaterialLabel();
            this.cabinLabel = new MaterialSkin.Controls.MaterialLabel();
            this.cargoPictureBox = new System.Windows.Forms.PictureBox();
            this.drivetrainPictureBox = new System.Windows.Forms.PictureBox();
            this.speedChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.drivetrainImageList = new System.Windows.Forms.ImageList(this.components);
            this.cargoImageList = new System.Windows.Forms.ImageList(this.components);
            this.mainTableLayoutPanel.SuspendLayout();
            this.bodyTableLayoutPanel.SuspendLayout();
            this.headPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gravatarPictureBox)).BeginInit();
            this.dataTableLayoutPanel.SuspendLayout();
            this.speedPanel.SuspendLayout();
            this.dataPanel.SuspendLayout();
            this.healthPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.drivetrainPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).BeginInit();
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
            this.bodyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 62.55981F));
            this.bodyTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 37.44019F));
            this.bodyTableLayoutPanel.Controls.Add(this.logOutButton, 1, 0);
            this.bodyTableLayoutPanel.Controls.Add(this.headPanel, 0, 0);
            this.bodyTableLayoutPanel.Controls.Add(this.dataTableLayoutPanel, 0, 1);
            this.bodyTableLayoutPanel.Controls.Add(this.healthPanel, 1, 1);
            this.bodyTableLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyTableLayoutPanel.Location = new System.Drawing.Point(3, 3);
            this.bodyTableLayoutPanel.Name = "bodyTableLayoutPanel";
            this.bodyTableLayoutPanel.RowCount = 2;
            this.bodyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 76F));
            this.bodyTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.bodyTableLayoutPanel.Size = new System.Drawing.Size(883, 494);
            this.bodyTableLayoutPanel.TabIndex = 1;
            // 
            // logOutButton
            // 
            this.logOutButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.logOutButton.AutoSize = true;
            this.logOutButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logOutButton.Depth = 0;
            this.logOutButton.Icon = null;
            this.logOutButton.Location = new System.Drawing.Point(775, 3);
            this.logOutButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logOutButton.Name = "logOutButton";
            this.logOutButton.Primary = true;
            this.logOutButton.Size = new System.Drawing.Size(105, 36);
            this.logOutButton.TabIndex = 3;
            this.logOutButton.Text = "{$LOG_OUT$}";
            this.logOutButton.UseVisualStyleBackColor = true;
            this.logOutButton.Click += new System.EventHandler(this.logOutButton_Click);
            // 
            // headPanel
            // 
            this.headPanel.Controls.Add(this.loggedInAsLabel);
            this.headPanel.Controls.Add(this.loggedInAsTitleLabel);
            this.headPanel.Controls.Add(this.gravatarPictureBox);
            this.headPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.headPanel.Location = new System.Drawing.Point(3, 3);
            this.headPanel.Name = "headPanel";
            this.headPanel.Size = new System.Drawing.Size(546, 70);
            this.headPanel.TabIndex = 1;
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
            // gravatarPictureBox
            // 
            this.gravatarPictureBox.Location = new System.Drawing.Point(3, 3);
            this.gravatarPictureBox.Name = "gravatarPictureBox";
            this.gravatarPictureBox.Size = new System.Drawing.Size(64, 64);
            this.gravatarPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.gravatarPictureBox.TabIndex = 0;
            this.gravatarPictureBox.TabStop = false;
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
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 144F));
            this.dataTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.dataTableLayoutPanel.Size = new System.Drawing.Size(546, 412);
            this.dataTableLayoutPanel.TabIndex = 4;
            // 
            // speedPanel
            // 
            this.speedPanel.Controls.Add(this.switchLengthUnitButton);
            this.speedPanel.Controls.Add(this.statusLabel);
            this.speedPanel.Controls.Add(this.speedLabel);
            this.speedPanel.Controls.Add(this.speedLimitLabel);
            this.speedPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.speedPanel.Location = new System.Drawing.Point(3, 3);
            this.speedPanel.Name = "speedPanel";
            this.speedPanel.Size = new System.Drawing.Size(540, 138);
            this.speedPanel.TabIndex = 2;
            this.speedPanel.Visible = false;
            // 
            // switchLengthUnitButton
            // 
            this.switchLengthUnitButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.switchLengthUnitButton.AutoSize = true;
            this.switchLengthUnitButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.switchLengthUnitButton.Depth = 0;
            this.switchLengthUnitButton.Icon = null;
            this.switchLengthUnitButton.Location = new System.Drawing.Point(4, 96);
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
            this.statusLabel.Size = new System.Drawing.Size(534, 24);
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
            this.speedLabel.Size = new System.Drawing.Size(534, 39);
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
            this.speedLimitLabel.Size = new System.Drawing.Size(534, 24);
            this.speedLimitLabel.TabIndex = 3;
            this.speedLimitLabel.Text = "SPEED_LIMIT";
            this.speedLimitLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataPanel
            // 
            this.dataPanel.Controls.Add(this.deadlineLabel);
            this.dataPanel.Controls.Add(this.yieldLabel);
            this.dataPanel.Controls.Add(this.routeLabel);
            this.dataPanel.Controls.Add(this.destinationLabel);
            this.dataPanel.Controls.Add(this.sourceLabel);
            this.dataPanel.Controls.Add(this.cargoLabel);
            this.dataPanel.Controls.Add(this.vehicleLabel);
            this.dataPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataPanel.Location = new System.Drawing.Point(3, 147);
            this.dataPanel.Name = "dataPanel";
            this.dataPanel.Size = new System.Drawing.Size(540, 262);
            this.dataPanel.TabIndex = 3;
            this.dataPanel.Visible = false;
            // 
            // deadlineLabel
            // 
            this.deadlineLabel.AutoSize = true;
            this.deadlineLabel.Depth = 0;
            this.deadlineLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.deadlineLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.deadlineLabel.Location = new System.Drawing.Point(3, 114);
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
            this.yieldLabel.Location = new System.Drawing.Point(3, 95);
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
            this.healthPanel.Controls.Add(this.trailerLabel);
            this.healthPanel.Controls.Add(this.wheelsLabel);
            this.healthPanel.Controls.Add(this.transmissionLabel);
            this.healthPanel.Controls.Add(this.engineLabel);
            this.healthPanel.Controls.Add(this.chassisLabel);
            this.healthPanel.Controls.Add(this.cabinLabel);
            this.healthPanel.Controls.Add(this.cargoPictureBox);
            this.healthPanel.Controls.Add(this.drivetrainPictureBox);
            this.healthPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.healthPanel.Location = new System.Drawing.Point(555, 79);
            this.healthPanel.Name = "healthPanel";
            this.healthPanel.Size = new System.Drawing.Size(325, 412);
            this.healthPanel.TabIndex = 5;
            this.healthPanel.Visible = false;
            // 
            // trailerLabel
            // 
            this.trailerLabel.AutoSize = true;
            this.trailerLabel.Depth = 0;
            this.trailerLabel.Font = new System.Drawing.Font("Roboto", 11F);
            this.trailerLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.trailerLabel.Location = new System.Drawing.Point(3, 99);
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
            // cargoPictureBox
            // 
            this.cargoPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.cargoPictureBox.Image = global::TruckingVSConnect2.Properties.Resources.NoCargo;
            this.cargoPictureBox.Location = new System.Drawing.Point(226, 64);
            this.cargoPictureBox.Name = "cargoPictureBox";
            this.cargoPictureBox.Size = new System.Drawing.Size(96, 256);
            this.cargoPictureBox.TabIndex = 1;
            this.cargoPictureBox.TabStop = false;
            // 
            // drivetrainPictureBox
            // 
            this.drivetrainPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.drivetrainPictureBox.Image = global::TruckingVSConnect2.Properties.Resources.Drivetrain;
            this.drivetrainPictureBox.Location = new System.Drawing.Point(226, 3);
            this.drivetrainPictureBox.Name = "drivetrainPictureBox";
            this.drivetrainPictureBox.Size = new System.Drawing.Size(96, 64);
            this.drivetrainPictureBox.TabIndex = 0;
            this.drivetrainPictureBox.TabStop = false;
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
            // drivetrainImageList
            // 
            this.drivetrainImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("drivetrainImageList.ImageStream")));
            this.drivetrainImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.drivetrainImageList.Images.SetKeyName(0, "Drivetrain.png");
            this.drivetrainImageList.Images.SetKeyName(1, "DrivetrainSlightlyDamaged.png");
            this.drivetrainImageList.Images.SetKeyName(2, "DrivetrainDamaged.png");
            this.drivetrainImageList.Images.SetKeyName(3, "DrivetrainHeavilyDamaged.png");
            this.drivetrainImageList.Images.SetKeyName(4, "DrivetrainFullyDamaged.png");
            // 
            // cargoImageList
            // 
            this.cargoImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("cargoImageList.ImageStream")));
            this.cargoImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.cargoImageList.Images.SetKeyName(0, "NoCargo.png");
            this.cargoImageList.Images.SetKeyName(1, "Cargo.png");
            this.cargoImageList.Images.SetKeyName(2, "CargoSlightlyDamaged.png");
            this.cargoImageList.Images.SetKeyName(3, "CargoDamaged.png");
            this.cargoImageList.Images.SetKeyName(4, "CargoHeavilyDamaged.png");
            this.cargoImageList.Images.SetKeyName(5, "CargoFullyDamaged.png");
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
            this.bodyTableLayoutPanel.PerformLayout();
            this.headPanel.ResumeLayout(false);
            this.headPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gravatarPictureBox)).EndInit();
            this.dataTableLayoutPanel.ResumeLayout(false);
            this.speedPanel.ResumeLayout(false);
            this.speedPanel.PerformLayout();
            this.dataPanel.ResumeLayout(false);
            this.dataPanel.PerformLayout();
            this.healthPanel.ResumeLayout(false);
            this.healthPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.cargoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.drivetrainPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.speedChart)).EndInit();
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
        private System.Windows.Forms.PictureBox drivetrainPictureBox;
        private System.Windows.Forms.ImageList drivetrainImageList;
        private System.Windows.Forms.ImageList cargoImageList;
        private MaterialSkin.Controls.MaterialLabel cabinLabel;
        private MaterialSkin.Controls.MaterialLabel chassisLabel;
        private MaterialSkin.Controls.MaterialLabel engineLabel;
        private MaterialSkin.Controls.MaterialLabel transmissionLabel;
        private MaterialSkin.Controls.MaterialLabel wheelsLabel;
        private MaterialSkin.Controls.MaterialLabel trailerLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart speedChart;
    }
}

