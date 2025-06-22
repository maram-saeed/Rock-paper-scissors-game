using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_paper_scissors
{
    public class clsGame
    {
      public enum enGameChoice { Stone = 1, Paper = 2, Scissors = 3 };
        public enum enWinner { 
           Player = 1,
           Computer = 2,
           Draw = 3 
        };

        public struct stRoundInfo
        {
           public short roundNumber;
           public enGameChoice playerChoice;
           public enGameChoice computerChoice;
           public enWinner winner;
           public string winnerName;
        };

        public struct stGameResults
        {
           public short gameRounds;
           public short computerWinTimes;
           public short player1WinTimes;
           public short drawTimes;
           public enWinner gameWinner;
           public string winnerName;

        };

        int RandomNumber(int From, int To)
        {
            Random random = new Random();
            int randNumber = random.Next(From, To);
            return randNumber;
        }


       public  enWinner WhoWonTheRound(stRoundInfo RoundInfo)
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


        //void ShowFinalGameResults(stGameResults GameResults)
        //{
        //    cout << Tabs(2) << "____________________[ Game Results ]____________________\n\n";
        //    cout << Tabs(2) << "Game Rounds		   : " << GameResults.gameRounds << endl;
        //    cout << Tabs(2) << "Player1 won times  : " << GameResults.player1WinTimes << endl;
        //    cout << Tabs(2) << "Computer won times : " << GameResults.computerWinTimes << endl;
        //    cout << Tabs(2) << "Draw times	       : " << GameResults.drawTimes << endl;
        //    cout << Tabs(2) << "Final winner	   : " << GameResults.winnerName << endl;
        //    cout << Tabs(2) << "___________________________________________________________\n";

        //    SetWinnerScreenColor(GameResults.gameWinner);
        //}


        //void ShowGameOverScreen()
        //{
        //    cout << Tabs(2) << "_________________________________________________________\n\n";
        //    cout << Tabs(2) << "				+++ G a m e O v e r +++\n";
        //    cout << Tabs(2) << "_________________________________________________________\n\n";
        //}



    }
}
