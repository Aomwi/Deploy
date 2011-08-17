using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace InputOXinEmpty
{
    class Program
    {
        static void Main(string[] args)
        {

            Input input = new Input();
            while (true)
            {
                Console.Write("Input O for player 1: ");
                string n1 = Console.ReadLine();

                input.InputO(n1);
                Console.Write("Input X for player 2: ");
                string n2 = Console.ReadLine();
                input.InputX(n2);
            }
        }
    }
}
