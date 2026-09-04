using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ShooterGame
{
    public partial class FormLeaderboard : Form
    {
        private FormMenu menuForm;

        private void FormLeaderboard_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"Resources\BackgroundLeaderboard.png");
        }

        private string playerName;
        public FormLeaderboard(FormMenu menu,string playerName)
        {
            this.playerName = playerName;

            InitializeComponent();
            this.menuForm = menu;

            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=leaderboard;Uid=root;Pwd=PASSWORD");
            try
            {
                connection.Open();
                string sql = "SELECT * FROM leaderboard ORDER BY score DESC LIMIT 10";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    if (reader["name"].ToString() == playerName)
                    {
                        lblLeaderboard.Text += ">>";
                    }
                    lblLeaderboard.Text += reader["name"].ToString() + " - " + reader["charactertype"].ToString() + " - " + reader["score"].ToString() + Environment.NewLine;
                }
                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }

        private void btnReturnMenu_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm.Show();
        }

        private void picFeedback_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormFeedback feedback = new FormFeedback(menuForm, playerName);
            feedback.Show();
        }
    }
}
