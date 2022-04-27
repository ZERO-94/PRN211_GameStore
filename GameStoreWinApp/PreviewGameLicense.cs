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
    public partial class PreviewGameLicense : Form
    {

        private Game game;
        private User user;
        private IUserRepository userRepository = new UserRepository();
        private IGameLicenseRepository gameLicenseRepository = new GameLicenseRepository();

        public PreviewGameLicense(Game game, User user)
        {
            this.game = game;
            this.user = user;
            InitializeComponent();
        }

        private void tbReceiverEmail_Validating(object sender, CancelEventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbReceiverEmail.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(tbReceiverEmail, "Receiver name must not be blank!");
            } else if(userRepository.findByEmail(tbReceiverEmail.Text.Trim()) != null)
            {
                e.Cancel= true;
                errorProvider1.SetError(tbReceiverEmail, "Invalid Receiver Email!");
            } else
            {
                e.Cancel = false;
                errorProvider1.SetError(tbReceiverEmail, null);
            }
        }

        private void PreviewGameLicense_Load(object sender, EventArgs e)
        {

            lbGameName.Text = game.Name;
            lbGameCategory.Text = game.Category.Name;
            lbActiveDate.Text = new DateTime().ToString();

            if(user == null) //gift
            {
                lbBuyerEmail.Visible = false;
                lbBuyerNameHeader.Visible = false;
            } else //buy game
            {
                lbReceiverHeader.Visible = false;
                tbReceiverEmail.Visible = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if(ValidateChildren(ValidationConstraints.Visible))
            {
                this.DialogResult = DialogResult.OK;
            } else
            {
                this.DialogResult = DialogResult.None;
            }
        }

        public GameLicense GetGameLicenseObject()
        {
            if (ValidateChildren(ValidationConstraints.Visible))
            {

                List<int> idNumber = gameLicenseRepository.GetAllGameLicenses().ConvertAll(x => int.Parse(x.Id.Replace("GL", "")));

                var maxNumber = idNumber.Max();

                GameLicense gameLicense = new GameLicense()
                {
                    Id = "GL" + (maxNumber + 1).ToString(),
                    Game = game,
                    Status = true
                };

                if(user == null) //gift
                {
                    User receiver = userRepository.findByEmail(tbReceiverEmail.Text.Trim());
                    gameLicense.User = receiver;
                } else
                {
                    gameLicense.User = user;
                }
                
                return gameLicense;
            }

            return null;
        }
    }
}
