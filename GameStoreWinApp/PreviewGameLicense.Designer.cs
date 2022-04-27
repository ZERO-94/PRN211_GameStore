namespace GameStoreWinApp
{
    partial class PreviewGameLicense
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
            this.label1 = new System.Windows.Forms.Label();
            this.lbBuyerNameHeader = new System.Windows.Forms.Label();
            this.lbBuyerEmail = new System.Windows.Forms.Label();
            this.lbGameName = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lbGameCategory = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lbActiveDate = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tbReceiverEmail = new System.Windows.Forms.TextBox();
            this.lbReceiverHeader = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(227, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game License Information";
            // 
            // lbBuyerNameHeader
            // 
            this.lbBuyerNameHeader.AutoSize = true;
            this.lbBuyerNameHeader.Location = new System.Drawing.Point(250, 150);
            this.lbBuyerNameHeader.Name = "lbBuyerNameHeader";
            this.lbBuyerNameHeader.Size = new System.Drawing.Size(75, 15);
            this.lbBuyerNameHeader.TabIndex = 1;
            this.lbBuyerNameHeader.Text = "Buyer email: ";
            // 
            // lbBuyerEmail
            // 
            this.lbBuyerEmail.AutoSize = true;
            this.lbBuyerEmail.Location = new System.Drawing.Point(327, 150);
            this.lbBuyerEmail.Name = "lbBuyerEmail";
            this.lbBuyerEmail.Size = new System.Drawing.Size(69, 15);
            this.lbBuyerEmail.TabIndex = 2;
            this.lbBuyerEmail.Text = "Buyer email";
            // 
            // lbGameName
            // 
            this.lbGameName.AutoSize = true;
            this.lbGameName.Location = new System.Drawing.Point(327, 183);
            this.lbGameName.Name = "lbGameName";
            this.lbGameName.Size = new System.Drawing.Size(73, 15);
            this.lbGameName.TabIndex = 4;
            this.lbGameName.Text = "Game Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(250, 183);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 15);
            this.label9.TabIndex = 3;
            this.label9.Text = "Game Name: ";
            // 
            // lbGameCategory
            // 
            this.lbGameCategory.AutoSize = true;
            this.lbGameCategory.Location = new System.Drawing.Point(345, 219);
            this.lbGameCategory.Name = "lbGameCategory";
            this.lbGameCategory.Size = new System.Drawing.Size(89, 15);
            this.lbGameCategory.TabIndex = 6;
            this.lbGameCategory.Text = "Game Category";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(250, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(92, 15);
            this.label6.TabIndex = 5;
            this.label6.Text = "Game Category:";
            // 
            // lbActiveDate
            // 
            this.lbActiveDate.AutoSize = true;
            this.lbActiveDate.Location = new System.Drawing.Point(325, 251);
            this.lbActiveDate.Name = "lbActiveDate";
            this.lbActiveDate.Size = new System.Drawing.Size(66, 15);
            this.lbActiveDate.TabIndex = 8;
            this.lbActiveDate.Text = "Active date";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(250, 251);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "Active date:";
            // 
            // tbReceiverEmail
            // 
            this.tbReceiverEmail.Location = new System.Drawing.Point(316, 285);
            this.tbReceiverEmail.Name = "tbReceiverEmail";
            this.tbReceiverEmail.Size = new System.Drawing.Size(265, 23);
            this.tbReceiverEmail.TabIndex = 9;
            this.tbReceiverEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbReceiverEmail_Validating);
            // 
            // lbReceiverHeader
            // 
            this.lbReceiverHeader.AutoSize = true;
            this.lbReceiverHeader.Location = new System.Drawing.Point(250, 288);
            this.lbReceiverHeader.Name = "lbReceiverHeader";
            this.lbReceiverHeader.Size = new System.Drawing.Size(60, 15);
            this.lbReceiverHeader.TabIndex = 10;
            this.lbReceiverHeader.Text = "A gift for: ";
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(713, 415);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnOK.Location = new System.Drawing.Point(632, 415);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 12;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // PreviewGameLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lbReceiverHeader);
            this.Controls.Add(this.tbReceiverEmail);
            this.Controls.Add(this.lbActiveDate);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lbGameCategory);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lbGameName);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lbBuyerEmail);
            this.Controls.Add(this.lbBuyerNameHeader);
            this.Controls.Add(this.label1);
            this.Name = "PreviewGameLicense";
            this.Text = "PreviewGameLicense";
            this.Load += new System.EventHandler(this.PreviewGameLicense_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbBuyerNameHeader;
        private System.Windows.Forms.Label lbBuyerEmail;
        private System.Windows.Forms.Label lbGameName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lbGameCategory;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbActiveDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tbReceiverEmail;
        private System.Windows.Forms.Label lbReceiverHeader;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}