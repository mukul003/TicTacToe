using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    internal class BotPlayer : Player
    {
        public BotPlayer(Symbol symbol) : base(PlayerType.BotPlayer, symbol)
        {
        }
    }
}
