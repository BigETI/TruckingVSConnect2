namespace TruckingVSConnect2
{
    partial class TextEditForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TextEditForm));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.cancelButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.okButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.valueTextField = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.mainPanel.Controls.Add(this.cancelButton);
            this.mainPanel.Controls.Add(this.okButton);
            this.mainPanel.Controls.Add(this.valueTextField);
            this.mainPanel.Location = new System.Drawing.Point(12, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(376, 71);
            this.mainPanel.TabIndex = 0;
            // 
            // cancelButton
            // 
            this.cancelButton.AutoSize = true;
            this.cancelButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.cancelButton.Depth = 0;
            this.cancelButton.Icon = null;
            this.cancelButton.Location = new System.Drawing.Point(73, 32);
            this.cancelButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Primary = true;
            this.cancelButton.Size = new System.Drawing.Size(98, 36);
            this.cancelButton.TabIndex = 2;
            this.cancelButton.Text = "{$CANCEL$}";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // okButton
            // 
            this.okButton.AutoSize = true;
            this.okButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.okButton.Depth = 0;
            this.okButton.Icon = null;
            this.okButton.Location = new System.Drawing.Point(3, 32);
            this.okButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.okButton.Name = "okButton";
            this.okButton.Primary = true;
            this.okButton.Size = new System.Drawing.Size(64, 36);
            this.okButton.TabIndex = 1;
            this.okButton.Text = "{$OK$}";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // valueTextField
            // 
            this.valueTextField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.valueTextField.Depth = 0;
            this.valueTextField.Hint = "";
            this.valueTextField.Location = new System.Drawing.Point(3, 3);
            this.valueTextField.MaxLength = 32767;
            this.valueTextField.MouseState = MaterialSkin.MouseState.HOVER;
            this.valueTextField.Name = "valueTextField";
            this.valueTextField.PasswordChar = '\0';
            this.valueTextField.SelectedText = "";
            this.valueTextField.SelectionLength = 0;
            this.valueTextField.SelectionStart = 0;
            this.valueTextField.Size = new System.Drawing.Size(370, 23);
            this.valueTextField.TabIndex = 0;
            this.valueTextField.TabStop = false;
            this.valueTextField.UseSystemPasswordChar = false;
            this.valueTextField.KeyUp += new System.Windows.Forms.KeyEventHandler(this.valueTextField_KeyUp);
            // 
            // TextEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 147);
            this.Controls.Add(this.mainPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1200, 147);
            this.MinimumSize = new System.Drawing.Size(400, 147);
            this.Name = "TextEditForm";
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private MaterialSkin.Controls.MaterialSingleLineTextField valueTextField;
        private MaterialSkin.Controls.MaterialRaisedButton cancelButton;
        private MaterialSkin.Controls.MaterialRaisedButton okButton;
    }
}