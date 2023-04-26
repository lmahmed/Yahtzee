namespace Project_2___Yahtzee
{
    public partial class Form1 : Form
    {
        Scoreboard PlayerOne;
        Scoreboard PlayerTwo;
        int Players;
        int TotalRounds;
        int CurrentRound;
        int Rolls;

        public Form1()
        {
            InitializeComponent();
            CategoryLabels playerOneLabel = new CategoryLabels(label21, label22, label23, label24, label25, label26, label27, label28, label29, label30, label31, label32, label33, label34, label35, label36);
            CategoryLabels playerTwoLabel = new CategoryLabels(label52, label51, label50, label49, label48, label47, label46, label45, label44, label43, label42, label41, label40, label39, label38, label37);
            PlayerOne = new Scoreboard(this, playerOneLabel);
            PlayerTwo = new Scoreboard(this, playerTwoLabel);

            TotalRounds = 13;
            CurrentRound = 1;
            Players = 1;
            Rolls = 3;

            currentRoundLabel.Text = CurrentRound.ToString();
        }

        private void changePlayer()
        {
            Rolls = 3;
            if (Players == 1)
            {
                Players = 2;
                PlayerOne.emptyScoreboard();
                if (CurrentRound == TotalRounds)
                {
                    PlayerOne.completeScoreboard();
                }
            }
            else if (Players == 2)
            {
                Players = 1;
                PlayerTwo.emptyScoreboard();
                if (CurrentRound != TotalRounds)
                {
                    currentRoundLabel.Text = (++CurrentRound).ToString();
                }
                else
                {
                    Rolls = 1_000_000;
                    PlayerTwo.completeScoreboard();
                    playAgainButton.Visible = true;
                }
            }
           
            // Rolls button 
            button1.Cursor = Cursors.Hand;

            resetDice();
            RollsRemaining.Text = Rolls.ToString();
        }
        private void resetDice ()
        {
            diceOne.BackColor = Color.Cyan;
            diceOne.Cursor = System.Windows.Forms.Cursors.Default;

            diceTwo.BackColor = Color.Cyan;
            diceTwo.Cursor = System.Windows.Forms.Cursors.Default;

            diceThree.BackColor = Color.Cyan;
            diceThree.Cursor = System.Windows.Forms.Cursors.Default;

            diceFour.BackColor = Color.Cyan;
            diceFour.Cursor = System.Windows.Forms.Cursors.Default;

            diceFive.BackColor = Color.Cyan;
            diceFive.Cursor = System.Windows.Forms.Cursors.Default;
        }
        private void diceOne_Click(object sender, EventArgs e)
        {
            if (Rolls == 3)
            {
                return;
            }

            if (diceOne.BackColor == System.Drawing.Color.Cyan)
            {
                diceOne.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                diceOne.BackColor = System.Drawing.Color.Cyan;
            }
        }

        private void diceTwo_Click(object sender, EventArgs e)
        {
            if (Rolls == 3)
            {
                return;
            }

            if (diceTwo.BackColor == System.Drawing.Color.Cyan)
            {
                diceTwo.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                diceTwo.BackColor = System.Drawing.Color.Cyan;
            }
        }

        private void diceThree_Click(object sender, EventArgs e)
        {
            if (Rolls == 3)
            {
                return;
            }

            if (diceThree.BackColor == System.Drawing.Color.Cyan)
            {
                diceThree.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                diceThree.BackColor = System.Drawing.Color.Cyan;
            }
        }
        private void diceFour_Click(object sender, EventArgs e)
        {
            if (Rolls == 3)
            {
                return;
            }

            if (diceFour.BackColor == System.Drawing.Color.Cyan)
            {
                diceFour.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                diceFour.BackColor = System.Drawing.Color.Cyan;
            }
        }

        private void diceFive_Click(object sender, EventArgs e)
        {
            if (Rolls == 3)
            {
                return;
            }

            if (diceFive.BackColor == System.Drawing.Color.Cyan)
            {
                diceFive.BackColor = System.Drawing.Color.Red;
            }
            else
            {
                diceFive.BackColor = System.Drawing.Color.Cyan;
            }
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            if (Rolls == 0)
            {
                return;
            }

            diceOne.Cursor = System.Windows.Forms.Cursors.Hand;
            diceTwo.Cursor = System.Windows.Forms.Cursors.Hand;
            diceThree.Cursor = System.Windows.Forms.Cursors.Hand;
            diceFour.Cursor = System.Windows.Forms.Cursors.Hand;
            diceFive.Cursor = System.Windows.Forms.Cursors.Hand;

            Random random = new Random();
            if (diceOne.BackColor == System.Drawing.Color.Cyan)
            {
                diceOne.Text = random.Next(1, 7).ToString();
            }
            if (diceTwo.BackColor == System.Drawing.Color.Cyan)
            {
                diceTwo.Text = random.Next(1, 7).ToString();
            }
            if (diceThree.BackColor == System.Drawing.Color.Cyan)
            {
                diceThree.Text = random.Next(1, 7).ToString();
            }
            if (diceFour.BackColor == System.Drawing.Color.Cyan)
            {
                diceFour.Text = random.Next(1, 7).ToString();
            }
            if (diceFive.BackColor == System.Drawing.Color.Cyan)
            {
                diceFive.Text = random.Next(1, 7).ToString();
            }
            
            if (Players == 1)
            {
                PlayerOne.calculateScoreboard();
            }
            else if (Players == 2)
            {
                PlayerTwo.calculateScoreboard();
            }

            RollsRemaining.Text = (--Rolls).ToString();

            if (Rolls == 0)
            {
                button1.Cursor = Cursors.Default;
            }    
        }

        private void Button1_VisibleChanged(object? sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void label21_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 1 && label21.BackColor == System.Drawing.SystemColors.Control)
            {
                label21.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label22_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 1 && label22.BackColor == System.Drawing.SystemColors.Control)
            {
                label22.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label23_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 1 && label23.BackColor == System.Drawing.SystemColors.Control)
            {
                label23.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label24_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 1 && label24.BackColor == System.Drawing.SystemColors.Control)
            {
                label24.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label25_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 1 && label25.BackColor == System.Drawing.SystemColors.Control)
            {
                label25.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label27_Click(object sender, EventArgs e)
        {

        }

        private void label26_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 1 && label26.BackColor == System.Drawing.SystemColors.Control)
            {
                label26.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label29_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 1 && label29.BackColor == System.Drawing.SystemColors.Control)
            {
                label29.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label30_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 1 && label30.BackColor == System.Drawing.SystemColors.Control)
            {
                label30.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label31_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 1 && label31.BackColor == System.Drawing.SystemColors.Control)
            {
                label31.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label32_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 1 && label32.BackColor == System.Drawing.SystemColors.Control)
            {
                label32.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label33_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 1 && label33.BackColor == System.Drawing.SystemColors.Control)
            {
                label33.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label34_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 1 && label34.BackColor == System.Drawing.SystemColors.Control)
            {
                label34.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label35_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 1 && label35.BackColor == System.Drawing.SystemColors.Control)
            {
                label35.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label52_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 2 && label52.BackColor == System.Drawing.SystemColors.Control)
            {
                label52.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label51_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 2 && label51.BackColor == System.Drawing.SystemColors.Control)
            {
                label51.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label50_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 2 && label50.BackColor == System.Drawing.SystemColors.Control)
            {
                label50.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label49_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 2 && label49.BackColor == System.Drawing.SystemColors.Control)
            {
                label49.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label48_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 2 && label48.BackColor == System.Drawing.SystemColors.Control)
            {
                label48.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label47_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 2 && label47.BackColor == System.Drawing.SystemColors.Control)
            {
                label47.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label44_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 2 && label44.BackColor == System.Drawing.SystemColors.Control)
            {
                label44.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label43_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 2 && label43.BackColor == System.Drawing.SystemColors.Control)
            {
                label43.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label42_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 2 && label42.BackColor == System.Drawing.SystemColors.Control)
            {
                label42.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label41_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 2 && label41.BackColor == System.Drawing.SystemColors.Control)
            {
                label41.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label40_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 2 && label40.BackColor == System.Drawing.SystemColors.Control)
            {
                label40.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label39_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 2 && label39.BackColor == System.Drawing.SystemColors.Control)
            {
                label39.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void label38_Click(object sender, EventArgs e)
        {
            if (Rolls != 3 && Players == 2 && label38.BackColor == System.Drawing.SystemColors.Control)
            {
                label38.BackColor = Color.Red;
                changePlayer();
            }
        }

        private void playAgainButton_Click(object sender, EventArgs e)
        {
            Rolls = 3;
            CurrentRound = 1;

            RollsRemaining.Text = Rolls.ToString();
            currentRoundLabel.Text = CurrentRound.ToString();

            resetDice();

            PlayerOne.reset();
            PlayerTwo.reset();

            playAgainButton.Visible = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
