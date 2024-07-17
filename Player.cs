namespace TicTacToe;

internal abstract class Player(string name, char figure)
{
    protected string _name = name;
    protected char _figure = figure;

    public abstract void MakeMove(GameField gameField);
}
