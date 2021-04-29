using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RPS_Game_App
{
    public partial class RPS : Form
    {

        string[] CPUchoiceList = { "rock", "paper", "scissor", "paper", "rock", "scissor" };

        int randomNumber = 0;

        Random rnd = new Random();

        string CPUChoice;

        string playerChoice;

        int playerScore;
        int CPUScore;

        public RPS()
        {
            InitializeComponent();

            playerChoice = "none";

            playerScore = 0;
            CPUScore = 0;
        }

        private void btnRock_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.rock;
            playerChoice = "rock";
        }

        private void btnPaper_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.paper;
            playerChoice = "paper";
        }

        private void btnScissor_Click(object sender, EventArgs e)
        {
            picPlayer.Image = Properties.Resources.scissor;
            playerChoice = "scissor";
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            randomNumber = rnd.Next(0, CPUchoiceList.Length);

            CPUChoice = CPUchoiceList[randomNumber];

            switch (CPUChoice)
            {
                case "rock":
                    picCPU.Image = Properties.Resources.rock;
                    {
                        if (playerChoice == "scissor")
                        {
                            CPUScore += 1;

                            MessageBox.Show("CPU Wins, Rock crushes Scissor");
                        }
                        else if (playerChoice == "paper")
                        {
                            playerScore += 1;

                            MessageBox.Show("Player Wins, Paper covers Rock");
                        }
                        else if (playerChoice == "rock")
                        {
                            MessageBox.Show("It's a draw!");
                        }
                        else if (playerChoice == "none")
                        {
                            MessageBox.Show("Please choose a move");
                        }
                        labelScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;
                        picCPU.Image = Properties.Resources.Animal_World;
                        if (playerScore > 4)
                        {
                            MessageBox.Show("Congrats, You Win the War!");
                            playerScore = 0;
                            CPUScore = 0;
                            labelScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;

                            playerChoice = "none";

                            picPlayer.Image = Properties.Resources.Animal_World;
                            picCPU.Image = Properties.Resources.Animal_World;
                        }
                        else if (CPUScore > 4)
                        {
                            MessageBox.Show("You lose! Better luck next time.");
                            playerScore = 0;
                            CPUScore = 0;
                            labelScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;

                            playerChoice = "none";

                            picPlayer.Image = Properties.Resources.Animal_World;
                            picCPU.Image = Properties.Resources.Animal_World;
                        }
                        break;
                    }
                case "paper":
                    picCPU.Image = Properties.Resources.paper;
                    if (playerChoice == "scissor")
                    {
                        playerScore += 1;

                        MessageBox.Show("Player Wins, Scissors cut Paper");
                    }
                    else if (playerChoice == "rock")
                    {
                        CPUScore += 1;

                        MessageBox.Show("CPU Wins, Paper covers Rock");
                    }
                    else if (playerChoice == "paper")
                    {
                        MessageBox.Show("It's a draw!");
                    }
                    else if (playerChoice == "none")
                    {
                        MessageBox.Show("Please choose a move");
                    }
                    labelScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;
                    picCPU.Image = Properties.Resources.Animal_World;
                    if (playerScore > 4)
                    {
                        MessageBox.Show("Congrats, You Win the War!");
                        playerScore = 0;
                        CPUScore = 0;
                        labelScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;

                        playerChoice = "none";

                        picPlayer.Image = Properties.Resources.Animal_World;
                        picCPU.Image = Properties.Resources.Animal_World;
                    }
                    else if (CPUScore > 4)
                    {
                        MessageBox.Show("You lose! Better luck next time.");
                        playerScore = 0;
                        CPUScore = 0;
                        labelScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;

                        playerChoice = "none";

                        picPlayer.Image = Properties.Resources.Animal_World;
                        picCPU.Image = Properties.Resources.Animal_World;
                    }
                    break;
                case "scissor":
                    picCPU.Image = Properties.Resources.scissor;
                    if (playerChoice == "rock")
                    {
                        playerScore += 1;

                        MessageBox.Show("Player Wins, Rock crushes Scissor");
                    }
                    else if (playerChoice == "paper")
                    {
                        CPUScore += 1;

                        MessageBox.Show("CPU Wins, Scissor cuts Paper");
                    }
                    else if (playerChoice == "scissor")
                    {
                        MessageBox.Show("It's a draw!");
                    }
                    else if (playerChoice == "none")
                    {
                        MessageBox.Show("Please choose a move");
                    }
                    labelScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;
                    picCPU.Image = Properties.Resources.Animal_World;
                    if (playerScore > 4)
                    {
                        MessageBox.Show("Congrats, You Win the War!");
                        playerScore = 0;
                        CPUScore = 0;
                        labelScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;

                        playerChoice = "none";

                        picPlayer.Image = Properties.Resources.Animal_World;
                        picCPU.Image = Properties.Resources.Animal_World;
                    }
                    else if (CPUScore > 4)
                    {
                        MessageBox.Show("You lose! Better luck next time.");
                        playerScore = 0;
                        CPUScore = 0;
                        labelScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;

                        playerChoice = "none";

                        picPlayer.Image = Properties.Resources.Animal_World;
                        picCPU.Image = Properties.Resources.Animal_World;
                    }
                    break;
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            playerScore = 0;
            CPUScore = 0;
            labelScore.Text = "Player: " + playerScore + " - " + "CPU: " + CPUScore;

            playerChoice = "none";

            picPlayer.Image = Properties.Resources.Animal_World;
            picCPU.Image = Properties.Resources.Animal_World;
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rock crushes Scissor, Scissor cuts Paper, and Paper covers Rock.");
            MessageBox.Show("First to 5 wins!");
        }
    }
}
