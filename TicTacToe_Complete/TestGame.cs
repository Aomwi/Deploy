using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Windows.Forms;

namespace TicTacToe
{
    [TestFixture]
    class TestGame
    {

        Form1 form = new Form1();
        Button button1 = new Button();
        Button button2 = new Button();
        Button button3 = new Button();

 
        [Test]
        public void Test_TwoPlayerPlay()
        {
            button1.Text = "";
            form.turn = true;
            form.TwoPlayerPlay(button1);
            Assert.AreEqual("X", button1.Text);
            
            button1.Text = "";
            form.turn = false;
            form.TwoPlayerPlay(button1);
            Assert.AreEqual("O", button1.Text);

            button2.Text = "O";
            form.turn = true;
            form.TwoPlayerPlay(button1);
            Assert.AreEqual("O", button2.Text);

            button2.Text = "O";
            form.turn = false;
            form.TwoPlayerPlay(button1);
            Assert.AreEqual("O", button2.Text);

            button3.Text = "X";
            form.turn = true;
            form.TwoPlayerPlay(button1);
            Assert.AreEqual("X", button3.Text);

            button3.Text = "X";
            form.turn = false;
            form.TwoPlayerPlay(button1);
            Assert.AreEqual("X", button3.Text);
        }

        [Test]
        public void Test_PlayerPlay()
        {
            button1.Text = "";
            button2.Text = "O";
            button3.Text = "X";

            form.PlayerPlay(button1);
            form.PlayerPlay(button2);
            form.PlayerPlay(button3);

            Assert.AreEqual("O", button1.Text);
            Assert.AreEqual("O", button2.Text);
            Assert.AreEqual("X", button3.Text);
        }

        [Test]
        public void Test_InputOX_WithTwoPlayer()
        {
            button1.Text = "";
            button2.Text = "O";
            button3.Text = "X";

            form.InputOX(button1);
            form.InputOX(button2);
            form.InputOX(button3);

            Assert.AreEqual("X", button1.Text);
            Assert.AreEqual("O", button2.Text);
            Assert.AreEqual("X", button3.Text);

        }

        [Test]
        public void Test_InputOX_WithComPlayer()
        {
            button1.Text = "";
            button2.Text = "O";
            button3.Text = "X";

            form.comPlay = true;

            form.InputOX(button1);
            form.InputOX(button2);
            form.InputOX(button3);

            Assert.AreEqual("O", button1.Text);
            Assert.AreEqual("O", button2.Text);
            Assert.AreEqual("X", button3.Text);

        }

        [Test]
        public void Test_Winner()
        {
            form.arrList.ElementAt(0).Text = "X";
            form.arrList.ElementAt(1).Text = "X";
            form.arrList.ElementAt(2).Text = "X";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            Assert.AreEqual(true, form.CheckWin());

            form.arrList.ElementAt(0).Text = "X";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "X";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "X";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            Assert.AreEqual(true, form.CheckWin());

            form.arrList.ElementAt(0).Text = "X";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "X";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "X";
            Assert.AreEqual(true, form.CheckWin());

            form.arrList.ElementAt(0).Text = "O";
            form.arrList.ElementAt(1).Text = "O";
            form.arrList.ElementAt(2).Text = "O";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            Assert.AreEqual(true, form.CheckWin());

            form.arrList.ElementAt(0).Text = "O";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "O";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "O";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            Assert.AreEqual(true, form.CheckWin());

            form.arrList.ElementAt(0).Text = "O";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "O";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "O";
            Assert.AreEqual(true, form.CheckWin());

            form.arrList.ElementAt(0).Text = "X";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "X";
            Assert.AreEqual(false, form.CheckWin());

            form.arrList.ElementAt(0).Text = "O";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "O";
            Assert.AreEqual(false, form.CheckWin());

        }

        [Test]
        public void Test_Check_Winner_Win()
        {
            form.arrList.ElementAt(0).Text = "X";
            form.arrList.ElementAt(1).Text = "X";
            form.arrList.ElementAt(2).Text = "X";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            form.Check_Winner();
            Assert.AreEqual(true, form.win);

            form.arrList.ElementAt(0).Text = "X";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "X";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "X";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            form.Check_Winner();
            Assert.AreEqual(true, form.win);

            form.arrList.ElementAt(0).Text = "X";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "X";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "X";
            form.Check_Winner();
            Assert.AreEqual(true, form.win);

            form.arrList.ElementAt(0).Text = "O";
            form.arrList.ElementAt(1).Text = "O";
            form.arrList.ElementAt(2).Text = "O";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            form.Check_Winner();
            Assert.AreEqual(true, form.win);

            form.arrList.ElementAt(0).Text = "O";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "O";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "O";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            form.Check_Winner();
            Assert.AreEqual(true, form.win);

            form.arrList.ElementAt(0).Text = "O";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "O";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "O";
            form.Check_Winner();
            Assert.AreEqual(true, form.win);

        }

