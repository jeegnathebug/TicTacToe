using System;
using System.Linq;
using System.Windows.Forms;

namespace TicTacToe
{
    public partial class TicTacToe : Form
    {
        // Preferences form
        Preferences preferenceForm;
        // X/O markers
        string marker;
        bool playerXTurn = true;
        // Turns
        int turnsX = 0;
        int turnsO = 0;
        // Player X moves
        Button[] playerXMoves = new Button[5];
        // Player O moves
        Button[] playerOMoves = new Button[4];

        public TicTacToe()
        {
            InitializeComponent();

            // Difficulty
            Properties.Settings.Default.difficultyEasy = true;
            Properties.Settings.Default.difficultyMedium = false;
            Properties.Settings.Default.difficultyHard = false;

            // Mode
            Properties.Settings.Default.vsComp = false;
            Properties.Settings.Default.vsHuman = true;

            // Wins/Losses/Draws
            Properties.Settings.Default.xWins = 0;
            Properties.Settings.Default.oWins = 0;
            Properties.Settings.Default.draws = 0;

            // Language (where true is English and false is French)
            Properties.Settings.Default.language = true;

            // Initialise preferences form
            preferenceForm = new Preferences(this);
        }

        private void btn_Click(object sender, EventArgs e)
        {

            // Cast sender to button
            Button btn = (Button)sender;

            if (playerXTurn)
            {
                marker = "X";
                playerXMoves[turnsX] = btn;
                turnsX++;
                playerXTurn = false;
            }
            else
            {
                if (Properties.Settings.Default.vsHuman)
                {
                    playerOMoves[turnsO] = btn;
                    turnsO++;
                    playerXTurn = true;
                }
            }

            // Disable button
            btn.Enabled = false;

            // Set mark
            btn.Text = marker;

            // Enable undo button
            btnUndo.Enabled = true;

            // END TURN

            // Set marker
            marker = "O";

            // Check for win/loss/draw before computer takes turn
            if (checkWin(playerXMoves))
            {
                displayWinner("X");
            }

            bool language = Properties.Settings.Default.language;
            if (turnsX == 5 && !checkWin(playerXMoves))
            {
                MessageBox.Show(language ? "It's a draw!" : "C'est un match nul!");
                Properties.Settings.Default.draws++;
                statusStripDraws.Text = (language ? "Draws: " : "Nuls: ") + Properties.Settings.Default.draws;

                // Disable buttons
                btnUndo.Enabled = false;
            }

            // If vs computer
            if (Properties.Settings.Default.vsComp && turnsO < 4 && !checkWin(playerXMoves))
            {
                compTurn();

                // Set markers
                marker = "X";
                playerXTurn = true;
            }

            // Check computer/player2 win
            if (checkWin(playerOMoves))
            {
                displayWinner("O");
            }
        }

