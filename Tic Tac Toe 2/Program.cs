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
                    string[] board = { "_", "_", "_", "_", "_", "_", "_", "_", "_" };

                    {
                        string player = player1;
                        int count = 1;
                        bool stopBoard = true;
                        while (stopBoard)

                            if (player == player1)
                            {
                                
                                BuildBoard(board); // Calls method and rebuilds the board.
                                Console.WriteLine($"{player1}'s Turn");
                                int entry = int.Parse(Console.ReadLine());
                                board[entry] = "X";
                                Console.WriteLine("To The Death!");
                                Console.WriteLine("Turn" + count);
                                count++;
                                player = player2;
                            }
                        
                            else if ( player == player2 )
                            {
                                Console.Clear();
                                BuildBoard(board); // Calls method and rebuilds the board.
                                Console.WriteLine($"{player2}'s Turn");
                                int entry2 = int.Parse(Console.ReadLine());
                                board[entry2] = "O";
                                Console.WriteLine("To The Death!");
                                Console.WriteLine("Turn" + count);
                                player = player1;

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
        static void BuildBoard(string[] board) //Method for building board.
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

