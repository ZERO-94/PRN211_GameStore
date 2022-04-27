namespace GameStoreWinApp
{
    partial class frmAccount
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
            this.createUser = new System.Windows.Forms.Button();
            this.deleteUser = new System.Windows.Forms.Button();
            this.updateUser = new System.Windows.Forms.Button();
            this.userDataGrid = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // createUser
            // 
            this.createUser.Location = new System.Drawing.Point(725, 295);
            this.createUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createUser.Name = "createUser";
            this.createUser.Size = new System.Drawing.Size(133, 31);
            this.createUser.TabIndex = 11;
            this.createUser.Text = "create member";
            this.createUser.UseVisualStyleBackColor = true;
            this.createUser.Click += new System.EventHandler(this.createUser_Click);
            // 
            // deleteUser
            // 
            this.deleteUser.Location = new System.Drawing.Point(725, 237);
            this.deleteUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteUser.Name = "deleteUser";
            this.deleteUser.Size = new System.Drawing.Size(133, 31);
            this.deleteUser.TabIndex = 10;
            this.deleteUser.Text = "delete";
            this.deleteUser.UseVisualStyleBackColor = true;
            this.deleteUser.Click += new System.EventHandler(this.deleteUser_Click);
            // 
            // updateUser
            // 
            this.updateUser.Location = new System.Drawing.Point(725, 181);
            this.updateUser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateUser.Name = "updateUser";
            this.updateUser.Size = new System.Drawing.Size(133, 31);
            this.updateUser.TabIndex = 9;
            this.updateUser.Text = "update";
            this.updateUser.UseVisualStyleBackColor = true;
            this.updateUser.Click += new System.EventHandler(this.updateUser_Click);
            // 
            // userDataGrid
            // 
            this.userDataGrid.AllowUserToAddRows = false;
            this.userDataGrid.AllowUserToDeleteRows = false;
            this.userDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userDataGrid.Location = new System.Drawing.Point(32, 183);
            this.userDataGrid.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.userDataGrid.MultiSelect = false;
            this.userDataGrid.Name = "userDataGrid";
            this.userDataGrid.ReadOnly = true;
            this.userDataGrid.RowHeadersWidth = 51;
            this.userDataGrid.RowTemplate.Height = 25;
            this.userDataGrid.Size = new System.Drawing.Size(686, 333);
            this.userDataGrid.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(203, 49);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(488, 60);
            this.label4.TabIndex = 40;
            this.label4.Text = "Member Management";
            // 
            // frmAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.createUser);
            this.Controls.Add(this.deleteUser);
            this.Controls.Add(this.updateUser);
            this.Controls.Add(this.userDataGrid);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAccount";
            this.Size = new System.Drawing.Size(887, 548);
            ((System.ComponentModel.ISupportInitialize)(this.userDataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button createUser;
        private System.Windows.Forms.Button deleteUser;
        private System.Windows.Forms.Button updateUser;
        private System.Windows.Forms.DataGridView userDataGrid;
        private System.Windows.Forms.Label label4;
    }
}
