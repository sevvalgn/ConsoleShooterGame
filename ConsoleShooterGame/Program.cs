using MySqlConnector;
using System.Collections.Specialized;
using System.Diagnostics.Metrics;
using System.Numerics;

namespace PlayerRankingSystem
{

    class Player //Parent class
    {
        private string playerName;
        public string PlayerName
        {
            get
            {
                return playerName;
            }
            set
            {
                playerName = value;
            }
        }
        public virtual int Attack()
        {
            return 0;
        }
        public virtual int Health()
        {
            return 0;
        }

        public int X;
        public int Y;
        public Player(string name, int x, int y) //Positions for characters
        {
            this.PlayerName = name;
            X = x;
            Y = y;
        }

    }

    class Fairy : Player
    {
        public Fairy(string name, int x, int y) : base(name, x, y) { }
        public override int Attack()
        {
            return 300;
        }

        public override int Health()
        {
            return 1200;
        }
    }

    class Soldier : Player
    {
        public Soldier(string name, int x, int y) : base(name, x, y) { }
        public override int Attack()
        {
            return 500;
        }

        public override int Health()
        {
            return 700;
        }
    }

    class OldMan : Player
    {
        public OldMan(string name, int x, int y) : base(name, x, y) { }
        public override int Attack()
        {
            return 1000;
        }

        public override int Health()
        {
            return 400;
        }
    }

    class Enemy : Player
    {
        public Enemy(string name, int x, int y) : base(name, x, y) { }
        public override int Attack()
        {
            return 100;
        }

        public override int Health()
        {
            return 5000;
        }
    }

    class Bullet
    {
        public int X;
        public int Y;
        public string Symbol;
        public Bullet(int x, int y, string symbol) //Positions for bullets
        {
            X = x;
            Y = y;
            Symbol = symbol; // *,>
        }

