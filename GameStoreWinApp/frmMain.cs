using BusinessObject.Models;
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
            if(user.RoleId == 2) //is Admin
            {
                myProfileMenuItem.Enabled = false;
                accountManagementMenuItem.Visible = true;

            } else if (user.RoleId == 1) //is Customer
            {
                myProfileMenuItem.Enabled = true;
                accountManagementMenuItem.Visible = false;
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmLogin.Show();
            user = null;
        }

        private void myProfileMenuItem_Click(object sender, EventArgs e)
        {
            frmMyProfile1.Show();
            frmMyProfile1.load(user);
        }
    }
}
