using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json.Schema;
using Project_2___Yahtzee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_2___Yahtzee.Tests
{
    [TestClass()]
    public class ScoreboardTests
    {
        
        [TestMethod()]
        public void testOnes()
        {
            // Arrange
            Form1 testForm = new Form1();
            CategoryLabels testCategoryLabels = new CategoryLabels(testForm.label21, testForm.label22, testForm.label23, testForm.label24, testForm.label25, testForm.label26, testForm.label27, testForm.label28, testForm.label29, testForm.label30, testForm.label31, testForm.label32, testForm.label33, testForm.label34, testForm.label35, testForm.label36);
            Scoreboard testScoreboard = new Scoreboard(testForm, testCategoryLabels);

            testForm.diceOne.Text =   "1";
            testForm.diceTwo.Text =   "1";
            testForm.diceThree.Text = "2";
            testForm.diceFour.Text =  "1";
            testForm.diceFive.Text =  "5";
            // Act
            testScoreboard.calculateScoreboard();

            // Assert
            int actual = 3;
            Assert.AreEqual(testScoreboard.Labels.Ones.Text, actual.ToString());
        }
        [TestMethod()]
        public void testTwos()
        {
            // Arrange
            Form1 testForm = new Form1();
            CategoryLabels testCategoryLabels = new CategoryLabels(testForm.label21, testForm.label22, testForm.label23, testForm.label24, testForm.label25, testForm.label26, testForm.label27, testForm.label28, testForm.label29, testForm.label30, testForm.label31, testForm.label32, testForm.label33, testForm.label34, testForm.label35, testForm.label36);
            Scoreboard testScoreboard = new Scoreboard(testForm, testCategoryLabels);

            testForm.diceOne.Text =   "3";
            testForm.diceTwo.Text =   "2";
            testForm.diceThree.Text = "5";
            testForm.diceFour.Text =  "3";
            testForm.diceFive.Text =  "1";
            // Act
            testScoreboard.calculateScoreboard();

            // Assert
            int expected = 2;
            Assert.AreEqual(expected.ToString(), testScoreboard.Labels.Twos.Text);
        }
        [TestMethod()]
        public void testThrees()
        {
            // Arrange
            Form1 testForm = new Form1();
            CategoryLabels testCategoryLabels = new CategoryLabels(testForm.label21, testForm.label22, testForm.label23, testForm.label24, testForm.label25, testForm.label26, testForm.label27, testForm.label28, testForm.label29, testForm.label30, testForm.label31, testForm.label32, testForm.label33, testForm.label34, testForm.label35, testForm.label36);
            Scoreboard testScoreboard = new Scoreboard(testForm, testCategoryLabels);

            testForm.diceOne.Text =   "3";
            testForm.diceTwo.Text =   "2";
            testForm.diceThree.Text = "5";
            testForm.diceFour.Text =  "3";
            testForm.diceFive.Text =  "1";
            // Act
            testScoreboard.calculateScoreboard();

            // Assert
            int expected = 6;
            Assert.AreEqual(expected.ToString(), testScoreboard.Labels.Threes.Text);
        }
        [TestMethod()]
        public void testFours()
        {
            // Arrange
            Form1 testForm = new Form1();
            CategoryLabels testCategoryLabels = new CategoryLabels(testForm.label21, testForm.label22, testForm.label23, testForm.label24, testForm.label25, testForm.label26, testForm.label27, testForm.label28, testForm.label29, testForm.label30, testForm.label31, testForm.label32, testForm.label33, testForm.label34, testForm.label35, testForm.label36);
            Scoreboard testScoreboard = new Scoreboard(testForm, testCategoryLabels);

            testForm.diceOne.Text =   "3";
            testForm.diceTwo.Text =   "4";
            testForm.diceThree.Text = "5";
            testForm.diceFour.Text =  "4";
            testForm.diceFive.Text =  "4";
            // Act
            testScoreboard.calculateScoreboard();

            // Assert
            int expected = 12;
            Assert.AreEqual(expected.ToString(), testScoreboard.Labels.Fours.Text);
        }
        [TestMethod()]
        public void testFives()
        {
            Form1 testForm = new Form1();
            CategoryLabels testCategoryLabels = new CategoryLabels(testForm.label21, testForm.label22, testForm.label23, testForm.label24, testForm.label25, testForm.label26, testForm.label27, testForm.label28, testForm.label29, testForm.label30, testForm.label31, testForm.label32, testForm.label33, testForm.label34, testForm.label35, testForm.label36);
            Scoreboard testScoreboard = new Scoreboard(testForm, testCategoryLabels);

            testForm.diceOne.Text = "5";
            testForm.diceTwo.Text = "5";
            testForm.diceThree.Text = "5";
            testForm.diceFour.Text = "4";
            testForm.diceFive.Text = "2";
            // Act
            testScoreboard.calculateScoreboard();

            // Assert
            int expected = 15;
            Assert.AreEqual(expected.ToString(), testScoreboard.Labels.Fives.Text);
        }
        [TestMethod()]
        public void testSixes()
        {
            Form1 testForm = new Form1();
            CategoryLabels testCategoryLabels = new CategoryLabels(testForm.label21, testForm.label22, testForm.label23, testForm.label24, testForm.label25, testForm.label26, testForm.label27, testForm.label28, testForm.label29, testForm.label30, testForm.label31, testForm.label32, testForm.label33, testForm.label34, testForm.label35, testForm.label36);
            Scoreboard testScoreboard = new Scoreboard(testForm, testCategoryLabels);

            testForm.diceOne.Text = "2";
            testForm.diceTwo.Text = "6";
            testForm.diceThree.Text = "3";
            testForm.diceFour.Text = "5";
            testForm.diceFive.Text = "6";
            // Act
            testScoreboard.calculateScoreboard();

            // Assert
            int expected = 12;
            Assert.AreEqual(expected.ToString(), testScoreboard.Labels.Sixes.Text);
        }
        [TestMethod()]
        public void testThreeOfAKind()
        {
            Form1 testForm = new Form1();
            CategoryLabels testCategoryLabels = new CategoryLabels(testForm.label21, testForm.label22, testForm.label23, testForm.label24, testForm.label25, testForm.label26, testForm.label27, testForm.label28, testForm.label29, testForm.label30, testForm.label31, testForm.label32, testForm.label33, testForm.label34, testForm.label35, testForm.label36);
            Scoreboard testScoreboard = new Scoreboard(testForm, testCategoryLabels);

            testForm.diceOne.Text = "2";
            testForm.diceTwo.Text = "4";
            testForm.diceThree.Text = "2";
            testForm.diceFour.Text = "6";
            testForm.diceFive.Text = "2";
            // Act
            testScoreboard.calculateScoreboard();

            // Assert
            int expected = 16;
            Assert.AreEqual(expected.ToString(), testScoreboard.Labels.ThreeOfAKind.Text);
        }
        [TestMethod()]
        public void testFourOfAKind()
        {
            Form1 testForm = new Form1();
            CategoryLabels testCategoryLabels = new CategoryLabels(testForm.label21, testForm.label22, testForm.label23, testForm.label24, testForm.label25, testForm.label26, testForm.label27, testForm.label28, testForm.label29, testForm.label30, testForm.label31, testForm.label32, testForm.label33, testForm.label34, testForm.label35, testForm.label36);
            Scoreboard testScoreboard = new Scoreboard(testForm, testCategoryLabels);

            testForm.diceOne.Text = "5";
            testForm.diceTwo.Text = "5";
            testForm.diceThree.Text = "5";
            testForm.diceFour.Text = "1";
            testForm.diceFive.Text = "5";
            // Act
            testScoreboard.calculateScoreboard();

            // Assert
            int expected = 21;
            Assert.AreEqual(expected.ToString(), testScoreboard.Labels.FourOfAKind.Text);
        }
        [TestMethod()]
        public void testFullHouse()
        {
            Form1 testForm = new Form1();
            CategoryLabels testCategoryLabels = new CategoryLabels(testForm.label21, testForm.label22, testForm.label23, testForm.label24, testForm.label25, testForm.label26, testForm.label27, testForm.label28, testForm.label29, testForm.label30, testForm.label31, testForm.label32, testForm.label33, testForm.label34, testForm.label35, testForm.label36);
            Scoreboard testScoreboard = new Scoreboard(testForm, testCategoryLabels);

            testForm.diceOne.Text = "6";
            testForm.diceTwo.Text = "5";
            testForm.diceThree.Text = "6";
            testForm.diceFour.Text = "5";
            testForm.diceFive.Text = "6";
            // Act
            testScoreboard.calculateScoreboard();

            // Assert
            int expected = 25;
            Assert.AreEqual(expected.ToString(), testScoreboard.Labels.FullHouse.Text);
        }
        [TestMethod()]
        public void testSmallStraight()
        {
            Form1 testForm = new Form1();
            CategoryLabels testCategoryLabels = new CategoryLabels(testForm.label21, testForm.label22, testForm.label23, testForm.label24, testForm.label25, testForm.label26, testForm.label27, testForm.label28, testForm.label29, testForm.label30, testForm.label31, testForm.label32, testForm.label33, testForm.label34, testForm.label35, testForm.label36);
            Scoreboard testScoreboard = new Scoreboard(testForm, testCategoryLabels);

            testForm.diceOne.Text = "4";
            testForm.diceTwo.Text = "5";
            testForm.diceThree.Text = "3";
            testForm.diceFour.Text = "4";
            testForm.diceFive.Text = "2";
            // Act
            testScoreboard.calculateScoreboard();

            // Assert
            int expected = 30;
            Assert.AreEqual(expected.ToString(), testScoreboard.Labels.SmallStraight.Text);
        }
        [TestMethod()]
        public void testLargeStraight()
        {
            Form1 testForm = new Form1();
            CategoryLabels testCategoryLabels = new CategoryLabels(testForm.label21, testForm.label22, testForm.label23, testForm.label24, testForm.label25, testForm.label26, testForm.label27, testForm.label28, testForm.label29, testForm.label30, testForm.label31, testForm.label32, testForm.label33, testForm.label34, testForm.label35, testForm.label36);
            Scoreboard testScoreboard = new Scoreboard(testForm, testCategoryLabels);

            testForm.diceOne.Text = "5";
            testForm.diceTwo.Text = "2";
            testForm.diceThree.Text = "4";
            testForm.diceFour.Text = "3";
            testForm.diceFive.Text = "6";
            // Act
            testScoreboard.calculateScoreboard();

            // Assert
            int expected = 40;
            Assert.AreEqual(expected.ToString(), testScoreboard.Labels.LargeStraight.Text);
        }
        [TestMethod()]
        public void testYahtzee()
        {
            Form1 testForm = new Form1();
            CategoryLabels testCategoryLabels = new CategoryLabels(testForm.label21, testForm.label22, testForm.label23, testForm.label24, testForm.label25, testForm.label26, testForm.label27, testForm.label28, testForm.label29, testForm.label30, testForm.label31, testForm.label32, testForm.label33, testForm.label34, testForm.label35, testForm.label36);
            Scoreboard testScoreboard = new Scoreboard(testForm, testCategoryLabels);

            testForm.diceOne.Text = "1";
            testForm.diceTwo.Text = "1";
            testForm.diceThree.Text = "1";
            testForm.diceFour.Text = "1";
            testForm.diceFive.Text = "1";
            // Act
            testScoreboard.calculateScoreboard();

            // Assert
            int expected = 50;
            Assert.AreEqual(expected.ToString(), testScoreboard.Labels.Yahtzee.Text);
        }
        [TestMethod()]
        public void testChance()
        {
            Form1 testForm = new Form1();
            CategoryLabels testCategoryLabels = new CategoryLabels(testForm.label21, testForm.label22, testForm.label23, testForm.label24, testForm.label25, testForm.label26, testForm.label27, testForm.label28, testForm.label29, testForm.label30, testForm.label31, testForm.label32, testForm.label33, testForm.label34, testForm.label35, testForm.label36);
            Scoreboard testScoreboard = new Scoreboard(testForm, testCategoryLabels);

            testForm.diceOne.Text = "1";
            testForm.diceTwo.Text = "2";
            testForm.diceThree.Text = "3";
            testForm.diceFour.Text = "4";
            testForm.diceFive.Text = "5";
            // Act
            testScoreboard.calculateScoreboard();

            // Assert
            int expected = 15;
            Assert.AreEqual(expected.ToString(), testScoreboard.Labels.Chance.Text);
        }

    }
}