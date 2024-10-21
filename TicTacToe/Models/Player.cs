using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    internal abstract class Player
    {
        public PlayerType playerType { get; set; }

        public Symbol symbol { get; set; }

        public Player(PlayerType playerType, Symbol symbol)
        {
            this.playerType = playerType;
            this.symbol = symbol;
        }

        public 
    }

    public enum PlayerType
    {
        HumanPlayer,
        BotPlayer
    }
}
