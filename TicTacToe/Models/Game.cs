using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe.Models
{
    internal class Game
    {
        private Board Board;

        private List<Player> Players;

        private List<Move> Moves;

        private List<WinningStrategies> WinningStrategies;

        public static class Builder
        {
            private Board Board;

            private List<Player> Players;

            private List<Move> Moves;

            private List<WinningStrategies> WinningStrategies;

            public Builder setPlayers(List<Player> players)
            {
                //this.pl
            }
        }

    }
}