        private void btn_MouseDown(object sender, MouseEventArgs e)
        {
            Button btn = (Button)sender;
            if (e.Button == MouseButtons.Right)
            {
                btn.Text = "!";
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            // Disable undo button
            btnUndo.Enabled = false;

            if (Properties.Settings.Default.vsComp)
            {
                // Undo both moves

                // Undo player X
                undoX();

                // Undo player O
                undoO();

                // Set marker
                playerXTurn = true;
            }
            else
            {
                // Undo last move
                if (!playerXTurn)
                {
                    // Undo player X
                    undoX();

                    // Set marker
                    playerXTurn = true;
                }
                else
                {
                    // Undo player O
                    undoO();

                    // Set marker
                    playerXTurn = false;
                }
            }

            btnUndo.Enabled = false;
        }

        private bool checkWin(Button[] playerMoves)
        {

            // Winning formats
            Button[] win1 = new Button[3] { btn1, btn2, btn3 };
            Button[] win2 = new Button[3] { btn4, btn5, btn6 };
            Button[] win3 = new Button[3] { btn7, btn8, btn9 };
            Button[] win4 = new Button[3] { btn1, btn4, btn7 };
            Button[] win5 = new Button[3] { btn2, btn5, btn8 };
            Button[] win6 = new Button[3] { btn3, btn6, btn9 };
            Button[] win7 = new Button[3] { btn1, btn5, btn9 };
            Button[] win8 = new Button[3] { btn3, btn5, btn7 };

            bool isWin = false;
            Button[][] winFormats = new Button[8][] { win1, win2, win3, win4, win5, win6, win7, win8 };
            Button[] win;

            // Goes through each win array
            int counter = 0;
            while (!isWin && counter < 8)
            {
                win = winFormats[counter];

                // Check win 
                if (!win.Except(playerMoves).Any())
                {
                    isWin = true;
                }

                counter++;
            }

            return isWin;
        }

        private void compTurn()
        {
            // Select difficulty
            if (Properties.Settings.Default.difficultyEasy)
            {
                difficultyEasy();
            }
            if (Properties.Settings.Default.difficultyMedium)
            {
                difficultyMedium();
            }
            if (Properties.Settings.Default.difficultyHard)
            {
                difficultyHard();
            }
        }

        private void difficultyEasy()
        {
            // Initialise button array
            Button[] allButtons = new Button[9] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            // Randomly generated number between 0 - 8
            Random randomIndex = new Random();
            int random = randomIndex.Next(0, 9);

            // Check if available
            int attempts = 0;
            while (!(allButtons[random].Enabled) && attempts < 9)
            {
                random = randomIndex.Next(0, 9);
                attempts++;
            }

            // Set chosen button
            setOMove(allButtons[random]);
        }

        private void difficultyMedium()
        {
            // Corner buttons (oppsite corners first)
            Button[] corners = new Button[4] { btn1, btn9, btn3, btn7 };

            // Check if available
            foreach (Button element in corners)
            {
                // If corner is available, select it
                if (element.Enabled)
                {
                    // Set chosen button
                    setOMove(element);

                    // Exit computer turn
                    return;
                }
            }

            if (btn5.Enabled == true)
            {
                // Set chosen button
                setOMove(btn5);

                // Exit computer turn
                return;
            }

            // If corners are not available, use easy settings
            difficultyEasy();
        }

        private void difficultyHard()
        {

            // First player move is corner, pick centre
            if (turnsO == 0 && (playerXMoves[0] == btn1 || playerXMoves[0] == btn3 || playerXMoves[0] == btn7 || playerXMoves[0] == btn9))
            {
                if (btn5.Enabled == true)
                {
                    // Set chosen button
                    setOMove(btn5);

                    // Exit computer turn
                    return;
                }
            }

            // First player move is centre, pick corner
            if (turnsO == 0 && (playerXMoves[0] == btn5))
            {
                difficultyMedium();

                // Exit computer turn
                return;
            }

            // First player move was neither corner nor centre. Should they really be playing vs hard?
            if (turnsO == 0 && (playerXMoves[0] == btn2 || playerXMoves[0] == btn4 || playerXMoves[0] == btn6 || playerXMoves[0] == btn8))
            {
                // Choose middle
                setOMove(btn5);
                // Exit computer turn
                return;
            }

            // Attack
            if (winningMove(playerOMoves) != null && winningMove(playerOMoves).Enabled == true)
            {
                // Set chosen button
                setOMove(winningMove(playerOMoves));

                // Exit computer turn
                return;
            }
            // Block
            if (winningMove(playerXMoves) != null && winningMove(playerXMoves).Enabled == true)
            {
                // Set chosen button
                setOMove(winningMove(playerXMoves));

                // Exit computer turn
                return;
            }

            // If no moves exist, play at random
            difficultyEasy();
            // Exit computer turn
            return;
        }

        private void displayWinner(string player)
        {
            // Info variables
            bool language = Properties.Settings.Default.language;
            int totalWins;
            string message;
            ToolStripStatusLabel winnerLabel;

            // Set info
            if (player == "X")
            {
                Properties.Settings.Default.xWins++;
                totalWins = Properties.Settings.Default.xWins;
                message = language ? "X Wins: " : "X Gagne: ";
                winnerLabel = statusStripWins;
            }
            else
            {
                Properties.Settings.Default.oWins++;
                totalWins = Properties.Settings.Default.oWins;
                message = language ? "O Wins: " : "O Gagne: ";
                winnerLabel = statusStripLosses;
            }

            // Display/update messages
            MessageBox.Show(language ? "Player " + player + " wins!" : "Jouer " + player + " gagne!");
            winnerLabel.Text = message + totalWins;

            // Disable buttons
            Button[] allButtons = new Button[9] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            foreach (Button button in allButtons)
            {
                button.Enabled = false;
            }
            btnUndo.Enabled = false;
        }

        private void menuBarItemClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void menuBarItemEnglish_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.language = true;

            menuBarItemFrench.Checked = false;
            menuBarItemEnglish.Checked = true;
            resetButtons();

            btnUndo.Text = "Undo";

            statusStripWins.Text = "X Wins: 0";
            statusStripLosses.Text = "O Wins: 0";
            statusStripDraws.Text = "Draws: 0";

            menuBarItemGame.Text = "Game";
            menuBarItemClose.Text = "Exit";
            menuBarItemNewGame.Text = "New Game";
            menuBarItemLanguage.Text = "Language";
            menuBarItemEnglish.Text = "English";
            menuBarItemFrench.Text = "French";
        }

        private void menuBarItemFrench_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.language = false;

            menuBarItemFrench.Checked = true;
            menuBarItemEnglish.Checked = false;
            resetButtons();

            btnUndo.Text = "Retour";

