using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BattleshipSimulator
{
    public partial class Form1 : Form
    {

        List<Button> playerPositionButtons;
        List<Button> enemyPossitionButtons;

        Random rand = new Random();

        int totalShips = 3;
        int round = 10;
        int playerScore;
        int enemyScore;


        public Form1()
        {
            InitializeComponent();
            RestartGame();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void EnemyPlayTimerEvent(object sender, EventArgs e)
        {

            if (playerPositionButtons.Count > 0 && round > 0)
            {
                round -= 1;

                txtRounds.Text = "Round: " + round;
                int index = rand.Next(playerPositionButtons.Count);

                if ((string)playerPositionButtons[index].Tag == "playerShip")
                {
                    playerPositionButtons[index].BackgroundImage = Properties.Resources.Fire;
                    label4.Text = playerPositionButtons[index].Text;
                    playerPositionButtons[index].Enabled = false;
                    playerPositionButtons[index].BackColor = Color.DarkBlue;
                    playerPositionButtons.RemoveAt(index);
                    enemyScore += 1;
                    txtEnemy.Text = enemyScore.ToString();
                    EnemyPlayTimer.Stop();
                }
                else
                {
                    playerPositionButtons[index].BackgroundImage = Properties.Resources.X;
                    label4.Text = playerPositionButtons[index].Text;
                    playerPositionButtons[index].Enabled = false;
                    playerPositionButtons[index].BackColor = Color.DarkBlue;
                    playerPositionButtons.RemoveAt(index);
                    EnemyPlayTimer.Stop();
                }
            }
            if (round < 1 || enemyScore > 2 || playerScore > 2)
            {
                if (playerScore > enemyScore)
                {
                    MessageBox.Show("You Win!", "CONGRATS!");
                    RestartGame();
                }
                else if (enemyScore > playerScore)
                {
                    MessageBox.Show("Lol I beat you! You suck!", "FAILURE!");
                    RestartGame();
                }
                else if (enemyScore == playerScore)
                {
                    MessageBox.Show("Damn... guess we tied...", "DRAW...");
                    RestartGame();
                }
            }
        }

        private void AttackButtonEvent(object sender, EventArgs e)
        {
            if (EnemyLocationListBox.Text != "")
            {
                var attackPosition = EnemyLocationListBox.Text.ToUpper();
                int index = enemyPossitionButtons.FindIndex(a => a.Name == attackPosition);

                if (enemyPossitionButtons[index].Enabled && round > 0)
                {
                    round -= 1;
                    txtRounds.Text = "Round: " + round;

                    if ((string)enemyPossitionButtons[index].Tag == "enemyShip")
                    {
                        enemyPossitionButtons[index].Enabled = false;
                        enemyPossitionButtons[index].BackgroundImage = Properties.Resources.Fire;
                        enemyPossitionButtons[index].BackColor = Color.DarkBlue;
                        playerScore += 1;
                        txtPlayer.Text = playerScore.ToString();
                        EnemyPlayTimer.Start();
                    }
                    else
                    {
                        enemyPossitionButtons[index].Enabled = false;
                        enemyPossitionButtons[index].BackgroundImage = Properties.Resources.X;
                        enemyPossitionButtons[index].BackColor = Color.DarkBlue;
                        EnemyPlayTimer.Start();
                    }
                }
            }
            else
            {
                MessageBox.Show("Choose a location from Dropdown menu first!", "N O P E !");
            }
        }

        private void PlayerPositionButtonsEvent(object sender, EventArgs e)
        {
            if (totalShips > 0)
            {
                var button = (Button)sender;

                button.Enabled = false;
                button.Tag = "playerShip";
                button.BackColor = Color.Orange;
                totalShips -= 1;
            }
            if (totalShips == 0)
            {
                btnAttack.Enabled = true;
                btnAttack.BackColor = Color.Red;
                btnAttack.ForeColor = Color.White;

                txtHelp.Text = "2) Now pick the attack position from the dropdown menu";
            }
        }

       private void RestartGame()
        {
            playerPositionButtons = new List<Button> { W1, W2, W3, W4, X1, X2, X3, X4, Y1, Y2, Y3, Y4, Z1, Z2, Z3, Z4 };
            enemyPossitionButtons = new List<Button> { A1, A2, A3, A4, B1, B2, B3, B4, C1, C2, C3, C4, D1, D2, D3, D4 };

            EnemyLocationListBox.Items.Clear();

            EnemyLocationListBox.Text = null;

            txtHelp.Text = "Click on Three Different locations from above to start!";

            for (int i = 0; i < enemyPossitionButtons.Count; i++)
            {
                enemyPossitionButtons[i].Enabled = true;
                enemyPossitionButtons[i].Tag = null;
                enemyPossitionButtons[i].BackColor = Color.White;
                enemyPossitionButtons[i].BackgroundImage = null;
                EnemyLocationListBox.Items.Add(enemyPossitionButtons[i].Text);
            }
            for (int i = 0; i < playerPositionButtons.Count; i++)
            {
                playerPositionButtons[i].Enabled = true;
                playerPositionButtons[i].Tag = null;
                playerPositionButtons[i].BackColor = Color.White;
                playerPositionButtons[i].BackgroundImage = null;
            }
            playerScore = 0;
            enemyScore = 0;
            round = 10;
            totalShips = 3;

            txtPlayer.Text = playerScore.ToString();
            txtEnemy.Text = enemyScore.ToString();
            label4.Text = "A1";

            btnAttack.Enabled = false;

            enemyLocationPicker();
        }

        private void enemyLocationPicker()
        {
            for (int i = 0; i < 3; i++)
            {
                int index = rand.Next(enemyPossitionButtons.Count);

                if (enemyPossitionButtons[index].Enabled == true && (string)enemyPossitionButtons[index].Tag == null)
                {
                    enemyPossitionButtons[index].Tag = "enemyShip";

                    Debug.WriteLine("Enemy Position: " + enemyPossitionButtons[index].Text);
                }
                else
                {
                    index = rand.Next(enemyPossitionButtons.Count);
                }
            }
        }

    }
}
