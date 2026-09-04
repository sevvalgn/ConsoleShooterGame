using MySqlConnector;

namespace ShooterGame
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"Resources\BackgroundLogin.png");
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string playerName = txtboxName.Text;
            string password = txtboxPwd.Text;
            if (!string.IsNullOrEmpty(playerName) && !string.IsNullOrEmpty(password))
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=leaderboard;Uid=root;Pwd=PASSWORD");
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM namepassword WHERE name = @name";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@name", playerName);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (!reader.Read())
                    {
                        reader.Close();
                        MessageBox.Show("No account for " + playerName + " please register.");
                    }
                    else
                    {
                        if (password == reader["password"].ToString())
                        {
                            //hide the login page and show the menu page
                            this.Hide();
                            FormMenu menu = new FormMenu(playerName);
                            menu.Show();
                        }
                        else
                        {
                            MessageBox.Show("Unvalid password, please try again.");
                            return;
                        }
                        reader.Close();
                    }
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
            else
            {
                MessageBox.Show("Please fill in required fields.");
            }
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            this.Hide();
            FormRegister register = new FormRegister(this);
            register.Show();
        }
    }
}
