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
    public partial class Challange1 : Form
    {
        List<Image> images = new List<Image>();
        Random pic = new Random();
        string answer = "";
        public Challange1()
        {
            InitializeComponent();
            Manager.Challange1Form = this;
            Finish.Click += correct;
            Finish.Hide();
            SetUp();
        }
        private void SetUp()
        {
            images.Add(Image.FromFile("guess1.JPG"));
            images.Add(Image.FromFile("Guess2.JPG"));
            images.Add(Image.FromFile("Guess3.JPG"));
            images.Add(Image.FromFile("Guess4.JPG"));
            images.Add(Image.FromFile("Guess5.JPG"));
            images.Add(Image.FromFile("Guess6.JPG"));
            images.Add(Image.FromFile("Guess7.JPG"));
            images.Add(Image.FromFile("Guess8.JPG"));
            images.Add(Image.FromFile("Guess9.JPG"));
            images.Add(Image.FromFile("Guess10.JPG"));
            start();
        }
        private void start()
        {
            PicBox.Image = images[pic.Next(0, 5)];
        }

        private void submit_Click(object sender, EventArgs e)
        {
            if(PicBox.Image == images[0])
            {
                answer = ("BEAUTY AND THE BEAST");
            }
            if (PicBox.Image == images[1])
            {
                answer = ("PARANORMAL ACTIVITY");
            }
            if (PicBox.Image == images[2])
            {
                answer = ("MIDNIGHT IN PARIS");
            }
            if (PicBox.Image == images[3])
            {
                answer = ("THE BREAKFAST CLUB");
            }
            if (PicBox.Image == images[4])
            {
                answer = ("OCEANS ELEVEN");
            }
            if (PicBox.Image == images[5])
            {
                answer = ("SEX IN THE CITY");
            }
            if (PicBox.Image == images[6])
            {
                answer = ("THE WOLF OF WALL STREET");
            }
            if (PicBox.Image == images[7])
            {
                answer = ("FREAKY FRIDAY");
            }
            if (PicBox.Image == images[8])
            {
                answer = ("CHICKEN RUN");
            }
            if (PicBox.Image == images[9])
            {
                answer = ("LORD OF THE RINGS");
            }
            if (answer.ToLower() == TextBox.Text.ToLower())
            {
                Manager.checker++;
                TextBox.Text = "correct";
                Finish.Show();
            }
            else
            {
                TextBox.Text = "wrong";
                Finish.Show();
            }
        }
        void correct(object sender, EventArgs e)
        {
            Manager.DisplayMain(true);
            this.Dispose();
        }
    }
}
