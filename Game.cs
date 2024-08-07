namespace TicTacToe
{
    internal abstract class Game(int fieldSize)
    {
        protected readonly GameField _gameField = new(fieldSize);
        protected readonly Player[] _players = new Player[2];

        protected char CheckEndGame()
        {
            bool isVictory(int begin, int step)
            {
                return _gameField.GetCellValue(begin) == _gameField.GetCellValue(begin + step) &&
                    _gameField.GetCellValue(begin + step) == _gameField.GetCellValue(begin + step * 2) &&
                    !_gameField.IsEmptyCell(begin);
            }

            bool flag = true;
            for (int i = 0; i < 9; i++)
            {
                if (_gameField.IsEmptyCell(i))
                {
                    flag = false;
                    break;
                }
            }
            if (flag)
            {
                return 'D';
            }
            if (isVictory(0, 1) || isVictory(6, 1) || isVictory(0, 3) || isVictory(2, 3) || isVictory(0, 4) || isVictory(2, 2))
            {
                return 'X';
            }
            return 'N';
        }

        protected void Play()
        {
            var rand = new Random();
            int playerMove = rand.Next(0, 2);
            char endGame = 'N';
            while (endGame == 'N')
            {
                Console.Clear();
                Console.WriteLine("Ход игрока \"" + _players[playerMove].Name + "\":");
                _gameField.Draw();
                _players[playerMove].MakeMove(_gameField);
                playerMove = Math.Abs(playerMove + 1 - 2);
                endGame = CheckEndGame();
            }
            Console.Clear();
            if (endGame == _players[0].Figure)
            {
                Console.WriteLine("Победил игрок \"" + _players[0].Name + "\"!");
            }
            else if (endGame == _players[1].Figure)
            {
                Console.WriteLine("Победил игрок \"" + _players[1].Name + "\"!");
            }
            else
            {
                Console.WriteLine("Ничья!");
            }
            _gameField.Draw();
        }

        public abstract void Run();
    }
}
