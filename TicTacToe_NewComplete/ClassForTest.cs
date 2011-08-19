using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;

namespace TicTacToe
{

    class ClassForTest
    {
        public static string name;

        public static string ShowName(string str)
        {
            return str;
        }

        public static void SetName(string n)
        {
            name = n;
        }

    }
}
