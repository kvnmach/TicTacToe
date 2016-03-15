using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tic Tac Toe");

            char currentPlayer = 'X';


            var board = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8' };

            while (true)
            {

                Console.WriteLine(" {0} | {1} | {2}", board[0], board[1], board[2]);
                Console.WriteLine("---------------");
                Console.WriteLine(" {0} | {1} | {2}", board[3], board[4], board[5]);
                Console.WriteLine("---------------");
                Console.WriteLine(" {0} | {1} | {2}", board[6], board[7], board[8]);

                Console.WriteLine($"Player {currentPlayer}, please enter a move");

                string userInput = Console.ReadLine();
                var move = int.Parse(userInput);

                if (currentPlayer == 'X')
                { currentPlayer = 'O'; }
                else
                { currentPlayer = 'X'; }



                if (move <= 0 || move <= 8)
                {
                    board[move] = currentPlayer;
                }
                else
                {

                    continue;
                    if (move <= 0 || move <= 8)
                    {
                        board[move] = currentPlayer;
                    }
                    else
                    {

                        continue;
                    }


                    if (board[0] == board[1] && board[1] == board[2])
                    {
                        Console.WriteLine("You won");
                        Console.ReadLine();
                    }
                    if (board[3] == board[4] && board[4] == board[5])
                    {
                        Console.WriteLine("You won");
                        Console.ReadLine();
                    }
                    if (board[6] == board[7] && board[7] == board[8])
                    {
                        Console.WriteLine("You won");
                        Console.ReadLine();
                    }

                    if (board[0] == board[3] && board[3] == board[6])
                    {
                        Console.WriteLine("You won");
                        Console.ReadLine();
                    }
                    if (board[1] == board[4] && board[4] == board[7])
                    {
                        Console.WriteLine("You won");
                        Console.ReadLine();
                    }
                    if (board[2] == board[5] && board[5] == board[8])
                    {
                        Console.WriteLine("You won");
                        Console.ReadLine();
                    }

                    if (board[0] == board[4] && board[4] == board[8])
                    {
                        Console.WriteLine("You won");
                        Console.ReadLine();
                    }
                    if (board[2] == board[4] && board[4] == board[6])
                    {
                        Console.WriteLine("You won");
                        Console.ReadLine();
                    }

                    bool isBoardFull = true;
                    foreach (var spot in board)
                    {


                        { isBoardFull = false; break; }
                        if (isBoardFull) { Console.Write("You Win!"); };





                    }
                }
            }
        }
    }
}
