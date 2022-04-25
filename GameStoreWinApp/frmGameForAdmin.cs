using BusinessObject.Models;
using DataAccess.repository;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GameStoreWinApp
{
    public partial class frmGameForAdmin : Form
    {
        private string operationType;
        private Game game;
        private GameRepository gameRepository;
        private CategoryRepository categoryRepository;
        public frmGameForAdmin(string operationType, Game updateGame)
        {
            this.operationType = operationType;
            game = updateGame;
            InitializeComponent();
            gameRepository = new GameRepository();
            categoryRepository = new CategoryRepository();
        }

        public Game GetGameObject()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                string categoryId = categoryRepository.GetCategoryIdByName(txtCategory.Text).Id;

                if (operationType.Equals("create"))
                {
                    Game newGame = new Game()
                    {
                        Id = txtId.Text.Trim(),
                        CategoryId = categoryRepository.GetCategoryById(categoryId).Id,
                        Name = txtName.Text.Trim(),
                        Description = txtDescription.Text.Trim(),
                        Status = Convert.ToBoolean(txtStatus.Text),
                        Price = Convert.ToInt32(txtPrice.Text),
                    };

                    return newGame;
                }
                else if (operationType.Equals("update"))
                {
                    game.CategoryId = categoryRepository.GetCategoryById(categoryId).Id;
                    game.Name = txtName.Text.Trim();
                    game.Description = txtDescription.Text.Trim();
                    game.Status = Convert.ToBoolean(txtStatus.Text);
                    game.Price = Convert.ToInt32(txtPrice);

                    return game;
                }
                else
                {
                    return null;
                }
            }

            return null;
        }

        private void addBtn_Game_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        private void quitBtn_Game_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmGameForAdmin_Load(object sender, EventArgs e)
        {
            //load category

            BindingSource bindingSource = new BindingSource();
            bindingSource.DataSource = categoryRepository.getCategoryNameList();
            txtCategory.DataSource = bindingSource;
            txtStatus.Text = "true";


            if (operationType.Equals("create"))
            {
                //show all
                lbOperation.Text = "CREATE GAME";
            }
            else if (operationType.Equals("update"))
            {
                //hide id and password
                lbOperation.Text = "UPDATE GAME: ID  " + game.Id;
                txtId.ReadOnly = true;

                //load data
                txtId.Text = game.Id;
                txtCategory.SelectedItem = categoryRepository.GetCategoryById(game.CategoryId);
                txtName.Text = game.Name;
                txtDescription.Text = game.Description;
                txtPrice.Text = game.Price.ToString();
                txtStatus.Text = game.Status.ToString();
            }
        }

        private void txtId_Validating_1(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("create"))
            {
                int result;
                if (string.IsNullOrWhiteSpace(txtId.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtId, "Id can't be blank!");
                }
                else if (gameRepository.GetGameById(txtId.Text.Trim()) != null)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(txtId, "Id can't be duplicated!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(txtId, null);
                }
            }
        }

        private void txtDescription_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescription.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtDescription, "Name can't be blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtDescription, null);
            }
        }

        private void txtPrice_Validating_1(object sender, CancelEventArgs e)
        {
            decimal result;
            if (string.IsNullOrWhiteSpace(txtPrice.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrice, "Price can't be blank!");
            }
            else if (!decimal.TryParse(txtPrice.Text.Trim(), out result))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrice, "Price must be decimal!");
            }
            else if (decimal.Parse(txtPrice.Text.Trim()) < 0)
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPrice, "Price must not be negative number!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtPrice, null);
            }
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtName, "Name can't be blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtName, null);
            }
        }
    }
}

