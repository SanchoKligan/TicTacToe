namespace TicTacToe;

internal static class Game
{
    public static void Run()
    {
        Player player, computer;
        Console.Write("Введите Ваше имя: ");
        string name = Console.ReadLine();
        char figure = ' ';
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
        player = new Human(name, figure);
        if (figure == 'X')
        {
            computer = new Computer("Компьютер", 'O');
        }
        else
        {
            computer = new Computer("Компьютер", 'X');
        }
        var gameField = new GameField();
        player.MakeMove(gameField);
    }
}
