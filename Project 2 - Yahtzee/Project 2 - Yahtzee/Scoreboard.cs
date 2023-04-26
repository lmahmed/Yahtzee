using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace Project_2___Yahtzee
{
    public class Scoreboard
    {
        public Form1 Form { get; set; }
        public int Ones;
        public int Twos;
        public int Threes;
        public int Fours;
        public int Fives;
        public int Sixes;

        public CategoryLabels Labels { get; set; }

        public Scoreboard(Form1 form, CategoryLabels labels)
        { 
            this.Form = form;
            
            Ones = 0;
            Twos = 0;
            Threes = 0;
            Fours = 0;
            Fives = 0;
            Sixes = 0;

            Labels = labels;
        }
        
        public void reset()
        {
            Labels.Ones.BackColor = SystemColors.Control;
            Labels.Twos.BackColor = SystemColors.Control;
            Labels.Threes.BackColor = SystemColors.Control;
            Labels.Fours.BackColor = SystemColors.Control;
            Labels.Fives.BackColor = SystemColors.Control;
            Labels.Sixes.BackColor = SystemColors.Control;
            Labels.ThreeOfAKind.BackColor = SystemColors.Control;
            Labels.FourOfAKind.BackColor = SystemColors.Control;
            Labels.FullHouse.BackColor = SystemColors.Control;
            Labels.SmallStraight.BackColor = SystemColors.Control;
            Labels.LargeStraight.BackColor = SystemColors.Control;
            Labels.Yahtzee.BackColor = SystemColors.Control;
            Labels.Chance.BackColor = SystemColors.Control;

            Labels.Ones.Text = String.Empty;
            Labels.Twos.Text = String.Empty;
            Labels.Threes.Text = String.Empty;
            Labels.Fours.Text = String.Empty;
            Labels.Fives.Text = String.Empty;
            Labels.Sixes.Text = String.Empty;
            Labels.Sum.Text = String.Empty;
            Labels.Bonus.Text = String.Empty;
            Labels.ThreeOfAKind.Text = String.Empty;
            Labels.FourOfAKind.Text = String.Empty;
            Labels.FullHouse.Text = String.Empty;
            Labels.SmallStraight.Text = String.Empty;
            Labels.LargeStraight.Text = String.Empty;
            Labels.Yahtzee.Text = String.Empty;
            Labels.Chance.Text = String.Empty;
            Labels.TotalScore.Text = String.Empty;
        }
        public void completeScoreboard()
        {
            int totalSum = Convert.ToInt32(Labels.Ones.Text) + Convert.ToInt32(Labels.Twos.Text) + Convert.ToInt32(Labels.Threes.Text)
                + Convert.ToInt32(Labels.Fours.Text) + Convert.ToInt32(Labels.Fives.Text) + Convert.ToInt32(Labels.Sixes.Text);

            Labels.Sum.Text = totalSum.ToString();
            // bonus
            if (totalSum >= 63)
            {
                Labels.Bonus.Text = $"{35}!";
                totalSum += 35;
            }
            else
            {
                Labels.Bonus.Text = 0.ToString();
            }

            totalSum += Convert.ToInt32(Labels.ThreeOfAKind.Text) + Convert.ToInt32(Labels.FourOfAKind.Text) + 
                Convert.ToInt32(Labels.FullHouse.Text) + Convert.ToInt32(Labels.SmallStraight.Text) + 
               Convert.ToInt32(Labels.LargeStraight.Text) + Convert.ToInt32(Labels.Yahtzee.Text) + Convert.ToInt32(Labels.Chance.Text);

            Labels.TotalScore.Text = totalSum.ToString();
        }

        // make unchosen categories empty
        public void emptyScoreboard()
        {
            if (Labels.Ones.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Ones.Text = string.Empty;
            }
            Labels.Ones.Cursor = System.Windows.Forms.Cursors.Default;

            if (Labels.Twos.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Twos.Text = string.Empty;
            }
            Labels.Twos.Cursor = System.Windows.Forms.Cursors.Default;

            if (Labels.Threes.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Threes.Text = string.Empty;
            }
            Labels.Threes.Cursor = System.Windows.Forms.Cursors.Default;

            if (Labels.Fours.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Fours.Text = string.Empty;
            }
            Labels.Fours.Cursor = System.Windows.Forms.Cursors.Default;

            if (Labels.Fives.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Fives.Text = string.Empty;
            }
            Labels.Fives.Cursor = System.Windows.Forms.Cursors.Default;

            if (Labels.Sixes.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Sixes.Text = string.Empty;
            }
            Labels.Sixes.Cursor = System.Windows.Forms.Cursors.Default;

            if (Labels.ThreeOfAKind.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.ThreeOfAKind.Text = string.Empty;
            }
            Labels.ThreeOfAKind.Cursor = System.Windows.Forms.Cursors.Default;

            if (Labels.FourOfAKind.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.FourOfAKind.Text = string.Empty;
            }
            Labels.FourOfAKind.Cursor = System.Windows.Forms.Cursors.Default;

            if (Labels.FullHouse.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.FullHouse.Text = string.Empty;
            }
            Labels.FullHouse.Cursor = System.Windows.Forms.Cursors.Default;

            if (Labels.SmallStraight.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.SmallStraight.Text = string.Empty;
            }
            Labels.SmallStraight.Cursor = System.Windows.Forms.Cursors.Default;

            if (Labels.LargeStraight.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.LargeStraight.Text = string.Empty;
            }
            Labels.LargeStraight.Cursor = System.Windows.Forms.Cursors.Default;

            if (Labels.Yahtzee.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Yahtzee.Text = string.Empty;
            }
            Labels.Yahtzee.Cursor = System.Windows.Forms.Cursors.Default;

            if (Labels.Chance.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Chance.Text = string.Empty;
            }
            Labels.Chance.Cursor = System.Windows.Forms.Cursors.Default;
        }

        public void calculateScoreboard()
        {
            int sum = Convert.ToInt32(Form.diceOne.Text) + Convert.ToInt32(Form.diceTwo.Text) + Convert.ToInt32(Form.diceThree.Text)
               + Convert.ToInt32(Form.diceFour.Text) + Convert.ToInt32(Form.diceFive.Text);

            Ones = calculateCountofNumber(1);
            Twos = calculateCountofNumber(2);
            Threes = calculateCountofNumber(3);
            Fours = calculateCountofNumber(4);
            Fives = calculateCountofNumber(5);
            Sixes = calculateCountofNumber(6);

            if (Labels.Ones.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Ones.Text = (Ones * 1).ToString();
                Labels.Ones.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            if (Labels.Twos.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Twos.Text = (Twos * 2).ToString();
                Labels.Twos.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            if (Labels.Threes.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Threes.Text = (Threes * 3).ToString();
                Labels.Threes.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            if (Labels.Fours.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Fours.Text = (Fours * 4).ToString();
                Labels.Fours.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            if (Labels.Fives.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Fives.Text = (Fives * 5).ToString();
                Labels.Fives.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            if (Labels.Sixes.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Sixes.Text = (Sixes * 6).ToString();
                Labels.Sixes.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            if (Labels.ThreeOfAKind.BackColor == System.Drawing.SystemColors.Control)
            {
                if ((Ones >= 3) || (Twos >= 3) || (Threes >= 3) || (Fours >= 3) || (Fives >= 3) || (Sixes >= 3))
                {
                    Labels.ThreeOfAKind.Text = sum.ToString();
                }
                else
                {
                    Labels.ThreeOfAKind.Text = "0";
                }
                Labels.ThreeOfAKind.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            if (Labels.FourOfAKind.BackColor == System.Drawing.SystemColors.Control)
            {
                if ((Ones >= 4) || (Twos >= 4) || (Threes >= 4) || (Fours >= 4) || (Fives >= 4) || (Sixes >= 4))
                {
                    Labels.FourOfAKind.Text = sum.ToString();
                }
                else
                {
                    Labels.FourOfAKind.Text = "0";
                }
                Labels.FourOfAKind.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            if (Labels.FullHouse.BackColor == System.Drawing.SystemColors.Control)
            {
                if ((Ones == 3 || Twos == 3 || Threes == 3 || Fours == 3 || Fives == 3 || Sixes == 3) && (Ones == 2 || Twos == 2 || Threes == 2 || Fours == 2 || Fives == 2 || Sixes == 2))
                {
                    Labels.FullHouse.Text = "25";
                }
                else
                {
                    Labels.FullHouse.Text = "0";
                }
                Labels.FullHouse.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            if (Labels.SmallStraight.BackColor == System.Drawing.SystemColors.Control)
            {
                if ((Ones >= 1 && Twos >= 1 && Threes >=1 && Fours >= 1) || (Twos >= 1 && Threes >= 1 && Fours >= 1 && Fives >= 1) || (Threes >= 1 && Fours >= 1 && Fives >= 1 && Sixes >=1))
                {
                    Labels.SmallStraight.Text = "30";
                }
                else
                {
                    Labels.SmallStraight.Text = "0";
                }
                Labels.SmallStraight.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            if (Labels.LargeStraight.BackColor == System.Drawing.SystemColors.Control)
            {
                if ((Ones == 1 && Twos == 1 && Threes == 1 && Fours == 1 && Fives == 1) || (Twos == 1 && Threes == 1 && Fours == 1 && Fives == 1 && Sixes == 1))
                {
                    Labels.LargeStraight.Text = "40";
                }
                else
                {
                    Labels.LargeStraight.Text ="0";
                }
                Labels.LargeStraight.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            if (Labels.Yahtzee.BackColor == System.Drawing.SystemColors.Control) 
            {
                if (Ones == 5 || Twos == 5 || Threes == 5 || Fours == 5 || Fives == 5 || Sixes == 5)
                {
                    Labels.Yahtzee.Text = "50";
                }
                else
                {
                    Labels.Yahtzee.Text = "0";
                }
                Labels.Yahtzee.Cursor = System.Windows.Forms.Cursors.Hand;
            }

            if (Labels.Chance.BackColor == System.Drawing.SystemColors.Control)
            {
                Labels.Chance.Text = sum.ToString();
                Labels.Chance.Cursor = System.Windows.Forms.Cursors.Hand;
            }

        }

        private int calculateCountofNumber(int number)
        {
            int counter = 0;
            if (Convert.ToInt32(Form.diceOne.Text) == number)
            {
                counter++;
            }
            if (Convert.ToInt32(Form.diceTwo.Text) == number)
            {
                counter++;
            }
            if (Convert.ToInt32(Form.diceThree.Text) == number)
            {
                counter++;
            }
            if (Convert.ToInt32(Form.diceFour.Text) == number)
            {
                counter++;
            }
            if (Convert.ToInt32(Form.diceFive.Text) == number)
            {
                counter++;
            }
            return counter;
        }
        
    }
}
