using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rock_paper_scissors.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;

namespace Rock_paper_scissors
{
    public partial class frmMainScreen : Form
    {
        List<Bitmap> imageList;
        public static byte playerWinTimes = 0, computerWinTimes = 0, drawTimes = 0;
        stGameResults gameResults;
        Image randomComputerChoice;

        frmShowFinalGameResultsScreen showFinalGameResultsScreen;

        public frmMainScreen(byte RoundsNumber, int Score)
        {
            InitializeComponent();

            imageList = new List<Bitmap>
        {
            Properties.Resources.scissors,
            Properties.Resources.paper,
            Properties.Resources.rock
        };

            roundInfo.roundNumber = RoundsNumber;
            lblScore.Text = frmStartGame.score.ToString();
            lblRounds.Text = frmStartGame.round.ToString();
        }

        public enum enGameChoice { Stone = 1, Paper = 2, Scissors = 3 };
        public enum enWinner
        {
            Player = 1,
            Computer = 2,
            Draw = 3
        };

        public struct stRoundInfo
        {
            public byte roundNumber;
            public enGameChoice playerChoice;
            public enGameChoice computerChoice;
            public enWinner winner;
            public string winnerName;
        };

        public struct stGameResults
        {
            public byte gameRounds;
            public byte computerWinTimes;
            public byte player1WinTimes;
            public byte drawTimes;
            public enWinner gameWinner;
            public string winnerName;

        };

        int RandomNumber(int From, int To)
        {
            Random random = new Random();
            int randNumber = random.Next(From, To);
            return randNumber;
        }


         enWinner WhoWonTheRound(stRoundInfo RoundInfo)
        {

            if (RoundInfo.playerChoice == RoundInfo.computerChoice)
            {
                return enWinner.Draw;
            }

            switch (RoundInfo.playerChoice)
            {
                case enGameChoice.Stone:
                    if (RoundInfo.computerChoice == enGameChoice.Paper)
                    {
                        return enWinner.Computer;
                    }
                    break;

                case enGameChoice.Paper:
                    if (RoundInfo.computerChoice == enGameChoice.Scissors)
                    {
                        return enWinner.Computer;
                    }
                    break;
                case enGameChoice.Scissors:
                    if (RoundInfo.computerChoice == enGameChoice.Stone)
                    {
                        return enWinner.Computer;
                    }
                    break;
            }
            return enWinner.Player;
        }

        enWinner WhoWonTheGame(byte Player1WinTimes, byte ComputerWinTimes)
        {
            if (Player1WinTimes > ComputerWinTimes)
                return enWinner.Player;
            else if (ComputerWinTimes > Player1WinTimes)
                return enWinner.Computer;
            else
                return enWinner.Draw;
        }

        stRoundInfo roundInfo;

        string WinnerName(enWinner Winner)
        {
            string []arrWinnerName = { "Player", "Computer", "No Winner" };
            return arrWinnerName[(int)Winner - 1];
        }

        private enGameChoice GetRandomComputerChoice()
        {
            int index = RandomNumber(1,4);
            return (enGameChoice)(index);
        }


        private Image GetImageForChoice(enGameChoice choice)
        {
            switch (choice)
            {
                case enGameChoice.Scissors: return Resources.scissors;
                case enGameChoice.Paper: return Resources.paper;
                case enGameChoice.Stone: return Resources.rock;
                default: return null;
            }
        }

        stGameResults FillGameResults(byte GameRounds, byte Player1WinTimes, byte ComputerWinTimes, byte DrawTimes)
        {
            stGameResults GameResults;

            GameResults.gameRounds = GameRounds;
            GameResults.player1WinTimes = Player1WinTimes;
            GameResults.computerWinTimes = ComputerWinTimes;
            GameResults.drawTimes = DrawTimes;
            GameResults.gameWinner = WhoWonTheGame(Player1WinTimes, ComputerWinTimes);
            GameResults.winnerName = WinnerName(GameResults.gameWinner);

            return GameResults;
        }

        stGameResults PlayGame(byte HowManyRounds)
        {
            if (frmStartGame.round > frmStartGame.totalRounds)
                return gameResults; // لا تغييرات

            if (roundInfo.winner == enWinner.Player)
                playerWinTimes++;
            else if (roundInfo.winner == enWinner.Computer)
                computerWinTimes++;
            else
                drawTimes++;

            return FillGameResults(HowManyRounds, playerWinTimes, computerWinTimes, drawTimes);
        }

        private void PlayRound(enGameChoice playerChoice, Image playerImage)
        {
            if (frmStartGame.round > frmStartGame.totalRounds)
            {
                pbRock.Enabled = false;
                pbPaper.Enabled = false;
                pbScissors.Enabled = false;
                return;
            }

            roundInfo.playerChoice = playerChoice;
            roundInfo.computerChoice = GetRandomComputerChoice();

            roundInfo.winner = WhoWonTheRound(roundInfo);
            roundInfo.winnerName = WinnerName(roundInfo.winner);

            Image computerImage = GetImageForChoice(roundInfo.computerChoice);

            frmStartGame frm = new frmStartGame(playerImage, computerImage, roundInfo.winnerName, roundInfo.roundNumber);

            if (frmStartGame.round > frmStartGame.totalRounds)
            {
                MessageBox.Show("Game has already ended. Please restart to play again.", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                showFinalGameResultsScreen = new frmShowFinalGameResultsScreen(
                    gameResults.gameRounds,
                    gameResults.player1WinTimes,
                    gameResults.computerWinTimes,
                    gameResults.drawTimes,
                    gameResults.winnerName
                );
                showFinalGameResultsScreen.Show();

                pbRock.Enabled = false;
                pbPaper.Enabled = false;
                pbScissors.Enabled = false;

                return;
            }
            else
            {
                frm.ShowDialog();
                lblScore.Text = frmStartGame.score.ToString();
                lblRounds.Text = frmStartGame.round.ToString();
                gameResults = PlayGame(roundInfo.roundNumber);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            guna2Panel1.BorderColor = Color.FromArgb(90, Color.White);
        }

        private void btnRules_Click(object sender, EventArgs e)
        {
            pnlRules.Visible = true;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            pnlRules.Visible = false;
        }
        
        private void pbScissors_Click(object sender, EventArgs e)
        {
            PlayRound(enGameChoice.Scissors, Resources.scissors);
        }

        private void pbPaper_Click(object sender, EventArgs e)
        {
            PlayRound(enGameChoice.Paper, Resources.paper);
        }

        private void pbRock_Click(object sender, EventArgs e)
        {
            PlayRound(enGameChoice.Stone, Resources.rock);
        }
    }
}
