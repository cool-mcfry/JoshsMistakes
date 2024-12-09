using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace my_game
{

    internal class Manager
    {
        // this part of cod has put all my forms in one area so that i can call upon them easier.
        // it also holds my varibe checker which counts how many times you win a mini game and this variable is easier to call upon since it is in this area.
        public static Main MainForm;
        public static Challange1 Challange1Form;
        public static memory memoryForm;
        public static Challange2 Challange2Form;
        public static int checker = 0;

        //this function is used to open or close the memory form.
        public static void DisplayMemory(bool show)
        {
            if (memoryForm == null) { return; }
            if (show)
            {
                memoryForm.Show();
            }
            else
            {
                memoryForm.Hide();
            }
        }

        //this function is used to open or close the main form
        public static void DisplayMain(bool show)
        {
            if (MainForm == null) { return; }
            if (show)
            {
                MainForm.Show();
            }
            else
            {
                MainForm.Hide();
            }
        }

        //this function is used to open or close the challange1 form
        public static void DisplayChallange1(bool show)
        {
            if (Challange1Form == null) { return; }
            if (show)
            {
                Challange1Form.Show();
            }
            else
            {
                Challange1Form.Hide();
            }
        }

        //this function is used to open or close the challange2 form
        public static void DisplayChallange2(bool show)
        {
            if (Challange2Form == null) { return; }
            if (show)
            {
                Challange2Form.Show();
            }
            else
            {
                Challange2Form.Hide();
            }
        }

    }



}
