namespace GameStoreWinApp
{
    partial class frmGame
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
            this.lbUnitInStock = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.searchBtn_Game = new System.Windows.Forms.Button();
            this.txtLowerPrice = new System.Windows.Forms.TextBox();
            this.txtHigherPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.createGame = new System.Windows.Forms.Button();
            this.deleteGame = new System.Windows.Forms.Button();
            this.updateGame = new System.Windows.Forms.Button();
            this.gameContainer = new System.Windows.Forms.DataGridView();
            this.lbId = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnBuy = new System.Windows.Forms.Button();
            this.btnSendPresent = new System.Windows.Forms.Button();
            this.txtCategory = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.gameContainer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbUnitInStock
            // 
            this.lbUnitInStock.AutoSize = true;
            this.lbUnitInStock.Location = new System.Drawing.Point(443, 217);
            this.lbUnitInStock.Name = "lbUnitInStock";
            this.lbUnitInStock.Size = new System.Drawing.Size(71, 20);
            this.lbUnitInStock.TabIndex = 33;
            this.lbUnitInStock.Text = "To (Price)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(162, 217);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 20);
            this.label3.TabIndex = 32;
            this.label3.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "From (Price)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Name";
            // 
            // searchBtn_Game
            // 
            this.searchBtn_Game.Location = new System.Drawing.Point(717, 207);
            this.searchBtn_Game.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.searchBtn_Game.Name = "searchBtn_Game";
            this.searchBtn_Game.Size = new System.Drawing.Size(133, 31);
            this.searchBtn_Game.TabIndex = 29;
            this.searchBtn_Game.Text = "Search";
            this.searchBtn_Game.UseVisualStyleBackColor = true;
            this.searchBtn_Game.Click += new System.EventHandler(this.searchBtn_Game_Click);
            // 
            // txtLowerPrice
            // 
            this.txtLowerPrice.Location = new System.Drawing.Point(443, 180);
            this.txtLowerPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtLowerPrice.Name = "txtLowerPrice";
            this.txtLowerPrice.Size = new System.Drawing.Size(236, 27);
            this.txtLowerPrice.TabIndex = 28;
            this.txtLowerPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtLowerPrice_Validating);
            // 
            // txtHigherPrice
            // 
            this.txtHigherPrice.Location = new System.Drawing.Point(443, 241);
            this.txtHigherPrice.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtHigherPrice.Name = "txtHigherPrice";
            this.txtHigherPrice.Size = new System.Drawing.Size(236, 27);
            this.txtHigherPrice.TabIndex = 27;
            this.txtHigherPrice.Validating += new System.ComponentModel.CancelEventHandler(this.txtHigherPrice_Validating);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(162, 180);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(236, 27);
            this.txtName.TabIndex = 26;
            // 
            // createGame
            // 
            this.createGame.Location = new System.Drawing.Point(717, 440);
            this.createGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.createGame.Name = "createGame";
            this.createGame.Size = new System.Drawing.Size(133, 31);
            this.createGame.TabIndex = 24;
            this.createGame.Text = "Create";
            this.createGame.UseVisualStyleBackColor = true;
            this.createGame.Click += new System.EventHandler(this.createGame_Click);
            // 
            // deleteGame
            // 
            this.deleteGame.Location = new System.Drawing.Point(717, 596);
            this.deleteGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.deleteGame.Name = "deleteGame";
            this.deleteGame.Size = new System.Drawing.Size(133, 31);
            this.deleteGame.TabIndex = 23;
            this.deleteGame.Text = "Delete";
            this.deleteGame.UseVisualStyleBackColor = true;
            this.deleteGame.Click += new System.EventHandler(this.deleteGame_Click);
            // 
            // updateGame
            // 
            this.updateGame.Location = new System.Drawing.Point(717, 519);
            this.updateGame.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.updateGame.Name = "updateGame";
            this.updateGame.Size = new System.Drawing.Size(133, 31);
            this.updateGame.TabIndex = 22;
            this.updateGame.Text = "Update";
            this.updateGame.UseVisualStyleBackColor = true;
            this.updateGame.Click += new System.EventHandler(this.updateGame_Click);
            // 
            // gameContainer
            // 
            this.gameContainer.AllowUserToAddRows = false;
            this.gameContainer.AllowUserToDeleteRows = false;
            this.gameContainer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gameContainer.Location = new System.Drawing.Point(33, 292);
            this.gameContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gameContainer.MultiSelect = false;
            this.gameContainer.Name = "gameContainer";
            this.gameContainer.ReadOnly = true;
            this.gameContainer.RowHeadersWidth = 51;
            this.gameContainer.RowTemplate.Height = 25;
            this.gameContainer.Size = new System.Drawing.Size(669, 333);
            this.gameContainer.TabIndex = 21;
            // 
            // lbId
            // 
            this.lbId.AutoSize = true;
            this.lbId.Location = new System.Drawing.Point(33, 180);
            this.lbId.Name = "lbId";
            this.lbId.Size = new System.Drawing.Size(24, 20);
            this.lbId.TabIndex = 34;
            this.lbId.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(33, 207);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(86, 27);
            this.txtID.TabIndex = 35;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnBuy
            // 
            this.btnBuy.Location = new System.Drawing.Point(717, 292);
            this.btnBuy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBuy.Name = "btnBuy";
            this.btnBuy.Size = new System.Drawing.Size(133, 31);
            this.btnBuy.TabIndex = 36;
            this.btnBuy.Text = "Buy";
            this.btnBuy.UseVisualStyleBackColor = true;
            this.btnBuy.Click += new System.EventHandler(this.btnBuy_Click);
            // 
            // btnSendPresent
            // 
            this.btnSendPresent.Location = new System.Drawing.Point(717, 365);
            this.btnSendPresent.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSendPresent.Name = "btnSendPresent";
            this.btnSendPresent.Size = new System.Drawing.Size(133, 31);
            this.btnSendPresent.TabIndex = 37;
            this.btnSendPresent.Text = "Send Present";
            this.btnSendPresent.UseVisualStyleBackColor = true;
            this.btnSendPresent.Click += new System.EventHandler(this.btnSendPresent_Click);
            // 
            // txtCategory
            // 
            this.txtCategory.FormattingEnabled = true;
            this.txtCategory.Location = new System.Drawing.Point(162, 241);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(236, 28);
            this.txtCategory.TabIndex = 38;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(295, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(432, 60);
            this.label4.TabIndex = 39;
            this.label4.Text = "Game Management";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.btnSendPresent);
            this.Controls.Add(this.btnBuy);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lbId);
            this.Controls.Add(this.lbUnitInStock);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchBtn_Game);
            this.Controls.Add(this.txtLowerPrice);
            this.Controls.Add(this.txtHigherPrice);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.createGame);
            this.Controls.Add(this.deleteGame);
            this.Controls.Add(this.updateGame);
            this.Controls.Add(this.gameContainer);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmGame";
            this.Size = new System.Drawing.Size(1014, 731);
            ((System.ComponentModel.ISupportInitialize)(this.gameContainer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUnitInStock;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchBtn_Game;
        private System.Windows.Forms.TextBox txtLowerPrice;
        private System.Windows.Forms.TextBox txtHigherPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button createGame;
        private System.Windows.Forms.Button deleteGame;
        private System.Windows.Forms.Button updateGame;
        private System.Windows.Forms.DataGridView gameContainer;
        private System.Windows.Forms.Label lbId;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnBuy;
        private System.Windows.Forms.Button btnSendPresent;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ComboBox txtCategory;
        private System.Windows.Forms.Label label4;
    }
}
