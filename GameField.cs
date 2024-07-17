namespace TicTacToe;

internal class GameField
{
    private readonly char[] _cells;

    public GameField()
    {
        _cells =
        [
            ' ', ' ', ' ',
            ' ', ' ', ' ',
            ' ', ' ', ' '
        ];
    }

    public void CellChangeValue(int cell, char figure)
    {
        _cells[cell] = figure;
    }

    public bool IsEmptyCell(int cell)
    {
        return _cells[cell] != ' ';
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
