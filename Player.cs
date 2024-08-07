namespace TicTacToe;

internal abstract class Player(string name, char figure)
{
    public string Name { get; } = name;

    public char Figure { get; } = figure;

    public abstract void MakeMove(GameField gameField);
}