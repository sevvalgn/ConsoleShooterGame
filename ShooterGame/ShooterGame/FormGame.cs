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
    public partial class FormGame : Form
    {
        string playerName;
        private FormMenu menuForm;
        private Player player;
        private Player Enemy = new Enemy("Enemy", 20, 30);
        private List<Image> playerImages;
        private List<Image> enemyImages;
        private List<Image> playerHpImages;
        private List<Image> enemyHpImages;
        private int playerHpFrame = 0;
        private decimal enemyHpFrame = 0;
        private int playerScore = 0;
        private bool isJumping;
        private int jumpPhase = 0;
        private bool isPlayerDamaged;
        private int playerDamagedTime = 0;
        private bool isEnemyDamaged;
        private int enemyDamagedTime = 0;


        public FormGame(FormMenu menuForm, string playerName, Player player)
        {
            InitializeComponent();

            this.menuForm = menuForm;
            this.playerName = playerName;
            this.player = player;
            playerImages = player.GetPlayerImage();
            enemyImages = Enemy.GetPlayerImage();
            playerHpImages = player.GetHPBarImage();
            enemyHpImages = Enemy.GetHPBarImage();
            timer1.Tick -= timer1_Tick;
            timer1.Tick += timer1_Tick;
            KeyDown -= FormGame_KeyDown;
            KeyDown += FormGame_KeyDown;
            this.DoubleBuffered = true;

        }
        private void FormGame_Load(object sender, EventArgs e)
        {
            this.BackgroundImage = Image.FromFile(@"Resources\BackgroundGame1.png");
            lblResult.Visible = false;
            lblScoreResult.Visible = false;
            picEnemyBullet.Visible = false;
            picPlayerBullet.Visible = false;

            picPlayer.Image = playerImages.ElementAt(0);
            picEnemy.Image = enemyImages.ElementAt(0);
            picPlayerHP.Image = playerHpImages.ElementAt(0);
            picEnemyHP.Image = enemyHpImages.ElementAt(0);
            picPlayerBullet.Image = player.GetBulletImage();
            picEnemyBullet.Image = Enemy.GetBulletImage();
            timer1.Interval = 100;
            timer1.Start();
        }
        private void FormGame_KeyDown(object sender, KeyEventArgs a)
        {
            if (a.KeyCode == Keys.Space && !isJumping)
            {
                picPlayer.Image = playerImages.ElementAt(5);
                picPlayerBullet.Visible = true;
            }
            else if (a.KeyCode == Keys.Up)
            {
                isJumping = true;
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            int enemyAttack = Enemy.Attack();
            int playerAttack = player.Attack();
            if(isJumping)
            {
                jumpPhase++;
                if (jumpPhase == 1)
                {
                    picPlayer.Image = playerImages.ElementAt(1);
                    picPlayer.Top -= 150;
                }
                else if(jumpPhase == 2)
                {
                    picPlayer.Image = playerImages.ElementAt(2);
                    picPlayer.Top -= 150;
                }
                else if(jumpPhase == 11)
                {
                    picPlayer.Image = playerImages.ElementAt(3);
                    picPlayer.Top += 150;
                }
                else if(jumpPhase == 13)
                {
                    picPlayer.Image = playerImages.ElementAt(3);
                    picPlayer.Top += 150;

                }
                else if (jumpPhase == 15)
                {
                    picPlayer.Image = playerImages.ElementAt(0);
                    jumpPhase = 0;
                    isJumping = false;
                }
            }
            picEnemyBullet.Visible = true;

            if (picEnemyBullet.Right < 0)
            {
                picEnemyBullet.Location = new Point(830, 469);
                picEnemyBullet.Visible = false;
            }
            else if (picEnemyBullet.Bounds.IntersectsWith(picPlayer.Bounds))
            {
                isPlayerDamaged = true;
                picEnemyBullet.Visible = false;
                picEnemyBullet.Location = new Point(830, 469);
                playerHpFrame += enemyAttack/100;
                if (playerHpFrame < playerHpImages.Count)
                {
                    picPlayerHP.Image = playerHpImages.ElementAt(playerHpFrame);
                }
                player.CurrentHealth = player.CurrentHealth - enemyAttack;
                playerScore -= player.Attack();
            }
            else
            {
                picEnemyBullet.Left -= 40;
            }
            if(isPlayerDamaged)
            {
                playerDamagedTime++;
                if (playerDamagedTime == 1)
                {
                    picPlayer.Image = playerImages.ElementAt(4);
                }
                else if(playerDamagedTime == 3)
                {
                    picPlayer.Image = playerImages.ElementAt(0);
                    playerDamagedTime = 0;
                    isPlayerDamaged = false;
                }
            }

            if (picPlayerBullet.Visible)
            {
                picPlayerBullet.Left += 40;
                if (picPlayerBullet.Bounds.IntersectsWith(picEnemy.Bounds))
                {
                    isEnemyDamaged = true;
                    picPlayerBullet.Visible = false;
                    picPlayerBullet.Location = new Point(381, 507);
                    Enemy.CurrentHealth = Enemy.CurrentHealth - playerAttack;
                    enemyHpFrame = enemyHpImages.Count - (Enemy.CurrentHealth / 1000 + 1);
                    if (enemyHpFrame < enemyHpImages.Count)
                    {
                        picEnemyHP.Image = enemyHpImages.ElementAt((int)enemyHpFrame);
                    }
                    else if(enemyHpFrame >= enemyHpImages.Count)
                    {
                        picEnemyHP.Image = enemyHpImages.ElementAt(14);
                    }
                    playerScore += playerAttack;
                }
            }
            if(isEnemyDamaged)
            {
                enemyDamagedTime++;
                if(enemyDamagedTime == 1)
                {
                    picEnemy.Image = enemyImages.ElementAt(2);
                }
                else if(enemyDamagedTime == 3)
                {
                    picEnemy.Image = enemyImages.ElementAt(0);
                    isEnemyDamaged = false;
                    enemyDamagedTime = 0;
                }
            }
            if (Enemy.CurrentHealth <= 0)
            {
                timer1.Stop();
                lblResult.Text = "<<VICTORY>>";
                lblScoreResult.Text = "Your current score is: " + playerScore;
                lblResult.Visible = true;
                lblScoreResult.Visible = true;
                this.Refresh();
                Thread.Sleep(2500);
                SaveScore(playerName, playerScore, player);
                this.Hide();
                menuForm.Show();

            }
            else if(player.CurrentHealth <= 0)
            {
                timer1.Stop();
                lblResult.Text = "<<GAME OVER>>";
                lblScoreResult.Text = "Your current score is: " + playerScore;
                lblResult.Visible = true;
                lblScoreResult.Visible = true;
                this.Refresh();
                Thread.Sleep(2500);
                SaveScore(playerName, playerScore, player);
                this.Hide();
                menuForm.Show();
            }
        }

        private void SaveScore(string playerName, int playerScore, Player player)
        {
            string type = player.GetType().Name;

            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=leaderboard;Uid=root;Pwd=PASSWORD");
            try
            {
                con.Open();
                string sql = "SELECT charactertype FROM leaderboard WHERE name = @name AND charactertype = @charactertype";
                MySqlCommand commands = new MySqlCommand(sql, con);
                commands.Parameters.AddWithValue("@name", playerName);
                commands.Parameters.AddWithValue("@charactertype", type);
                MySqlDataReader readers = commands.ExecuteReader();
                if (readers.Read())
                {
                    readers.Close();
                    string sqll = "SELECT score FROM leaderboard WHERE name = @name AND charactertype = @charactertype";
                    MySqlCommand command = new MySqlCommand(sqll, con);
                    command.Parameters.AddWithValue("@name", playerName);
                    command.Parameters.AddWithValue("@charactertype", type);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        int oldScore = Convert.ToInt32(reader["score"]);
                        reader.Close();
                        if (oldScore < playerScore)
                        {
                            string sqql = "UPDATE leaderboard SET score = @score WHERE name = @name AND charactertype = @charactertype";
                            MySqlCommand cmd = new MySqlCommand(sqql, con);
                            cmd.Parameters.AddWithValue("@name", playerName);
                            cmd.Parameters.AddWithValue("@charactertype", type);
                            cmd.Parameters.AddWithValue("@score", playerScore);
                            cmd.ExecuteNonQuery();
                        }
                    }
                    else
                    {
                        reader.Close();
                        string sqlll = "UPDATE leaderboard SET score = @score WHERE name = @name AND charactertype = @charactertype";
                        MySqlCommand cmd = new MySqlCommand(sqlll, con);
                        cmd.Parameters.AddWithValue("@name", playerName);
                        cmd.Parameters.AddWithValue("@charactertype", type);
                        cmd.Parameters.AddWithValue("@score", playerScore);
                        cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    readers.Close();
                    string sqqlll = "INSERT INTO leaderboard(name, charactertype, score)" + "VALUES(@name, @charactertype, @score)";
                    MySqlCommand commandd = new MySqlCommand(sqqlll, con);
                    commandd.Parameters.AddWithValue("@name", playerName);
                    commandd.Parameters.AddWithValue("@charactertype", type);
                    commandd.Parameters.AddWithValue("@score", playerScore);
                    commandd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                con.Close();
            }
        }
    }
}

