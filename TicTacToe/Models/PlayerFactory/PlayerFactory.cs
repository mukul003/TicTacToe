using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models.PlayerFactory
{
    internal static class PlayerFactory
    {
        public static Player createPlayerFactory(PlayerType type)
        {
            Player player;
            switch(type) { 
               case PlayerType.HumanPlayer 
               : player = new HumanPlayer();
                    break;
                case PlayerType.BotPlayer
               : player = new BotPlayer();
                    break;
                default: throw new InvalidDataException();                                        
            }

            return player;
        }
    }
}
