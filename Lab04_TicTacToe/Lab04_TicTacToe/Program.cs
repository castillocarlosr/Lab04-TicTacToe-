using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    class Program
    {
        ///Carlos Castillo Jan. 11, 2019
        /// <summary>
        /// Should hopefully run well and start the tic-tac-toe by calling the game.
        /// </summary>
        /// <param name="args">Main</param>
        /// <return>console game</return>
        static void Main(string[] args)
        {
            LetsPlayTicTacToe();
        }

        /// <summary>
        /// This is where the magic starts.  This prompts the user for their names.
        /// </summary>
        /// <return></return>
        static void LetsPlayTicTacToe()
        {
            //Console.Clear();
            Console.WriteLine("Welcome to the amazing world of Tic Tac Toe");
            Console.WriteLine("\n");
            Console.WriteLine("Player 1 has marker \"X\"");
            Console.Write("Player 1 please type in your name: ");
            string inputNameOne = Console.ReadLine();
            Console.WriteLine("Player 2 has marker \"O\"");
            Console.Write("Player 2 please type in your name: ");
            string inputNameTwo = Console.ReadLine();

            Player playerOne = new Player
            {
                Name = inputNameOne,
                Marker = "X"
            };
            Player playerTwo = new Player
            {
                Name = inputNameTwo,
                Marker = "O"
            };

            //Creates the game
            Game newGame = new Game(playerOne, playerTwo);
            Console.WriteLine("");

            //Playes the game
            string winner = newGame.Play().Name;

            //Displayes the winner
            if(winner == null)
            {
                Console.WriteLine("It is a DRAW!");
            }
            else
            {
                Console.WriteLine($"Congratulations {winner}.  You have WON!");
            }

            Console.WriteLine("Would you like to play again?  y/n");
            string playAgain = Console.ReadLine();
            if(playAgain.ToLower() == "y")
            {
                LetsPlayTicTacToe();
            }
        }
    }
}
