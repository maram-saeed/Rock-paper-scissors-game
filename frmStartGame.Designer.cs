namespace Rock_paper_scissors
{
    partial class frmStartGame
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnRules2 = new Guna.UI2.WinForms.Guna2Button();
            this.pbPlayerChoice = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblPlayerChoice = new System.Windows.Forms.Label();
            this.lblComputerChoice = new System.Windows.Forms.Label();
            this.pbComputerChoice = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblRounds = new System.Windows.Forms.Label();
            this.lblWin = new System.Windows.Forms.Label();
            this.btnPlayAgain = new Guna.UI2.WinForms.Guna2Button();
            this.lblLose = new System.Windows.Forms.Label();
            this.lblDraw = new System.Windows.Forms.Label();
            this.btnDefault = new Guna.UI2.WinForms.Guna2CircleButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pnlRules = new Guna.UI2.WinForms.Guna2Panel();
            this.pbClose = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerChoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerChoice)).BeginInit();
            this.pnlRules.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.Silver;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.guna2PictureBox3);
            this.guna2Panel1.Controls.Add(this.guna2GradientPanel1);
            this.guna2Panel1.Location = new System.Drawing.Point(278, 44);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(566, 129);
            this.guna2Panel1.TabIndex = 7;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::Rock_paper_scissors.Properties.Resources.logo1;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(16, 15);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(139, 104);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 7;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 5;
            this.guna2GradientPanel1.Controls.Add(this.label1);
            this.guna2GradientPanel1.Controls.Add(this.lblScore);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.White;
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.WhiteSmoke;
            this.guna2GradientPanel1.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.Vertical;
            this.guna2GradientPanel1.Location = new System.Drawing.Point(425, 15);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(121, 92);
            this.guna2GradientPanel1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label1.Location = new System.Drawing.Point(34, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 2;
            this.label1.Text = "SCORE";
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblScore.Location = new System.Drawing.Point(31, 25);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(58, 67);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "0";
            // 
            // btnRules2
            // 
            this.btnRules2.Animated = true;
            this.btnRules2.BackColor = System.Drawing.Color.Transparent;
            this.btnRules2.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnRules2.BorderRadius = 5;
            this.btnRules2.BorderThickness = 1;
            this.btnRules2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRules2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRules2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRules2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRules2.FillColor = System.Drawing.Color.Transparent;
            this.btnRules2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRules2.ForeColor = System.Drawing.Color.White;
            this.btnRules2.Location = new System.Drawing.Point(955, 623);
            this.btnRules2.Name = "btnRules2";
            this.btnRules2.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.btnRules2.Size = new System.Drawing.Size(120, 37);
            this.btnRules2.TabIndex = 8;
            this.btnRules2.Text = "Rules";
            this.btnRules2.TextTransform = Guna.UI2.WinForms.Enums.TextTransform.UpperCase;
            this.btnRules2.Click += new System.EventHandler(this.btnRules2_Click);
            // 
            // pbPlayerChoice
            // 
            this.pbPlayerChoice.BackColor = System.Drawing.Color.Transparent;
            this.pbPlayerChoice.Image = global::Rock_paper_scissors.Properties.Resources.scissors;
            this.pbPlayerChoice.ImageRotate = 0F;
            this.pbPlayerChoice.Location = new System.Drawing.Point(228, 287);
            this.pbPlayerChoice.Name = "pbPlayerChoice";
            this.pbPlayerChoice.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbPlayerChoice.Size = new System.Drawing.Size(358, 276);
            this.pbPlayerChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbPlayerChoice.TabIndex = 9;
            this.pbPlayerChoice.TabStop = false;
            this.pbPlayerChoice.UseTransparentBackground = true;
            this.pbPlayerChoice.Click += new System.EventHandler(this.pbPlayerChoice_Click);
            // 
            // lblPlayerChoice
            // 
            this.lblPlayerChoice.AutoSize = true;
            this.lblPlayerChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerChoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerChoice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPlayerChoice.Location = new System.Drawing.Point(358, 240);
            this.lblPlayerChoice.Name = "lblPlayerChoice";
            this.lblPlayerChoice.Size = new System.Drawing.Size(143, 28);
            this.lblPlayerChoice.TabIndex = 10;
            this.lblPlayerChoice.Text = "YOUR CHOICE";
            // 
            // lblComputerChoice
            // 
            this.lblComputerChoice.AutoSize = true;
            this.lblComputerChoice.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerChoice.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComputerChoice.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblComputerChoice.Location = new System.Drawing.Point(605, 240);
            this.lblComputerChoice.Name = "lblComputerChoice";
            this.lblComputerChoice.Size = new System.Drawing.Size(197, 28);
            this.lblComputerChoice.TabIndex = 12;
            this.lblComputerChoice.Text = "COMPUTER CHOICE";
            // 
            // pbComputerChoice
            // 
            this.pbComputerChoice.BackColor = System.Drawing.Color.Transparent;
            this.pbComputerChoice.Image = global::Rock_paper_scissors.Properties.Resources.scissors;
            this.pbComputerChoice.ImageRotate = 0F;
            this.pbComputerChoice.Location = new System.Drawing.Point(505, 287);
            this.pbComputerChoice.Name = "pbComputerChoice";
            this.pbComputerChoice.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.pbComputerChoice.Size = new System.Drawing.Size(358, 276);
            this.pbComputerChoice.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbComputerChoice.TabIndex = 11;
            this.pbComputerChoice.TabStop = false;
            this.pbComputerChoice.UseTransparentBackground = true;
            this.pbComputerChoice.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label5.Location = new System.Drawing.Point(53, 632);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 28);
            this.label5.TabIndex = 13;
            this.label5.Text = "Round:";
            // 
            // lblRounds
            // 
            this.lblRounds.AutoSize = true;
            this.lblRounds.BackColor = System.Drawing.Color.Transparent;
            this.lblRounds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRounds.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblRounds.Location = new System.Drawing.Point(128, 632);
            this.lblRounds.Name = "lblRounds";
            this.lblRounds.Size = new System.Drawing.Size(24, 28);
            this.lblRounds.TabIndex = 14;
            this.lblRounds.Text = "0";
            // 
            // lblWin
            // 
            this.lblWin.AutoSize = true;
            this.lblWin.BackColor = System.Drawing.Color.Transparent;
            this.lblWin.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblWin.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblWin.Location = new System.Drawing.Point(49, 398);
            this.lblWin.Name = "lblWin";
            this.lblWin.Size = new System.Drawing.Size(196, 52);
            this.lblWin.TabIndex = 15;
            this.lblWin.Text = "YOU WIN";
            this.lblWin.Visible = false;
            // 
            // btnPlayAgain
            // 
            this.btnPlayAgain.Animated = true;
            this.btnPlayAgain.BackColor = System.Drawing.Color.Transparent;
            this.btnPlayAgain.BorderRadius = 5;
            this.btnPlayAgain.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayAgain.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPlayAgain.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPlayAgain.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPlayAgain.FillColor = System.Drawing.Color.White;
            this.btnPlayAgain.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold);
            this.btnPlayAgain.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnPlayAgain.HoverState.FillColor = System.Drawing.Color.White;
            this.btnPlayAgain.HoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnPlayAgain.Location = new System.Drawing.Point(58, 472);
            this.btnPlayAgain.Name = "btnPlayAgain";
            this.btnPlayAgain.Size = new System.Drawing.Size(178, 41);
            this.btnPlayAgain.TabIndex = 16;
            this.btnPlayAgain.Text = "PLAY AGAIN";
            this.btnPlayAgain.Visible = false;
            this.btnPlayAgain.Click += new System.EventHandler(this.btnPlayAgain_Click);
            // 
            // lblLose
            // 
            this.lblLose.AutoSize = true;
            this.lblLose.BackColor = System.Drawing.Color.Transparent;
            this.lblLose.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblLose.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblLose.Location = new System.Drawing.Point(49, 346);
            this.lblLose.Name = "lblLose";
            this.lblLose.Size = new System.Drawing.Size(206, 52);
            this.lblLose.TabIndex = 17;
            this.lblLose.Text = "YOU LOSE";
            this.lblLose.Visible = false;
            // 
            // lblDraw
            // 
            this.lblDraw.AutoSize = true;
            this.lblDraw.BackColor = System.Drawing.Color.Transparent;
            this.lblDraw.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Bold);
            this.lblDraw.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblDraw.Location = new System.Drawing.Point(49, 294);
            this.lblDraw.Name = "lblDraw";
            this.lblDraw.Size = new System.Drawing.Size(141, 52);
            this.lblDraw.TabIndex = 18;
            this.lblDraw.Text = "DRAW";
            this.lblDraw.Visible = false;
            // 
            // btnDefault
            // 
            this.btnDefault.BackColor = System.Drawing.Color.Transparent;
            this.btnDefault.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDefault.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDefault.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDefault.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDefault.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(3)))), ((int)(((byte)(26)))), ((int)(((byte)(64)))));
            this.btnDefault.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btnDefault.ForeColor = System.Drawing.Color.White;
            this.btnDefault.Location = new System.Drawing.Point(621, 346);
            this.btnDefault.Name = "btnDefault";
            this.btnDefault.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.btnDefault.Size = new System.Drawing.Size(150, 150);
            this.btnDefault.TabIndex = 19;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pnlRules
            // 
            this.pnlRules.BackColor = System.Drawing.Color.White;
            this.pnlRules.BorderRadius = 10;
            this.pnlRules.Controls.Add(this.guna2PictureBox2);
            this.pnlRules.Controls.Add(this.pbClose);
            this.pnlRules.Controls.Add(this.label3);
            this.pnlRules.Location = new System.Drawing.Point(386, 164);
            this.pnlRules.Name = "pnlRules";
            this.pnlRules.Size = new System.Drawing.Size(395, 386);
            this.pnlRules.TabIndex = 20;
            this.pnlRules.Visible = false;
            // 
            // pbClose
            // 
            this.pbClose.BackColor = System.Drawing.Color.Transparent;
            this.pbClose.Image = global::Rock_paper_scissors.Properties.Resources.icon_close;
            this.pbClose.ImageRotate = 0F;
            this.pbClose.Location = new System.Drawing.Point(334, 33);
            this.pbClose.Name = "pbClose";
            this.pbClose.Size = new System.Drawing.Size(38, 21);
            this.pbClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbClose.TabIndex = 2;
            this.pbClose.TabStop = false;
            this.pbClose.UseTransparentBackground = true;
            this.pbClose.Click += new System.EventHandler(this.pbClose_Click);
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox2.Image = global::Rock_paper_scissors.Properties.Resources.Screenshot_2025_06_08_180424_removebg_preview1;
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(3, 60);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(394, 323);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 1;
            this.guna2PictureBox2.TabStop = false;
            this.guna2PictureBox2.UseTransparentBackground = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(25, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "RULES";
            // 
            // frmStartGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rock_paper_scissors.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(1166, 715);
            this.Controls.Add(this.pnlRules);
            this.Controls.Add(this.lblDraw);
            this.Controls.Add(this.lblLose);
            this.Controls.Add(this.btnPlayAgain);
            this.Controls.Add(this.lblWin);
            this.Controls.Add(this.lblRounds);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblComputerChoice);
            this.Controls.Add(this.lblPlayerChoice);
            this.Controls.Add(this.btnRules2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.btnDefault);
            this.Controls.Add(this.pbComputerChoice);
            this.Controls.Add(this.pbPlayerChoice);
            this.Name = "frmStartGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStartGame";
            this.Load += new System.EventHandler(this.frmStartGame_Load);
            this.guna2Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayerChoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbComputerChoice)).EndInit();
            this.pnlRules.ResumeLayout(false);
            this.pnlRules.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private Guna.UI2.WinForms.Guna2Button btnRules2;
        private System.Windows.Forms.Label lblPlayerChoice;
        private System.Windows.Forms.Label lblComputerChoice;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbPlayerChoice;
        public Guna.UI2.WinForms.Guna2CirclePictureBox pbComputerChoice;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblRounds;
        private System.Windows.Forms.Label lblWin;
        private Guna.UI2.WinForms.Guna2Button btnPlayAgain;
        private System.Windows.Forms.Label lblLose;
        private System.Windows.Forms.Label lblDraw;
        private Guna.UI2.WinForms.Guna2CircleButton btnDefault;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Panel pnlRules;
        private Guna.UI2.WinForms.Guna2PictureBox pbClose;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private System.Windows.Forms.Label label3;
    }
}