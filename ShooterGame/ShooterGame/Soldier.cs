using System;
using System.Collections.Generic;
using System.Text;

namespace ShooterGame
{
    internal class Soldier : Player
    {
        public Soldier(string name, int x, int y) : base(name, x, y) 
        {
            CurrentHealth = Health();
        }
        public override int Attack()
        {
            return 500;
        }

        public override int Health()
        {
            return 500;
        }

        public override List<Image> GetPlayerImage()
        {
            List<Image> SoldierFrames = new List<Image>
            { Image.FromFile(@"Resources\SoldierFrame1.png"),
              Image.FromFile(@"Resources\SoldierFrame2.png"),
              Image.FromFile(@"Resources\SoldierFrame3.png"),
              Image.FromFile(@"Resources\SoldierFrame4.png"),
              Image.FromFile(@"Resources\SoldierFrame5.png"),
              Image.FromFile(@"Resources\SoldierFrame6.png"),
            };
            return SoldierFrames;
        }

        public override Image GetBulletImage()
        {
            return Image.FromFile(@"Resources\BulletSoldierPic.png");
        }
        public override List<Image> GetHPBarImage()
        {
            List<Image> HPBarFrames = new List<Image>
            {
                Image.FromFile(@"Resources\SoldierHP1.png"),
                Image.FromFile(@"Resources\SoldierHP2.png"),
                Image.FromFile(@"Resources\SoldierHP3.png"),
                Image.FromFile(@"Resources\SoldierHP4.png"),
                Image.FromFile(@"Resources\SoldierHP5.png"),
                Image.FromFile(@"Resources\SoldierHP6.png"),
            };
            return HPBarFrames;

        }
    }
}
