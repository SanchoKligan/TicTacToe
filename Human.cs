namespace TicTacToe;

internal class Human(string name, char figure) : Player(name, figure)
{
    public override void MakeMove(GameField gameField)
    {
        int x = 2, y = 2, cell = 0;
        Console.Clear();
        Console.WriteLine("Ход игрока \"" + _name + "\":");
        gameField.Draw();
        Console.SetCursorPosition(x, y);
        ConsoleKeyInfo keyInfo;
        do
        {
            keyInfo = Console.ReadKey(true);
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    if (x > 2)
                    {
                        x -= 4;
                        cell--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                    if (x < 10)
                    {
                        x += 4;
                        cell++;
                    }
                    break;
                case ConsoleKey.UpArrow:
                    if (y > 2)
                    {
                        y -= 2;
                        cell -= 3;
                    }
                    break;
                case ConsoleKey.DownArrow:
                    if (y < 6)
                    {
                        y += 2;
                        cell += 3;
                    }
                    break;
                case ConsoleKey.Enter:
                    if (!gameField.IsEmptyCell(cell))
                    {
                        gameField.CellChangeValue(cell, _figure);
                    }
                    else
                    {
                        keyInfo = new ConsoleKeyInfo();
                    }
                    break;

            }
            Console.SetCursorPosition(x, y);
        }
        while (keyInfo.Key != ConsoleKey.Enter);
    }
}