        [Test]
        public void Test_Check_Winner_Draw()
        {
            form.count = 9;
            form.Check_Winner();
            Assert.AreEqual(true, form.draw);
        }

        [Test]
        public void Test_CheckVertical()
        {
            

            form.arrList.ElementAt(0).Text = "X";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "X";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "X";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            form.CheckVertical(0);
            Assert.AreEqual(3, form.numX);

            form.arrList.ElementAt(0).Text = "O";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "O";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "O";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            form.CheckVertical(0);
            Assert.AreEqual(3, form.numO);

        }

        [Test]
        public void Test_CheckHorizontal()
        {
            form.arrList.ElementAt(0).Text = "X";
            form.arrList.ElementAt(1).Text = "X";
            form.arrList.ElementAt(2).Text = "X";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            form.CheckHorizontal(0);
            Assert.AreEqual(3, form.numX);

            form.arrList.ElementAt(0).Text = "O";
            form.arrList.ElementAt(1).Text = "O";
            form.arrList.ElementAt(2).Text = "O";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            form.CheckHorizontal(0);
            Assert.AreEqual(3, form.numO);
        }

        [Test]
        public void Test_Check_Transverse()
        {
            form.comInput = false;

            form.arrList.ElementAt(0).Text = "X";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "X";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "X";
            form.Check_Transverse();
            Assert.AreEqual(3, form.numX);

            form.arrList.ElementAt(0).Text = "O";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "O";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "O";
            form.Check_Transverse();
            Assert.AreEqual(3, form.numO);

            form.comInput = false;
            form.arrList.ElementAt(0).Text = "";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "X";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "X";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "X";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            form.Check_Transverse();
            // Assert.AreEqual(3, form.numX);

            form.arrList.ElementAt(0).Text = "";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "O";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "O";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "O";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            form.Check_Transverse();
           // Assert.AreEqual(2, form.numO);
        }

        [Test]
        public void Test_CheckTransverse()
        {
            form.arrList.ElementAt(0).Text = "X";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "X";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "X";

            form.CheckTransverse(0, 0);
            Assert.AreEqual(1, form.numX);
            form.CheckTransverse(1, 1);
            Assert.AreEqual(2, form.numX);
            form.CheckTransverse(2, 2);
            Assert.AreEqual(3, form.numX);

            form.arrList.ElementAt(0).Text = "O";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "O";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "O";

            form.CheckTransverse(0, 0);
            Assert.AreEqual(1, form.numO);
            form.CheckTransverse(1, 1);
            Assert.AreEqual(2, form.numO);
            form.CheckTransverse(2, 2);
            Assert.AreEqual(3, form.numO);

            form.arrList.ElementAt(0).Text = "";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "X";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "X";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "X";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";
            form.Check_Transverse();

            form.numX = 0;
            form.CheckTransverse(2, 0);
            Assert.AreEqual(1, form.numX);
            form.CheckTransverse(1, 1);
            Assert.AreEqual(2, form.numX);
            form.CheckTransverse(0, 2);
            Assert.AreEqual(3, form.numX);

            form.arrList.ElementAt(0).Text = "";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "O";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "O";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "O";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "";

            form.CheckTransverse(2, 0);
            Assert.AreEqual(1, form.numO);
            form.CheckTransverse(1, 1);
            Assert.AreEqual(2, form.numO);
            form.CheckTransverse(0, 2);
            Assert.AreEqual(3, form.numO);

        }
    
        [Test]
        public void Test_FillOnEmptyTile()
        {
            form.arrList.ElementAt(0).Text = "X";
            form.arrList.ElementAt(1).Text = "X";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "O";
            form.arrList.ElementAt(8).Text = "O";

            form.FillOnEmptyTile(2, 0, 0, 2); //Horizontal
            Assert.AreEqual("X", form.listButton[0, 2].Text);

            form.FillOnEmptyTile(0, 2, 2, 0); //Horizontal
            Assert.AreEqual("X", form.listButton[2, 0].Text);

            form.arrList.ElementAt(0).Text = "X";
            form.arrList.ElementAt(1).Text = "";
            form.arrList.ElementAt(2).Text = "";
            form.arrList.ElementAt(3).Text = "X";
            form.arrList.ElementAt(4).Text = "";
            form.arrList.ElementAt(5).Text = "O";
            form.arrList.ElementAt(6).Text = "";
            form.arrList.ElementAt(7).Text = "";
            form.arrList.ElementAt(8).Text = "O";

            form.FillOnEmptyTile(2, 0, 2, 0); //Vertical
            Assert.AreEqual("X", form.listButton[2, 0].Text);

            form.FillOnEmptyTile(0, 2, 0, 2); //Vertical
            Assert.AreEqual("X", form.listButton[0, 2].Text);

        }
        

    }
}
