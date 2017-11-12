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

        bool flag = false;
        FishAdult a = new FishAdult(0, 0, g);// 
        Bitmap frm;
        static Graphics g;

        private void button1_Click(object sender, EventArgs e)
        {
            //fish.Height = 179;
            //fish.Width = 298;
            frm = new Bitmap("background.png");
            fish.Image = new Bitmap(Image.FromFile("Ryba.png"), 225,143);
            g = Graphics.FromImage(frm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image a = fish.Image;    //все 3 строчки зеркально отражают картинку рыбы в picturebox
            a.RotateFlip(RotateFlipType.RotateNoneFlipY);
            fish.Image = a;
            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            g = Graphics.FromImage(frm);
            if (fish.Top > 0)
            {
                g.DrawImage(fish.Image, fish.Left, fish.Top -= 40);
                //Point MP = PointToClient(MousePosition);
                //fish.Location = MP;
                //g.DrawImage(fish.Image, fish.Location.X, fish.Location.Y - (fish.Height / 2) + 40);
                BackgroundImage = frm;
            }
            else
                timer1.Enabled = false;
            frm = new Bitmap("background.png");
        }


        private void Form1_Click(object sender, EventArgs e)
        {
            //g = Graphics.FromImage(frm);
            if (flag == true)
            {                
                a.Create(MousePosition.X, MousePosition.Y);
                BackgroundImage = frm;
                flag = false;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            flag = true;
            //frm = new Bitmap("background.png");
            //g = Graphics.FromImage(frm);
        }
    }
}
