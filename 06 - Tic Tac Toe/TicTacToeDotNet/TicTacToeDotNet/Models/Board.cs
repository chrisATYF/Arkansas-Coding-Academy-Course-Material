using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeDotNet.Enums;

namespace TicTacToeDotNet.Models
{
    class Board
    {
        private int _moveCount = 0;
        public Outcome CurrentStatus { get; set; }
        public List<Square> Squares { get; set; }

        public void Build()
        {
            CurrentStatus = Outcome.InProgress;
            Squares = new List<Square>();

            var id = 1;
            for (int x = 0; x < 3; x++)
            {
                for (int y = 0; y < 3; y++)
                {
                    Squares.Add(new Square
                    {
                        Position = new Position
                        {
                            Id = id,
                            XPosition = x,
                            YPosition = y
                        }
                    });

                    id++;
                }
            }
        }

        public string Print()
        {
            var output = "";
            foreach (var square in Squares)
            {
                if (square.Position.Id % 3 == 0)
                {
                    output = output + square.Print() + "\n";

                    if (square.Position.XPosition < 2)
                    {
                        output = output + PrintLine();
                    }
                }
                else
                {
                    output = output + square.Print() + "|";
                }
            }
            
            return output;
        }

        private string PrintLine()
        {
            return "---+---+---\n";
        }

        public bool IsWinner()
        {
            var isWinner = false;
            for (int i = 0; i < Squares.Count; i++)
            {
                var currentSquare = Squares[i];
                if (!Squares[i].isChecked())
                {
                    continue;
                }

                if (currentSquare.Position.Id == 1)
                {
                    //look diag left to right
                    var s1 = Squares[i + 4];
                    var s2 = Squares[i + 8];

                    if (currentSquare.TicTac == s1.TicTac && currentSquare.TicTac == s2.TicTac)
                    {
                        isWinner = true;
                    }
                }

                if (currentSquare.Position.Id == 3)
                {
                    //look right to left
                    var s1 = Squares[i + 2];
                    var s2 = Squares[i + 4];

                    if (currentSquare.TicTac == s1.TicTac && currentSquare.TicTac == s2.TicTac)
                    {
                        isWinner = true;
                    }
                }

                if (currentSquare.Position.YPosition == 0)
                {
                    //look down if first row
                    var s1 = Squares[i + 3];
                    var s2 = Squares[i + 6];

                    if (currentSquare.TicTac == s1.TicTac && currentSquare.TicTac == s2.TicTac)
                    {
                        isWinner = true;
                    }
                }

                if (currentSquare.Position.XPosition == 0)
                {
                    //look right if first column
                    var s1 = Squares[i + 1];
                    var s2 = Squares[i + 2];

                    if (currentSquare.TicTac == s1.TicTac && currentSquare.TicTac == s2.TicTac)
                    {
                        isWinner = true;
                    }
                }
            }

            if (!isWinner && _moveCount == 9)
            {
                CurrentStatus = Outcome.CatsGame;
            }
            
            return isWinner;
        }

        public bool MakeMove(int positionId, TicTac move)
        {
            var isValidMove = false;
            foreach (var square in Squares)
            {
                if (square.Position.Id != positionId)
                {
                    continue;
                }

                if (!square.isChecked())
                {
                    square.TicTac = move;
                    isValidMove = true;
                    _moveCount = _moveCount + 1;
                    break;
                }
            }

            return isValidMove;
        }
    }
}
