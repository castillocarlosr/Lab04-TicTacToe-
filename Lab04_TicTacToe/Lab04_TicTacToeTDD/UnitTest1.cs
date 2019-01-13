using System;
using Xunit;
using Lab04_TicTacToe.Classes;
//using static Lab04_TicTacToe.Program;

namespace Lab04_TicTacToeTDD
{
    public class UnitTest1
    {
        [Fact]
        public void VerticalWin()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Game gameTest = new Game(playerOne, playerTwo);

            Board boardTest = new Board();
            boardTest.GameBoard = new string[,]
            {
                {"1", "2", "3" },
                {"4", "5", "4" },
                {"X", "X", "X" }
            };
            gameTest.Board = boardTest;
            Assert.True(gameTest.CheckForWinner(gameTest.Board));
        }

        [Fact]
        public void HorizontalWin()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Game gameTest = new Game(playerOne, playerTwo);

            Board boardTest = new Board();
            boardTest.GameBoard = new string[,]
            {
                {"1", "2", "X" },
                {"4", "5", "X" },
                {"7", "8", "X" }
            };
            gameTest.Board = boardTest;
            Assert.True(gameTest.CheckForWinner(gameTest.Board));
        }

        [Fact]
        public void DiagonalWin()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Game gameTest = new Game(playerOne, playerTwo);

            Board boardTest = new Board();
            boardTest.GameBoard = new string[,]
            {
                {"1", "2", "X" },
                {"4", "X", "9" },
                {"X", "8", "9" }
            };
            gameTest.Board = boardTest;
            Assert.True(gameTest.CheckForWinner(gameTest.Board));
        }

        [Fact]
        public void Tie()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Game gameTest = new Game(playerOne, playerTwo);

            Board boardTest = new Board();
            boardTest.GameBoard = new string[,]
            {
                {"1", "2", "3" },
                {"4", "5", "6" },
                {"7", "8", "9" }
            };
            gameTest.Board = boardTest;
            Assert.False(gameTest.CheckForWinner(gameTest.Board));
        }

        [Fact]
        public void SwitchPlayer()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Game gameTest = new Game(playerOne, playerTwo);

            playerOne.IsTurn = true;
            gameTest.SwitchPlayer();

            Assert.True(playerTwo.IsTurn);
        }

        [Fact]
        public void IndexCheck()
        {
            Player playerOne = new Player();
            Player playerTwo = new Player();
            Game gameTest = new Game(playerOne, playerTwo);

            Position position = new Position(0, 0);
            Position currentPosition = Player.PositionForNumber(1);
            Assert.Equal(position.Row, position.Column);
        }
    }
}
