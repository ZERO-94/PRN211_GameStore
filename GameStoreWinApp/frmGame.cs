using BusinessObject.Models;
using DataAccess.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GameStoreWinApp
{
    public partial class frmGame : UserControl
    {
        private GameRepository gameRepository;
        private CategoryRepository categoryReposity;
        private frmGameForAdmin formGameForAdmin;
        private IGameLicenseRepository gameLicenseRepository;
        private User user;

        public frmGame()
        {
            InitializeComponent();
            gameRepository = new GameRepository();
            categoryReposity = new CategoryRepository();
            gameLicenseRepository = new GameLicenseRepository();
        }

        public void SetUser(User user)
        {
            this.user = user;
            if (user.RoleId == 1)
            {
                lbId.Visible = false;
                txtID.Visible = false;

                createGame.Visible = false;
                updateGame.Visible = false;
                deleteGame.Visible = false;

                btnBuy.Visible = true;
                btnSendPresent.Visible = true;
            }
            else
            {
                lbId.Visible = true;
                txtID.Visible = true;

                createGame.Visible = true;
                updateGame.Visible = true;
                deleteGame.Visible = true;

                btnBuy.Visible = false;
                btnSendPresent.Visible = false;
            }
            load();
        }

        private delegate List<Game> TableFilter(List<Game> GameList);

        private void loadTableData(TableFilter filter)
        {
            DataTable gameTable = new DataTable();
            gameTable.Columns.Add("ID");
            gameTable.Columns.Add("Category");
            gameTable.Columns.Add("Name");
            gameTable.Columns.Add("Description");
            gameTable.Columns.Add("Price");
            gameTable.Columns.Add("Status");


            //load data
            List<Game> games = gameRepository.GetAllGames();

            //filter in here
            List<Game> gamesAfterFilter = filter(games);

            foreach (Game game in gamesAfterFilter)
            {
                String gameCategory = game.CategoryId;
                gameTable.Rows.Add(game.Id, categoryReposity.GetCategoryById(gameCategory).Name, game.Name, game.Description, game.Price, game.Status);
            }

            gameContainer.DataSource = gameTable;
            txtCategory.DataSource = categoryReposity.getCategoryNameList();
            txtCategory.Text = "";
        }

        private void searchBtn_Game_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //load table
                loadTableData(delegate (List<Game> list)
                {
                    string? searchId = txtID.Text.Trim().Length <= 0 ? null : txtID.Text.Trim();
                    string? searchName = txtName.Text.Trim().Length <= 0 ? null : txtName.Text.Trim();
                    string? searchCategory = txtCategory.Text.Trim().Length <= 0 ? null : txtCategory.Text;
                    decimal? lowerPrice = txtLowerPrice.Text.Trim().Length <= 0 ? null : decimal.Parse(txtLowerPrice.Text.Trim());
                    decimal? higherPrice = txtHigherPrice.Text.Trim().Length <= 0 ? null : decimal.Parse(txtHigherPrice.Text.Trim());

                    return gameRepository.SearchGame(searchId, searchName, searchCategory, lowerPrice, higherPrice);
                });
            }
        }

        public void load()
        {
            loadTableData(delegate (List<Game> list)
            {
                return list; //get all
            });
        }

        private void createGame_Click(object sender, EventArgs e)
        {
            try
            {
                formGameForAdmin = new frmGameForAdmin("create", null);

                if (formGameForAdmin.ShowDialog() == DialogResult.OK)
                {
                    //create Game
                    Game gameObject = formGameForAdmin.GetGameObject();

                    bool createRes = gameRepository.CreateGame(gameObject);
                    if (createRes) MessageBox.Show("Create successfully");
                    else MessageBox.Show("Failed to create");
                }
            }
            finally
            {
                loadTableData(delegate (List<Game> list)
                {
                    return list;
                });
            }

        }

        private void updateGame_Click(object sender, EventArgs e)
        {
            try
            {
                string updateId = (string)gameContainer.Rows[gameContainer.CurrentCell.RowIndex].Cells[0].Value;

                if (updateId != null)
                {
                    Game updateGame = gameRepository.GetGameById(updateId);
                    frmGameForAdmin frmGameForAdmin = new frmGameForAdmin("update", updateGame);

                    if (frmGameForAdmin.ShowDialog() == DialogResult.OK)
                    {
                        //create Game
                        Game GameObject = frmGameForAdmin.GetGameObject();

                        bool updateRes = gameRepository.UpdateGame(GameObject);
                        if (updateRes) MessageBox.Show("Update successfully");
                        else MessageBox.Show("Failed to update");
                    }
                }
            }
            finally
            {
                loadTableData(delegate (List<Game> list)
                {
                    return list;
                });
            }
        }

        private void deleteGame_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteId = (string)gameContainer.Rows[gameContainer.CurrentCell.RowIndex].Cells[0].Value;

                if (deleteId != null)
                {
                    bool deleteRes = gameRepository.DeleteGame(deleteId);
                    if (deleteRes)
                    {
                        MessageBox.Show("Delete successfully");
                    }
                    else
                    {
                        MessageBox.Show("Failed to delete");
                    }
                }
                else
                {
                    MessageBox.Show("There is problem, try again!");
                }
            }
            finally
            {
                loadTableData(delegate (List<Game> list)
                {
                    return list;
                });
            }
        }

        private void txtLowerPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            decimal result;
            if (String.IsNullOrEmpty(txtLowerPrice.Text) || String.IsNullOrWhiteSpace(txtLowerPrice.Text))
            {

            }
            else
            {
                if (!decimal.TryParse(txtLowerPrice.Text.Trim(), out result))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtLowerPrice, "Price must be decimal!");
                }
                else if (decimal.Parse(txtLowerPrice.Text.Trim()) < 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtLowerPrice, "Price must not be negative number!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtLowerPrice, null);
                }
            }

        }

        private void txtHigherPrice_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            decimal result;
            if (String.IsNullOrEmpty(txtHigherPrice.Text) || String.IsNullOrWhiteSpace(txtHigherPrice.Text))
            {

            }
            else
            {
                if (!decimal.TryParse(txtHigherPrice.Text.Trim(), out result))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtHigherPrice, "Price must be decimal!");
                }
                else if (decimal.Parse(txtHigherPrice.Text.Trim()) < 0)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtHigherPrice, "Price must not be negative number!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtHigherPrice, null);
                }
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            try
            {
                string updateId = (string)gameContainer.Rows[gameContainer.CurrentCell.RowIndex].Cells[0].Value;

                if (gameLicenseRepository.GetGameLicenseByUserIDAndGameID(user.Id, updateId) != null)
                {
                    MessageBox.Show("You already have this game!");
                    return;
                }

                if (updateId != null)
                {
                    Game buyGame = gameRepository.GetGameById(updateId);
                    PreviewGameLicense previewGameLicense = new PreviewGameLicense(buyGame, user);

                    if (previewGameLicense.ShowDialog() == DialogResult.OK)
                    {
                        GameLicense GameLicenseObject = previewGameLicense.GetGameLicenseObject();

                        bool createRes = gameLicenseRepository.CreateGameLicense(GameLicenseObject);
                        if (createRes) MessageBox.Show("Create successfully");
                        else MessageBox.Show("Failed to create");
                    }
                }
            }
            finally
            {
                loadTableData(delegate (List<Game> list)
                {
                    return list;
                });
            }
        }

        private void btnSendPresent_Click(object sender, EventArgs e)
        {
            try
            {
                string updateId = (string)gameContainer.Rows[gameContainer.CurrentCell.RowIndex].Cells[0].Value;

                if (updateId != null)
                {
                    Game buyGame = gameRepository.GetGameById(updateId);
                    PreviewGameLicense previewGameLicense = new PreviewGameLicense(buyGame, null);

                    if (previewGameLicense.ShowDialog() == DialogResult.OK)
                    {
                        GameLicense GameLicenseObject = previewGameLicense.GetGameLicenseObject();

                        bool createRes = gameLicenseRepository.CreateGameLicense(GameLicenseObject);
                        if (createRes) MessageBox.Show("Create successfully");
                        else MessageBox.Show("Failed to create");
                    }
                }
            }
            finally
            {
                loadTableData(delegate (List<Game> list)
                {
                    return list;
                });
            }
        }
    }
}
