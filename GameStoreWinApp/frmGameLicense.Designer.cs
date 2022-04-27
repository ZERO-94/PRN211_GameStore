namespace GameStoreWinApp
{
    partial class frmGameLicense
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.deactivateGameBtn = new System.Windows.Forms.Button();
            this.gameLicenseContainer = new System.Windows.Forms.DataGridView();
            this.endDatePicker = new System.Windows.Forms.DateTimePicker();
            this.startDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.ComboBox();
            this.IDLabel = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.memberLabel = new System.Windows.Forms.Label();
            this.searchBtn_GameLicense = new System.Windows.Forms.Button();
            this.txtGameID = new System.Windows.Forms.ComboBox();
            this.gameLabel = new System.Windows.Forms.Label();
            this.refreshBtn = new System.Windows.Forms.Button();
            this.activeBtn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameLicenseContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // deactivateGameBtn
            // 
            this.deactivateGameBtn.Location = new System.Drawing.Point(721, 519);
            this.deactivateGameBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deactivateGameBtn.Name = "deactivateGameBtn";
            this.deactivateGameBtn.Size = new System.Drawing.Size(150, 31);
            this.deactivateGameBtn.TabIndex = 84;
            this.deactivateGameBtn.Text = "Deactivate";
            this.deactivateGameBtn.UseVisualStyleBackColor = true;
            this.deactivateGameBtn.Click += new System.EventHandler(this.deactivateGameBtn_Click);
            // 
            // gameLicenseContainer
            // 
            this.gameLicenseContainer.AllowUserToAddRows = false;
            this.gameLicenseContainer.AllowUserToDeleteRows = false;
            this.gameLicenseContainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameLicenseContainer.Location = new System.Drawing.Point(22, 287);
            this.gameLicenseContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gameLicenseContainer.MultiSelect = false;
            this.gameLicenseContainer.Name = "gameLicenseContainer";
            this.gameLicenseContainer.ReadOnly = true;
            this.gameLicenseContainer.RowHeadersWidth = 51;
            this.gameLicenseContainer.RowTemplate.Height = 25;
            this.gameLicenseContainer.Size = new System.Drawing.Size(680, 349);
            this.gameLicenseContainer.TabIndex = 82;
            // 
            // endDatePicker
            // 
            this.endDatePicker.Location = new System.Drawing.Point(419, 221);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(257, 27);
            this.endDatePicker.TabIndex = 80;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(419, 148);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(257, 27);
            this.startDatePicker.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(419, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "To (Date)";
            // 
            // txtUserID
            // 
            this.txtUserID.FormattingEnabled = true;
            this.txtUserID.Location = new System.Drawing.Point(133, 220);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(249, 28);
            this.txtUserID.TabIndex = 76;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(22, 164);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(24, 20);
            this.IDLabel.TabIndex = 75;
            this.IDLabel.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(22, 188);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 27);
            this.txtID.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(419, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "From (Date)";
            // 
            // memberLabel
            // 
            this.memberLabel.AutoSize = true;
            this.memberLabel.Location = new System.Drawing.Point(133, 196);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(65, 20);
            this.memberLabel.TabIndex = 72;
            this.memberLabel.Text = "Member";
            // 
            // searchBtn_GameLicense
            // 
            this.searchBtn_GameLicense.Location = new System.Drawing.Point(721, 186);
            this.searchBtn_GameLicense.Name = "searchBtn_GameLicense";
            this.searchBtn_GameLicense.Size = new System.Drawing.Size(94, 29);
            this.searchBtn_GameLicense.TabIndex = 86;
            this.searchBtn_GameLicense.Text = "Search";
            this.searchBtn_GameLicense.UseVisualStyleBackColor = true;
            this.searchBtn_GameLicense.Click += new System.EventHandler(this.searchBtn_GameLicense_Click);
            // 
            // txtGameID
            // 
            this.txtGameID.FormattingEnabled = true;
            this.txtGameID.Location = new System.Drawing.Point(133, 148);
            this.txtGameID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGameID.Name = "txtGameID";
            this.txtGameID.Size = new System.Drawing.Size(249, 28);
            this.txtGameID.TabIndex = 88;
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(133, 124);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(48, 20);
            this.gameLabel.TabIndex = 87;
            this.gameLabel.Text = "Game";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(721, 390);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(150, 32);
            this.refreshBtn.TabIndex = 89;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // activeBtn
            // 
            this.activeBtn.Location = new System.Drawing.Point(721, 455);
            this.activeBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.activeBtn.Name = "activeBtn";
            this.activeBtn.Size = new System.Drawing.Size(150, 31);
            this.activeBtn.TabIndex = 90;
            this.activeBtn.Text = "Activate";
            this.activeBtn.UseVisualStyleBackColor = true;
            this.activeBtn.Click += new System.EventHandler(this.activeBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(162, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(595, 60);
            this.label4.TabIndex = 91;
            this.label4.Text = "Game License Management";
            // 
            // frmGameLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.activeBtn);
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.txtGameID);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.searchBtn_GameLicense);
            this.Controls.Add(this.deactivateGameBtn);
            this.Controls.Add(this.gameLicenseContainer);
            this.Controls.Add(this.endDatePicker);
            this.Controls.Add(this.startDatePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.IDLabel);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.memberLabel);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGameLicense";
            this.Size = new System.Drawing.Size(889, 659);
            ((System.ComponentModel.ISupportInitialize)(this.gameLicenseContainer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button deactivateGameBtn;
        private System.Windows.Forms.DataGridView gameLicenseContainer;
        private System.Windows.Forms.DateTimePicker endDatePicker;
        private System.Windows.Forms.DateTimePicker startDatePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox txtUserID;
        private System.Windows.Forms.Label IDLabel;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label memberLabel;
        private System.Windows.Forms.Button searchBtn_GameLicense;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label gameLabel;
        private System.Windows.Forms.ComboBox txtGameID;
        private System.Windows.Forms.Button refreshBtn;
        private System.Windows.Forms.Button activeBtn;
        private System.Windows.Forms.Label label4;
    }
}
