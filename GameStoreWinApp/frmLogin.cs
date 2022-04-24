
using BusinessObject.Models;
using DataAccess.repository;
using GameStoreWinApp;
using System;
using System.ComponentModel;
using System.Windows.Forms;

namespace GameStoreWinApp
{
    public partial class frmLogin : Form
    {
        private IUserRepository userRepository;
        public frmLogin()
        {
            userRepository = new UserRepository();
            InitializeComponent();
        }

        private void tbEmail_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbEmail.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbEmail, "Email can't be blank!");
            } else
            {
                e.Cancel= false;
                errorProvider1.SetError(tbEmail,"");
            }
        }

        private void tbPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbPassword, "Password can't be blank!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbPassword, "");
            }
        }

        private void login_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Enabled))
            {
                
                User authenticatedUser = userRepository.CheckLogin(tbEmail.Text.Trim(), tbPassword.Text.Trim());
                if (authenticatedUser != null)
                {
                    //redirect to new screen
                    RedirectToForm(authenticatedUser);
                } else
                {
                    MessageBox.Show("Invalid account!");
                }
            }
        }

        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void RedirectToForm(User user)
        {
            tbEmail.ResetText();
            tbPassword.ResetText();
            this.Hide();

            frmMain frmMain = new frmMain(user, this);
            this.FormClosed += (s, e) => frmMain.Close();
            frmMain.FormClosed += (s, e) => this.Close();
            frmMain.Show();

        }
    }
}
