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
        private int x;
        private int y;
        Graphics g;
        ICreator cr = new FishAdultCreator();
        private List<IFish> fishes = new List<IFish>();

        public FishAdult(int x, int y, Graphics g)
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
            for (int i = 0; i < fishes.Count; i++)
            {
                if ((fishes[i] as FishAdult).x > 160)
                    fishes[i] = MoveLeft(fishes[i] as FishAdult);
                if ((fishes[i] as FishAdult).x < 1402)
                    fishes[i] = MoveRight(fishes[i] as FishAdult);
            }
        }

        private IFish MoveRight(FishAdult fish)
        {
            g.DrawImage(Image.FromFile("Ryba.png"), fish.x += 40, fish.y);
            return fish;
        }

        private IFish MoveLeft(FishAdult fish)
        {
            g.DrawImage(Image.FromFile("Ryba.png"), fish.x -= 40, fish.y);
            return fish;
        }
    }
}
