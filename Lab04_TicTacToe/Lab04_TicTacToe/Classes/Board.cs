using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Board
    {
		/// <summary>
		/// A 2D array of the gameboard
		/// </summary>
        ///<param name="GameBoard">GameBoard</param>
        /// <return>string array</return>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

        /// <summary>
        /// This is what displays to the console when called.
        /// Basically have to double for-loop to read and display the board game to console.
        /// </summary>
        /// <return>console</return>
		public void DisplayBoard()
		{
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    Console.Write($"|{GameBoard[i, j]}|");
                }
                Console.WriteLine("\n");
            }
		}
	}
}
