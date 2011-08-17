using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class Form1 : Form
    {
        private  char[,] arrTiles;
        private bool turn = true;
     

        public Form1()
        {
            InitializeComponent();
            arrTiles = new char[3, 3];
            setFont();
        }

        public void setFont()
        {
            button1.Font = new Font("Tahoma", 15, FontStyle.Bold);
            button2.Font = new Font("Tahoma", 15, FontStyle.Bold);
            button3.Font = new Font("Tahoma", 15, FontStyle.Bold);
            button4.Font = new Font("Tahoma", 15, FontStyle.Bold);
            button5.Font = new Font("Tahoma", 15, FontStyle.Bold);
            button6.Font = new Font("Tahoma", 15, FontStyle.Bold);
            button7.Font = new Font("Tahoma", 15, FontStyle.Bold);
            button8.Font = new Font("Tahoma", 15, FontStyle.Bold);
            button9.Font = new Font("Tahoma", 15, FontStyle.Bold);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "")
            {
                if (turn)
                {
                    button1.Text = "X";
                    label1.Text = "Current players, X";
                }
                else
                {
                    button1.Text = "O";
                    label1.Text = "Current players, O";
                }

                turn = !turn;


                }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "")
            {
                if (turn)
                {
                    button2.Text = "X";
                    label1.Text = "Current players, X";
                }
                else
                {
                    button2.Text = "O";
                    label1.Text = "Current players, O";
                }

                turn = !turn;

            }
        }

      
      private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "")
            {
                if (turn)
                {
                    button4.Text = "X";
                    label1.Text = "Current players, X";
                }
                else
                {
                    button4.Text = "O";
                    label1.Text = "Current players, O";
                }

                turn = !turn;
               
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "")
            {
                if (turn)
                {
                    button5.Text = "X";
                    label1.Text = "Current players, X";
                }
                else
                {
                    button5.Text = "O";
                    label1.Text = "Current players, O";
                }

                turn = !turn;

            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "")
            {
                if (turn)
                {
                    button6.Text = "X";
                    label1.Text = "Current players, X";
                }
                else
                {
                    button6.Text = "O";
                    label1.Text = "Current players, O";
                }

                turn = !turn;

            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "")
            {
                if (turn)
                {
                    button7.Text = "X";
                    label1.Text = "Current players, X";
                }
                else
                {
                    button7.Text = "O";
                    label1.Text = "Current players, O";
                }

                turn = !turn;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "")
            {
                if (turn)
                {
                    button8.Text = "X";
                    label1.Text = "Current players, X";
                }
                else
                {
                    button8.Text = "O";
                    label1.Text = "Current players, O";
                }

                turn = !turn;

            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "")
            {
                if (turn)
                {
                    button9.Text = "X";
                    label1.Text = "Current players, X";
                }
                else
                {
                    button9.Text = "O";
                    label1.Text = "Current players, O";
                }

                turn = !turn;

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "")
            {
                if (turn)
                {
                    button3.Text = "X";
                    label1.Text = "Current players, X";
                }
                else
                {
                    button3.Text = "O";
                    label1.Text = "Current players, X";
                }

                turn = !turn;

            }
        }  

     
    }
}
