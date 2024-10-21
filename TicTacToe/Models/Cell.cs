using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    internal class Cell
    {
        private int Row { get; set; }
        private int Column { get; set; }

        public void setRow(int row)
        {
            this.Row = row;
        }

        public void setColumn(int column)
        {
            this.Column = column;
        }
    }
}
