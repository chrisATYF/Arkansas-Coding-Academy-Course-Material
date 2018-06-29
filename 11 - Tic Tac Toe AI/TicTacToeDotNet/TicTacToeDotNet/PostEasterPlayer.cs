using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeDotNet.Core;
using TicTacToeDotNet.Core.Enums;
using TicTacToeDotNet.Core.Models;

namespace TicTacToeDotNet
{
    public class PostEasterPlayer : IPlayer
    {
        public int DeterminePlay(TicTac yourTicTac, Board board)
        {
            var winningSquares = new List<List<Square>>
            {
                board.LeftToRightDiag,
                board.RightToLeftDiag,
                board.Col(1),
                board.Col(2),
                board.Col(3),
                board.Row(1),
                board.Row(2),
                board.Row(3)
            };

            foreach (var squares in winningSquares)
            {
                var secretSauce = IsWinning(squares, yourTicTac);
                if (secretSauce.IsWinning)
                {
                    return secretSauce.WinningSquare.Position.Id;
                }
            }

            foreach (var squares in winningSquares)
            {
                var secretSauce = IsWinning(squares, IsOpponentWinning(yourTicTac));
                if (secretSauce.IsWinning)
                {
                    return secretSauce.WinningSquare.Position.Id;
                }
            }

            if (!board.CenterSquare.HasTicOrTac())
            {
                return board.CenterSquare.Position.Id;
            }

            foreach (var squares in board.CornerSquares)
            {
                if (!squares.HasTicOrTac())
                {
                    return squares.Position.Id;
                }
            }

            foreach (var squares in board.MiddleSquares)
            {
                if (!squares.HasTicOrTac())
                {
                    return squares.Position.Id;
                }
            }

            return board.RandomSquare.Position.Id;
        }

        public string SayHello()
        {
            return "Bigger better Chris";
        }

        private TicTac IsOpponentWinning(TicTac myTic)
        {
            return myTic == TicTac.X
                ? TicTac.O
                : TicTac.X;
        }

        private TicTacSecretSauce IsWinning(IEnumerable<Square> squares, TicTac valueToCheck)
        {
            var output = new TicTacSecretSauce
            {
                IsWinning = false
            };



            if (squares.Count() != 3)
            {
                return output;
            }

            var square1 = squares[0];
            var square2 = squares[1];
            var square3 = squares[2];
            if (square1.HasTicOrTac() && square2.HasTicOrTac() && square3.HasTicOrTac())
            {
                return output;
            }

            var emptyCount = 0;
            if (!square1.HasTicOrTac())
            {
                emptyCount++;
            }
            if (!square2.HasTicOrTac())
            {
                emptyCount++;
            }
            if (!square3.HasTicOrTac())
            {
                emptyCount++;
            }
            if(emptyCount != 1)
            {
                return output;
            }

            if (square1.TicTac == valueToCheck && square2.TicTac == valueToCheck && !square3.HasTicOrTac())
            {
                output.IsWinning = true;
                output.WinningSquare = square3;
                return output;
            }
            if (square2.TicTac == valueToCheck && square3.TicTac == valueToCheck && !square1.HasTicOrTac())
            {
                output.IsWinning = true;
                output.WinningSquare = square1;
                return output;
            }
            if (square1.TicTac == valueToCheck && square3.TicTac == valueToCheck && !square2.HasTicOrTac())
            {
                output.IsWinning = true;
                output.WinningSquare = square2;
                return output;
            }

            return output;
        }
    }

    public class TicTacSecretSauce
    {
        public bool IsWinning { get; set; }
        public Square WinningSquare { get; set; }
    }
}
