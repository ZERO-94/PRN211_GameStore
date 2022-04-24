namespace GameStoreWinApp
{
    partial class frmMyProfile
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
            this.components = new System.ComponentModel.Container();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.changePassword = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.newPassword = new System.Windows.Forms.Label();
            this.tbNewPassword = new System.Windows.Forms.TextBox();
            this.reConfirm = new System.Windows.Forms.Label();
            this.oldPassword = new System.Windows.Forms.Label();
            this.tbReConfirm = new System.Windows.Forms.TextBox();
            this.tbOldPassword = new System.Windows.Forms.TextBox();
            this.Email = new System.Windows.Forms.Label();
            this.lbName = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(425, 149);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(216, 25);
            this.label3.TabIndex = 60;
            this.label3.Text = "Change your password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(45, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(238, 25);
            this.label2.TabIndex = 59;
            this.label2.Text = "Your general information";
            // 
            // username
            // 
            this.username.AutoSize = true;
            this.username.Location = new System.Drawing.Point(95, 58);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(59, 15);
            this.username.TabIndex = 58;
            this.username.Text = "username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 15);
            this.label1.TabIndex = 57;
            this.label1.Text = "Welcome,";
            // 
            // changePassword
            // 
            this.changePassword.Location = new System.Drawing.Point(616, 330);
            this.changePassword.Name = "changePassword";
            this.changePassword.Size = new System.Drawing.Size(122, 23);
            this.changePassword.TabIndex = 56;
            this.changePassword.Text = "change password";
            this.changePassword.UseVisualStyleBackColor = true;
            this.changePassword.Click += new System.EventHandler(this.changePassword_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(278, 284);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 55;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // newPassword
            // 
            this.newPassword.AutoSize = true;
            this.newPassword.Location = new System.Drawing.Point(451, 283);
            this.newPassword.Name = "newPassword";
            this.newPassword.Size = new System.Drawing.Size(84, 15);
            this.newPassword.TabIndex = 54;
            this.newPassword.Text = "New Password";
            // 
            // tbNewPassword
            // 
            this.tbNewPassword.Location = new System.Drawing.Point(451, 301);
            this.tbNewPassword.Name = "tbNewPassword";
            this.tbNewPassword.PasswordChar = '*';
            this.tbNewPassword.Size = new System.Drawing.Size(287, 23);
            this.tbNewPassword.TabIndex = 53;
            this.tbNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbNewPassword_Validating);
            // 
            // reConfirm
            // 
            this.reConfirm.AutoSize = true;
            this.reConfirm.Location = new System.Drawing.Point(451, 236);
            this.reConfirm.Name = "reConfirm";
            this.reConfirm.Size = new System.Drawing.Size(67, 15);
            this.reConfirm.TabIndex = 52;
            this.reConfirm.Text = "Re-confirm";
            // 
            // oldPassword
            // 
            this.oldPassword.AutoSize = true;
            this.oldPassword.Location = new System.Drawing.Point(451, 189);
            this.oldPassword.Name = "oldPassword";
            this.oldPassword.Size = new System.Drawing.Size(79, 15);
            this.oldPassword.TabIndex = 51;
            this.oldPassword.Text = "Old Password";
            // 
            // tbReConfirm
            // 
            this.tbReConfirm.Location = new System.Drawing.Point(451, 254);
            this.tbReConfirm.Name = "tbReConfirm";
            this.tbReConfirm.PasswordChar = '*';
            this.tbReConfirm.Size = new System.Drawing.Size(287, 23);
            this.tbReConfirm.TabIndex = 50;
            this.tbReConfirm.Validating += new System.ComponentModel.CancelEventHandler(this.tbReConfirm_Validating);
            // 
            // tbOldPassword
            // 
            this.tbOldPassword.Location = new System.Drawing.Point(451, 207);
            this.tbOldPassword.Name = "tbOldPassword";
            this.tbOldPassword.PasswordChar = '*';
            this.tbOldPassword.Size = new System.Drawing.Size(287, 23);
            this.tbOldPassword.TabIndex = 49;
            this.tbOldPassword.Validating += new System.ComponentModel.CancelEventHandler(this.tbOldPassword_Validating);
            // 
            // Email
            // 
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(66, 236);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(36, 15);
            this.Email.TabIndex = 48;
            this.Email.Text = "Email";
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Location = new System.Drawing.Point(66, 189);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(39, 15);
            this.lbName.TabIndex = 47;
            this.lbName.Text = "Name";
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(66, 254);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(287, 23);
            this.tbEmail.TabIndex = 46;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(66, 207);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(287, 23);
            this.tbName.TabIndex = 45;
            this.tbName.Validating += new System.ComponentModel.CancelEventHandler(this.tbName_Validating);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // frmMyProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.changePassword);
            this.Controls.Add(this.update);
            this.Controls.Add(this.newPassword);
            this.Controls.Add(this.tbNewPassword);
            this.Controls.Add(this.reConfirm);
            this.Controls.Add(this.oldPassword);
            this.Controls.Add(this.tbReConfirm);
            this.Controls.Add(this.tbOldPassword);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.lbName);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbName);
            this.Name = "frmMyProfile";
            this.Size = new System.Drawing.Size(776, 411);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button changePassword;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Label newPassword;
        private System.Windows.Forms.TextBox tbNewPassword;
        private System.Windows.Forms.Label reConfirm;
        private System.Windows.Forms.Label oldPassword;
        private System.Windows.Forms.TextBox tbReConfirm;
        private System.Windows.Forms.TextBox tbOldPassword;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
