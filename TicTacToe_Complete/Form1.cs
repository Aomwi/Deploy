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
        public int count = 0, numX = 0, numO = 0, posX = 0, posY = 0;
        public List<Button> arrList = new List<Button>();
        public Button[,] listButton = new Button[3, 3];
        public List<int> listNum;
        public bool comPlay, randomInput;
        public bool win = false, draw = false, comInput = false, turn = true;
       
        public Form1()
        {
            InitializeComponent();
            setFont();
            KeepButtonToList();
        
        }

        public void KeepButtonToList()
        {
            int n = 0;
            arrList.Add(button1);
            arrList.Add(button2);
            arrList.Add(button3);
            arrList.Add(button4);
            arrList.Add(button5);
            arrList.Add(button6);
            arrList.Add(button7);
            arrList.Add(button8);
            arrList.Add(button9);

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    listButton[i, j] = arrList.ElementAt(n);
                    n++;
                }
            }
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
            label1.Font = new Font("Tahoma", 13, FontStyle.Bold);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            InputOX(button1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            InputOX(button2);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            InputOX(button3);           
        }
      
        private void button4_Click(object sender, EventArgs e)
        {
            InputOX(button4);                   
        }

        private void button5_Click(object sender, EventArgs e)
        {
            InputOX(button5);            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            InputOX(button6);                     
        }

        private void button7_Click(object sender, EventArgs e)
        {
            InputOX(button7);      
        }

        private void button8_Click(object sender, EventArgs e)
        {
            InputOX(button8);                      
        }
       
        private void button9_Click(object sender, EventArgs e)
        {
            InputOX(button9);          
        }

        public void TwoPlayerPlay(Button button)
        {            
            if (button.Text == "")
            {
                count++;
                if (turn)
                {
                    button.Text = "X";
                    label1.Text = " Turn O ";

                }
                else
                {
                    button.Text = "O";
                    label1.Text = " Turn X ";
                }
                turn = !turn;
            }

            Check_Winner();
            win = false;
            draw = false;
        }

        public void PlayerPlay(Button button)
        {

            if (button.Text == "")
            {
                  button.Text = "O";
                  count++;
                  label1.Text = " Turn X ";
            }

            Check_Winner();
        }

        public void InputOX(Button button)
        {

            if (comPlay == true && button.Text == "")
            {
                PlayerPlay(button);

                if (win == false && draw == false)
                {
                    ComputerPlay();
                }
                else
                {
                    win = false;
                    draw = false;
                }
            }
            else if (comPlay == true && button.Text != "")
            {

            }
            else
                TwoPlayerPlay(button);
        }

        public void ComputerPlay()
        {
            randomInput = true;
            comInput = false;

            for (int i = 0; i < 3; i++)
            {
                CheckHorizontal(i);

                if (comInput == true)
                    break;

                CheckVertical(i);

                if (comInput == true)
                    break;
            }

            Check_Transverse(); //Check Transvers
           
            if (randomInput == true)
            {
                RandomInput();
                count++;
            }
            Check_Winner();
            win = false;
            draw = false;
        }

        public void Check_Winner()
        {
            if (CheckWin() == true)
            {
                MessageBox.Show("Congratulation!", "You are win");
                SetEmptyTiles();
                win = true;
                count = 0;
            }
            else
            {
                if (count == 9)
                {
                    MessageBox.Show("Draw !!", "Draw !!");
                    SetEmptyTiles();
                    draw = true;
                    count = 0;
                }
            }
        }

        public void Check_Transverse()
        {
            if (comInput == false)
            {
                SetValueToZero();
                CheckTransverse(2, 0);
                CheckTransverse(1, 1);
                CheckTransverse(0, 2);
                FillOnEmptyTile(numX, numO, posX, posY);
            }

            if (comInput == false)
            {
                SetValueToZero();
                CheckTransverse(0, 0);
                CheckTransverse(1, 1);
                CheckTransverse(2, 2);
                FillOnEmptyTile(numX, numO, posX, posY);
            }
        }

        public bool CheckWin()
        {
            for (int i = 0; i <= 2; i++)
            {
                if (listButton[0, i].Text == "X" && listButton[1, i].Text == "X" && listButton[2, i].Text == "X")
                {
                    label2.Text = "Player X is Winner!!";
                    return true;
                }
                else if (listButton[0, i].Text == "O" && listButton[1, i].Text == "O" && listButton[2, i].Text == "O")
                {
                     label2.Text = "Player O is Winner!!";
                     return true;
                }
                if (listButton[i, 0].Text == "X" && listButton[i, 1].Text == "X" && listButton[i, 2].Text == "X")
                {
                    label2.Text = "Player X is Winner!!";
                    return true;
                }
                else if (listButton[i, 0].Text == "O" && listButton[i, 1].Text == "O" && listButton[i, 2].Text == "O")
                {
                     label2.Text = "Player O is Winner!!";
                     return true;
                }
            }

            if (listButton[0, 0].Text == "X" && listButton[1,1].Text == "X" && listButton[2, 2].Text == "X")
            {
                label2.Text = "Player X is Winner!!";
                return true;

            }
            else if (listButton[0, 0].Text == "O" && listButton[1, 1].Text == "O" && listButton[2, 2].Text == "O")
            {
                label2.Text = "Player O is Winner!!";
                return true;
            }
            else if (listButton[0, 2].Text == "X" && listButton[1, 1].Text == "X" && listButton[2, 0].Text == "X")
            {
                label2.Text = "Player X is Winner!!";
                return true;
            }
            else if (listButton[0, 2].Text == "O" && listButton[1, 1].Text == "O" && listButton[2, 0].Text == "O")
            {
                label2.Text = "Player O is Winner!!";
                return true;
            }
            return false;              
        }

        public void SetEmptyTiles()
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

        }

        private void vSComputerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vSComputerToolStripMenuItem.Checked = true;
            SetEmptyTiles();
            vSPlayerToolStripMenuItem.Checked = false;
            comPlay = true;
        }

        private void vSPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            vSComputerToolStripMenuItem.Checked = false;           
            vSPlayerToolStripMenuItem.Checked = true;
            comPlay = false;
        }
     
        public void RandomInput()
        {
            listNum = new List<int>();

            for (int i = 0; i < 9; i++)
            {
                if (arrList.ElementAt(i).Text == "")
                {
                    listNum.Add(i);
                }
            }

            int numLength = listNum.Count;
            Random random = new Random();
            int randNum = random.Next() % numLength;
            int indexList = listNum.ElementAt(randNum);
            arrList.ElementAt(indexList).Text = "X";
        }

        public void CheckVertical(int fixCol)
        {
            SetValueToZero();

            for (int row = 0; row < 3; row++)
            {
                if (listButton[row, fixCol].Text == "X")
                    numX++;
                else if (listButton[row, fixCol].Text == "O")
                    numO++;
                else
                {
                    posX = row;
                    posY = fixCol;
                }
            }

            FillOnEmptyTile(numX, numO, posX, posY);
        }

        public void CheckHorizontal(int fixRow)
        {
            SetValueToZero();

            //Check each row has "O" or "X" 2 tiles
            for (int col = 0; col < 3; col++)
            {
                if (listButton[fixRow, col].Text == "X")
                {
                    numX++;
                }
                else if (listButton[fixRow, col].Text == "O")
                    numO++;
                else
                {
                    posX = fixRow;
                    posY = col;
                }
            }

            FillOnEmptyTile(numX, numO, posX, posY);
        }

        public void CheckTransverse(int i, int j)
        {           
            if (listButton[i, j].Text == "X")
                numX++;
            else if (listButton[i, j].Text == "O")
                numO++;
            else
            {
                posX = i;
                posY = j;
            }           
        }

        public void FillOnEmptyTile(int numX,int numO,int posX, int posY)
        {
            if (numX == 2 && listButton[posX, posY].Text == "") //If there are 2 "X" in the same row, set the empty tile to ""
            {
                listButton[posX, posY].Text = "X";
                count++;
                comInput = true;
                randomInput = false;

            }
            else if (numO == 2 && listButton[posX, posY].Text == "") //If there are 2 "O" in the same row, set the empty tile to ""
            {
                listButton[posX, posY].Text = "X";
                count++;
                comInput = true;
                randomInput = false;
            }
        }

        public void SetValueToZero()
        {
            numX = 0;
            numO = 0;
            posX = 0;
            posY = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetEmptyTiles();
        }
 

    }
}
