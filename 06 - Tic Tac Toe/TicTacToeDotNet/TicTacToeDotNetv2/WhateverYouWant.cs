using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeDotNet.Core;
using TicTacToeDotNet.Core.Enums;
using TicTacToeDotNet.Core.Models;

namespace TicTacToeDotNetv2
{
    public class WhateverYouWant : IPlayer
    {
        public int DeterminePlay(TicTac yourTicTac, Board board)
        {
            if (board.MakePlay(yourTicTac, 1))
            {
                return 1;
            }
            else if (board.MakePlay(yourTicTac, 9))
            {
                return 9;
            }
            else if (board.IsCenterSquareAvailable)
            {
                return board.CenterSquare.Position.Id;
            }
            else if (board.MakePlay(yourTicTac, 3))
            {
                return 3;
            }
            else if (board.MakePlay(yourTicTac, 4))
            {
                return 4;
            }
            else if (board.MakePlay(yourTicTac, 8))
            {
                return 8;
            }
            else
            {
                return board.RandomSquare.Position.Id;
            }
        }

        public string SayHello()
        {
            return "Chris";
        }
    }
}
