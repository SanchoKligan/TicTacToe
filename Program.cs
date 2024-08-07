global using System;

namespace TicTacToe;

internal class Program
{
    static int Main(string[] args)
    {
        Game game;
        switch (args.Length)
        {
            case 0:
                game = new Singleplayer(3);
                game.Run();
                break;
            case 1:
                if (args[0] == "-s")
                {
                    game = new Singleplayer(3);
                }
                else if (args[0] == "-m")
                {
                    game = new Multiplayer(3);
                }
                else if (args[0] == "-h" ||  args[0] == "--help")
                {
                    Console.WriteLine("Использование: TicTacToe* [АРГУМЕНТЫ] ...\n" +
                        "При отсутствии аргументов вызывается команда: TicTacToe* -s 3\n\n" +
                        "* - Имя приложения может отличаться в зависимости от ОС\n\n" +
                        "-s           игра в одиночном режиме (с компьютером)\n" +
                        "             через пробел необходимо указать размер поля (от 3 до 10)\n" +
                        "-m           игра в многопользовательском режиме (два игрока)\n" +
                        "             через пробел необходимо указать размер поля (от 3 до 10)\n" +
                        "-h, --help   вывод справки");
                    return 0;
                }
                else
                {
                    Console.WriteLine("Неверный аргумент " + args[0] + "\n" +
                        "Для вывода справки используйте аргумент -h (--help)");
                    return 1;
                }
                game.Run();
                break;
            case 2:
                int argValue = 0;
                if (args[0] == "-s" || args[0] == "-m")
                {
                    if (int.TryParse(args[1], out argValue) && argValue >= 3 && argValue <= 10)
                    {
                        if (args[0] == "-s")
                        {
                            game = new Singleplayer(argValue);
                        }
                        else
                        {
                            game = new Multiplayer(argValue);
                        }
                        game.Run();
                    }
                    else
                    {
                        Console.WriteLine("Неверный размер поля " + args[1] + "\n" +
                            "Для вывода справки используйте аргумент -h (--help)");
                        return 1;
                    }
                }
                else
                {
                    Console.WriteLine("Неверный аргумент " + args[0] + " " + args[1] + "\n" +
                        "Для вывода справки используйте аргумент -h (--help)");
                }
                break;
            default:
                Console.WriteLine("Неверное количество аргументов\n" +
                    "Для вывода справки используйте аргумент -h (--help)");
                return 1;
        }
        return 0;
    }
}
