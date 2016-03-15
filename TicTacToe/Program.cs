using System;
using System.Linq;

namespace TicTacToe
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe");

            var currentPlayer = 'X';


            var board = new[] {'0', '1', '2', '3', '4', '5', '6', '7', '8'};

            while (true)
            {
                DrawBoard(board);


                var move = AskForMove(currentPlayer);

                board[move] = currentPlayer;

                if (CheckForWin(board))
                {
                    Console.WriteLine("You won");
                    Console.ReadLine();
                    break;
                }

                var isBoardFull = board.All(spot => spot == 'X' || spot == 'O');
                if (isBoardFull)
                {
                    Console.Write("You Tied!");
                    break;
                }

                //switch turn
                currentPlayer = currentPlayer == 'X' ? 'O' : 'X';
            }
        }

        private static int AskForMove(char currentPlayer)
        {
            int move;

            string userInput;
            do
            {
                Console.WriteLine($"Player {currentPlayer}, please enter a move");
                userInput = Console.ReadLine();
            } while (!int.TryParse(userInput, out move));

            return move;
        }

        private static void DrawBoard(char[] board)
        {
            Console.WriteLine(" {0} | {1} | {2}", board[0], board[1], board[2]);
            Console.WriteLine("------------");
            Console.WriteLine(" {0} | {1} | {2}", board[3], board[4], board[5]);
            Console.WriteLine("------------");
            Console.WriteLine(" {0} | {1} | {2}", board[6], board[7], board[8]);
        }

        private static bool CheckForWin(char[] board)
        {
            if ((board[0] == board[1] && board[1] == board[2])
                || (board[3] == board[4] && board[4] == board[5])
                || (board[6] == board[7] && board[7] == board[8])
                || (board[0] == board[3] && board[3] == board[6])
                || (board[1] == board[4] && board[4] == board[7])
                || (board[2] == board[5] && board[5] == board[8])
                || (board[0] == board[4] && board[4] == board[8])
                || (board[2] == board[4] && board[4] == board[6]))
            {
                return true;
            }
            return false;
        }
    }
}