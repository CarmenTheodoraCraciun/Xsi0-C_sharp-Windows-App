using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Xsi0
{
    public partial class Xsi0_form : System.Windows.Forms.Form
    {
        public Xsi0_form()
        {
            InitializeComponent();
        }

        int[] t = new int[9];
        int runda = 0;

        private void reset()
        {
            button1.Text = ""; button2.Text = ""; button3.Text = "";
            button4.Text = ""; button5.Text = ""; button6.Text = "";
            button7.Text = ""; button8.Text = ""; button9.Text = "";
            //string[] t = new string[9];
            for (int i = 0; i < 9; ++i)
                t[i] = 0;
            button1.BackColor = Color.LightBlue;
            button2.BackColor = Color.LightBlue;
            button3.BackColor = Color.LightBlue;
            button4.BackColor = Color.LightBlue;
            button5.BackColor = Color.LightBlue;
            button6.BackColor = Color.LightBlue;
            button7.BackColor = Color.LightBlue;
            button8.BackColor = Color.LightBlue;
            button9.BackColor = Color.LightBlue;
            runda = 0;
        }

        private bool cauta()
        {
            if (t[0] != 0 && t[0] == t[4] && t[0] == t[8])
                return true;
            if (t[2] != 0 && t[2] == t[4] && t[2] == t[6])
                return true;
            for (int i = 0; i < 7; i += 3)
                if (t[i]!=0 && t[i] == t[i + 1] && t[i] == t[i + 2])
                    return true;
            for(int i=0;i<3;++i)
                if (t[i] != 0 && t[i] == t[i + 3] && t[i] == t[i + 6])
                    return true;
            return false;
        }

        private void mesaj(int runda,int[] t)
        {
            if(runda>4 && cauta())
            {
                if (runda % 2 == 0)
                       MessageBox.Show("O este castigator!", "Avem un catigator!", MessageBoxButtons.OK,MessageBoxIcon.None);
                else
                    MessageBox.Show("X este castigator!", "Avem un catigator!", MessageBoxButtons.OK, MessageBoxIcon.None);
                reset();
            }
            else
                if (runda == 9)
                    {
                        MessageBox.Show("Avem remiza!", "Remiza", MessageBoxButtons.OK, MessageBoxIcon.None);
                        reset();
                    }
                    
        }

        private void simbol(Button b, int index)
        {
            if (t[index]==0)
            {
                ++runda;
                if (runda % 2 == 0)
                {
                    t[index] = 1; b.BackColor = Color.DarkCyan; b.Text = "O";
                }
                else
                {
                    t[index] = 2; b.BackColor = Color.ForestGreen; b.Text = "X";
                }
                mesaj(runda,t);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            simbol(button1, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            simbol(button2, 1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            simbol(button3, 2);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            simbol(button4, 3);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            simbol(button5, 4);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            simbol(button6, 5);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            simbol(button7, 6);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            simbol(button8, 7);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            simbol(button9, 8);
        }
    }
}