            statusStripWins.Text = "X Gagne: 0";
            statusStripLosses.Text = "O Gagne: 0";
            statusStripDraws.Text = "Nuls: 0";

            menuBarItemGame.Text = "Jeu";
            menuBarItemClose.Text = "Quitter";
            menuBarItemNewGame.Text = "Nouvelle Partie";
            menuBarItemLanguage.Text = "Langue";
            menuBarItemEnglish.Text = "Anglais";
            menuBarItemFrench.Text = "Francais";
        }

        private void menuBarItemNewGame_Click(object sender, EventArgs e)
        {
            resetButtons();
        }

        private void menuBarItemOptions_Click(object sender, EventArgs e)
        {
            preferenceForm = new Preferences(this);
            preferenceForm.Show();
        }

        public void resetButtons()
        {
            // Initialise all buttons
            Button[] allButtons = new Button[9] { btn1, btn2, btn3, btn4, btn5, btn6, btn7, btn8, btn9 };

            foreach (Button element in allButtons)
            {
                element.Text = "";
                element.Enabled = true;
            }

            // Reset markers
            playerXTurn = true;
            marker = "X";

            playerXMoves = new Button[5];
            turnsX = 0;
            playerOMoves = new Button[4];
            turnsO = 0;
        }

        private void setOMove(Button button)
        {
            // Set chosen button
            button.Text = marker;
            button.Enabled = false;

            // Add to playerOMoves
            playerOMoves[turnsO] = button;
            turnsO++;
        }

        private void undoO()
        {
            turnsO--;
            playerOMoves[turnsO].Enabled = true;
            playerOMoves[turnsO].Text = "";
            playerOMoves[turnsO] = null;
        }

        private void undoX()
        {
            turnsX--;
            playerXMoves[turnsX].Enabled = true;
            playerXMoves[turnsX].Text = "";
            playerXMoves[turnsX] = null;
        }

        private Button winningMove(Button[] playerMoves)
        {
            // player needs button 1 to win
            if (btn1.Enabled == true && ((playerMoves.Contains(btn7) && playerMoves.Contains(btn4)) || (playerMoves.Contains(btn2) && playerMoves.Contains(btn3)) || (playerMoves.Contains(btn5) && playerMoves.Contains(btn9))))
            {
                return btn1;
            }

            // player needs button 2 to win
            if (btn2.Enabled == true && ((playerMoves.Contains(btn1) && playerMoves.Contains(btn3)) || (playerMoves.Contains(btn5) && playerMoves.Contains(btn8))))
            {
                return btn2;
            }

            // player needs button 3 to win
            if (btn3.Enabled == true && ((playerMoves.Contains(btn1) && playerMoves.Contains(btn2)) || (playerMoves.Contains(btn6) && playerMoves.Contains(btn9)) || (playerMoves.Contains(btn5) && playerMoves.Contains(btn7))))
            {
                return btn3;
            }

            // player needs button 4 to win
            if (btn4.Enabled == true && ((playerMoves.Contains(btn1) && playerMoves.Contains(btn7)) || (playerMoves.Contains(btn5) && playerMoves.Contains(btn6))))
            {
                return btn4;
            }

            // player needs button 5 to win
            if (btn5.Enabled == true && ((playerMoves.Contains(btn2) && playerMoves.Contains(btn8)) || (playerMoves.Contains(btn4) && playerMoves.Contains(btn6)) || (playerMoves.Contains(btn1) && playerMoves.Contains(btn9)) || (playerMoves.Contains(btn3) && playerMoves.Contains(btn7))))
            {
                return btn5;
            }

            // player needs button 6 to win
            if (btn6.Enabled == true && ((playerMoves.Contains(btn3) && playerMoves.Contains(btn9)) || (playerMoves.Contains(btn4) && playerMoves.Contains(btn5))))
            {
                return btn6;
            }

            // player needs button 7 to win
            if (btn7.Enabled == true && ((playerMoves.Contains(btn1) && playerMoves.Contains(btn4)) || (playerMoves.Contains(btn8) && playerMoves.Contains(btn9)) || (playerMoves.Contains(btn3) && playerMoves.Contains(btn5))))
            {
                return btn7;
            }

            // player needs button 8 to win
            if (btn8.Enabled == true && ((playerMoves.Contains(btn2) && playerMoves.Contains(btn5)) || (playerMoves.Contains(btn7) && playerMoves.Contains(btn9))))
            {
                return btn8;
            }

            // player needs button 9 to win
            if (btn9.Enabled == true && ((playerMoves.Contains(btn3) && playerMoves.Contains(btn6)) || (playerMoves.Contains(btn7) && playerMoves.Contains(btn8)) || (playerMoves.Contains(btn1) && playerMoves.Contains(btn5))))
            {
                return btn9;
            }

            return null;
        }
    }
}
