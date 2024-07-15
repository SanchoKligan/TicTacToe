namespace TicTacToe;

internal abstract class Player(string name, char figure)
{
    public string Name { get; set; } = name;

    public char Figure { get; set; } = figure;

    public abstract void MakeMove(GameField gameField);
}
