using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_2___Yahtzee
{
    public class CategoryLabels
    {
        public Label Ones { get; set; }

        public Label Twos { get; set; }

        public Label Threes { get; set; }

        public Label Fours { get; set; }  

        public Label Fives { get; set; }

        public Label Sixes { get; set; }

        public Label Sum { get; set; }

        public Label Bonus { get; set; }

        public Label ThreeOfAKind { get; set; }

        public Label FourOfAKind { get; set; }

        public Label FullHouse { get; set; }
        
        public Label SmallStraight { get; set; }

        public Label LargeStraight { get; set; }

        public Label Chance { get; set; }

        public Label Yahtzee { get; set; }

        public Label TotalScore { get; set; }

        public CategoryLabels(Label ones, Label twos, Label threes, Label fours, Label fives, Label sixes, Label sum, Label bonus, Label threeOfAKind, Label fourOfAKind, Label fullHouse, Label smallStraight, Label largeStraight, Label chance, Label yahtzee, Label totalScore  )
        {
            Ones = ones;
            Twos = twos;
            Threes = threes;
            Fours = fours;
            Fives = fives;
            Sixes = sixes;
            Sum = sum;
            Bonus = bonus;
            ThreeOfAKind = threeOfAKind;
            FourOfAKind = fourOfAKind;
            FullHouse = fullHouse;
            SmallStraight = smallStraight;
            LargeStraight = largeStraight;
            Chance = chance;
            Yahtzee = yahtzee;
            TotalScore = totalScore;
        }

    }
}
