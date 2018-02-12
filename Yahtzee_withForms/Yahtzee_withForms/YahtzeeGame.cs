using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Yahtzee_withForms
{
    public class YahtzeeGame
    {
        private int[] dice = new int[5];
        private bool[] diceToRoll = new bool[5] { true, true, true, true, true };
        private Random randomNum = new Random();
        private int rollNumber = 1;
        private int roundNumber = 1;
        private int totalScore = 0;

        public void holdDice(bool[] toRoll)
        {
            diceToRoll = toRoll;
        }

        public void setRound(int round)
        {
            roundNumber = round;
            rollNumber = 1;
        }

        public int getRound()
        {
            return roundNumber;
        }

        public int getTotalScore()
        {
            return totalScore;
        }

        public void addBonus()
        {
            totalScore += 35;
        }

        public int getRollNumber()
        {
            return rollNumber;
        }

        public int[] rollDice()
        {
            for (int i = 0; i < dice.Length; i++)
            {
                
                if (diceToRoll[i])
                {
                    dice[i] = randomNum.Next(1, 7);
                }
            }
            rollNumber++;
            if (rollNumber == 5)
            {
                rollNumber = 1;
                roundNumber++;
            }
            return dice;
        }

        public void submitScore (int score)
        {
            totalScore += score;
        }
     
       
    }
}

