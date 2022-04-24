using BusinessObject.Models;
using DataAccess.repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameStoreWinApp
{
    public partial class frmAccount : UserControl
    {
        private User User;
        private UserRepository userRepository;
        private frmLogin loginForm;

        public frmAccount()
        {
            userRepository = new UserRepository();
            InitializeComponent();
        }

        private delegate List<User> TableFilter(List<User> UserList);

        private void loadTableData(TableFilter filter)
        {
            DataTable UserTable = new DataTable();
            UserTable.Columns.Add("ID");
            UserTable.Columns.Add("Email");
            UserTable.Columns.Add("Name");
            UserTable.Columns.Add("Role");
            UserTable.Columns.Add("Active");

            //load data
            List<User> Users = userRepository.findAll();

            //filter in here
            List<User> UsersAfterFilter = filter(Users);

            foreach (User User in UsersAfterFilter)
            {
                UserTable.Rows.Add(User.Id, User.Email, User.Username, User.Role.RoleName, User.Status);
            }

            userDataGrid.DataSource = UserTable;
        }

        private void logout_Click(object sender, EventArgs e)
        {
            //logout
            loginForm.Show();
            User = null;

            this.Hide();
        }

        private void createUser_Click(object sender, EventArgs e)
        {
            try
            {
                frmAccountDetail frmUserForUser = new frmAccountDetail("create", null);

                if (frmUserForUser.ShowDialog() == DialogResult.OK)
                {
                    //create User
                    User userObject = frmUserForUser.GetUserObject();

                    bool createRes = userRepository.createUser(userObject);
                    if (createRes) MessageBox.Show("Create successfully");
                    else MessageBox.Show("Failed to create");
                }
            }
            finally
            {
                loadTableData(delegate (List<User> list)
                {
                    return list;
                });
            }
        }

        private void updateUser_Click(object sender, EventArgs e)
        {
            try
            {
                string updateId = (string)userDataGrid.Rows[userDataGrid.CurrentCell.RowIndex].Cells[0].Value;

                if (updateId != null)
                {
                    User updateUser = userRepository.findById(updateId);
                    frmAccountDetail frmUserForUser = new frmAccountDetail("update", updateUser);

                    if (frmUserForUser.ShowDialog() == DialogResult.OK)
                    {
                        //create User
                        User userObject = frmUserForUser.GetUserObject();

                        bool updateRes = userRepository.updateUser(userObject);
                        if (updateRes) MessageBox.Show("Update successfully");
                        else MessageBox.Show("Failed to update");
                    }
                }
            }
            finally
            {
                loadTableData(delegate (List<User> list)
                {
                    return list;
                });
            }
        }

        public void load()
        {
            if (this.Visible == true)
            {
                loadTableData(delegate (List<User> list)
                {
                    return list; //get all
                });
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {

        }
    }
}
