namespace GameStoreWinApp
{
    partial class frmMain
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gameMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.accountManagementMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gameLicensesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.myProfileMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frmMyProfile1 = new GameStoreWinApp.frmMyProfile();
            this.frmAccount1 = new GameStoreWinApp.frmAccount();
            this.frmGame1 = new GameStoreWinApp.frmGame();
            this.frmGameLicense1 = new GameStoreWinApp.frmGameLicense();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuItem,
            this.accountManagementMenuItem,
            this.gameLicensesMenuItem,
            this.myProfileMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(914, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameMenuItem
            // 
            this.gameMenuItem.Name = "gameMenuItem";
            this.gameMenuItem.Size = new System.Drawing.Size(62, 24);
            this.gameMenuItem.Text = "Game";
            this.gameMenuItem.Click += new System.EventHandler(this.gameMenuItem_Click);
            // 
            // accountManagementMenuItem
            // 
            this.accountManagementMenuItem.Name = "accountManagementMenuItem";
            this.accountManagementMenuItem.Size = new System.Drawing.Size(169, 24);
            this.accountManagementMenuItem.Text = "Account management";
            this.accountManagementMenuItem.Click += new System.EventHandler(this.accountManagementMenuItem_Click);
            // 
            // gameLicensesMenuItem
            // 
            this.gameLicensesMenuItem.Name = "gameLicensesMenuItem";
            this.gameLicensesMenuItem.Size = new System.Drawing.Size(120, 24);
            this.gameLicensesMenuItem.Text = "Game Licenses";
            this.gameLicensesMenuItem.Click += new System.EventHandler(this.gameLicensesMenuItem_Click);
            // 
            // myProfileMenuItem
            // 
            this.myProfileMenuItem.Name = "myProfileMenuItem";
            this.myProfileMenuItem.Size = new System.Drawing.Size(90, 24);
            this.myProfileMenuItem.Text = "My Profile";
            this.myProfileMenuItem.Click += new System.EventHandler(this.myProfileMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // frmMyProfile1
            // 
            this.frmMyProfile1.Location = new System.Drawing.Point(14, 36);
            this.frmMyProfile1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.frmMyProfile1.Name = "frmMyProfile1";
            this.frmMyProfile1.Size = new System.Drawing.Size(887, 548);
            this.frmMyProfile1.TabIndex = 1;
            this.frmMyProfile1.Visible = false;
            // 
            // frmAccount1
            // 
            this.frmAccount1.Location = new System.Drawing.Point(14, 36);
            this.frmAccount1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.frmAccount1.Name = "frmAccount1";
            this.frmAccount1.Size = new System.Drawing.Size(887, 548);
            this.frmAccount1.TabIndex = 2;
            this.frmAccount1.Visible = false;
            this.frmAccount1.Load += new System.EventHandler(this.frmAccount1_Load);
            // 
            // frmGame1
            // 
            this.frmGame1.Location = new System.Drawing.Point(0, 34);
            this.frmGame1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.frmGame1.Name = "frmGame1";
            this.frmGame1.Size = new System.Drawing.Size(1109, 685);
            this.frmGame1.TabIndex = 3;
            this.frmGame1.Load += new System.EventHandler(this.frmGame1_Load);
            // 
            // frmGameLicense1
            // 
            this.frmGameLicense1.Location = new System.Drawing.Point(0, 34);
            this.frmGameLicense1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.frmGameLicense1.Name = "frmGameLicense1";
            this.frmGameLicense1.Size = new System.Drawing.Size(1109, 685);
            this.frmGameLicense1.TabIndex = 4;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.frmGameLicense1);
            this.Controls.Add(this.frmGame1);
            this.Controls.Add(this.frmAccount1);
            this.Controls.Add(this.frmMyProfile1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.Text = "frmMain";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gameMenuItem;
        private System.Windows.Forms.ToolStripMenuItem accountManagementMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gameLicensesMenuItem;
        private System.Windows.Forms.ToolStripMenuItem myProfileMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private frmMyProfile frmMyProfile1;
        private frmAccount frmAccount1;
        private frmGame frmGame1;
        private frmGameLicense frmGameLicense1;
    }
}