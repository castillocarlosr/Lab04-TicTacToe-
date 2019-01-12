using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    class Board
    {
		/// <summary>
		/// A 2D array of the gameboard
		/// </summary>
        ///<param name="">Main</param>
        /// <return>nothing</return>
		public string[,] GameBoard = new string[,]
		{
			{"1", "2", "3"},
			{"4", "5", "6"},
			{"7", "8", "9"},
		};

        /// <summary>
        /// This is what displays to the console when called.
        /// Basically have to double for-loop to read and display the board game.
        /// </summary>
        /// <return>console</return>
		public void DisplayBoard()
		{

            //TODO: Output the board to the console
            for (int i = 0; i < GameBoard.GetLength(0); i++)
            {
                for (int j = 0; j < GameBoard.GetLength(1); j++)
                {
                    Console.Write(string.Format("{0}", GameBoard[i, j]));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
            Console.ReadLine();
		
		}
	}
}
