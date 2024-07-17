namespace TicTacToe;

internal static class Game
{
    private static readonly GameField _gameField;
    private static readonly Player[] _players;

    static Game()
    {
        _gameField = new();
        _players = new Player[2];
    }

    public static void SinglePlay()
    {
        Console.Write("Введите Ваше имя: ");
        string name = Console.ReadLine();
        char figure;
        while (true)
        {
            Console.Write("Выберите фигуру (X или O): ");
            figure = char.Parse(Console.ReadLine());
            if (figure == 'X' || figure == 'O')
            {
                break;
            }
            else
            {
                Console.WriteLine("Недопустимое значение!\n");
            }
        }
        _players[0] = new Human(name, figure);
        if (figure == 'X')
        {
            _players[1] = new Computer("Компьютер", 'O');
        }
        else
        {
            _players[1] = new Computer("Компьютер", 'X');
        }
        Play();
    }

    public static void MultiPlay()
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

    private static void Play()
    {
        var rand = new Random();
        int playerMove = rand.Next(0, 2);
        while (true)
        {
            _players[playerMove].MakeMove(_gameField);
            playerMove = Math.Abs(playerMove + 1 - 2);
        }
    }
}
