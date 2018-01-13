namespace TruckingVSConnect2
{
    partial class FindUsersForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FindUsersForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.foundUsersGridView = new System.Windows.Forms.DataGridView();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.foundUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.foundUsersDataSet = new System.Data.DataSet();
            this.foundUsersDataTable = new System.Data.DataTable();
            this.nameFoundUserDataColumn = new System.Data.DataColumn();
            this.filterPanel = new System.Windows.Forms.Panel();
            this.filterTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.addUserPictureBox = new System.Windows.Forms.PictureBox();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.foundUsersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundUsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundUsersDataTable)).BeginInit();
            this.filterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addUserPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mainPanel.Controls.Add(this.foundUsersGridView);
            this.mainPanel.Controls.Add(this.filterPanel);
            this.mainPanel.Location = new System.Drawing.Point(12, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(879, 416);
            this.mainPanel.TabIndex = 0;
            // 
            // foundUsersGridView
            // 
            this.foundUsersGridView.AllowUserToAddRows = false;
            this.foundUsersGridView.AllowUserToDeleteRows = false;
            this.foundUsersGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(76)))), ((int)(((byte)(76)))));
            this.foundUsersGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.foundUsersGridView.AutoGenerateColumns = false;
            this.foundUsersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.foundUsersGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.foundUsersGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.foundUsersGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.foundUsersGridView.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.foundUsersGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.foundUsersGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.foundUsersGridView.ColumnHeadersHeight = 32;
            this.foundUsersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.foundUsersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameDataGridViewTextBoxColumn});
            this.foundUsersGridView.DataSource = this.foundUsersBindingSource;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(86)))), ((int)(((byte)(170)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.foundUsersGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.foundUsersGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.foundUsersGridView.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.foundUsersGridView.EnableHeadersVisualStyles = false;
            this.foundUsersGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(63)))), ((int)(((byte)(63)))), ((int)(((byte)(63)))));
            this.foundUsersGridView.Location = new System.Drawing.Point(0, 70);
            this.foundUsersGridView.MultiSelect = false;
            this.foundUsersGridView.Name = "foundUsersGridView";
            this.foundUsersGridView.ReadOnly = true;
            this.foundUsersGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.foundUsersGridView.RowHeadersVisible = false;
            this.foundUsersGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.foundUsersGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.foundUsersGridView.Size = new System.Drawing.Size(879, 346);
            this.foundUsersGridView.TabIndex = 6;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // foundUsersBindingSource
            // 
            this.foundUsersBindingSource.DataMember = "FoundUsers";
            this.foundUsersBindingSource.DataSource = this.foundUsersDataSet;
            // 
            // foundUsersDataSet
            // 
            this.foundUsersDataSet.DataSetName = "FoundUsersDataSet";
            this.foundUsersDataSet.Tables.AddRange(new System.Data.DataTable[] {
            this.foundUsersDataTable});
            // 
            // foundUsersDataTable
            // 
            this.foundUsersDataTable.Columns.AddRange(new System.Data.DataColumn[] {
            this.nameFoundUserDataColumn});
            this.foundUsersDataTable.TableName = "FoundUsers";
            // 
            // nameFoundUserDataColumn
            // 
            this.nameFoundUserDataColumn.ColumnName = "Name";
            // 
            // filterPanel
            // 
            this.filterPanel.Controls.Add(this.filterTextField);
            this.filterPanel.Controls.Add(this.addUserPictureBox);
            this.filterPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterPanel.Location = new System.Drawing.Point(0, 0);
            this.filterPanel.Name = "filterPanel";
            this.filterPanel.Size = new System.Drawing.Size(879, 70);
            this.filterPanel.TabIndex = 4;
            // 
            // filterTextField
            // 
            this.filterTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.filterTextField.Depth = 0;
            this.filterTextField.Hint = "{$USERNAME_HINT$}";
            this.filterTextField.Location = new System.Drawing.Point(3, 41);
            this.filterTextField.MaxLength = 32767;
            this.filterTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.filterTextField.Name = "filterTextField";
            this.filterTextField.PasswordChar = '\0';
            this.filterTextField.SelectedText = "";
            this.filterTextField.SelectionLength = 0;
            this.filterTextField.SelectionStart = 0;
            this.filterTextField.Size = new System.Drawing.Size(803, 23);
            this.filterTextField.TabIndex = 1;
            this.filterTextField.TabStop = false;
            this.filterTextField.UseSystemPasswordChar = false;
            this.filterTextField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.filterTextField_KeyUp);
            // 
            // addUserPictureBox
            // 
            this.addUserPictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addUserPictureBox.Image = global::TruckingVSConnect2.Properties.Resources.AddUserIcon;
            this.addUserPictureBox.Location = new System.Drawing.Point(812, 3);
            this.addUserPictureBox.Name = "addUserPictureBox";
            this.addUserPictureBox.Size = new System.Drawing.Size(64, 64);
            this.addUserPictureBox.TabIndex = 0;
            this.addUserPictureBox.TabStop = false;
            this.addUserPictureBox.Click += new System.EventHandler(this.addUserPictureBox_Click);
            // 
            // FindUsersForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(903, 492);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FindUsersForm";
            this.Text = "{$FIND_USERS$}";
            this.mainPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.foundUsersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundUsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foundUsersDataTable)).EndInit();
            this.filterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.addUserPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.PictureBox addUserPictureBox;
        private System.Data.DataSet foundUsersDataSet;
        private System.Windows.Forms.Panel filterPanel;
        private MaterialSkin.Controls.MaterialSingleLineTextField filterTextField;
        private System.Windows.Forms.DataGridView foundUsersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource foundUsersBindingSource;
        private System.Data.DataTable foundUsersDataTable;
        private System.Data.DataColumn nameFoundUserDataColumn;
    }
}