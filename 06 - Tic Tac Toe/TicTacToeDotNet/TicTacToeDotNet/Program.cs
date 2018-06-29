using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeDotNet.Enums;
using TicTacToeDotNet.Models;

namespace TicTacToeDotNet
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Good luck");

            var board = new Board();
            board.Build();

            Console.WriteLine(board.Print());

            var currentPlayer = TicTac.X;
            while (board.CurrentStatus != Outcome.CatsGame || !board.IsWinner())
            {
                var position = Convert.ToInt32(Console.ReadLine());

                if (!board.MakeMove(position, currentPlayer))
                {
                    Console.WriteLine("That square is taken");
                }
                else
                {
                    Console.WriteLine(board.Print());

                    if (currentPlayer == TicTac.X)
                    {
                        currentPlayer = TicTac.O;
                    }
                    else
                    {
                        currentPlayer = TicTac.X;
                    }
                }
            }
            Console.WriteLine("Winner winner chicken dinner");
            Console.ReadLine();
        }
    }
}
