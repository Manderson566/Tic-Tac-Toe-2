using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_Tac_Toe_2
{
    class Program
    {

        static void Main(string[] args)

        {
            bool restart = true;
            while (restart)
            {
                Console.WriteLine("Welcome to Tic Tac Toe. Do you want to play? Y/N");
                string playYN = Console.ReadLine();
                if (playYN.ToUpper() == "N")
                {
                    restart = false;
                }
                else if (playYN.ToUpper() == "Y")
                {
                    Console.WriteLine("Player One Enter Name");
                    restart = false;
                    string player1 = Console.ReadLine();
                    Console.WriteLine("Player Two Enter Name");
                    string player2 = Console.ReadLine();
                    Console.WriteLine($"{player1}'s Turn");
                    string[] board = { "_", "_", "_", "_", "_", "_", "_", "_", "_" };
                  
                    {
                        bool stopBoard = true;
                        while (true)
                        {
                            BuildBoard(board);
                            int entry = int.Parse(Console.ReadLine());
                            board[]
                        }
                    }
                }





                else
                {
                    Console.WriteLine("Please Make a Valid Entry");
                    restart = true;
                }

            }

        }
        static void BuildBoard(string[] board)
        {
            int counter = 0;
            foreach (string place in board)
            {
                Console.Write("  " + place);
                if (counter == 2)
                {
                    Console.WriteLine("");
                    counter = 0;
                }
                else
                {
                    counter++;
                }
            }

        }
    }
}

