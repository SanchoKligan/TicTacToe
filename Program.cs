global using System;

namespace TicTacToe;

internal class Program
{
    static void Main(string[] args)
    {
        Game game;
        if (args.Length == 1 && args[0] == "-s")
        {
            game = new Singleplayer();
        }
        else if (args.Length == 1 && args[0] == "-m")
        {
            game = new Multiplayer();
        }
        else
        {
            Console.WriteLine("Введите аргументы (-s для игры с компьютером или -m для игры вдвоём)!");
            return;
        }
        game.Run();
    }
}
