using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
namespace TicTacToe
{
    class Test
    {
        [Test]

        public void TestInput()
        {
            Form1 aaa = new Form1();

            Assert.AreEqual(true, aaa.evaluate_checkwin());

        }

        [Test]
        public void TestCheckWin2DiagnoseXWin()
        {
            char[,] tiles;
            tiles = new char[3,3];
            setTiles(tiles, 0, ' ', ' ', 'x');
            setTiles(tiles, 1, ' ', 'x', ' ');
            setTiles(tiles, 2, 'x', ' ', ' ');

            char winner = new Form1().CheckWin2(tiles);
            Assert.AreEqual('X', winner);
        }

        [Test]
        public void TestCheckWin2HorizontalXWin()
        {
            char[,] tiles;
            tiles = new char[3, 3];
            setTiles(tiles, 0, 'x', 'x', 'x');
            setTiles(tiles, 1, ' ', ' ', ' ');
            setTiles(tiles, 2, ' ', ' ', ' ');

            char winner = new Form1().CheckWin2(tiles);
            Assert.AreEqual('X', winner);
        }
        [Test]
        public void TestCheckWin2VerticalXwin()
        {
            char[,] tiles;
            tiles = new char[3, 3];
            setTiles(tiles, 0, 'x', ' ', ' ');
            setTiles(tiles, 1, 'x', ' ', ' ');
            setTiles(tiles, 2, 'x', ' ', ' ');

            char winner = new Form1().CheckWin2(tiles);
            Assert.AreEqual('X', winner);
        }
        public void setTiles(char[,] tiles, int row, char a, char b, char c)
        {
            tiles[row, 0] = a;
            tiles[row, 1] = b;
            tiles[row, 2] = c;
        }
    }
}
