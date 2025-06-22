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

namespace Rock_paper_scissors
{
    public partial class frmStartGame : Form
    {
        string winnerName;
        public static byte score = 0;
        public static byte totalRounds = 0;
        public static byte round = 0;
        public static bool isClosed = false;
        public byte counter;

        frmMainScreen mainScreen;
        public frmStartGame(Image selectedImage, Image computerSelectedImage, string winnerName, byte roundsNumber)
        {
            InitializeComponent();
            pbPlayerChoice.Image = selectedImage;
            pbComputerChoice.Image = computerSelectedImage;
            this.winnerName = winnerName;

            lblScore.Text = score.ToString();
            mainScreen = new frmMainScreen(0, score);
            frmStartGame.totalRounds = roundsNumber;

            if (!(round > totalRounds))
            {
                round++;
                lblRounds.Text = round.ToString();
            }

        }

        void checkWinInUi()
        {
            pbComputerChoice.Visible = true;
            btnDefault.Visible = false;
            if (winnerName == "Player")
            {
                if (lblWin.Visible == false && btnPlayAgain.Visible == false)
                {
                    score++;
                    lblScore.Text = score.ToString();
                }

                lblWin.Visible = true;
                lblLose.Visible = false;
                btnPlayAgain.Visible = true;

                lblWin.Location = new Point(410, 300);
                btnPlayAgain.Location = new Point(410, 350);

                lblPlayerChoice.Location = new Point(220, 190);
                pbPlayerChoice.Location = new Point(110, pbPlayerChoice.Location.Y);

                lblComputerChoice.Location = new Point(600, 190);

                pbComputerChoice.Location = new Point(530, pbComputerChoice.Location.Y);
            }

            else if (winnerName == "Computer")
            {
                pbComputerChoice.Visible = true;
                btnDefault.Visible = false;
                if (lblLose.Visible == false && btnPlayAgain.Visible == false)
                {
                    if (score > 0)
                    {
                        score--;
                        lblScore.Text = score.ToString();
                    }
                }

                lblWin.Visible = false;
                lblLose.Visible = true;
                btnPlayAgain.Visible = true;

                lblLose.Location = new Point(410, 300);
                btnPlayAgain.Location = new Point(410, 350);

                lblPlayerChoice.Location = new Point(220, 190);
                pbPlayerChoice.Location = new Point(110, pbPlayerChoice.Location.Y);

                lblComputerChoice.Location = new Point(600, 190);
                if (pbComputerChoice.Image == Resources.rock)
                {
                    //pbComputerChoice.Location = new Point(700, pbComputerChoice.Location.Y);

                    lblLose.Location = new Point(450, 300);
                    btnPlayAgain.Location = new Point(450, 350);
                }

                else
                    pbComputerChoice.Location = new Point(530, pbComputerChoice.Location.Y);
            }

            else
            {
                pbComputerChoice.Visible = true;
                btnDefault.Visible = false;
                lblWin.Visible = false;
                lblLose.Visible = false;
                lblDraw.Visible = true;

                lblDraw.Location = new Point(430, 300);

                btnPlayAgain.Visible = true;
                btnPlayAgain.Location = new Point(410, 350);

                lblPlayerChoice.Location = new Point(220, 190);
                pbPlayerChoice.Location = new Point(110, pbPlayerChoice.Location.Y);

                lblComputerChoice.Location = new Point(600, 190);

                pbComputerChoice.Location = new Point(530, pbComputerChoice.Location.Y);
            }
        }

