﻿namespace GameStoreWinApp
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
            this.updateGameLicense = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gameLicenseContainer)).BeginInit();
            this.SuspendLayout();
            // 
            // deactivateGameBtn
            // 
            this.deactivateGameBtn.Location = new System.Drawing.Point(722, 384);
            this.deactivateGameBtn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deactivateGameBtn.Name = "deactivateGameBtn";
            this.deactivateGameBtn.Size = new System.Drawing.Size(150, 31);
            this.deactivateGameBtn.TabIndex = 84;
            this.deactivateGameBtn.Text = "Deactivate";
            this.deactivateGameBtn.UseVisualStyleBackColor = true;
            // 
            // gameLicenseContainer
            // 
            this.gameLicenseContainer.AllowUserToAddRows = false;
            this.gameLicenseContainer.AllowUserToDeleteRows = false;
            this.gameLicenseContainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameLicenseContainer.Location = new System.Drawing.Point(23, 186);
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
            this.endDatePicker.Location = new System.Drawing.Point(420, 120);
            this.endDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.endDatePicker.Name = "endDatePicker";
            this.endDatePicker.Size = new System.Drawing.Size(257, 27);
            this.endDatePicker.TabIndex = 80;
            // 
            // startDatePicker
            // 
            this.startDatePicker.Location = new System.Drawing.Point(420, 47);
            this.startDatePicker.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.startDatePicker.Name = "startDatePicker";
            this.startDatePicker.Size = new System.Drawing.Size(257, 27);
            this.startDatePicker.TabIndex = 79;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(420, 96);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 77;
            this.label3.Text = "To (Date)";
            // 
            // txtUserID
            // 
            this.txtUserID.FormattingEnabled = true;
            this.txtUserID.Location = new System.Drawing.Point(134, 119);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(249, 28);
            this.txtUserID.TabIndex = 76;
            // 
            // IDLabel
            // 
            this.IDLabel.AutoSize = true;
            this.IDLabel.Location = new System.Drawing.Point(23, 63);
            this.IDLabel.Name = "IDLabel";
            this.IDLabel.Size = new System.Drawing.Size(24, 20);
            this.IDLabel.TabIndex = 75;
            this.IDLabel.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(23, 87);
            this.txtID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(60, 27);
            this.txtID.TabIndex = 74;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(420, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 73;
            this.label2.Text = "From (Date)";
            // 
            // memberLabel
            // 
            this.memberLabel.AutoSize = true;
            this.memberLabel.Location = new System.Drawing.Point(134, 95);
            this.memberLabel.Name = "memberLabel";
            this.memberLabel.Size = new System.Drawing.Size(65, 20);
            this.memberLabel.TabIndex = 72;
            this.memberLabel.Text = "Member";
            // 
            // searchBtn_GameLicense
            // 
            this.searchBtn_GameLicense.Location = new System.Drawing.Point(722, 85);
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
            this.txtGameID.Location = new System.Drawing.Point(134, 47);
            this.txtGameID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGameID.Name = "txtGameID";
            this.txtGameID.Size = new System.Drawing.Size(249, 28);
            this.txtGameID.TabIndex = 88;
            // 
            // gameLabel
            // 
            this.gameLabel.AutoSize = true;
            this.gameLabel.Location = new System.Drawing.Point(134, 23);
            this.gameLabel.Name = "gameLabel";
            this.gameLabel.Size = new System.Drawing.Size(48, 20);
            this.gameLabel.TabIndex = 87;
            this.gameLabel.Text = "Game";
            // 
            // refreshBtn
            // 
            this.refreshBtn.Location = new System.Drawing.Point(722, 265);
            this.refreshBtn.Name = "refreshBtn";
            this.refreshBtn.Size = new System.Drawing.Size(150, 32);
            this.refreshBtn.TabIndex = 89;
            this.refreshBtn.Text = "Refresh";
            this.refreshBtn.UseVisualStyleBackColor = true;
            this.refreshBtn.Click += new System.EventHandler(this.refreshBtn_Click);
            // 
            // updateGameLicense
            // 
            this.updateGameLicense.Location = new System.Drawing.Point(722, 326);
            this.updateGameLicense.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateGameLicense.Name = "updateGameLicense";
            this.updateGameLicense.Size = new System.Drawing.Size(150, 31);
            this.updateGameLicense.TabIndex = 85;
            this.updateGameLicense.Text = "Update";
            this.updateGameLicense.UseVisualStyleBackColor = true;
            this.updateGameLicense.Click += new System.EventHandler(this.updateGameLicense_Click);
            // 
            // frmGameLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.refreshBtn);
            this.Controls.Add(this.txtGameID);
            this.Controls.Add(this.gameLabel);
            this.Controls.Add(this.searchBtn_GameLicense);
            this.Controls.Add(this.updateGameLicense);
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
            this.Size = new System.Drawing.Size(889, 568);
            this.Load += new System.EventHandler(this.frmGameLicense_Load);
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
        private System.Windows.Forms.Button updateGameLicense;
    }
}
