using System;

namespace TicTacToe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe");

            var currentPlayer = 'X';


            var board = new[] { '0', '1', '2', '3', '4', '5', '6', '7', '8' };

            while (true)
            {
                Console.WriteLine(" {0} | {1} | {2}", board[0], board[1], board[2]);
                Console.WriteLine("---------------");
                Console.WriteLine(" {0} | {1} | {2}", board[3], board[4], board[5]);
                Console.WriteLine("---------------");
                Console.WriteLine(" {0} | {1} | {2}", board[6], board[7], board[8]);

                Console.WriteLine($"Player {currentPlayer}, please enter a move");

                var userInput = Console.ReadLine();
                var move = int.Parse(userInput);


                board[move] = currentPlayer;



                if (board[0] == board[1] && board[1] == board[2])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                    break;
                }
                if (board[3] == board[4] && board[4] == board[5])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                    break;
                }
                if (board[6] == board[7] && board[7] == board[8])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                    break;
                }

                if (board[0] == board[3] && board[3] == board[6])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                    break;
                }
                if (board[1] == board[4] && board[4] == board[7])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                    break;
                }
                if (board[2] == board[5] && board[5] == board[8])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                    break;
                }

                if (board[0] == board[4] && board[4] == board[8])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                    break;
                }
                if (board[2] == board[4] && board[4] == board[6])
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                    break;
                }


                var isBoardFull = true;
                foreach (var spot in board)
                {
                    if (spot != 'X' || spot != 'O')
                    {
                        isBoardFull = false;
                        break;
                    }
                }

                if (isBoardFull)
                {
                    Console.Write("You Win!");
                    break;
                }


                //switch turn
                if (currentPlayer == 'X')
                {
                    currentPlayer = 'O';
                }
                else
                {
                    currentPlayer = 'X';
                }
            }
        }
    }
}