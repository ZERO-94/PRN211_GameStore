using BusinessObject.Models;
using DataAccess.repository;
using System;
using System.Windows.Forms;

namespace GameStoreWinApp
{
    public partial class frmConfirm : Form
    {
        private string operation;
        private Category category;
        private CategoryRepository categoryRepository;
        private GameRepository gameRepository;
        public frmCategory formCategory;

        public frmConfirm(frmCategory form, Category category, string operation)
        {
            InitializeComponent();
            this.category = category;
            this.operation = operation;
            formCategory = form;
            categoryRepository = new CategoryRepository();
            gameRepository = new GameRepository();
        }



        private void yesBtn_Click(object sender, EventArgs e)
        {
            if (operation == "delete")
            {
                var gameList = gameRepository.GetFilteredGameByCategory(category.Id, gameRepository.GetAllGames());
                if (categoryRepository.DeleteCategory(category) && gameList.Count == 0)
                {
                    MessageBox.Show("Delete successfully!");
                }
                else
                {
                    string errorMsg = "";
                    foreach (Game game in gameList)
                    {
                        errorMsg += game.Name + "\n";
                    }
                    MessageBox.Show($"Delete failed!\n Game: {errorMsg}");
                }
            }
            if (operation == "update")
            {
                if (categoryRepository.UpdateCategory(category))
                {
                    MessageBox.Show("Update successfully");
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }
            }
            this.Close();
        }

        private void noBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmConfirm_Load(object sender, EventArgs e)
        {
            label1.Text = "";
            if (operation == "delete")
            {
                operationLabel.Text = "You must delete all product with this ID \nto perform this action";
            }
            else
            {
                operationLabel.Text = "This action will affect all these products!";
            }

        }
    }
}
