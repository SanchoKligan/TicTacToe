namespace TicTacToe
{
    internal class Multiplayer(int fieldSize) : Game(fieldSize)
    {
        public override void Run()
        {
            Console.Write("Введите имя первого игрока: ");
            string name1 = Console.ReadLine();
            Console.Write("Введите имя второго игрока: ");
            string name2 = Console.ReadLine();
            var rand = new Random();
            if (rand.Next(0, 2) == 0)
            {
                _players[0] = new Human(name1, 'X');
                _players[1] = new Human(name2, 'O');
            }
            else
            {
                _players[0] = new Human(name1, 'O');
                _players[1] = new Human(name2, 'X');
            }
            Play();
        }
    }
}
