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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gameMenuItem,
            this.accountManagementMenuItem,
            this.gameLicensesMenuItem,
            this.myProfileMenuItem,
            this.logoutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gameMenuItem
            // 
            this.gameMenuItem.Name = "gameMenuItem";
            this.gameMenuItem.Size = new System.Drawing.Size(50, 20);
            this.gameMenuItem.Text = "Game";
            // 
            // accountManagementMenuItem
            // 
            this.accountManagementMenuItem.Name = "accountManagementMenuItem";
            this.accountManagementMenuItem.Size = new System.Drawing.Size(138, 20);
            this.accountManagementMenuItem.Text = "Account management";
            // 
            // gameLicensesMenuItem
            // 
            this.gameLicensesMenuItem.Name = "gameLicensesMenuItem";
            this.gameLicensesMenuItem.Size = new System.Drawing.Size(97, 20);
            this.gameLicensesMenuItem.Text = "Game Licenses";
            // 
            // myProfileMenuItem
            // 
            this.myProfileMenuItem.Name = "myProfileMenuItem";
            this.myProfileMenuItem.Size = new System.Drawing.Size(73, 20);
            this.myProfileMenuItem.Text = "My Profile";
            this.myProfileMenuItem.Click += new System.EventHandler(this.myProfileMenuItem_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // frmMyProfile1
            // 
            this.frmMyProfile1.Location = new System.Drawing.Point(12, 27);
            this.frmMyProfile1.Name = "frmMyProfile1";
            this.frmMyProfile1.Size = new System.Drawing.Size(776, 411);
            this.frmMyProfile1.TabIndex = 1;
            this.frmMyProfile1.Visible = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.frmMyProfile1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
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
    }
}