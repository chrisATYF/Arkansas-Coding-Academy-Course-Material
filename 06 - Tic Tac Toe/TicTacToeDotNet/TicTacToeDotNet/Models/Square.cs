using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicTacToeDotNet.Enums;

namespace TicTacToeDotNet.Models
{
    public class Square
    {
        public TicTac TicTac { get; set; }

        public Position Position { get; set; }

        public bool isChecked()
        {
            if (TicTac == TicTac.Empty)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public bool CheckForWinner()
        {
            switch (Position.Id)
            {
                case 1:
                case 2:
                case 3:
                case 4:
                case 7:
                    return true;
                default:
                    return false;
            }
        }

        public string Print()
        {
            if (TicTac == TicTac.X)
            {
                return " X ";
            }

            if (TicTac == TicTac.O)
            {
                return " O ";
            }

            return "   ";
        }
    }
}
