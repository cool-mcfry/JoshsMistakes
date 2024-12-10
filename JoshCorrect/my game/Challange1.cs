using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_game
{
    public partial class Challange1 : Form
    { 
        /* here there is a list created that holds the images used in the game.
         * there is also a random variable creted and a string named answer. */
        List<Image> images = new List<Image>();
        Random pic = new Random();
        string answer = "";

        /* making challange1 form = this causes my challange1 form to be the current instance of the class.
         * it changes the click event for finish to be correct and hides the button
         * it then starts the setup function */
        public Challange1()
        {
            InitializeComponent();
            Manager.Challange1Form = this;
            Finish.Click += correct;
            Finish.Hide();
            SetUp();
        }

        /* this function adds all my images to the image list then starts the function 'start' */
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

        /* this function gets a random number and then uses that random number to pic a image from the list to show the user
         * it also checks that this image has not already been used in the game and if it has it keeps changing it till it finds one which hasnt been used */
        private void start()
        {
            int select = pic.Next(0, 10);
            for (int i = 0; i < Manager.FilmNum.Count; i++)
            {
                while (Manager.FilmNum[i] == select)
                {
                    select = pic.Next(0, 10);
                }
            }
            Manager.FilmNum.Add(select);
            PicBox.Image = images[select];
        }

        private void submit_Click(object sender, EventArgs e)
        {
            submit.Hide();
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
                Manager.lost = 0;
                Finish.Show();
            }
            else
            {
                TextBox.Text = "wrong. the correct answer was '"+answer+"'";
                Manager.lost++;
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

