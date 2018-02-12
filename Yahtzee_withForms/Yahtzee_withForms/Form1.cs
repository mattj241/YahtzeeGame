using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yahtzee_withForms
{
    public partial class Form1 : Form
    {
        YahtzeeGame newGame = new YahtzeeGame();
        ScoreCardOptions scoreCard = new ScoreCardOptions();
        private int upperBonus = 35;
        private int upperTotal = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void updateScore()
        {
            Score_label.Text = newGame.getTotalScore().ToString();
        }

        private void updateRoundNumber()
        {
            Round_Label.Text = $"{newGame.getRound().ToString()} of 13";
            Roll_button.Show();
        }

        private void unCheckHoldBoxes()
        {
            checkBox1.Checked = false;
            checkBox2.Checked = false;
            checkBox3.Checked = false;
            checkBox4.Checked = false;
            checkBox5.Checked = false;
        }

        private void checkForBonus()
        {
            if (upperTotal >= 63)
            {
                newGame.addBonus();
                Bonus_label.Show();
            }
        }

        private void Roll_button_Click(object sender, EventArgs e)
        {
            checkForBonus();
            updateRoundNumber();
            if (newGame.getRound() < 14)
            {
                if (newGame.getRollNumber() <= 4)
                {
                    bool[] diceToRoll = setDiceToRoll();
                    newGame.holdDice(diceToRoll);
                    int[] diceRoll = newGame.rollDice();

                    scoreCard.assignUpperScores(diceRoll);
                    scoreCard.assignLowerScore(diceRoll);
                    updateScoringLabels();

                    updateDicePicture(diceRoll, 0, pictureBox1);
                    updateDicePicture(diceRoll, 1, pictureBox2);
                    updateDicePicture(diceRoll, 2, pictureBox3);
                    updateDicePicture(diceRoll, 3, pictureBox4);
                    updateDicePicture(diceRoll, 4, pictureBox5);
                    if (newGame.getRollNumber() == 4)
                    {
                        Roll_button.Hide();
                    }
                }
            }
            else
            {
                Round_Label.Text = "";
                MessageBox.Show($"Final score: {newGame.getTotalScore()}\nThanks for playing! Restart the program to play again!");
            }
        }

       

        private void updateDicePicture(int[] inputDice, int index, PictureBox inputPicture)
        {
            
            if (inputDice[index] == 1)
            {
                inputPicture.Image = Yahtzee_withForms.Properties.Resources.dice1;
            }
            else if (inputDice[index] == 2)
            {
                inputPicture.Image = Yahtzee_withForms.Properties.Resources.dice2;
            }
            else if (inputDice[index] == 3)
            {
                inputPicture.Image = Yahtzee_withForms.Properties.Resources.dice3;
            }
            else if (inputDice[index] == 4)
            {
                inputPicture.Image = Yahtzee_withForms.Properties.Resources.dice4;
            }
            else if (inputDice[index] == 5)
            {
                inputPicture.Image = Yahtzee_withForms.Properties.Resources.dice5;
            }
            else
            {
                inputPicture.Image = Yahtzee_withForms.Properties.Resources.dice6;
            }
            
        }

        private void updateScoringLabels()
        {
            AceLabel.Text = $"Aces: {scoreCard.aceScore}";
            TwoLabel.Text = $"Twos: {scoreCard.duoScore}";
            ThreeLabel.Text = $"Threes: {scoreCard.triScore}";
            FourLabel.Text = $"Fours: {scoreCard.quadScore}";
            FiveLabel.Text = $"Fives: {scoreCard.quintScore}";
            SixLabel.Text = $"Sixes: {scoreCard.hexScore}";
            ThreeOfKindLabel.Text = $"Three of a Kind: {scoreCard.threeOfKind}";
            FourOfKindLabel.Text = $"Four of a Kind: {scoreCard.fourOfKind}";
            FullHouseLabel.Text = $"Full House: {scoreCard.fullHouse}";
            SmlStraightLabel.Text = $"Small Straight: {scoreCard.smallStraight}";
            LgStraightLabel.Text = $"Large Straight: {scoreCard.largeStraight}";
            YahtzeeLabel.Text = $"Yahtzee: {scoreCard.yahtzee}";
            ChanceLabel.Text = $"Chance: {scoreCard.chance}";
        }

        private bool[] setDiceToRoll()
        {
            bool[] diceToRoll = new bool[5] { true, true, true, true, true };

            if(checkBox1.Checked)
            {
                diceToRoll[0] = false;
            }
            if(checkBox2.Checked)
            {
                diceToRoll[1] = false;
            }
            if (checkBox3.Checked)
            {
                diceToRoll[2] = false;
            }
            if (checkBox4.Checked)
            {
                diceToRoll[3] = false;
            }
            if (checkBox5.Checked)
            {
                diceToRoll[4] = false;
            }
            return diceToRoll;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Bonus_label.Hide();
            Roll_button_Click(sender, e);
            MessageBox.Show("Insructions:\n Click on the scores to the right to submit your score and end the round!" + 
                "\n**Note: You are automatically given your first roll.");
        }

        private void AceLabel_Click(object sender, EventArgs e)
        {
            newGame.submitScore(scoreCard.aceScore);
            upperTotal += scoreCard.aceScore;
            AceLabel.Hide();
            updateScore();
            newGame.setRound(newGame.getRound() + 1);
            updateRoundNumber();
            unCheckHoldBoxes();
            Roll_button_Click(sender, e);
        }

        private void TwoLabel_Click(object sender, EventArgs e)
        {
            newGame.submitScore(scoreCard.duoScore);
            upperTotal += scoreCard.duoScore;
            TwoLabel.Hide();
            updateScore();
            newGame.setRound(newGame.getRound() + 1);
            updateRoundNumber();
            unCheckHoldBoxes();
            Roll_button_Click(sender, e);
        }

        private void ThreeLabel_Click(object sender, EventArgs e)
        {
            newGame.submitScore(scoreCard.triScore);
            upperTotal += scoreCard.triScore;
            ThreeLabel.Hide();
            updateScore();
            newGame.setRound(newGame.getRound() + 1);
            updateRoundNumber();
            unCheckHoldBoxes();
            Roll_button_Click(sender, e);
        }

        private void FourLabel_Click(object sender, EventArgs e)
        {
            newGame.submitScore(scoreCard.quadScore);
            upperTotal += scoreCard.quadScore;
            FourLabel.Hide();
            updateScore();
            newGame.setRound(newGame.getRound() + 1);
            updateRoundNumber();
            unCheckHoldBoxes();
            Roll_button_Click(sender, e);
        }

        private void FiveLabel_Click(object sender, EventArgs e)
        {
            newGame.submitScore(scoreCard.quintScore);
            upperTotal += scoreCard.quintScore;
            FiveLabel.Hide();
            updateScore();
            newGame.setRound(newGame.getRound() + 1);
            updateRoundNumber();
            unCheckHoldBoxes();
            Roll_button_Click(sender, e);
        }

        private void SixLabel_Click(object sender, EventArgs e)
        {
            newGame.submitScore(scoreCard.hexScore);
            upperTotal += scoreCard.hexScore;
            SixLabel.Hide();
            updateScore();
            newGame.setRound(newGame.getRound() + 1);
            updateRoundNumber();
            unCheckHoldBoxes();
            Roll_button_Click(sender, e);
        }

        private void ThreeOfKindLabel_Click(object sender, EventArgs e)
        {
            newGame.submitScore(scoreCard.threeOfKind);
            ThreeOfKindLabel.Hide();
            updateScore();
            newGame.setRound(newGame.getRound() + 1);
            updateRoundNumber();
            unCheckHoldBoxes();
            Roll_button_Click(sender, e);
        }

        private void FourOfKindLabel_Click(object sender, EventArgs e)
        {
            newGame.submitScore(scoreCard.fourOfKind);
            FourOfKindLabel.Hide();
            updateScore();
            newGame.setRound(newGame.getRound() + 1);
            updateRoundNumber();
            unCheckHoldBoxes();
            Roll_button_Click(sender, e);
        }

        private void FullHouseLabel_Click(object sender, EventArgs e)
        {
            newGame.submitScore(scoreCard.fullHouse);
            FullHouseLabel.Hide();
            updateScore();
            newGame.setRound(newGame.getRound() + 1);
            updateRoundNumber();
            unCheckHoldBoxes();
            Roll_button_Click(sender, e);
        }

        private void SmlStraightLabel_Click(object sender, EventArgs e)
        {
            newGame.submitScore(scoreCard.smallStraight);
            SmlStraightLabel.Hide();
            updateScore();
            newGame.setRound(newGame.getRound() + 1);
            updateRoundNumber();
            unCheckHoldBoxes();
            Roll_button_Click(sender, e);
        }

        private void LgStraightLabel_Click(object sender, EventArgs e)
        {
            newGame.submitScore(scoreCard.largeStraight);
            LgStraightLabel.Hide();
            updateScore();
            newGame.setRound(newGame.getRound() + 1);
            updateRoundNumber();
            unCheckHoldBoxes();
            Roll_button_Click(sender, e);
        }

        private void YahtzeeLabel_Click(object sender, EventArgs e)
        {
            newGame.submitScore(scoreCard.yahtzee);
            YahtzeeLabel.Hide();
            updateScore();
            newGame.setRound(newGame.getRound() + 1);
            updateRoundNumber();
            unCheckHoldBoxes();
            Roll_button_Click(sender, e);
        }

        private void ChanceLabel_Click(object sender, EventArgs e)
        {
            newGame.submitScore(scoreCard.chance);
            ChanceLabel.Hide();
            updateScore();
            newGame.setRound(newGame.getRound() + 1);
            updateRoundNumber();
            unCheckHoldBoxes();
            Roll_button_Click(sender, e);
        }
    }
}
