using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    internal class Board
    {
        private int Dimensions { get; set; }

        private List<List<Cell>> Cells { get; set; }

        public Board(int dimensions)
        {
            this.Dimensions = dimensions;
        }

        public void CreateBoard()
        {
            //Cells = new List<List<Cell>>();
            //for(int i=0;i< Dimensions; i++)
            //{
            //    List<Cell> cells = new List<Cell>();
            //    for(int j = 0; j < Dimensions; j++)
            //    {
                    
            //        cells.Add( new Cell().setRow(i).setCol(j));
            //    }
            //}
        }

        
    }
}
