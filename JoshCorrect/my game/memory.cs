using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace my_game
{
    public partial class memory : Form
    {
        /* the variable win is set to false here since later it checks if the answer is right and sets it to true if it is.
         * the button memorize is created here so i can use it later 
         * there are two lists created here which store buttons an colours for the buttons */
        public bool win = false;
        static Button memorize = new Button();
        List<Color> colours = new List<Color>();
        List<Button> buttons = new List<Button>();
        /* this bit of code has 2 arrays one for thee postios of buttons and another for psoitoons of colours
         * it also has a list of the buttons that the user selects 
         * there is also a color variable which contains the colour which the user needs to find */
        Button[] buttonPositions = new Button[37];
        List<Button> selected = new List<Button>();
        Color[] colorPosition = new Color[37];
        Color colorAnswer;
        public memory()
        {
            /* making memory form = this causes memory form to be the current instance of the class.
             * this part of the code hides a button until later */
            InitializeComponent();
            Manager.memoryForm = this;
            Ready.Hide();
        }

        /* this function adds all my colours to the list of colours and begins the set up function */
        private void Start_Click(object sender, EventArgs e)
        {
            colours.Add(Color.Magenta);
            colours.Add(Color.RoyalBlue);
            colours.Add(Color.IndianRed);
            colours.Add(Color.ForestGreen);
            SetUp();
        }

        /* this function sets up the board so that is i full of buttons with colours on them and it ensure that they are randomly placed.
         * it also adds a button which tells the user to memorize the colours them click ready
         * it also un hides the button we hid earlier */
        private void SetUp()
        {
            Random color = new Random();
            Start.Hide();
            memorize.Size = new Size(Start.Width, Start.Height);
            memorize.Location = new Point(Start.Location.X, Start.Location.Y);
            memorize.Text = "memorize the colours then click ready";
            memorize.Font = new Font(Start.Font.FontFamily, Start.Font.Size / 2);
            this.Controls.Add(memorize);
            Button blue = new Button();
            int hight = MemoryBoard.Height / 6;
            int width = MemoryBoard.Width / 6;
            int x = 0;
            int y = 0;
            int xcod = 0;
            int ycod=0;
            for (int i = 0; i < 37; i++)
            {
                Button colourButton = new Button();
                colourButton.Name = "button" + i;
                colourButton.Size = new Size(width, hight);
                colourButton.Location = new Point(x, y);
                colourButton.BackColor = colours[color.Next(0, 4)];
                buttonPositions[i] = colourButton;
                colorPosition[i] = colourButton.BackColor;
                buttons.Add(colourButton);
                MemoryBoard.Controls.Add(colourButton);
                y = y + hight;
                ycod++;
                if ((i + 1) % 6 == 0)
                {
                    x = x + width;
                    y = 0;
                    ycod = 0;
                    xcod++;
                }
            }
            Ready.Show();
        }
        
        
        // this starts the play function
        private void Ready_Click(object sender, EventArgs e)
        {
            play();
        }

        /* this hides the memorize button and in its place it places a submit button
         * it also randomly picks a colour for you to find and changes the text o the ready button to tell you what colour to find
         * it also changes the colour of all the buttons to black
         * it then adds a click event to the coloured buttons called white */
        private void play()
        {
            memorize.Hide();
            Button submit = new Button();
            submit.Size = new Size(Start.Width, Start.Height);
            submit.Location = new Point(Start.Location.X, Start.Location.Y);
            submit.Text = "submit";
            submit.Font = new Font(Start.Font.FontFamily, Start.Font.Size / 2);
            submit.Click += check;
            this.Controls.Add(submit);
            Random find = new Random();
            int answer = find.Next(0,4);
            Ready.Font = new Font(Start.Font.FontFamily, Start.Font.Size / 2);
            colorAnswer = colours[answer];
            Ready.Text = "find a button thats colour was" + colours[answer];
            int i = 0;
            int j = 0;
            foreach ( Button x in buttons)
            {
                x.BackColor = Color.Black;
                x.Click += WHITE; 
            }
        }

        /* this changes the colour of any buttons clicked to white */
        void WHITE(object sender, EventArgs e)
        {
            Button x = sender as Button;
            x.BackColor = Color.White;
            selected.Add(x);
        }

        /* this function checks to make sure that the user has clicked a box of the colour they needed to find.
         * if they found the right button then  it tells theem they are right an adds 1 to the checker and if not then it tells them they are wrong */
        void check(object sender, EventArgs e)
        {
            foreach(Button b in selected)
            {
                for(int i = 0; i < buttonPositions.Length; i++)
                {
                    Button b2 = buttonPositions[i];
                    if (b2 == b)
                    {
                        if (colorPosition[i] == colorAnswer)
                        {
                            Right.Text = "correct";
                            Manager.checker++;
                        }
                        if (colorPosition[i] != colorAnswer)
                        {
                            Right.Text = "Wrong";
                        }
                    }
                }
            }
        }

        /* this function closes the form when clicked */
        private void CloseForm_Click(object sender, EventArgs e)
        {
            Manager.DisplayMain(true);
            this.Dispose();
        }
    }
}
