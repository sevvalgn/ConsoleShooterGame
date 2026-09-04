using System;
using System.Collections.Generic;
using System.Text;

namespace ShooterGame
{
    internal class Enemy : Player
    {
        public Enemy(string name, int x, int y) : base(name, x, y) 
        {
            CurrentHealth = Health();
        }
        public override int Attack()
        {
            return 100;
        }

        public override int Health()
        {
            return 14000;
        }
        public override List<Image> GetPlayerImage()
        {
            List<Image> EnemyFrames = new List<Image>
            { Image.FromFile(@"Resources\EnemyFrame1.png"),
              Image.FromFile(@"Resources\EnemyFrame2.png"),
              Image.FromFile(@"Resources\EnemyFrame3.png")
            };
            return EnemyFrames;
        }

        public override List<Image> GetHPBarImage()
        {
            List<Image> HPBarFrames = new List<Image>
            {
                Image.FromFile(@"Resources\EnemyHP1.png"),
                Image.FromFile(@"Resources\EnemyHP2.png"),
                Image.FromFile(@"Resources\EnemyHP3.png"),
                Image.FromFile(@"Resources\EnemyHP4.png"),
                Image.FromFile(@"Resources\EnemyHP5.png"),
                Image.FromFile(@"Resources\EnemyHP6.png"),
                Image.FromFile(@"Resources\EnemyHP7.png"),
                Image.FromFile(@"Resources\EnemyHP8.png"),
                Image.FromFile(@"Resources\EnemyHP9.png"),
                Image.FromFile(@"Resources\EnemyHP10.png"),
                Image.FromFile(@"Resources\EnemyHP11.png"),
                Image.FromFile(@"Resources\EnemyHP12.png"),
                Image.FromFile(@"Resources\EnemyHP13.png"),
                Image.FromFile(@"Resources\EnemyHP14.png"),
                Image.FromFile(@"Resources\EnemyHP15.png"),
            };
            return HPBarFrames;

        }
        public override Image GetBulletImage()
        {
            return Image.FromFile(@"Resources\BulletEnemy.png");
        }
    }
}
