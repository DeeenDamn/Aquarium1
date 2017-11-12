using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    class FishChildCreator : ICreator
    {
        public IFish Create(int x, int y, Graphics g)
        {
            g.DrawImage(Image.FromFile("Ryba.png"), x - 25, y - 30, 50, 32);
            return new FishAdult(x - 25, y - 30, g);
        }
    }
}
