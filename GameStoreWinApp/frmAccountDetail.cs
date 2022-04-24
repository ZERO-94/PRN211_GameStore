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
    public partial class frmAccountDetail : Form
    {

        private string operationType;
        private User user;
        private IUserRepository userRepository;
        private IRoleRepository roleRepository;
        private List<Role> roleList;

        public frmAccountDetail(string operationType, User updateUser)
        {
            this.operationType = operationType;
            user = updateUser;
            roleRepository = new RoleRepository();
            userRepository = new UserRepository();

            InitializeComponent();
            btnCancel.CausesValidation = false;
        }

        public User GetUserObject()
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {

                if (operationType.Equals("create"))
                {
                    User newUser = new User()
                    {
                        Id = tbId.Text.Trim(),
                        Username = tbUsername.Text.Trim(),
                        Email = tbEmail.Text.Trim(),
                        Password = tbPassword.Text.Trim(),
                        Role = (Role)cbRole.SelectedItem
                    };
                    return newUser;
                }
                else if (operationType.Equals("update"))
                {
                    user.Username = tbUsername.Text.Trim();
                    user.Email = tbEmail.Text.Trim();
                    user.Password = tbPassword.Text.Trim();
                    user.Role = (Role)cbRole.SelectedItem;

                    return user;
                }
                else
                {
                    return null;
                }
            }

            return null;
        }

        private void tbId_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("create"))
            {
                int result;
                if (string.IsNullOrWhiteSpace(tbId.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbId, "Id can't be blank!");
                }
                else if (userRepository.findById(tbId.Text.Trim()) != null)
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbId, "Id can't be duplicated!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbId, null);
                }
            }
        }

        private void tbUsername_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbUsername.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbUsername, "Name can't be blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbUsername, null);
            }
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Email can't be blank!");
            }
            else if (!tbEmail.Text.Trim().Equals(user.Email) && userRepository.findByEmail(tbEmail.Text.Trim()) != null)
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Email already exists!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbEmail, null);
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("create"))
            {
                if (string.IsNullOrWhiteSpace(tbPassword.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbPassword, "Email can't be blank!");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbPassword, null);
                }
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
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

        private void frmAccountDetail_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAccountDetail_Load(object sender, EventArgs e)
        {
            //load role type
            roleList = roleRepository.GetAllRoles();

            cbRole.DataSource = roleList;
            cbRole.ValueMember = "Id";
            cbRole.DisplayMember = "RoleName";


            if (operationType.Equals("create"))
            {
                btnActiveAndDeactive.Hide();

                //show all
                lbOperation.Text = "Create new user";
            }
            else if (operationType.Equals("update"))
            {

                if(user.Status)
                {
                    btnActiveAndDeactive.Text = "Deactive";
                } else
                {
                    btnActiveAndDeactive.Text = "Active";
                }

                //hide id and password
                lbOperation.Text = "Update user with ID: " + user.Id;
                tbId.Hide();
                lbId.Hide();
                tbPassword.Hide();
                lbPassword.Hide();

                //load data
                tbId.Text = user.Id;
                tbEmail.Text = user.Email;
                tbUsername.Text = user.Username;
                cbRole.SelectedItem = user.Role;
                tbPassword.Text = user.Password;
            }
        }

        private void btnActiveAndDeactive_Click(object sender, EventArgs e)
        {
            if (user.Status)
            {
                bool deactiveRes = userRepository.DeactiveAccount(user.Id);
                if (deactiveRes) MessageBox.Show("Deactive account successfully");
                else MessageBox.Show("Deactive account failed");
                user = userRepository.findById(user.Id);
                btnActiveAndDeactive.Text = "Active";
            }
            else
            {
                bool deactiveRes = userRepository.ActiveAccount(user.Id);
                if (deactiveRes) MessageBox.Show("Active account successfully");
                else MessageBox.Show("Active account failed");
                user = userRepository.findById(user.Id);
                btnActiveAndDeactive.Text = "Deactive";
            }
        }
    }
}
