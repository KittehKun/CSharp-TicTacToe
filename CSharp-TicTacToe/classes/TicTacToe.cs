using System;
namespace CSharp_TicTacToe.classes
{
    public class TicTacToe
    {
        //Fields
        private char[,] playingField; //Comma is used to declare 2D array in C#

        //Constructor
        public TicTacToe()
        {
            this.playingField = new char[11,11]; //Used to draw field
            for(int row=0; row < playingField.GetLength(0); row++) //Goes through 1st dimension
            {
                for(int col=0; col < playingField.GetLength(1); col++) //Goes through 2nd dimension
                {
                    Console.WriteLine($"Row: {row} | Column {col}");
                }
            }
        }

        //Methods
        /// <summary>
        /// Initializes the playing field and outputs it to the console.
        /// </summary>
        public void StartGame()
        {
            Console.WriteLine("Welcome to Tic Tac Toe!");
            Console.WriteLine("Press any key to start game!");
            Console.ReadKey();
            DrawGame();
        }

        private void DrawGame()
        {

        }
    }
}

