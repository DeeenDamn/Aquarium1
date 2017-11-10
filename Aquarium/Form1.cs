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

        private void button1_Click(object sender, EventArgs e)
        {
            flag = true;
            pictureBox1.Visible = true;
            fish.Visible = true;
            pictureBox1.Width = Width;
            pictureBox1.Height = Height;
            fish.Height = 140;
            fish.Width = 240;
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
            if (fish.Top > 0)   //рыба всплывает
                fish.Top -= 20;
            else
                timer1.Enabled = false;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (flag == true)
            {
                FishAdult a = new FishAdult();
                Graphics g = pictureBox1.CreateGraphics();
                a.Create(MousePosition.X, MousePosition.Y, g);
                flag = false;
            }
        }
    }
}
