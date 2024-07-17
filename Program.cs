global using System;

namespace TicTacToe;

internal class Program
{
    static void Main(string[] args)
    {
        if (args.Length == 1 && args[0] == "-s")
        {
            Game.SinglePlay();
        }
        else if (args.Length == 1 && args[0] == "-m")
        {
            Game.MultiPlay();
        }
        else
        {
            Console.WriteLine("Введите аргументы (-s для игры с компьютером или -m для игры вдвоём)!");
        }
    }
}