        public string GetBullet()
        {
            return Symbol;
        }
    }
    internal class Program
    {
        static List<Player> characterlist = new List<Player>();
        static void Main(string[] args)
        {
            Player Fairy = new Fairy("Fairy", 0, 0);
            Player Soldier = new Soldier("Soldier", 0, 0);
            Player OldMan = new OldMan("OldMan", 0, 0);
            characterlist.Add(Fairy);
            characterlist.Add(Soldier);
            characterlist.Add(OldMan);

            string playerName = LogIn();

            while (true)
            {
                Console.WriteLine("1. Start the Game");
                Console.WriteLine("2. Show Leaderboard");
                Console.WriteLine("3. Exit Program");
                string choice;
                do
                {
                    Console.WriteLine("Enter your choice (1 or 2 or 3) : ");
                    choice = Console.ReadLine();
                }
                while (choice != "1" && choice != "2" && choice != "3");

                if (choice == "1")
                {
                    Showcharacterlist();
                    Player player = CharacterChoice(playerName);
                    StarttheGame(playerName,player);
                }
                else if (choice == "2")
                {
                    Leaderboard();
                }
                else
                {
                    Console.WriteLine("Existing the program.");
                    break;
                }
            }
           
            static int StarttheGame(string playerName, Player player)
            {

                Console.WriteLine($"Welcome {playerName}!");
                Console.WriteLine("You must defeat the enemy by damaging him and avoiding his shots.");
                Console.WriteLine("--------------------------------------------------------------------");
                Console.WriteLine("                               START                                  ");
                Console.WriteLine("--------------------------------------------------------------------");

                Player Enemy = new Enemy("Enemy", 20, 30);
                var Bullet = new Bullet(19, 30, "*");
                var PlayerBullet = new Bullet(8, 30, ">");
                Console.WriteLine("An enemy appears!");
                Console.WriteLine("Enter 'space' to attack");
                int enemyHealth = Enemy.Health();
                int playerAttack = player.Attack();
                int playerHealth = player.Health();
                int enemyAttack = Enemy.Attack();
                int playerScore = 0;
                string type = player.GetType().Name;

                DateTime jumptime = DateTime.Now;
                DateTime landtime = DateTime.Now;
                DateTime lastenemyattack = DateTime.Now;
                string bullet = Bullet.GetBullet();
                string playerbullet = PlayerBullet.GetBullet();
                Console.SetCursorPosition(player.X, player.Y); //Display the characters
                Console.Write("Player");
                Console.SetCursorPosition(Enemy.X, Enemy.Y);
                Console.Write(Enemy.PlayerName);
                bool IsJumping = false;
                while (true)
                {
                    if (Console.KeyAvailable) //Player attack or player jumps
                    {
                        var keyInfo = Console.ReadKey(true);

                        if (Bullet.X == PlayerBullet.X)
                        {
                            Bullet.X--;
                        }

                        if (keyInfo.Key == ConsoleKey.Spacebar)
                        {

                            if (PlayerBullet.X == player.X + 6)
                            {
                                Console.SetCursorPosition(PlayerBullet.X, PlayerBullet.Y);
                                Console.Write(playerbullet);
                                Thread.Sleep(100);
                                if (PlayerBullet.X != Bullet.X)
                                {
                                    Console.SetCursorPosition(player.X + 6, player.Y);
                                    Console.Write(" ");
                                }
                                PlayerBullet.X = PlayerBullet.X + 1;
                            }

                        }
                        else if (keyInfo.Key == ConsoleKey.UpArrow)
                        {
                            if (!IsJumping && (DateTime.Now - landtime).TotalSeconds > 0.2) //Calculate the time that the player lands
                            {
                                Console.SetCursorPosition(player.X, player.Y);
                                Console.Write("      ");
                                player.Y--;
                                Console.SetCursorPosition(player.X, player.Y);
                                Console.Write("Player");
                                jumptime = DateTime.Now;
                                IsJumping = true;
                            }
                        }
                    }

                    if (PlayerBullet.X > player.X + 6)// Update player's bullet 
                    {
                        Console.SetCursorPosition(PlayerBullet.X, PlayerBullet.Y);
                        Console.Write(playerbullet);
                        Thread.Sleep(100);

                        if (PlayerBullet.X != Bullet.X && PlayerBullet.Y == Bullet.Y)
                        {
                            Console.SetCursorPosition(PlayerBullet.X, PlayerBullet.Y);
                            Console.Write(" ");
                        }
                        PlayerBullet.X = PlayerBullet.X + 1;
                        if (PlayerBullet.X == Enemy.X)// player's bullet hits the enemy
                        {
                            Console.SetCursorPosition(Enemy.X, Enemy.Y);
                            Console.Write("      ");
                            enemyHealth = enemyHealth - playerAttack;
                            Thread.Sleep(100);
                            Console.SetCursorPosition(Enemy.X, Enemy.Y);
                            Console.Write("Enemy");
                            Console.SetCursorPosition(Enemy.X, Enemy.Y + 1);
                            Console.WriteLine(enemyHealth);
                            PlayerBullet.X = player.X + 6;
                            playerScore += 100;
                            continue;
                        }
                    }

                    if (IsJumping)
                    {
                        if ((DateTime.Now - jumptime).TotalSeconds > 1.5)//Calculate the time that how long the player stayed in the air
                        {
                            Console.SetCursorPosition(player.X, player.Y);
                            Console.Write("      ");
                            player.Y++;
                            Console.SetCursorPosition(player.X, player.Y);
                            Console.Write("Player");
                            IsJumping = false;
                            landtime = DateTime.Now;

                        }
                    }

                    if ((DateTime.Now - lastenemyattack).TotalSeconds >= 0.1) //Calculate the time for the bullet'S progress
                    {
                        Console.SetCursorPosition(Bullet.X, Bullet.Y);
                        Console.Write(bullet);
                        Thread.Sleep(100);
                        if (Bullet.X != PlayerBullet.X && Bullet.X == Enemy.X - 1)
                        {
                            Console.SetCursorPosition(Bullet.X, Bullet.Y);
                            Console.Write(" "); // delete the previous bullet
                        }
                        else if (Bullet.X == PlayerBullet.X && PlayerBullet.Y == Bullet.Y)
                        {
                            Console.SetCursorPosition(Bullet.X, Bullet.Y);
                            Console.Write(" ");

                        }
                        else
                        {
                            Console.SetCursorPosition(Bullet.X, Bullet.Y);
                            Console.Write(" ");
                        }

                        lastenemyattack = DateTime.Now;

                        if (Bullet.X > player.X - 1 && Bullet.X < player.X + 6 && Bullet.Y == player.Y) //Enemy's bullet hits the player
                        {
                            Console.SetCursorPosition(player.X, player.Y);
                            Console.Write("      ");
                            playerHealth = playerHealth - enemyAttack;
                            Bullet.X = Enemy.X - 1;
                            Thread.Sleep(150);
                            Console.SetCursorPosition(player.X, player.Y);
                            Console.Write("Player");
                            lastenemyattack = DateTime.Now;
                            Console.SetCursorPosition(player.X, player.Y + 1);
                            Console.WriteLine(playerHealth);
                            continue;
                        }
                        else if (Bullet.X == player.X - 1)//if player jumps
                        {
                            Bullet.X = Enemy.X - 1;
                        }
                        Bullet.X = Bullet.X - 1;
                    }
                    if (playerHealth <= 0)//the results
                    {
                        Lost();
                        break;
                    }
                    else if (enemyHealth <= 0)
                    {
                        Won();
                        break;

                    }

                }
                Console.WriteLine($"Your score is {playerScore}");
                SaveScore(playerName,playerScore,player);
                return playerScore;

            }

            static Player CharacterChoice(string playerName)
            {
                Player player;

                Console.WriteLine("Which character do you want to play?");
                string choice;
                do
                {
                    Console.WriteLine("Enter your choice (1,2 or 3): ");
                    choice = Console.ReadLine();

                }
                while (string.IsNullOrWhiteSpace(choice) || choice != "1" && choice != "2" && choice != "3");

                if (choice == "1")
                {
                    player = new Fairy(playerName, 2, 30);
                }
                else if (choice == "2")
                {
                    player = new Soldier(playerName, 2, 30);
                }
                else
                {
                    player = new OldMan(playerName, 2, 30);
                }

                return player;
            }

        }

