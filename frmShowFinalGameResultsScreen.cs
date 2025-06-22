using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rock_paper_scissors
{
    public partial class frmShowFinalGameResultsScreen : Form
    {
        int rounds, playerWonTimes, computerWonTimes, drawTimes;

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
        "Do you want to play again?",
        "Game Over",
        MessageBoxButtons.YesNo,
        MessageBoxIcon.Question
    );

            if (result == DialogResult.Yes)
            {

                frmStartGame.score = 0;
                frmStartGame.round = 0;

                frmMainScreen.playerWinTimes = 0;
                frmMainScreen.computerWinTimes = 0;
                frmMainScreen.drawTimes = 0;

                frmStartScreen startScreen = new frmStartScreen();
                startScreen.ShowDialog();

                foreach (Form frm in Application.OpenForms.OfType<Form>().ToList())
                {
                    if (frm != startScreen)
                        frm.Close();
                }
            }
            else
            {
                Application.Exit();
            }
        }

        string finalWinner;
        public frmShowFinalGameResultsScreen(int Rounds, byte PlayerWonTimes, byte ComputerWonTimes, byte DrawTimes, string FinalWinner)
        {
            InitializeComponent();
            rounds = Rounds;
            playerWonTimes = PlayerWonTimes;
            computerWonTimes = ComputerWonTimes;
            drawTimes = DrawTimes;
            finalWinner = FinalWinner;
        }

        private void frmShowFinalGameResultsScreen_Load(object sender, EventArgs e)
        {
            lblResultGameRounds.Text = rounds.ToString();
            lblPlayerWonTimes.Text = playerWonTimes.ToString();
            lblComputerWonTimes.Text = computerWonTimes.ToString();
            lblDrawTimes.Text = drawTimes.ToString();
            lblFinalWinner.Text = finalWinner.ToString();

            if (finalWinner == "Player")
                lblFinalWinner.ForeColor = Color.GreenYellow;


            else if (finalWinner == "Computer")
                lblFinalWinner.ForeColor = Color.Red;

            else
                lblFinalWinner.ForeColor = Color.Orange;
        }
    }
}
