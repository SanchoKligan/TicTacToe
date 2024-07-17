namespace TicTacToe
{
    internal class Singleplayer() : Game()
    {
        public override void Run()
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
    }
}
