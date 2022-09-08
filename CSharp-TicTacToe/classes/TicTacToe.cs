using System;
namespace CSharp_TicTacToe.classes
{
    public class TicTacToe
    {
        //Fields
        private string[,] playingField; //Comma is used to declare 2D array in C#

        //Constructor
        public TicTacToe()
        {
            this.playingField = new string[11,11]; //Used to draw field
            for(int row=0; row < playingField.GetLength(0); row++) //Goes through 1st dimension
            {
                for(int col=0; col < playingField.GetLength(1); col++) //Goes through 2nd dimension
                {
                    if((col+1) % 4 == 0 && (col+1) != 12)
                    {
                        playingField[row, col] = "|";
                    } else if(row == 3 || row == 7)
                    {
                        playingField[row, col] = "-";
                    }
                    else
                    {
                        playingField[row, col] = " ";
                    }
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
            for(int i=0; i < this.playingField.GetLength(0); i++) //1st Dimension
            {
                for(int j=0; j < this.playingField.GetLength(1); j++) //2nd Dimension
                {
                    Console.Write(playingField[i, j]);
                }
                Console.WriteLine();
            }
        }
    }
}

