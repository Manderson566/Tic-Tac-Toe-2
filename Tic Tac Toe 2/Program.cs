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
                    string[] board = { "______0", "______1", "______2", "______3", "______4", "______5", "______6", "______7", "______8" };

                    {
                        string player = player1;
                        int count = 1;
                        bool stopBoard = true;
                        while (stopBoard)
                            if ((board[0].Contains("X")) && (board[1].Contains("X")) && (board[2].Contains("X")) ||
                                (board[3].Contains("X")) && (board[4].Contains("X")) && (board[5].Contains("X")) ||
                                (board[6].Contains("X")) && (board[7].Contains("X")) && (board[8].Contains("X")) ||
                                (board[0].Contains("X")) && (board[4].Contains("X")) && (board[8].Contains("X")) ||
                                (board[2].Contains("X")) && (board[4].Contains("X")) && (board[6].Contains("X")) ||
                                (board[1].Contains("X")) && (board[4].Contains("X")) && (board[7].Contains("X")) ||
                                (board[0].Contains("X")) && (board[3].Contains("X")) && (board[6].Contains("X")) ||
                                (board[2].Contains("X")) && (board[5].Contains("X")) && (board[8].Contains("X")))
                            //0 1 2
                            //3 4 5
                            //6 7 8
                            {
                                Console.WriteLine("Winner X");
                                stopBoard = false;
                            }
                            else if ((board[0].Contains("O")) && (board[1].Contains("O")) && (board[2].Contains("O")) ||
                                (board[3].Contains("O")) && (board[4].Contains("O")) && (board[5].Contains("O")) ||
                                (board[6].Contains("O")) && (board[7].Contains("O")) && (board[8].Contains("O")) ||
                                (board[0].Contains("O")) && (board[4].Contains("O")) && (board[8].Contains("O")) ||
                                (board[2].Contains("O")) && (board[4].Contains("O")) && (board[6].Contains("O")) ||
                                (board[1].Contains("O")) && (board[4].Contains("O")) && (board[7].Contains("O")) ||
                                (board[0].Contains("O")) && (board[3].Contains("O")) && (board[6].Contains("O")) ||
                                (board[2].Contains("O")) && (board[5].Contains("O")) && (board[8].Contains("O")))
                            {
                                Console.WriteLine("Winner O");
                                stopBoard = false;

                            }
                            else if
                               (player == player1)
                            {

                                BuildBoard(board); // Calls method and rebuilds the board.
                                Console.WriteLine($"{player1}'s Turn");
                                int entry = int.Parse(Console.ReadLine());
                                board[entry] = "___X___";
                                Console.WriteLine("Turn" + count);
                                count++;
                                player = player2;

                            }

                            else if (player == player2)
                            {

                                BuildBoard(board); // Calls method and rebuilds the board.
                                Console.WriteLine($"{player2}'s Turn");
                                int entry2 = int.Parse(Console.ReadLine());
                                board[entry2] = "___O___";
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