        static void Showcharacterlist()
        {

            for (int i = 0; i < characterlist.Count; i++)
            {

                Console.WriteLine($"{i + 1}. {characterlist[i].PlayerName} - Health: {characterlist[i].Health()} - Attack: {characterlist[i].Attack()}");
            }
        }

        static string LogIn()
        {
            string playerName = null;
            while (string.IsNullOrEmpty(playerName))
            {
                Console.WriteLine("Please name your player.");
                playerName = Console.ReadLine().ToLower();

                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=leaderboard;Uid=root;Pwd=MySQLklmn583");
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM namepassword WHERE name = @name";
                    MySqlCommand command = new MySqlCommand(sql, connection);
                    command.Parameters.AddWithValue("@name", playerName);
                    MySqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Console.WriteLine("Please enter your password: ");
                        string password = Console.ReadLine();
                        if (password == reader["password"].ToString())
                        {
                            Console.WriteLine("True password.");
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Unvalid password.");
                            continue;
                        }
                    }
                    else
                    {
                        reader.Close();
                        Console.WriteLine("Create a password then log in: ");
                        string password = Console.ReadLine();
                        string sqll = "INSERT INTO namepassword(name,password)" + "VALUES(@name, @password)";
                        MySqlCommand cmd = new MySqlCommand(sqll, connection);
                        cmd.Parameters.AddWithValue("@name", playerName);
                        cmd.Parameters.AddWithValue("password", password);
                        cmd.ExecuteNonQuery();
                    }
                }

                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    connection.Close();
                }
            }

            return playerName;
        }
        static void SaveScore(string playerName, int playerScore, Player player)
        {
            string type = player.GetType().Name;

            MySqlConnection con = new MySqlConnection("Server=localhost;DataBase=leaderboard;Uid=root;Pwd=MySQLklmn583");
            try
            {
                con.Open();
                string sqqll = "SELECT charactertype FROM leaderboard WHERE name = @name AND charactertype = @charactertype";
                MySqlCommand commands = new MySqlCommand(sqqll, con);
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
                            string sql = "UPDATE leaderboard SET score = @score WHERE name = @name AND charactertype = @charactertype";
                            MySqlCommand cmd = new MySqlCommand(sql, con);
                            cmd.Parameters.AddWithValue("@name", playerName);
                            cmd.Parameters.AddWithValue("@charactertype", type);
                            cmd.Parameters.AddWithValue("@score", playerScore);
                            cmd.ExecuteNonQuery();
                            Console.WriteLine("Saved.");
                        }
                    }
                    else
                    {
                        reader.Close();
                        string sql = "UPDATE leaderboard SET score = @score WHERE name = @name AND charactertype = @charactertype";
                        MySqlCommand cmd = new MySqlCommand(sql, con);
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
                    Console.WriteLine("Saved.");
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

        static void Lost()
        {
            Console.WriteLine("-------------------------------------------------");
            Console.WriteLine("Game over. You have been defeated by the enemy.");
            Console.WriteLine("-------------------------------------------------");
        }

        static void Won()
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Congratulations! You have defeated the enemy.");
            Console.WriteLine("---------------------------------------------");
        }
        static void Leaderboard()
        {
            MySqlConnection connection = new MySqlConnection("Server=localhost;Database=leaderboard;Uid=root;Pwd=MySQLklmn583");
            try
            {
                connection.Open();
                string sql = "SELECT * FROM leaderboard ORDER BY score DESC";
                MySqlCommand command = new MySqlCommand(sql, connection);
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader["name"] + " " + reader["charactertype"] + " " + reader["score"]);
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                connection.Close();
            }

        }
    }
}
