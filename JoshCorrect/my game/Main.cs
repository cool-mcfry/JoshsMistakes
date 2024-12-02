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
            InitializeComponent();
            Manager.MainForm = this;
            colour.Add(Color.Crimson);
            colour.Add(Color.LawnGreen);
            colour.Add(Color.RoyalBlue);
        }

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
                GameBoard.Controls.Add(square);
                y = y + hight;
                if ((i + 1) % 6 == 0)
                {
                    x = x + width;
                    y = 0;
                }
            }
        }
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
            }
        }
        public void Win()
        {
            GameBoard.Controls.Clear();
            int height = GameBoard.Height;
            int width = GameBoard.Width;
            Button win = new Button();
            win.Size = new Size(width, height);
            GameBoard.Controls.Add(win);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (Manager.checker == 5)
            {
                Win();
            }
        }
    }
}
