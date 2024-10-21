using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    internal class HumanPlayer : Player
    {
        public HumanPlayer(Symbol symbol, User user) :base(PlayerType.HumanPlayer, symbol)
        {

        }
    }
}
