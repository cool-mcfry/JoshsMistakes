using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_game
{
    public partial class Main : Form
    {
        //this part of the code holds varibles mem, chall1 and chall2 which are my 3 diffrent forms to craete a new one each time they are opened.
        //it also holds a image for the stat button on the game board, a list of colours so tht each button has a colour wich corresponds with the minigame it plays.
        //there are also 5 diffrent lists which hold the values for all my buttons depending on whic row they are in on the board.
        static memory mem;
        static Challange1 chall1;
        static Challange2 chall2;
        Image start = Image.FromFile("start.JPG");
        List<Color> colour = new List<Color>();
        List<Button> row1 = new List<Button>();
        List<Button> row2 = new List<Button>();
        List<Button> row3 = new List<Button>();
        List<Button> row4 = new List<Button>();
        List<Button> row5 = new List<Button>();

    public Main()
        {
            //making main form = this causes my Main form to be the current instance of the class.
            //this part of the code also adds my 3 diffrent colours to my list of colours.
            InitializeComponent();
            Manager.MainForm = this;
            colour.Add(Color.Crimson);
            colour.Add(Color.LawnGreen);
            colour.Add(Color.RoyalBlue);
        }

        /* in this function when pictureBox1 is clicked it removes the game rules from view and then sets up the
           GameBoard up adding the buttons to their correct list and assigning them a colour, size and position on the board.*/ 
        // GameBoard is my pannel which has all the buttons on it. width is the width of th game board divided by 5 and height is the width of the hgame board divided by 6.
        // x and why are the variables i use to position each button in the correct place.
        // c is used to keep track of which colour the next button needs to be .
        public void pictureBox1_Click(object sender, EventArgs e)
        {
            info1.Hide();
            info2.Hide();
            int hight = GameBoard.Height / 6;
            int width = GameBoard.Width / 5;
            int x = 0;
            int y = 0;
            int c = 0;
            for (int i = 0; i < 30; i++)
            {
                Button square = new Button();
                square.Size = new Size(width, hight);
                square.Location = new Point(x, y);
                square.BackColor = colour[c];
                if ((i >= 0) && (i < 6))
                {
                    row1.Add(square);
                    square.Name = "FirstRow";
                }
                if ((i >= 6) && (i < 12))
                {
                    row2.Add(square);
                    square.Name = "SecondRow";
                }
                if ((i >= 12) && (i < 18))
                {
                    row3.Add(square);
                    square.Name = "ThirdRow";
                }
                if ((i >= 18) && (i < 24))
                {
                    row4.Add(square);
                    square.Name = "FourthRow";
                }
                if ((i >= 24) && (i < 30))
                {
                    row5.Add(square);
                    square.Name = "FithRow";
                }
                square.Click += challange;
                c++;
                if (c == 3)
                {
                    c = 0;
                }
                // this adds the buttons to the game board.
                GameBoard.Controls.Add(square);
                y = y + hight;
                if ((i + 1) % 6 == 0)
                {
                    x = x + width;
                    y = 0;
                }
            }
        }

        /* this function first uses the checker so it knows what row of buttons are able to be pressed.
         * once it knows what buttons can and cant be pressed currently, it assigns each button a form/mini game based on what colour button it is.
         * then based on what colour button has been clicked it opens the corresponding mini gae form for the user to play */
        public void challange(object sender, EventArgs e)
        {
            Button p = sender as Button;
            if ((p.Name == "FirstRow") && (Manager.checker == 0))
            {
                if (p.BackColor == Color.Crimson)
                {
                    mem = new memory();
                    Manager.DisplayMemory(true);
                    Manager.DisplayMain(false);
                }
                if (p.BackColor == Color.RoyalBlue)
                {
                    chall1 = new Challange1();
                    Manager.DisplayChallange1(true);
                    Manager.DisplayMain(false);
                }
                if (p.BackColor == Color.LawnGreen)
                {
                    chall2 = new Challange2();
                    Manager.DisplayChallange2(true);
                    Manager.DisplayMain(false);
                }
                p.BackColor = Color.Gray;
                p.Enabled = false;
            }
            if ((p.Name == "SecondRow") && (Manager.checker == 1))
            {
                if (p.BackColor == Color.Crimson)
                {
                    mem = new memory();
                    Manager.DisplayMemory(true);
                    Manager.DisplayMain(false);
                }
                if (p.BackColor == Color.RoyalBlue)
                {
                    chall1 = new Challange1();
                    Manager.DisplayChallange1(true);
                    Manager.DisplayMain(false);
                }
                if (p.BackColor == Color.LawnGreen)
                {
                    chall2 = new Challange2();
                    Manager.DisplayChallange2(true);
                    Manager.DisplayMain(false);
                }
                p.BackColor = Color.Gray;
                p.Enabled = false;
            }
            if ((p.Name == "ThirdRow") && (Manager.checker == 2))
            {
                if (p.BackColor == Color.Crimson)
                {
                    mem = new memory();
                    Manager.DisplayMemory(true);
                    Manager.DisplayMain(false);
                }
                if (p.BackColor == Color.RoyalBlue)
                {
                    chall1 = new Challange1();
                    Manager.DisplayChallange1(true);
                    Manager.DisplayMain(false);
                }
                if (p.BackColor == Color.LawnGreen)
                {
                    chall2 = new Challange2();
                    Manager.DisplayChallange2(true);
                    Manager.DisplayMain(false);
                }
                p.BackColor = Color.Gray;
                p.Enabled = false;
            }
            if ((p.Name == "FourthRow") && (Manager.checker == 3))
            {
                if (p.BackColor == Color.Crimson)
                {
                    mem = new memory();
                    Manager.DisplayMemory(true);
                    Manager.DisplayMain(false);
                }
                if (p.BackColor == Color.RoyalBlue)
                {
                    chall1 = new Challange1();
                    Manager.DisplayChallange1(true);
                    Manager.DisplayMain(false);
                }
                if (p.BackColor == Color.LawnGreen)
                {
                    chall2 = new Challange2();
                    Manager.DisplayChallange2(true);
                    Manager.DisplayMain(false);
                }
                p.BackColor = Color.Gray;
                p.Enabled = false;
            }
            if ((p.Name == "FithRow") && (Manager.checker == 4))
            {
                if (p.BackColor == Color.Crimson)
                {
                    mem = new memory();
                    Manager.DisplayMemory(true);
                    Manager.DisplayMain(false);
                }
                if (p.BackColor == Color.RoyalBlue)
                {
                    chall1 = new Challange1();
                    Manager.DisplayChallange1(true);
                    Manager.DisplayMain(false);
                }
                if (p.BackColor == Color.LawnGreen)
                {
                    chall2 = new Challange2();
                    Manager.DisplayChallange2(true);
                    Manager.DisplayMain(false);
                }
                p.BackColor = Color.Gray;
                p.Enabled = false;
            }

        }

        /* When pictureBox2 is pressed, this function checks to see how many mini games have been won.
         * if the user has won enough mini games to reach the end of the board then it calls the function win. 
         * if the user has lost to many mini games in a row then it calls the lost function */
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Manager.checker >= 5)
            {
                Win();
            }
            if (Manager.lost == 6)
            {
                lost();
            }
        }
        /* this function first removes all of the buttons from the game board.
         * then is creates a new button which fills the game bord and displays the words "you win". */
        public void Win()
        {
            GameBoard.Controls.Clear();
            int height = GameBoard.Height;
            int width = GameBoard.Width;
            Button win = new Button();
            win.Size = new Size(width, height);
            win.Text = "you win";
            win.Font = new Font("Script", 50);
            GameBoard.Controls.Add(win);
        }

        /* this function first removes all of the buttons from the game board.
         * then is creates a new button which fills the game bord and displays the words "you lost". */
        public void lost()
        {
            GameBoard.Controls.Clear();
            int height = GameBoard.Height;
            int width = GameBoard.Width;
            Button lose = new Button();
            lose.Size = new Size(width, height);
            lose.Text = "you lost";
            lose.Font = new Font("Script", 50);
            GameBoard.Controls.Add(lose);
        }
    }
}
