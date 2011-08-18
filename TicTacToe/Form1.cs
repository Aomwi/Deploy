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
        private int count = 0;
       

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
            test(0, 0, button1);
          
             
   
        }

        private void button2_Click(object sender, EventArgs e)
        {
            test(0, 1, button2);

         
          
        }
        private void button3_Click(object sender, EventArgs e)
        {
            test(0, 2, button3);
           
        }

      
      private void button4_Click(object sender, EventArgs e)
        {
            test(1, 0, button4);

          
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            test(1, 1, button5);

            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            test(1, 2, button6);
           
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            test(2, 0, button7);
        
        }

        private void button8_Click(object sender, EventArgs e)
        {
            test(2, 1, button8);
         
                   
           
        }


        
        private void button9_Click(object sender, EventArgs e)
        {
            test(2, 2, button9);
           

        }

        public void test(int x, int y, System.Windows.Forms.Button button)
        {
            
            if (button.Text == "")
            {
                count++;
                if (turn)
                {
                    arrTiles[x, y] = 'x';
                    button.Text = "X";
                    label1.Text = " Turn O ";

                }
                else
                {
                    arrTiles[x, y] = 'o';
                    button.Text = "O";
                    label1.Text = " Turn X ";

                }

                turn = !turn;

            }

            if (CheckkWin() == true)
            {
                MessageBox.Show("Congratulation!", "You are win");
                setEmptyTiles();
                count = 0;
            }
            else
            {
                if (count == 9)
                {
                    MessageBox.Show("Draw !!", "Draw !!");
                    setEmptyTiles();
                    count = 0;
                }
            }

        }
        

        public bool CheckkWin()

        {
            for (int i = 0; i <= 2; i++)
            {
                if (arrTiles[0, i] == 'x' && arrTiles[1, i] == 'x' && arrTiles[2, i] == 'x')
                {
                    label2.Text = "Player X is Winner!!";
                    return true;
                }
                else if (arrTiles[0, i] == 'o' && arrTiles[1, i] == 'o' && arrTiles[2, i] == 'o')
                {
                     label2.Text = "Player O is Winner!!";
                     return true;
                }
                if (arrTiles[i, 0] == 'x' && arrTiles[i, 1] == 'x' && arrTiles[i, 2] == 'x')
                {
                    label2.Text = "Player X is Winner!!";
                    return true;
                }
                else if (arrTiles[i, 0] == 'o' && arrTiles[i, 1] == 'o' && arrTiles[i, 2] == 'o')
                {
                     label2.Text = "Player O is Winner!!";
                     return true;
                }
            }

            if (arrTiles[0, 0] == 'x' && arrTiles[1, 1] == 'x' && arrTiles[2, 2] == 'x')
            {
                label2.Text = "Player X is Winner!!";
                return true;

            }
            else if (arrTiles[0, 0] == 'o' && arrTiles[1, 1] == 'o' && arrTiles[2, 2] == 'o')
            {
                label2.Text = "Player O is Winner!!";
                return true;
            }
            else if (arrTiles[0, 2] == 'x' && arrTiles[1, 1] == 'x' && arrTiles[2, 0] == 'x')
            {
                label2.Text = "Player X is Winner!!";
                return true;
            }
            else if (arrTiles[0, 2] == 'o' && arrTiles[1, 1] == 'o' && arrTiles[2, 0] == 'o')
            {
                label2.Text = "Player O is Winner!!";
                return true;
            }

            return false;      
        
        }

        /*
        
        public void CheckHorizontally()
        {
            for (int i = 0; i < 2; i++)
            {
                if (arrTiles[0, i] == 'x' && arrTiles[1,i] == 'x' && arrTiles[2,i] == 'x')
                {
                    label2.Text = "Player X is Winner!!";
                }
                else if (arrTiles[0,i] == 'o' && arrTiles[1, i] == 'o' && arrTiles[2,i] == 'o')
                {
                    label2.Text = "Player O is Winner!!";
                    
                }
            }

        }
          
       
        public void CheckVertical()
        {
            for (int i = 0; i < 2; i++)
            {
                if (arrTiles[i, 0]== 'x' && arrTiles[i, 1] == 'x' && arrTiles[i, 2] == 'x')
                {
                    label2.Text = "Player X is Winner!!";
                }
                else if (arrTiles[i, 0] == 'o' && arrTiles[i, 1] == 'o' && arrTiles[i, 2] == 'o')
                {
                    label2.Text = "Player O is Winner!!";
                }
            }
            
        
        }

      
     
       public void CheckCrosswiseDown()
        {

           
                if (arrTiles[0,0] == 'x' && arrTiles[1, 1] == 'x' && arrTiles[2, 2] == 'x')
                {
                    label2.Text = "Player X is Winner!!";
                  
                }
               
                else if (arrTiles[0, 0] == 'o' && arrTiles[1, 1] == 'o' && arrTiles[2, 2] == 'o')
                {
                    label2.Text = "Player O is Winner!!"; 
                }

               
        }
       public void CheckCrosswiseUp()
       {


           if (arrTiles[0, 2] == 'x' && arrTiles[1, 1] == 'x' && arrTiles[2, 0] == 'x')
           {
               label2.Text = "Player X is Winner!!";
           }

           else if (arrTiles[0, 2] == 'o' && arrTiles[1, 1] == 'o' && arrTiles[2, 0] == 'o')
           {
               label2.Text = "Player O is Winner!!";
           }
           
          

       }


       public void Equa()
       {
           

           label2.Text = "Don't has The Winner";
       }

       public void checkWin()
       {
           
           CheckHorizontally();
           CheckCrosswiseDown();
           CheckCrosswiseUp();

          

       }
 * */

        public void setEmptyTiles()
        {
            button1.Text = "";
            button2.Text = "";
            button3.Text = "";
            button4.Text = "";
            button5.Text = "";
            button6.Text = "";
            button7.Text = "";
            button8.Text = "";
            button9.Text = "";
            label2.Text = "";

            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    arrTiles[i, j] = 'f';

        }

    }
}