        /* void checkWinInUi()
        {
            pbComputerChoice.Visible = true;
            btnDefault.Visible = false;

            // *** قيم X الجديدة لصور اللاعب والكمبيوتر (تقديرية من الصورة التي قدمتها) ***
            // هذه القيم تهدف إلى جعل الدوائر متماثلة بصريًا على الشاشة.
            int playerChoiceImageX = 150; // موقع X لصورة اختيار اللاعب (الحد الأيسر)
            int computerChoiceImageX = 650; // موقع X لصورة اختيار الكمبيوتر (الحد الأيسر)

            // *** قيم Y الثابتة للعناصر المركزية (نص النتيجة وزر اللعب مرة أخرى) ***
            int middleLabelY = 300;
            int playAgainButtonY = 350;

            // *** قيم X الثابتة للعناصر المركزية (قد تحتاج إلى تعديل بسيط بناءً على عرض النص الفعلي) ***
            int middleLabelX_Win = 410;   // موقع X لنص "WIN"
            int middleLabelX_Lose = 410;  // موقع X لنص "LOSE"
            int middleLabelX_Draw = 430;  // موقع X لنص "DRAW" (كما كان في الكود الأصلي)
            int playAgainButtonX = 410;   // موقع X لزر "PLAY AGAIN"

            if (winnerName == "Player")
            {
                if (lblWin.Visible == false && btnPlayAgain.Visible == false)
                {
                    score = score + 1;
                    lblScore.Text = score.ToString();
                }

                lblWin.Visible = true;
                lblLose.Visible = false;
                lblDraw.Visible = false; // تأكد من إخفاء lblDraw

                lblWin.Location = new Point(middleLabelX_Win, middleLabelY);
                btnPlayAgain.Location = new Point(playAgainButtonX, playAgainButtonY);

                // تعيين مواقع صور اللاعب والكمبيوتر باستخدام القيم الثابتة الجديدة
                lblPlayerChoice.Location = new Point(220, 190); // احتفظ بموقع تسمية اللاعب
                pbPlayerChoice.Location = new Point(playerChoiceImageX, pbPlayerChoice.Location.Y);

                lblComputerChoice.Location = new Point(600, 190); // احتفظ بموقع تسمية الكمبيوتر
                pbComputerChoice.Location = new Point(computerChoiceImageX, pbComputerChoice.Location.Y);
            }
            else if (winnerName == "Computer")
            {
                pbComputerChoice.Visible = true;
                btnDefault.Visible = false;
                if (lblLose.Visible == false && btnPlayAgain.Visible == false)
                {
                    if (score > 0)
                    {
                        score = score - 1;
                        lblScore.Text = score.ToString();
                    }
                }

                lblWin.Visible = false;
                lblLose.Visible = true;
                lblDraw.Visible = false; // تأكد من إخفاء lblDraw

                lblLose.Location = new Point(middleLabelX_Lose, middleLabelY);
                btnPlayAgain.Location = new Point(playAgainButtonX, playAgainButtonY);

                // تعيين مواقع صور اللاعب والكمبيوتر باستخدام القيم الثابتة الجديدة
                lblPlayerChoice.Location = new Point(220, 190);
                pbPlayerChoice.Location = new Point(playerChoiceImageX, pbPlayerChoice.Location.Y);

                lblComputerChoice.Location = new Point(600, 190);
                pbComputerChoice.Location = new Point(computerChoiceImageX, pbComputerChoice.Location.Y);
            }
            else // حالة التعادل (winnerName == "Draw")
            {
                pbComputerChoice.Visible = true;
                btnDefault.Visible = false;
                lblWin.Visible = false;
                lblLose.Visible = false;
                lblDraw.Visible = true;

                lblDraw.Location = new Point(middleLabelX_Draw, middleLabelY); // استخدم X الأصلي لـ DRAW
                btnPlayAgain.Location = new Point(playAgainButtonX, playAgainButtonY);

                // تعيين مواقع صور اللاعب والكمبيوتر باستخدام القيم الثابتة الجديدة
                lblPlayerChoice.Location = new Point(220, 190);
                pbPlayerChoice.Location = new Point(playerChoiceImageX, pbPlayerChoice.Location.Y);

                lblComputerChoice.Location = new Point(600, 190);
                pbComputerChoice.Location = new Point(computerChoiceImageX, pbComputerChoice.Location.Y);
            }
        }
        */

        private void pbPlayerChoice_Click(object sender, EventArgs e)
        {
            //checkWinInUi();
        }

        private void btnPlayAgain_Click(object sender, EventArgs e)
        {

            if (round >= totalRounds)
            {
                btnPlayAgain.Enabled = false;
                this.Close(); // ✅ لا تزيد الجولة
                return;
            }

           // round++; // ✅ الزيادة هنا فقط
            this.Close();
            isClosed = true;
        }

        private void frmStartGame_Load(object sender, EventArgs e)
        {

            counter = 3;

            if (counter == 0)
            { 
                timer1.Enabled = false;

            }
            else
                timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnDefault.Text = counter.ToString();

            if (counter == 0)
            {
                timer1.Enabled = false;
                checkWinInUi();
            }
            else
            {
                counter--;
            }
        }

        private void btnRules2_Click(object sender, EventArgs e)
        {
            pnlRules.BringToFront();
            pnlRules.Visible = true;
        }

        private void pbClose_Click(object sender, EventArgs e)
        {
            pnlRules.Visible = false;
        }
    }
}
