using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySqlConnector;

namespace ShooterGame
{
    public partial class FormFeedback : Form
    {
        private string playerName;
        private FormMenu menuForm;
        public FormFeedback(FormMenu menuForm, string playerName)
        {
            InitializeComponent();
            this.menuForm = menuForm;
            this.playerName = playerName;
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            string feedback = txtboxfeedback.Text;
            if (!string.IsNullOrWhiteSpace(feedback))
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=leaderboard;Uid=root;Pwd=PASSWORD");
                try
                {
                    connection.Open();
                    string sql = "INSERT INTO feedback (name, feedback) VALUES(@name, @feedback)";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    cmd.Parameters.AddWithValue("@name", playerName);
                    cmd.Parameters.AddWithValue("@feedback", feedback);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Feedback submitted successfully.");
                    this.Hide();
                    menuForm.Show();
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuForm.Show();
        }
    }
}
