namespace TruckingVSConnect2
{
    partial class GroupForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.usersGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.truckDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cargoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.sourceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.destinationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.distanceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.remainingTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.incomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.massDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersDataSet = new System.Data.DataSet();
            this.usersDataTable = new System.Data.DataTable();
            this.nameUserDataColumn = new System.Data.DataColumn();
            this.speedUserDataColumn = new System.Data.DataColumn();
            this.speedLimitUserDataColumn = new System.Data.DataColumn();
            this.truckUserDataColumn = new System.Data.DataColumn();
            this.cargoUserDataColumn = new System.Data.DataColumn();
            this.sourceUserDataColumn = new System.Data.DataColumn();
            this.destinationUserDataColumn = new System.Data.DataColumn();
            this.distanceUserDataColumn = new System.Data.DataColumn();
            this.remainingTimeUserDataColumn = new System.Data.DataColumn();
            this.incomeUserDataColumn = new System.Data.DataColumn();
            this.massUserDataColumn = new System.Data.DataColumn();
            this.topLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.addUserPictureBox = new System.Windows.Forms.PictureBox();
            this.liveMapPictureBox = new System.Windows.Forms.PictureBox();
            this.threadTimer = new System.Windows.Forms.Timer(this.components);
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataTable)).BeginInit();
            this.topLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addUserPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveMapPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mainPanel.Controls.Add(this.usersGridView);
            this.mainPanel.Controls.Add(this.topLayoutPanel);
            this.mainPanel.Location = new System.Drawing.Point(12, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(867, 433);
            this.mainPanel.TabIndex = 0;
            // 
            // usersGridView
            // 
            this.usersGridView.AllowUserToAddRows = false;
            this.usersGridView.AllowUserToDeleteRows = false;
            this.usersGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.usersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.usersGridView.AutoGenerateColumns = false;
            this.usersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.usersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.usersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.usersGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.usersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.usersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.usersGridView.ColumnHeadersHeight = 32;
            this.usersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.usersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn,
            this.speedDataGridViewTextBoxColumn,
            this.speedLimitDataGridViewTextBoxColumn,
            this.truckDataGridViewTextBoxColumn,
            this.cargoDataGridViewTextBoxColumn,
            this.sourceDataGridViewTextBoxColumn,
            this.destinationDataGridViewTextBoxColumn,
            this.distanceDataGridViewTextBoxColumn,
            this.remainingTimeDataGridViewTextBoxColumn,
            this.incomeDataGridViewTextBoxColumn,
            this.massDataGridViewTextBoxColumn});
            this.usersGridView.DataSource = this.usersBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.usersGridView.DefaultCellStyle = dataGridViewCellStyle6;
            this.usersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.usersGridView.EnableHeadersVisualStyles = false;
            this.usersGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.usersGridView.Location = new System.Drawing.Point(0, 70);
            this.usersGridView.MultiSelect = false;
            this.usersGridView.Name = "usersGridView";
            this.usersGridView.ReadOnly = true;
            this.usersGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.usersGridView.RowHeadersVisible = false;
            this.usersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.usersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.usersGridView.Size = new System.Drawing.Size(867, 363);
            this.usersGridView.TabIndex = 1;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            this.speedDataGridViewTextBoxColumn.HeaderText = "Speed";
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            this.speedDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // speedLimitDataGridViewTextBoxColumn
            // 
            this.speedLimitDataGridViewTextBoxColumn.DataPropertyName = "Speed limit";
            this.speedLimitDataGridViewTextBoxColumn.HeaderText = "Speed limit";
            this.speedLimitDataGridViewTextBoxColumn.Name = "speedLimitDataGridViewTextBoxColumn";
            this.speedLimitDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // truckDataGridViewTextBoxColumn
            // 
            this.truckDataGridViewTextBoxColumn.DataPropertyName = "Truck";
            this.truckDataGridViewTextBoxColumn.HeaderText = "Truck";
            this.truckDataGridViewTextBoxColumn.Name = "truckDataGridViewTextBoxColumn";
            this.truckDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cargoDataGridViewTextBoxColumn
            // 
            this.cargoDataGridViewTextBoxColumn.DataPropertyName = "Cargo";
            this.cargoDataGridViewTextBoxColumn.HeaderText = "Cargo";
            this.cargoDataGridViewTextBoxColumn.Name = "cargoDataGridViewTextBoxColumn";
            this.cargoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // sourceDataGridViewTextBoxColumn
            // 
            this.sourceDataGridViewTextBoxColumn.DataPropertyName = "Source";
            this.sourceDataGridViewTextBoxColumn.HeaderText = "Source";
            this.sourceDataGridViewTextBoxColumn.Name = "sourceDataGridViewTextBoxColumn";
            this.sourceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // destinationDataGridViewTextBoxColumn
            // 
            this.destinationDataGridViewTextBoxColumn.DataPropertyName = "Destination";
            this.destinationDataGridViewTextBoxColumn.HeaderText = "Destination";
            this.destinationDataGridViewTextBoxColumn.Name = "destinationDataGridViewTextBoxColumn";
            this.destinationDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // distanceDataGridViewTextBoxColumn
            // 
            this.distanceDataGridViewTextBoxColumn.DataPropertyName = "Distance";
            this.distanceDataGridViewTextBoxColumn.HeaderText = "Distance";
            this.distanceDataGridViewTextBoxColumn.Name = "distanceDataGridViewTextBoxColumn";
            this.distanceDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // remainingTimeDataGridViewTextBoxColumn
            // 
            this.remainingTimeDataGridViewTextBoxColumn.DataPropertyName = "Remaining time";
            this.remainingTimeDataGridViewTextBoxColumn.HeaderText = "Remaining time";
            this.remainingTimeDataGridViewTextBoxColumn.Name = "remainingTimeDataGridViewTextBoxColumn";
            this.remainingTimeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // incomeDataGridViewTextBoxColumn
            // 
            this.incomeDataGridViewTextBoxColumn.DataPropertyName = "Income";
            this.incomeDataGridViewTextBoxColumn.HeaderText = "Income";
            this.incomeDataGridViewTextBoxColumn.Name = "incomeDataGridViewTextBoxColumn";
            this.incomeDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // massDataGridViewTextBoxColumn
            // 
            this.massDataGridViewTextBoxColumn.DataPropertyName = "Mass";
            this.massDataGridViewTextBoxColumn.HeaderText = "Mass";
            this.massDataGridViewTextBoxColumn.Name = "massDataGridViewTextBoxColumn";
            this.massDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "Users";
            this.usersBindingSource.DataSource = this.usersDataSet;
            // 
            // usersDataSet
            // 
            this.usersDataSet.DataSetName = "NewDataSet";
            this.usersDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.usersDataTable});
            // 
            // usersDataTable
            // 
            this.usersDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.nameUserDataColumn,
            this.speedUserDataColumn,
            this.speedLimitUserDataColumn,
            this.truckUserDataColumn,
            this.cargoUserDataColumn,
            this.sourceUserDataColumn,
            this.destinationUserDataColumn,
            this.distanceUserDataColumn,
            this.remainingTimeUserDataColumn,
            this.incomeUserDataColumn,
            this.massUserDataColumn});
            this.usersDataTable.TableName = "Users";
            // 
            // nameUserDataColumn
            // 
            this.nameUserDataColumn.ColumnName = "Name";
            // 
            // speedUserDataColumn
            // 
            this.speedUserDataColumn.ColumnName = "Speed";
            // 
            // speedLimitUserDataColumn
            // 
            this.speedLimitUserDataColumn.ColumnName = "Speed limit";
            // 
            // truckUserDataColumn
            // 
            this.truckUserDataColumn.ColumnName = "Truck";
            // 
            // cargoUserDataColumn
            // 
            this.cargoUserDataColumn.ColumnName = "Cargo";
            // 
            // sourceUserDataColumn
            // 
            this.sourceUserDataColumn.ColumnName = "Source";
            // 
            // destinationUserDataColumn
            // 
            this.destinationUserDataColumn.ColumnName = "Destination";
            // 
            // distanceUserDataColumn
            // 
            this.distanceUserDataColumn.ColumnName = "Distance";
            // 
            // remainingTimeUserDataColumn
            // 
            this.remainingTimeUserDataColumn.ColumnName = "Remaining time";
            // 
            // incomeUserDataColumn
            // 
            this.incomeUserDataColumn.ColumnName = "Income";
            // 
            // massUserDataColumn
            // 
            this.massUserDataColumn.ColumnName = "Mass";
            // 
            // topLayoutPanel
            // 
            this.topLayoutPanel.Controls.Add(this.addUserPictureBox);
            this.topLayoutPanel.Controls.Add(this.liveMapPictureBox);
            this.topLayoutPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.topLayoutPanel.Name = "topLayoutPanel";
            this.topLayoutPanel.Size = new System.Drawing.Size(867, 70);
            this.topLayoutPanel.TabIndex = 0;
            // 
            // addUserPictureBox
            // 
            this.addUserPictureBox.Image = global::TruckingVSConnect2.Properties.Resources.AddUserIcon;
            this.addUserPictureBox.Location = new System.Drawing.Point(3, 3);
            this.addUserPictureBox.Name = "addUserPictureBox";
            this.addUserPictureBox.Size = new System.Drawing.Size(64, 64);
            this.addUserPictureBox.TabIndex = 0;
            this.addUserPictureBox.TabStop = false;
            this.addUserPictureBox.Click += new System.EventHandler(this.addUserPictureBox_Click);
            this.addUserPictureBox.MouseEnter += new System.EventHandler(this.genericPictureBox_MouseEnter);
            this.addUserPictureBox.MouseLeave += new System.EventHandler(this.genericPictureBox_MouseLeave);
            // 
            // liveMapPictureBox
            // 
            this.liveMapPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.liveMapPictureBox.Image = global::TruckingVSConnect2.Properties.Resources.MapIcon;
            this.liveMapPictureBox.Location = new System.Drawing.Point(73, 3);
            this.liveMapPictureBox.Name = "liveMapPictureBox";
            this.liveMapPictureBox.Size = new System.Drawing.Size(64, 64);
            this.liveMapPictureBox.TabIndex = 5;
            this.liveMapPictureBox.TabStop = false;
            this.liveMapPictureBox.Click += new System.EventHandler(this.liveMapPictureBox_Click);
            this.liveMapPictureBox.MouseEnter += new System.EventHandler(this.genericPictureBox_MouseEnter);
            this.liveMapPictureBox.MouseLeave += new System.EventHandler(this.genericPictureBox_MouseLeave);
            // 
            // threadTimer
            // 
            this.threadTimer.Interval = 20;
            this.threadTimer.Tick += new System.EventHandler(this.threadTimer_Tick);
            // 
            // GroupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 509);
            this.Controls.Add(this.mainPanel);
            this.Name = "GroupForm";
            this.Text = "{$GROUP_TITLE$}";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.usersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersDataTable)).EndInit();
            this.topLayoutPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addUserPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.liveMapPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.FlowLayoutPanel topLayoutPanel;
        private System.Windows.Forms.PictureBox addUserPictureBox;
        private System.Data.DataSet usersDataSet;
        private System.Data.DataTable usersDataTable;
        private System.Data.DataColumn nameUserDataColumn;
        private System.Data.DataColumn speedUserDataColumn;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private System.Windows.Forms.DataGridView usersGridView;
        private System.Data.DataColumn speedLimitUserDataColumn;
        private System.Data.DataColumn truckUserDataColumn;
        private System.Data.DataColumn cargoUserDataColumn;
        private System.Data.DataColumn sourceUserDataColumn;
        private System.Data.DataColumn destinationUserDataColumn;
        private System.Data.DataColumn distanceUserDataColumn;
        private System.Data.DataColumn remainingTimeUserDataColumn;
        private System.Data.DataColumn incomeUserDataColumn;
        private System.Data.DataColumn massUserDataColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn truckDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cargoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn sourceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn destinationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn distanceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn remainingTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn incomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn massDataGridViewTextBoxColumn;
        private System.Windows.Forms.Timer threadTimer;
        private System.Windows.Forms.PictureBox liveMapPictureBox;
    }
}