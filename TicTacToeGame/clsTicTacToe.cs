using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    /// <summary>
    /// This class performs all in depth checks inside of the array
    /// It returns all of the boolean variables needed
    /// to update the GUI
    /// </summary>
    public class clsTicTacToe
    {
        #region var Initialization
        public clsTicTacToe() { boardEval = new string[3, 3]; }
        public bool startGame; // Ensuring that the user wants to start the game


        public int p1Wins; // Amount of wins for player 1
        public int p2Wins; // Amount of wins for player 2
        public int ties; // Amount of wins for player 3
        public int playCount; // amount of times played

        public bool p1Winner = false; // bool values to update who won on the gui. 
        public bool p2Winner = false;
        public bool noWinner = false;

        private string winType; //Row1 win

        private string[,] boardEval; // the array that hold the values entered to be evaluated
        #endregion var Initialization

        /// <summary>
        /// This is setting all of the values in the array
        /// </summary>
        /// <param name="row"></param>
        /// <param name="col"></param>
        /// <param name="value"></param>
        public void setSpot(int row, int col, string value)
        {
            boardEval[row, col] = value;
            playCount++;
        }
        
        /// <summary>
        /// This will evaluate and return the winType 
        /// It will also increment the amount of wins
        /// for either player one or two.
        /// It is a novel.
        /// </summary>
        /// <returns></returns>
        public string checkWin()
        {
            //Row1 win
            if(boardEval[0,0] != null && boardEval[0,0] == boardEval[0, 1] && boardEval[0, 1] == boardEval[0, 2]) // row 1 win
            {
                if(boardEval[0, 0] == "X")
                {
                    p1Wins++;
                    p1Winner = true;
                }
                else if (boardEval[0, 0] == "O")
                {
                    p2Wins++;
                    p2Winner = true;
                }
                winType = "Row1";
                return winType;
            }
            else if (boardEval[1, 0] != null && boardEval[1, 0] == boardEval[1, 1] && boardEval[1, 1] == boardEval[1, 2]) // row 2 win
            {
                if (boardEval[1, 0] == "X")
                {
                    p1Wins++;
                    p1Winner = true;
                }
                else if (boardEval[1, 0] == "O")
                {
                    p2Wins++;
                    p2Winner = true;
                }
                winType = "Row2";
                return winType;
            }
            else if (boardEval[2, 0] != null && boardEval[2, 0] == boardEval[2, 1] && boardEval[2, 1] == boardEval[2, 2]) // row 3 win
            {
                if (boardEval[2, 0] == "X")
                {
                    p1Wins++;
                    p1Winner = true;
                }
                else if (boardEval[2, 0] == "O")
                {
                    p2Wins++;
                    p2Winner = true;
                }
                winType = "Row3";
                return winType;
            }
            else if (boardEval[0, 0] != null && boardEval[0, 0] == boardEval[1, 0] && boardEval[1, 0] == boardEval[2, 0]) // column 1 win
            {
                if (boardEval[0, 0] == "X")
                {
                    p1Wins++;
                    p1Winner = true;
                }
                else if (boardEval[0, 0] == "O")
                {
                    p2Wins++;
                    p2Winner = true;
                }
                winType = "Col1";
                return winType;
            }
            else if (boardEval[0, 1] != null && boardEval[0, 1] == boardEval[1, 1] && boardEval[1, 1] == boardEval[2, 1]) // column 2 win
            {
                if (boardEval[0, 1] == "X")
                {
                    p1Wins++;
                    p1Winner = true;
                }
                else if (boardEval[0, 1] == "O")
                {
                    p2Wins++;
                    p2Winner = true;
                }
                winType = "Col2";
                return winType;
            }
            else if (boardEval[0, 2] != null && boardEval[0, 2] == boardEval[1, 2] && boardEval[1, 2] == boardEval[2, 2]) // column 3 win
            {
                if (boardEval[0, 2] == "X")
                {
                    p1Wins++;
                    p1Winner = true;
                }
                else if (boardEval[0, 2] == "O")
                {
                    p2Wins++;
                    p2Winner = true;
                }
                winType = "Col3";
                return winType;
            }
            else if (boardEval[0, 0] != null && boardEval[0, 0] == boardEval[1, 1] && boardEval[1, 1] == boardEval[2, 2]) // diag 1 win (left top to right bottom)
            {
                if (boardEval[0, 0] == "X")
                {
                    p1Wins++;
                    p1Winner = true;
                }
                else if (boardEval[0, 0] == "O")
                {
                    p2Wins++;
                    p2Winner = true;
                }
                winType = "Diag1";
                return winType;
            }
            else if (boardEval[0, 2] != null && boardEval[0, 2] == boardEval[1, 1] && boardEval[1, 1] == boardEval[2, 0]) // diag 2 win (right top to left bottom)
            {
                if (boardEval[0, 2] == "X")
                {
                    p1Wins++;
                    p1Winner = true;
                }
                else if (boardEval[0, 2] == "O")
                {
                    p2Wins++;
                    p2Winner = true;
                }
                winType = "Diag2";
                return winType;
            }
            else
            {
                if(playCount == 9)
                {
                    ties++;
                    noWinner = true;
                }
                else
                {
                    return "";
                }
                
            }


            return "";
        }

        /// <summary>
        /// This will clear the array and also the playcounter
        /// </summary>
        public void clearScreen()
        {
            Array.Clear(boardEval, 0, boardEval.Length);
            playCount = 0;
            return;
        }
        
    }// end clsTicTacToe
}
