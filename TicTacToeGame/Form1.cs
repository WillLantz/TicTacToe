using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// This is calling to our clsTicTacToe class
        /// which performs all of the in depth functions
        /// </summary>
        clsTicTacToe clsTicTacMath;

        /// <summary>
        /// Loading the form
        /// </summary>
        public Form1()
        {
            InitializeComponent();

            clsTicTacMath = new clsTicTacToe();

            gameStatLbl.Text = $"Player {playerIndex} Turn"; // Starting / printing the playerIndex at 1

            statLabel.Text = $"Statistics\n\nPlayer 1 wins: {player1Wins}\n\nPlayer 2 wins: {player2Wins}\n\nTies: {ties}";

        }

        #region var Initiation

        private int playerIndex = 1; // will alternate from 1 or 2 to display who's turn it is. Starts at 1
        private int tIndex; // keeping track of rows in the array
        private int tTag = 0; // keeping track of columns in array
        private int playCount; // player can only play 9 times, will keep track of when the board is full

        private int player1Wins = 0;
        private int player2Wins = 0;
        private int ties = 0;
        
        bool p1Turn = true; // keeping track of whos turn it is
        bool p2Turn = false; // keeping track of whos turn it is
        #endregion var Initiation


        /// <summary>
        /// When the start game button is pushed
        /// The screen will be cleared and any arrays emptied
        /// All values will be reset to what they were at 
        /// the beginning of the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void startGameBtn_Click(object sender, EventArgs e)
        {
            lbl00.Text = "";
            lbl01.Text = "";
            lbl02.Text = "";
            lbl10.Text = "";
            lbl11.Text = "";
            lbl12.Text = "";
            lbl20.Text = "";
            lbl21.Text = "";
            lbl22.Text = "";
                              
            lbl00.BackColor = SystemColors.ScrollBar;
            lbl01.BackColor = SystemColors.ScrollBar;
            lbl02.BackColor = SystemColors.ScrollBar;
            lbl10.BackColor = SystemColors.ScrollBar;
            lbl11.BackColor = SystemColors.ScrollBar;
            lbl12.BackColor = SystemColors.ScrollBar;
            lbl20.BackColor = SystemColors.ScrollBar;
            lbl21.BackColor = SystemColors.ScrollBar;
            lbl22.BackColor = SystemColors.ScrollBar;

            clsTicTacMath.clearScreen();

            p1Turn = true;
            p2Turn = false;

            clsTicTacMath.p1Winner = false;
            clsTicTacMath.p2Winner = false;
            clsTicTacMath.noWinner = false;

            lbl00.Enabled = true;
            lbl01.Enabled = true;
            lbl02.Enabled = true;
            lbl10.Enabled = true;
            lbl11.Enabled = true;
            lbl12.Enabled = true;
            lbl20.Enabled = true;
            lbl21.Enabled = true;
            lbl22.Enabled = true;

            gameStatLbl.Text = "Player 1 turn";
        }// end startGameBtn_Click

        /// <summary>
        /// This takes care of all board click actions
        /// Like changing label values / colors
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void boardClick(object sender, EventArgs e)
        {

            Label myLabel = (Label)sender;
            tIndex = myLabel.TabIndex;
            tTag = Convert.ToInt32(myLabel.Tag);
  
            // if the label text is blank, fill it with X or O
            // else, return
            if (myLabel.Text == "") 
            {
                if (p1Turn == true)
                {
                    myLabel.Text = "X";
                    clsTicTacMath.setSpot(tIndex, tTag, "X"); //using setSpot method in the clsTicTacToe class
                    updateBoard();
                }
                else if (p2Turn == true)
                {
                    myLabel.Text = "O";
                    clsTicTacMath.setSpot(tIndex, tTag, "O"); //using setSpot method in the clsTicTacToe class
                    updateBoard();
                }
            }
            else
            {
                return;
            }

            playCount++; // incrementing play count to keep track of how full the array is
            changePlayerTurn(); // calling to change whos turn it is
            updateGameStats(); // updating wins / losses / ties
        } // end boardClick

        /// <summary>
        /// This method updates the boards depending on the value it got back from checkWin in
        /// the clsTicTacToe class
        /// </summary>
        private void updateBoard()
        {
            string winType = clsTicTacMath.checkWin();

            // Row are row wins
            // Col are column wins
            // Diag are diagonal wins

            if (winType == "Row1")
            {
                lbl00.BackColor = Color.Lime;
                lbl01.BackColor = Color.Lime;
                lbl02.BackColor = Color.Lime;
            }
            else if (winType == "Row2")
            {
                lbl10.BackColor = Color.Lime;
                lbl11.BackColor = Color.Lime;
                lbl12.BackColor = Color.Lime;
            }
            else if (winType == "Row3")
            {
                lbl20.BackColor = Color.Lime;
                lbl21.BackColor = Color.Lime;
                lbl22.BackColor = Color.Lime;
            }
            else if (winType == "Col1")
            {
                lbl00.BackColor = Color.Lime;
                lbl10.BackColor = Color.Lime;
                lbl20.BackColor = Color.Lime;
            }
            else if (winType == "Col2")
            {
                lbl01.BackColor = Color.Lime;
                lbl11.BackColor = Color.Lime;
                lbl21.BackColor = Color.Lime;
            }
            else if (winType == "Col3")
            {
                lbl02.BackColor = Color.Lime;
                lbl12.BackColor = Color.Lime;
                lbl22.BackColor = Color.Lime;
            }
            else if (winType == "Diag1")
            {
                lbl00.BackColor = Color.Lime;
                lbl11.BackColor = Color.Lime;
                lbl22.BackColor = Color.Lime;
            }
            else if (winType == "Diag2")
            {
                lbl02.BackColor = Color.Lime;
                lbl11.BackColor = Color.Lime;
                lbl20.BackColor = Color.Lime;
            }
            else
            {
                return;
            }

        } // end updateBoard

        /// <summary>
        /// This method will keep track of whose turn it is
        /// and change the values accordingly
        /// </summary>
        public void changePlayerTurn()
        {
            if(p1Turn == true && p2Turn == false) // change p1 turn to false, p2 turn to true
            {              
                p1Turn = false;
                p2Turn = true;
                gameStatLbl.Text = "Player 2 turn"; // Update the player turn label
            }
            else if(p1Turn == false && p2Turn == true) // change p1 turn to true, p2 turn to false
            {  
                p1Turn = true;
                p2Turn = false;
                gameStatLbl.Text = "Player 1 turn"; // Update the player turn label
            }

        }// end changePlayerTurn

        /// <summary>
        /// This will update the game stats and also the board
        /// if the game is won or has a tie. 
        /// </summary>
        public void updateGameStats()
        {
            player1Wins = clsTicTacMath.p1Wins;
            player2Wins = clsTicTacMath.p2Wins;
            ties = clsTicTacMath.ties;

            if (clsTicTacMath.p1Winner == true || clsTicTacMath.p2Winner == true || clsTicTacMath.noWinner == true) // if the game has been won, lock the tiles
            {
                lockBoard();//jump to lockBoard
            }

            statLabel.Text = $"Statistics\n\nPlayer 1 wins: {player1Wins}\n\nPlayer 2 wins: {player2Wins}\n\nTies: {ties}";

            if(clsTicTacMath.p1Winner)// Update the labls
            {
                gameStatLbl.Text = "PLAYER 1 WINS\n\nPRESS START GAME TO START A NEW GAME";
            }
            else if(clsTicTacMath.p2Winner)
            {
                gameStatLbl.Text = "PLAYER 2 WINS\n\nPRESS START GAME TO START A NEW GAME";
            }
            else if(clsTicTacMath.noWinner)
            {
                gameStatLbl.Text = "TIE GAME\n\nPRESS START GAME TO START A NEW GAME";
            }


            return;
        }
        
        /// <summary>
        /// This method will lock the board after the game is won
        /// </summary>
        public void lockBoard()
        {
            lbl00.Enabled = false;
            lbl01.Enabled = false;
            lbl02.Enabled = false;
            lbl10.Enabled = false;
            lbl11.Enabled = false;
            lbl12.Enabled = false;
            lbl20.Enabled = false;
            lbl21.Enabled = false;
            lbl22.Enabled = false;

        }                   


    } // end form
}
