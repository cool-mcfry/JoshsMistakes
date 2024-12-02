using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_game
{
    public partial class Challange2 : Form
    {
        List <Image> images = new List <Image> ();
        Random pic = new Random ();
        public Challange2()
        {
            InitializeComponent();
            SetUp();
        }
        private void SetUp()
        {
            images.Add(Image.FromFile("rock.JPG"));
            images.Add(Image.FromFile("paper.JPG"));
            images.Add(Image.FromFile("scissors.JPG"));

        }
        private void start_Click(object sender, EventArgs e)
        {
            Game();
        }
        private void Game()
        {
            start.Text = "Submit";
            Rock.Click += change1;
            Paper.Click += change2;
            Scissors.Click += change3;
            start.Click += play;
        }
        void change1(object sender, EventArgs e)
        {
            BigPic.Image = images[0];
        }
        void change2(object sender, EventArgs e)
        {
            BigPic.Image = images[1];
        }
        void change3(object sender, EventArgs e)
        {
            BigPic.Image = images[2];
        }
        void play(object sender, EventArgs e)
        {
            BigPic2.Image = images[pic.Next(0,4)];
            if (BigPic.Image == BigPic2.Image)
            {
                start.Text = "Draw";
            }
            /*
            if (BigPic.Image )
            {
                start.Text = "Draw";
            }*/
        }
        private void CloseForm_Click(object sender, EventArgs e)
        {
            Manager.DisplayMain(true);
            this.Dispose();
        }
    }
}
