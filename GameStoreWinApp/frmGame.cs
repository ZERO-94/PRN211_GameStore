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

        public frmGame()
        {
            InitializeComponent();
            gameRepository = new GameRepository();
            categoryReposity = new CategoryRepository();
        }

        private delegate List<Game> TableFilter(List<Game> productList);

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
            };
        }

        public void load()
        {
            loadTableData(delegate (List<Game> list)
            {
                return list; //get all
            });
        }


        private void frmGame_Load(object sender, EventArgs e)
        {
            load();
        }

        private void createGame_Click(object sender, EventArgs e)
        {
            try
            {
                formGameForAdmin = new frmGameForAdmin("create", null);

                if (formGameForAdmin.ShowDialog() == DialogResult.OK)
                {
                    //create product
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
    }
}
