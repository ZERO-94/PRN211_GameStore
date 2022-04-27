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
        frmConfirm formConfirm;
        public string operation;
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
            operation = "update";
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
                    formConfirm = new frmConfirm(this, category, operation);
                    formConfirm.ShowDialog();
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
            operation = "delete";
            try
            {
                string deleteId = (string)categoryContainer.Rows[categoryContainer.CurrentCell.RowIndex].Cells[0].Value;

                if (deleteId != null)
                {
                    var category = categoryReposity.GetCategoryById(deleteId);
                    formConfirm = new frmConfirm(this, category, operation);
                    formConfirm.ShowDialog();
                    load();
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
