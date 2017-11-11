using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace BL
{
    public class FishChild : IFish
    {
        private int x;
        private int y;
        Graphics g;
        ICreator cr = new FishChildCreator();
        private List<IFish> fishes = new List<IFish>();

        public FishChild(int x, int y, Graphics g)
        {
            this.x = x;
            this.y = y;
            this.g = g;
        }

        public void Create(int x, int y)
        {
            fishes.Add(cr.Create(x, y, g));
        }

        public void Move()
        {

        }
    }
}
