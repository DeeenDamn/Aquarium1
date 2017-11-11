using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace Aquarium
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool flag;
        Bitmap frm;

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            fish.Height = 179;
            fish.Width = 298;
            frm = new Bitmap("background.png");
            fish.Image = new Bitmap(Image.FromFile("Ryba.png"), 225,143);            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            flag = false;
            Image a = fish.Image;    //все 3 строчки зеркально отражают картинку рыбы в picturebox
            a.RotateFlip(RotateFlipType.RotateNoneFlipY);
            fish.Image = a;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Graphics g = Graphics.FromImage(frm);
            if (fish.Top > 0)
            {
                Point MP = PointToClient(MousePosition);
                fish.Location = MP;
                g.DrawImage(fish.Image, fish.Location.X , fish.Location.Y - (fish.Height / 2) + 40);
                BackgroundImage = frm;
            }
            else
                timer1.Enabled = false;
            frm = new Bitmap("background.png");
        }


        private void fish_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                FishAdult a = new FishAdult();
                flag = false;
            }
        }
    }
}
