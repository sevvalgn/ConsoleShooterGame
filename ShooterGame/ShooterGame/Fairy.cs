using System;
using System.Collections.Generic;
using System.Text;

namespace ShooterGame
{
    internal class Fairy : Player
    {
        public Fairy(string name, int x, int y) : base(name, x, y)
        {
            CurrentHealth = Health();
        }
        public override int Attack()
        {
            return 250;
        }

        public override int Health()
        {
            return 800;
        }

        public override List<Image> GetPlayerImage()
        {
            List<Image> FairyFrames = new List<Image>
            { Image.FromFile(@"Resources\FairyFrame1.png"),
              Image.FromFile(@"Resources\FairyFrame2.png"),
              Image.FromFile(@"Resources\FairyFrame3.png"),
              Image.FromFile(@"Resources\FairyFrame4.png"),
              Image.FromFile(@"Resources\FairyFrame5.png"),
              Image.FromFile(@"Resources\FairyFrame6.png"),
            };   
            return FairyFrames;
        }
        public override List<Image> GetHPBarImage()
        {
            List<Image> HPBarFrames = new List<Image>
            {
                Image.FromFile(@"Resources\FairyHPBar1.png"),
                Image.FromFile(@"Resources\FairyHPBar2.png"),
                Image.FromFile(@"Resources\FairyHPBar3.png"),
                Image.FromFile(@"Resources\FairyHPBar4.png"),
                Image.FromFile(@"Resources\FairyHPBar5.png"),
                Image.FromFile(@"Resources\FairyHPBar6.png"),
                Image.FromFile(@"Resources\FairyHPBar7.png"),
                Image.FromFile(@"Resources\FairyHPBar8.png"),
                Image.FromFile(@"Resources\FairyHPBar9.png"),

            };
            return HPBarFrames;
        }
        public override Image GetBulletImage()
        {
            return Image.FromFile(@"Resources\BulletFairyPic.png");
        }
    }
}
