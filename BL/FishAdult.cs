using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class FishAdult : IFish
    {
        ICreator cr = new FishAdultCreator();
        List<IFish> fishes = new List<IFish>();

        public void Create(int x, int y, Graphics g)
        {
            fishes.Add(cr.Create(x, y, g));
        }
    }
}
