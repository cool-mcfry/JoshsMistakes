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
            Manager.Challange2Form = this;
            result.Hide();
            CloseForm.Hide();
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
            start.Hide();
            result.Show();
            CloseForm.Show();
            BigPic2.Image = images[pic.Next(0,3)];
            if (BigPic.Image == BigPic2.Image)
            {
                result.Text = "Draw";
                Manager.lost++;
            }
            if ((BigPic.Image == images[0]) && (BigPic2.Image == images[1]))
            {
                result.Text = "you lose";
                Manager.lost++;
            }
            if ((BigPic.Image == images[0]) && (BigPic2.Image == images[2]))
            {
                result.Text = "you win";
                Manager.lost = 0;
                Manager.checker++;
            }
            if ((BigPic.Image == images[1]) && (BigPic2.Image == images[0]))
            {
                result.Text = "you win";
                Manager.lost = 0;
                Manager.checker++;
            }
            if ((BigPic.Image == images[1]) && (BigPic2.Image == images[2]))
            {
                result.Text = "you lose";
                Manager.lost++;
            }
            if ((BigPic.Image == images[2]) && (BigPic2.Image == images[0]))
            {
                result.Text = "you lose";
                Manager.lost++;
            }
            if ((BigPic.Image == images[2]) && (BigPic2.Image == images[1]))
            {
                result.Text = "you win";
                Manager.lost = 0;
                Manager.checker++;
            }
        }
        private void CloseForm_Click(object sender, EventArgs e)
        {
            Manager.DisplayMain(true);
            this.Dispose();
        }

    }
}
