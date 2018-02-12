using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Yahtzee_withForms
{
    public class ScoreCardOptions
    {
        public int aceScore;
        public int duoScore;
        public int triScore;
        public int quadScore;
        public int quintScore;
        public int hexScore;
        public int threeOfKind;
        public int fourOfKind;
        public int fullHouse;
        public int smallStraight;
        public int largeStraight;
        public int yahtzee;
        public int chance;
        

        public int calcUpper(int [] dice, int bracket)
        {
            int score = 0;
            for (int i = 0; i < dice.Length; i++)
            {
                if (dice[i] == bracket)
                {
                    score += bracket;
                }
            }
            return score;
        }

        public void assignUpperScores(int [] dice)
        {
            aceScore = calcUpper(dice, 1);
            duoScore = calcUpper(dice, 2);
            triScore = calcUpper(dice, 3);
            quadScore = calcUpper(dice, 4);
            quintScore = calcUpper(dice, 5);
            hexScore = calcUpper(dice, 6);
        }


        public int calcThreeOfKind(int [] dice)
        {
            int tally = 0;
            for(int dieValue = 1; dieValue <= 6; dieValue++)
            {
                for (int j = 0; j < dice.Length; j++)
                {
                    if (dice[j] == dieValue)
                    {
                        tally++;
                        if (tally == 3)
                        {
                            return calcChance(dice);
                        }
                    }
                }
                tally = 0; 
            }
            return 0;
        }

        public int calcFourOfKind(int[] dice)
        {
            int tally = 0;
            for (int dieValue = 1; dieValue <= 6; dieValue++)
            {
                for (int j = 0; j < dice.Length; j++)
                {
                    if (dice[j] == dieValue)
                    {
                        tally++;
                        if (tally == 4)
                        {
                            return calcChance(dice);
                        }
                    }
                }
                tally = 0;
            }
            return 0;
        }

        public int calcFullHouse(int[] dice)
        {
            int[] tally = new int[7];
            for (int index = 0; index < dice.Length; index++)
            {
                tally[dice[index]]++;
            }
            for (int index = 0; index < tally.Length; index++)
            {
                if (tally[index] == 3)
                {
                    for (int jndex = 0; jndex < tally.Length; jndex++)
                    {
                        if (tally[jndex] == 2)
                        {
                            return 25;
                        }
                    }
                }
            }
            return 0;
        }

        //pre: pass in dice values, and number searched for
        //post: returns true if value exists in array
        public bool SeekValue(int[] dice, int number)
        {
            for (int index = 0; index < dice.Length; index++)
            {
                if (number == dice[index])
                {
                    return true;
                }
            }
            return false;
        }

        //pre: pass in dice values
        //post: calculates smallstraight values based on dice roll
        public int calcSmallStraight(int[] dice)
        {
            for (int index = 0; index < dice.Length; index++)
            {
                int tally = 0;
                for (int jndex = index; jndex < index + 4; jndex++)
                {
                    if (SeekValue(dice, jndex))
                    {
                        tally++;
                    }
                }
                if (tally >= 4)
                {
                    return 30;
                }
            }
            return 0;
        }

        //pre: pass in dice values
        //post: calculates large straight values based on dice roll
        public int calcLargeStraight(int[] dice)
        {
            for (int index = 0; index < dice.Length; index++)
            {
                int tally = 0;
                for (int jndex = index; jndex < index + 5; jndex++)
                {
                    if (SeekValue(dice, jndex))
                    {
                        tally++;
                    }
                }
                if (tally >= 5)
                {
                    return 40;
                }
            }
            return 0;
        }

        public int calcYahtzee(int[] dice)
        {
            for (int index = 0; index < dice.Length; index++)
            {
                if (dice[index] != dice[0])
                {
                    return 0;
                }
            }
            return 50;
        }

        public int calcChance(int[] dice)
        {
            int total = 0;
            for(int i = 0; i < dice.Length; i++)
            {
                total += dice[i];
            }
            return total;
        }

        public void assignLowerScore(int [] dice)
        {
            threeOfKind = calcThreeOfKind(dice);
            fourOfKind = calcFourOfKind(dice);
            fullHouse = calcFullHouse(dice);
            smallStraight = calcSmallStraight(dice);
            largeStraight = calcLargeStraight(dice);
            yahtzee = calcYahtzee(dice);
            chance = calcChance(dice);
        }

    }
}
