using System;
using System.Collections.Generic;
using System.Text;

namespace ShooterGame
{
    internal class OldMan : Player
    {
        public OldMan(string name, int x, int y) : base(name, x, y)
        {
            CurrentHealth = Health();
        }
        public override int Attack()
        {
            return 1000;
        }

        public override int Health()
        {
            return 300;
        }
        public override List<Image> GetPlayerImage()
        {
            List<Image> OldManFrames = new List<Image>
            { Image.FromFile(@"Resources\OldmanFrame1.png"),
              Image.FromFile(@"Resources\OldmanFrame2-3.png"),
              Image.FromFile(@"Resources\OldmanFrame2-3.png"),
              Image.FromFile(@"Resources\OldManFrame4.png"),
              Image.FromFile(@"Resources\OldmanFrame5.png"),
              Image.FromFile(@"Resources\OldmanFrame6.png"),
            };
            return OldManFrames;
        }

        public override Image GetBulletImage()
        {
            return Image.FromFile(@"Resources\BulletOldManPic.png");
        }

        public override List<Image> GetHPBarImage()
        {
            List<Image> HPBarFrames = new List<Image>
            {
                Image.FromFile(@"Resources\OldmanHP4.png"),
                Image.FromFile(@"Resources\OldmanHP1.png"),
                Image.FromFile(@"Resources\OldmanHP2.png"),
                Image.FromFile(@"Resources\OldmanHP3.png"),
            };
            return HPBarFrames;

        }
    }
}
