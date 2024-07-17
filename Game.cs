using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToe
{
    internal abstract class Game
    {
        protected readonly GameField _gameField;
        protected readonly Player[] _players;

        public Game()
        {
            _gameField = new();
            _players = new Player[2];
        }

        protected void Play()
        {
            var rand = new Random();
            int playerMove = rand.Next(0, 2);
            while (true)
            {
                _players[playerMove].MakeMove(_gameField);
                playerMove = Math.Abs(playerMove + 1 - 2);
            }
        }

        public abstract void Run();
    }
}
