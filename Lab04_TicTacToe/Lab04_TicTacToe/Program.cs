using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.WriteLine("Welcome to the amazing world of Tic Tac Toe");
            Console.WriteLine("\n");
            Console.Write("Player 1 please type in your name: ");
            string inputNameOne = Console.ReadLine();
            Console.Write("Player 2 please type in your name: ");
            string inputNameTwo = Console.ReadLine();
            //Game TicTacToe = new Game(inputNameOne, inputNameTwo);
            Console.WriteLine(GameBoard);
        }
    }
}
