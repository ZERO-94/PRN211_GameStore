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
    public partial class frmMyProfile : UserControl
    {
        private User user;
        private UserRepository userRepository;
        private string operationType = "update";
        public frmMyProfile()
        {
            userRepository = new UserRepository();
            InitializeComponent();
        }

        private void loadFormData()
        {
            //add data to form
            tbEmail.Text = user.Email;
            tbName.Text = user.Username;
        }

        private void update_Click(object sender, EventArgs e)
        {
            operationType = "update";
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                // update
                user.Username = tbName.Text.Trim();
                user.Email = tbEmail.Text.Trim();

                bool updateRes = userRepository.updateUser(user);
                if (updateRes) MessageBox.Show("Update successfully");
                else MessageBox.Show("Failed to update");

                user = userRepository.findById(user.Id);
                loadFormData();
            }
        }

        private void tbName_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("update"))
            {
                if (string.IsNullOrWhiteSpace(tbName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbName, "Name can't be blank");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbName, null);
                }
            }
        }

        private void frmProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("update"))
            {
                if (string.IsNullOrWhiteSpace(tbEmail.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbEmail, "Email can't be blank");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbEmail, null);
                }
            }
        }

        private void tbOldPassword_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("changePassword"))
            {
                if (string.IsNullOrWhiteSpace(tbOldPassword.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbOldPassword, "Old password can't be blank");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbOldPassword, null);
                }
            }
        }

        private void tbReConfirm_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("changePassword"))
            {
                if (string.IsNullOrWhiteSpace(tbReConfirm.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbReConfirm, "Re-confirm password can't be blank");

                }
                else if (!tbOldPassword.Text.Equals(tbReConfirm.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbReConfirm, "Re-confirm password must be the same as old password");
                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbReConfirm, null);
                }
            }
        }

        private void tbNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (operationType.Equals("changePassword"))
            {
                if (string.IsNullOrWhiteSpace(tbNewPassword.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(tbNewPassword, "New password can't be blank");

                }
                else
                {
                    e.Cancel = false;
                    errorProvider1.SetError(tbNewPassword, null);
                }
            }
        }

        private void changePassword_Click(object sender, EventArgs e)
        {
            operationType = "changePassword";
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                // change password

                bool changePasswordRes = userRepository.ChangePassword(user.Id, tbOldPassword.Text.Trim(), tbNewPassword.Text.Trim());
                if (changePasswordRes) MessageBox.Show("Change password successfully");
                else MessageBox.Show("Invalid old password!");

                user = userRepository.findById(user.Id);
                loadFormData();

                //rest form
                tbOldPassword.ResetText();
                tbReConfirm.ResetText();
                tbNewPassword.ResetText();
            }
        }

        public void load(User user)
        {
            this.user = user;

            if (user != null)
            {
                //init data
                username.Text = user.Username;

                //add data to form
                loadFormData();
            }
        }
    }
}
