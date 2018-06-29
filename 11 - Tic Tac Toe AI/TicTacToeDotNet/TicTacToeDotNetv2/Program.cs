using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeDotNet;
using TicTacToeDotNet.Core;

namespace TicTacToeDotNetv2
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new EasyPlayer();
            var player2 = new PostEasterPlayer();

            TicTacToeEngine.PlayGame(player1, player2);

            Console.ReadLine();
        }
    }
}
