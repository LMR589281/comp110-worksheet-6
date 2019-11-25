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
        Mark[,] board; 
        // Constructor. Perform any necessary data initialisation here.
        // Uncomment the optional parameters if attempting the stretch goal -- keep the default values to avoid breaking unit tests.
        public OxoBoard(/* int width = 3, int height = 3, int inARow = 3 */) {
            board = new Mark[3, 3]; //declare list as a 2d array 
    }
		// Return the contents of the specified square.
		public Mark GetSquare(int x, int y){
            if (board[x, y] == Mark.None)//checks if empty 
            {
                return Mark.None;//return none
    }
            else if (board[x, y] == Mark.O)//checks if O
    {
                return Mark.O;//return O
    }
            else //checks if X
    {
                return Mark.X;//return X
    }
        }
		// If the specified square is currently empty, fill it with mark and return true.
		// If the square is not empty, leave it as-is and return False.
		public bool SetSquare(int x, int y, Mark mark){
            if (board[x, y] == Mark.None)//checks if tile is empty
            {
                board[x, y] = mark;//marks the board with the given input
                return true;//returns true
            }
            else //checks if tile has X or O
    {
                return false;//returns false
    }
        }
		// If there are still empty squares on the board, return false.
		// If there are no empty squares, return true.
		public bool IsBoardFull() { //loops the same quare 9 times does not go through all combinations
            int square = 0;  //this is used to check how many squares of the board is full
            for (int x = 0; x < 3; x++) { //loops 9 times to check the 3x3 board
                for (int y = 0; y < 3; y++)
                {
                    if (board[x, y] == Mark.X || board[x, y] == Mark.O)
                    {//checks if tile has X or O
                        square++;   //increase square if the tile has been used
                    }
                }
            }
            if (square == 9) {   //checks if all 9 square have been fulled 
                return true;    //returns true
            }
            else {
                return false;   //returns false
            }
		}
		// If a player has three in a row, return Mark.O or Mark.X depending on which player.
		// Otherwise, return Mark.None.
		public Mark GetWinner(){//sorry for the brute force, baised on top left
            bool winner = true;
            Mark old_mark = Mark.None;
            for (int x = 0; x  < 3; x++) {
                for (int y = 0; y < 3; y++) {
                    old_mark = board[x, 0];
                    if (board[x, y] != old_mark) {
                        winner = false;
                    
                    }
                }
            if (winner == true)
                {
                    return old_mark;
                }
            }
                }


            //if (board[x, y + 1] == mark && board[x, y + 2] == mark)
                //return mark;
            }







            /*
                        public Mark[] marks = new Mark[Mark.X, Mark.O];

                        for (int i=0; i< 1; i++) {//loops through once for all X combinations then does all O combinations

                        if (board(0, 0) == marks[i] && board(1, 0) == marks[i] && board(2, 0) == marks[i]) { return marks[i]; }//across 1 for X/O 
                        else if (board(0, 1) == marks[i] && board(1, 1) == marks[i] && board(2, 1) == marks[i]) { return marks[i]; }//across 2 for X/O
                        else if (board(0, 2) == marks[i] && board(1, 2) == marks[i] && board(2, 2) == marks[i]) { return marks[i]; }//across 3 for X/O
                        else if (board(0, 0) == marks[i] && board(0, 1) == marks[i] && board(0, 2) == marks[i]) { return marks[i]; }//up and down 1 for X/O
                        else if (board(0, 1) == marks[i] && board(1, 1) == marks[i] && board(2, 1) == marks[i]) { return marks[i]; }//up and down 2 for X/O
                        else if (board(0, 2) == marks[i] && board(1, 2) == marks[i] && board(2, 2) == marks[i]) { return marks[i]; }//up and down 3 for X/O
                        else if (board(0, 2) == marks[i] && board(1, 1) == marks[i] && board(2, 0) == marks[i]) { return marks[i]; }//diagonal 1 for X/O
                        else if (board(0, 0) == marks[i] && board(1, 1) == marks[i] && board(2, 2) == marks[i]) { return marks[i]; }}//diagonal 2 for X/O
                else { return Mark.None; }
            }
            */


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


