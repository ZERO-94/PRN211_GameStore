using BusinessObject.Models;
using DataAccess.repository;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace GameStoreWinApp
{
    public partial class frmGameLicense : UserControl
    {

        public User currentUser { get; set; }
        private GameLicenseRepository gameLicenseRepository;
        private GameRepository gameRepository;
        private UserRepository userRepository;
        public frmGameLicense()
        {
            InitializeComponent();
            gameLicenseRepository = new GameLicenseRepository();
            gameRepository = new GameRepository();
            userRepository = new UserRepository();
        }

        private delegate List<GameLicense> TableFilter(List<GameLicense> GameList);

        private void loadTableData(TableFilter filter)
        {
            DataTable gameLicenseTable = new DataTable();
            gameLicenseTable.Columns.Add("ID");
            gameLicenseTable.Columns.Add("UserID");
            gameLicenseTable.Columns.Add("Username");
            gameLicenseTable.Columns.Add("GameID");
            gameLicenseTable.Columns.Add("Game Name");
            gameLicenseTable.Columns.Add("Buy Time");
            gameLicenseTable.Columns.Add("Status");

            List<GameLicense> gameLicenses = new List<GameLicense>();
            if (currentUser.RoleId == 1)
            {
                gameLicenses = gameLicenseRepository.GetGameLicensesListByUserID(currentUser.Id, gameLicenseRepository.GetAllGameLicenses());
            }
            else
            {
                gameLicenses = gameLicenseRepository.GetAllGameLicenses();
            }
            //load data
            gameLicenses = gameLicenseRepository.GetAllGameLicenses();

            //filter in here
            List<GameLicense> gamesLicenseAfterFilter = filter(gameLicenses);

            foreach (GameLicense gameLicense in gamesLicenseAfterFilter)
            {
                gameLicenseTable.Rows.Add(gameLicense.Id, gameLicense.UserId, gameLicense.User.Username, gameLicense.GameId, gameLicense.Game.Name, gameLicense.BuyTime, gameLicense.Status);
            }

            gameLicenseContainer.DataSource = gameLicenseTable;

            txtGameID.DataSource = gameRepository.GetGameIdList();
            txtUserID.DataSource = userRepository.GetUserIdList();
        }
        private void searchBtn_GameLicense_Click(object sender, EventArgs e)
        {
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                //load table
                loadTableData(delegate (List<GameLicense> list)
                {
                    string? id = txtID.Text.Trim().Length <= 0 ? null : txtID.Text.Trim();
                    string? gameId = txtGameID.Text.Trim().Length <= 0 ? null : txtGameID.Text.Trim();
                    string? userId = txtUserID.Text.Trim().Length <= 0 ? null : txtUserID.Text.Trim();
                    DateTime? lowerDate = startDatePicker.Value;
                    DateTime? higherDate = endDatePicker.Value;

                    return gameLicenseRepository.SearchGameLicense(id, gameId, userId, lowerDate, higherDate);
                });
            };
        }

        public void load()
        {
            loadTableData(delegate (List<GameLicense> list)
            {
                return list; //get all
            });
        }

        private void frmGameLicense_Load(object sender, EventArgs e)
        {
            load();
        }

        private void refreshBtn_Click(object sender, EventArgs e)
        {
            load();
            txtGameID.Text = "";
            txtUserID.Text = "";
            txtID.Text = "";
        }
        private void deactivateGameBtn_Click(object sender, EventArgs e)
        {
            string updateId = (string)gameLicenseContainer.Rows[gameLicenseContainer.CurrentCell.RowIndex].Cells[0].Value;

            if (updateId != null)
            {
                if (gameLicenseRepository.DeactivateGameLicense(updateId))
                {
                    MessageBox.Show("Deactiveate succesfully");
                    load();
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }

            }
            else
            {
                MessageBox.Show("This Id isn't exist");
            }
        }

        private void activeBtn_Click(object sender, EventArgs e)
        {
            string updateId = (string)gameLicenseContainer.Rows[gameLicenseContainer.CurrentCell.RowIndex].Cells[0].Value;

            if (updateId != null)
            {
                if (gameLicenseRepository.ActivateGameLicense(updateId))
                {
                    MessageBox.Show("Activate succesfully");
                    load();
                }
                else
                {
                    MessageBox.Show("Update failed!");
                }

            }
            else
            {
                MessageBox.Show("This Id isn't exist");
            }
        }
    }

}

