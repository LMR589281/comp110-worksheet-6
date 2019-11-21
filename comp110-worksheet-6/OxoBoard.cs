using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace comp110_worksheet_6
{
    public enum Mark { None, O, X };

    public class OxoBoard
    {
        // Constructor. Perform any necessary data initialisation here.
        // Uncomment the optional parameters if attempting the stretch goal -- keep the default values to avoid breaking unit tests.
        public OxoBoard(/* int width = 3, int height = 3, int inARow = 3 */) {
            public int[,] board = new int[3, 3]; //declare list as a 2d array 
            //return board;
    }
}

 
 

		// Return the contents of the specified square.
		public Mark GetSquare(int x, int y){
            if (board(x, y) == Mark.None)//checks if empty 
            {
                return Mark.None;//return none
    }
            else if (board(x, y) == Mark.O)//checks if O
    {
                return Mark.O;//return O
    }
            else if (board(x, y) == Mark.X)//checks if X
    {
                return Mark.X;//return X
    }
            else { 
                //error
            }
        }

		// If the specified square is currently empty, fill it with mark and return true.
		// If the square is not empty, leave it as-is and return False.
		public bool SetSquare(int x, int y, Mark mark){
            if (board(x, y) == mark.None)//checks if tile is empty
            {
                board(x, y) == mark//marks the board with the given input
                return true;//returns true
            }
            else if (board(x, y) == mark.O || board(x, y) == mark.X)//checks if tile has X or O
    {
                return false;//returns false
    }
            else
            {
                //error
            }
        }

		// If there are still empty squares on the board, return false.
		// If there are no empty squares, return true.
		public bool IsBoardFull() {//loops the same quare 9 times does not go through all combinations
            public int square = 0;//this is used to check how many squares of the board is full
            for (int i=0; i < 8; i++) {//loops 9 times to check the 3x3 board
                if (board(x, y) == mark.X || board(x, y) == mark.O){//checks if tile has X or O
                    square++//increase square if the tile has been used
                }
            }
            if (square = 9) {//checks if all 9 square have been fulled 
                return true;//returns true
            }
            else {
                return false;//returns false
            }
		}

		// If a player has three in a row, return Mark.O or Mark.X depending on which player.
		// Otherwise, return Mark.None.
		public Mark GetWinner(){//sorry for the brute force, baised on top left
            if (board(0, 0) == Mark.X && board(1, 0) == Mark.X && board(2, 0) == Mark.X) { return Mark.X; }//across 1 for X 
            else if (board(0, 1) == Mark.X && board(1, 1) == Mark.X && board(2, 1) == Mark.X) { return Mark.X; }//across 2 for X
            else if (board(0, 2) == Mark.X && board(1, 2) == Mark.X && board(2, 2) == Mark.X) { return Mark.X; }//across 3 for X
            else if (board(0, 0) == Mark.X && board(0, 1) == Mark.X && board(0, 2) == Mark.X) { return Mark.X; }//up and down 1 for X
            else if (board(0, 1) == Mark.X && board(1, 1) == Mark.X && board(2, 1) == Mark.X) { return Mark.X; }//up and down 2 for X
            else if (board(0, 2) == Mark.X && board(1, 2) == Mark.X && board(2, 2) == Mark.X) { return Mark.X; }//up and down 3 for X
            else if (board(0, 2) == Mark.X && board(1, 1) == Mark.X && board(2, 0) == Mark.X) { return Mark.X; }//diagonal 1 for X
            else if (board(0, 0) == Mark.X && board(1, 1) == Mark.X && board(2, 2) == Mark.X) { return Mark.X; }//diagonal 2 for X

            else if (board(0, 0) == Mark.O && board(1, 0) == Mark.O && board(2, 0) == Mark.O) { return Mark.O; }//across 1 for O 
            else if (board(0, 1) == Mark.O && board(1, 1) == Mark.O && board(2, 1) == Mark.O) { return Mark.O; }//across 2 for O
            else if (board(0, 2) == Mark.O && board(1, 2) == Mark.O && board(2, 2) == Mark.O) { return Mark.O; }//across 3 for O
            else if (board(0, 0) == Mark.O && board(0, 1) == Mark.O && board(0, 2) == Mark.O) { return Mark.O; }//up and down 1 for O
            else if (board(0, 1) == Mark.O && board(1, 1) == Mark.O && board(2, 1) == Mark.O) { return Mark.O; }//up and down 2 for O
            else if (board(0, 2) == Mark.O && board(1, 2) == Mark.O && board(2, 2) == Mark.O) { return Mark.O; }//up and down 3 for O
            else if (board(0, 2) == Mark.O && board(1, 1) == Mark.O && board(2, 0) == Mark.O) { return Mark.O; }//diagonal 1 for O
            else if (board(0, 0) == Mark.O && board(1, 1) == Mark.O && board(2, 2) == Mark.O) { return Mark.O; }//diagonal 2 for O

    else { return Mark.None; }
}

		// Display the current board state in the terminal. You should only need to edit this if you are attempting the stretch goal.
		public void PrintBoard()
		{
			for (int y = 0; y < 3; y++)
			{
				if (y > 0)
					Console.WriteLine("--+---+--");

				for (int x = 0; x < 3; x++)
				{
					if (x > 0)
						Console.Write(" | ");

					switch (GetSquare(x, y))
					{
						case Mark.None:
							Console.Write(" "); break;
						case Mark.O:
							Console.Write("O"); break;
						case Mark.X:
							Console.Write("X"); break;
					}
				}

				Console.WriteLine();
			}
		}
	}
}

