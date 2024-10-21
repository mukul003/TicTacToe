using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    internal class Symbol
    {
        public char Character { get; set; }

        public Symbol(char Character)
        {
            this.Character = Character;
        }
    }
}
