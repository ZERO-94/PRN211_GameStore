using BusinessObject.Models;
using System;
using System.Windows.Forms;

namespace GameStoreWinApp
{
    public partial class frmMain : Form
    {

        private User user;
        private frmLogin frmLogin;

        public frmMain(User user, frmLogin frmLogin)
        {
            this.frmLogin = frmLogin;
            this.user = user;
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            if (user.RoleId == 2) //is Admin
            {
                myProfileMenuItem.Visible = false;
                accountManagementMenuItem.Visible = true;

            }
            else if (user.RoleId == 1) //is Customer
            {
                myProfileMenuItem.Visible = true;
                accountManagementMenuItem.Visible = false;
            }
            frmGame1.Show();
            frmGame1.SetUser(user);
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
            user = null;
        }

        private void myProfileMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount1.Hide();
            frmGame1.Hide();
            frmGameLicense1.Hide();
            frmMyProfile1.Show();
            frmMyProfile1.load(user);
        }

        private void accountManagementMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount1.Show();
            frmAccount1.load();
            frmGame1.Hide();
            frmGameLicense1.Hide();
        }


        private void gameLicensesMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount1.Hide();
            frmGame1.Hide();
            frmGameLicense1.Show();
            frmGame1.load();
        }

        private void frmAccount1_Load(object sender, EventArgs e)
        {

        }

        private void gameMenuItem_Click(object sender, EventArgs e)
        {
            frmAccount1.Hide();
            frmGameLicense1.Hide();
            frmGame1.Show();
            frmGame1.SetUser(user);
            frmGame1.load();
        }
    }
}
