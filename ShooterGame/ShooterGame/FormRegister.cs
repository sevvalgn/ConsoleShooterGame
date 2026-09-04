using MySqlConnector;
namespace ShooterGame
{
    public partial class FormRegister : Form
    {
        private FormLogin loginform;
        public FormRegister(FormLogin formLogin)
        {
            InitializeComponent();
            this.loginform = formLogin;
        }
        private void btnRegister_Click(object sender, EventArgs e)
        {
            if (txtboxPwd.Text == txtboxPwdAgain.Text)
            {
                string password = txtboxPwd.Text;
                string playerName = txtboxName.Text;
                if (!string.IsNullOrEmpty(playerName) && !string.IsNullOrEmpty(password))
                {
                    MySqlConnection con = new MySqlConnection("server=localhost;Database=leaderboard;Uid=root;Pwd=PASSWORD");

                    try
                    {
                        con.Open();
                        string sql = "SELECT * FROM namepassword WHERE name = @name";
                        MySqlCommand command = new MySqlCommand(sql, con);
                        command.Parameters.AddWithValue("@name", playerName);
                        MySqlDataReader reader = command.ExecuteReader();
                        if (reader.Read())
                        {
                            reader.Close();

                            MessageBox.Show("Account for " + playerName + " already exist. Please enter a different name.");
                        }
                        else
                        {
                            reader.Close();
                            string sqll = "INSERT INTO namepassword (name,password)" + "VALUES(@name, @password)";
                            MySqlCommand cmd = new MySqlCommand(sqll, con);
                            cmd.Parameters.AddWithValue("@name", playerName);
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.ExecuteNonQuery();
                            MessageBox.Show("Account created successfully.");
                            this.Hide();
                            loginform.Show();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    finally
                    {
                        con.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Please fill in required fields.");
                }
            }
            else
            {
                MessageBox.Show("The passwords do not match. Please try again.");
            }
        }
        private void btnBacktoLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            loginform.Show();
        }
    }
}
