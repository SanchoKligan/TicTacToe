namespace TicTacToe;

internal class GameField
{
    private readonly char[] _cells;

    public int FieldSize { get; }

    public GameField(int fieldSize)
    {
        FieldSize = fieldSize * fieldSize;
        _cells = new char[FieldSize];
        for (int i = 0; i < FieldSize; i++)
        {
            _cells[i] = ' ';
        }
    }

    public char GetCellValue(int cell)
    {
        return _cells[cell];
    }

    public void ChangeCellValue(int cell, char figure)
    {
        _cells[cell] = figure;
    }

    public bool IsEmptyCell(int cell)
    {
        return _cells[cell] == ' ';
    }

    public void Draw()
    {
        Console.WriteLine("+---+---+---+");
        Console.WriteLine("| " + _cells[0] + " | " + _cells[1] + " | " + _cells[2] + " |");
        Console.WriteLine("+---+---+---+");
        Console.WriteLine("| " + _cells[3] + " | " + _cells[4] + " | " + _cells[5] + " |");
        Console.WriteLine("+---+---+---+");
        Console.WriteLine("| " + _cells[6] + " | " + _cells[7] + " | " + _cells[8] + " |");
        Console.WriteLine("+---+---+---+");
    }
}
