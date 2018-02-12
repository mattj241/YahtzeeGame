using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Yahtzee_withForms;

namespace YahtzeeUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestThreeOfAKind()
        {
            int[] testDice = new int[5] { 1, 1, 4, 6, 6 };
            ScoreCardOptions testGame = new ScoreCardOptions();
            int test = testGame.calcThreeOfKind(testDice);
            Assert.AreEqual(0, test);
        }

        [TestMethod]
        public void TestFourOfAKind()
        {
            int[] testDice = new int[5] { 5, 5, 5, 2, 5 };
            ScoreCardOptions testGame = new ScoreCardOptions();
            int test = testGame.calcFourOfKind(testDice);
            Assert.AreEqual(20, test);
        }

        [TestMethod]
        public void TestFullHouse()
        {
            int[] testDice = new int[5] { 4, 1, 4, 1, 4 };
            ScoreCardOptions testGame = new ScoreCardOptions();
            int test = testGame.calcFullHouse(testDice);
            Assert.AreEqual(25, test);
        }

        [TestMethod]
        public void TestSmallStr()
        {
            int[] testDice = new int[5] { 1, 3, 2, 4, 1 };
            ScoreCardOptions testGame = new ScoreCardOptions();
            int test = testGame.calcSmallStraight(testDice);
            Assert.AreEqual(30, test);
        }

        [TestMethod]
        public void TestLargeStr()
        {
            int[] testDice = new int[5] { 1, 3, 2, 4, 5 };
            ScoreCardOptions testGame = new ScoreCardOptions();
            int test = testGame.calcLargeStraight(testDice);
            Assert.AreEqual(40, test);
        }

        [TestMethod]
        public void TestYahtzee()
        {
            int[] testDice = new int[5] { 1, 1, 1, 1, 1 };
            ScoreCardOptions testGame = new ScoreCardOptions();
            int test = testGame.calcYahtzee(testDice);
            Assert.AreEqual(50, test);
        }

        [TestMethod]
        public void TestChance()
        {
            int[] testDice = new int[5] { 1, 1, 1, 1, 2 };
            ScoreCardOptions testGame = new ScoreCardOptions();
            int test = testGame.calcChance(testDice);
            Assert.AreEqual(6, test);
        }

        [TestMethod]
        public void TestUpper()
        {
            int[] testDice = new int[5] { 1, 1, 1, 1, 2 };
            ScoreCardOptions testGame = new ScoreCardOptions();
            int test = testGame.calcUpper(testDice, 1);
            Assert.AreEqual(4, test);
        }

        
    }
}
