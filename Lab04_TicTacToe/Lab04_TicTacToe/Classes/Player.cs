﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab04_TicTacToe.Classes
{
    public class Player
    {
        /// <summary>
        /// This is what gets the name and sets them as P1 and P2
        /// </summary>
        /// <return>string</return>
        public string Name { get; set; }

		/// <summary>
		/// P1 is X and P2 will be O
		/// </summary>
        /// <return>string</return>
		public string Marker { get; set; }

		/// <summary>
		/// Flag to determine if it is the user's turn
		/// </summary>
        /// <return></return>
		public bool IsTurn { get; set; }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="board"></param>
        /// <returns></returns>
		public Position GetPosition(Board board)
		{
			Position desiredCoordinate = null;
			while (desiredCoordinate is null)
			{
				Console.WriteLine("Please select a location");
				Int32.TryParse(Console.ReadLine(), out int position);
				desiredCoordinate = PositionForNumber(position);
			}
			return desiredCoordinate;

		}

        /// <summary>
        /// This is where the user enters the number for which position they want.
        /// </summary>
        /// <param name="position"></param>
        /// <returns></returns>
		public static Position PositionForNumber(int position)
		{
            switch (position)
			{
				case 1: return new Position(0, 0); // Top Left
				case 2: return new Position(0, 1); // Top Middle
				case 3: return new Position(0, 2); // Top Right
				case 4: return new Position(1, 0); // Middle Left
				case 5: return new Position(1, 1); // Middle Middle
				case 6: return new Position(1, 2); // Middle Right
				case 7: return new Position(2, 0); // Bottom Left
				case 8: return new Position(2, 1); // Bottom Middle 
				case 9: return new Position(2, 2); // Bottom Right

				default: return null;
			}
		}

        /// <summary>
        /// This is where the player turns are made and switch between one and two.
        /// </summary>
        /// <param name="board"></param>
        public void TakeTurn(Board board)
		{
			IsTurn = true;

            //Had to add Marker in console line so I could know if I was X or O
			Console.WriteLine($"{Name} it is your turn and your marker us {Marker}");

			Position position = GetPosition(board);

			if (Int32.TryParse(board.GameBoard[position.Row, position.Column], out int _))
			{
				board.GameBoard[position.Row, position.Column] = Marker;
			}
			else
			{
				Console.WriteLine("This space is already occupied");
                Console.ReadLine();
                IsTurn = false;
			}
		}
	}
}
