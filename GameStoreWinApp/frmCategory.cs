using BusinessObject.Models;
using DataAccess.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GameStoreWinApp
{
    public partial class frmCategory : UserControl
    {
        private GameRepository gameRepository;
        private CategoryRepository categoryReposity;
        public frmCategory()
        {
            InitializeComponent();
            gameRepository = new GameRepository();
            categoryReposity = new CategoryRepository();
        }

        public void load()
        {
            DataTable categoryTable = new DataTable();
            categoryTable.Columns.Add("ID");
            categoryTable.Columns.Add("Name");
            categoryTable.Columns.Add("Description");


            //load data
            List<Category> categories = categoryReposity.GetAllCategories();

            //filter in here
            //List<Category> categoriesAfterFilter = filter(categories);

            foreach (Category category in categories)
            {
                categoryTable.Rows.Add(category.Id, category.Name, category.Description);
            }

            categoryContainer.DataSource = categoryTable;
        }

        private void frmCategory_Load(object sender, EventArgs e)
        {

        }

        private void createBtn_Click(object sender, EventArgs e)
        {
            string searchId = txtID.Text.Trim();
            string searchName = txtName.Text.Trim();
            string searchDescription = txtDescription.Text.Trim();
            if (String.IsNullOrEmpty(searchId) || String.IsNullOrWhiteSpace(searchId) ||
                String.IsNullOrEmpty(searchName) || String.IsNullOrWhiteSpace(searchName) ||
                String.IsNullOrEmpty(searchDescription) || String.IsNullOrWhiteSpace(searchDescription))
            {
                MessageBox.Show("Please enter all fields");
            }
            else
            {
                if (categoryReposity.GetCategoryById(searchId) == null)
                {

                    Category category = new Category()
                    {
                        Id = searchId,
                        Name = searchName,
                        Description = searchDescription,
                    };

                    categoryReposity.CreateCategory(category);
                    MessageBox.Show("Create successfully");
                    load();
                }
                else
                {
                    MessageBox.Show("This ID is exist");
                }
            }
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            string searchId = txtID.Text.Trim();
            string searchName = txtName.Text.Trim();
            string searchDescription = txtDescription.Text.Trim();
            if (String.IsNullOrEmpty(searchId) || String.IsNullOrWhiteSpace(searchId) ||
                String.IsNullOrEmpty(searchName) || String.IsNullOrWhiteSpace(searchName) ||
                String.IsNullOrEmpty(searchDescription) || String.IsNullOrWhiteSpace(searchDescription))
            {
                MessageBox.Show("Please enter all fields");
            }
            else
            {
                if (categoryReposity.GetCategoryById(searchId) != null)
                {

                    Category category = new Category()
                    {
                        Id = searchId,
                        Name = searchName,
                        Description = searchDescription,
                    };

                    categoryReposity.UpdateCategory(category);
                    MessageBox.Show("Update successfully");
                    load();
                }
                else
                {
                    MessageBox.Show("This ID isn't exist");
                }
            }
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            try
            {
                string deleteId = (string)categoryContainer.Rows[categoryContainer.CurrentCell.RowIndex].Cells[0].Value;

                if (deleteId != null)
                {
                    bool deleteRes = categoryReposity.DeleteCategory(deleteId);
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
                load();
            }
        }
    }
}
