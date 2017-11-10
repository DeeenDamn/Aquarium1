using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    class FishAdultCreator : ICreator
    {
        public IFish Create(int x, int y, Graphics g)
        {
            g.DrawImage(Image.FromFile("fish1.jpg"), x, y);
            return new FishAdult();
        }
    }
}
