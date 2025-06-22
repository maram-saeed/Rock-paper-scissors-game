namespace Rock_paper_scissors
{
    partial class frmShowFinalGameResultsScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblFinalWinner = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDrawTimes = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblComputerWonTimes = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblPlayerWonTimes = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblResultGameRounds = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnEndGame = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(255, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(345, 67);
            this.label1.TabIndex = 0;
            this.label1.Text = "Game Results";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2Panel1.BorderRadius = 5;
            this.guna2Panel1.BorderThickness = 2;
            this.guna2Panel1.Controls.Add(this.lblFinalWinner);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.lblDrawTimes);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.lblComputerWonTimes);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.lblPlayerWonTimes);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.lblResultGameRounds);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Location = new System.Drawing.Point(122, 182);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(619, 282);
            this.guna2Panel1.TabIndex = 2;
            // 
            // lblFinalWinner
            // 
            this.lblFinalWinner.AutoSize = true;
            this.lblFinalWinner.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalWinner.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFinalWinner.ForeColor = System.Drawing.Color.White;
            this.lblFinalWinner.Location = new System.Drawing.Point(151, 204);
            this.lblFinalWinner.Name = "lblFinalWinner";
            this.lblFinalWinner.Size = new System.Drawing.Size(71, 28);
            this.lblFinalWinner.TabIndex = 12;
            this.lblFinalWinner.Text = "Player";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(15, 204);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 28);
            this.label8.TabIndex = 11;
            this.label8.Text = "Final Winner:";
            // 
            // lblDrawTimes
            // 
            this.lblDrawTimes.AutoSize = true;
            this.lblDrawTimes.BackColor = System.Drawing.Color.Transparent;
            this.lblDrawTimes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDrawTimes.ForeColor = System.Drawing.Color.White;
            this.lblDrawTimes.Location = new System.Drawing.Point(140, 156);
            this.lblDrawTimes.Name = "lblDrawTimes";
            this.lblDrawTimes.Size = new System.Drawing.Size(24, 28);
            this.lblDrawTimes.TabIndex = 10;
            this.lblDrawTimes.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(15, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 28);
            this.label6.TabIndex = 9;
            this.label6.Text = "Draw Times:";
            // 
            // lblComputerWonTimes
            // 
            this.lblComputerWonTimes.AutoSize = true;
            this.lblComputerWonTimes.BackColor = System.Drawing.Color.Transparent;
            this.lblComputerWonTimes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblComputerWonTimes.ForeColor = System.Drawing.Color.White;
            this.lblComputerWonTimes.Location = new System.Drawing.Point(230, 112);
            this.lblComputerWonTimes.Name = "lblComputerWonTimes";
            this.lblComputerWonTimes.Size = new System.Drawing.Size(24, 28);
            this.lblComputerWonTimes.TabIndex = 8;
            this.lblComputerWonTimes.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(15, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 28);
            this.label5.TabIndex = 7;
            this.label5.Text = "Computer Won Times:";
            // 
            // lblPlayerWonTimes
            // 
            this.lblPlayerWonTimes.AutoSize = true;
            this.lblPlayerWonTimes.BackColor = System.Drawing.Color.Transparent;
            this.lblPlayerWonTimes.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblPlayerWonTimes.ForeColor = System.Drawing.Color.White;
            this.lblPlayerWonTimes.Location = new System.Drawing.Point(198, 68);
            this.lblPlayerWonTimes.Name = "lblPlayerWonTimes";
            this.lblPlayerWonTimes.Size = new System.Drawing.Size(24, 28);
            this.lblPlayerWonTimes.TabIndex = 6;
            this.lblPlayerWonTimes.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(15, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 28);
            this.label4.TabIndex = 5;
            this.label4.Text = "Player Won Times:";
            // 
            // lblResultGameRounds
            // 
            this.lblResultGameRounds.AutoSize = true;
            this.lblResultGameRounds.BackColor = System.Drawing.Color.Transparent;
            this.lblResultGameRounds.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblResultGameRounds.ForeColor = System.Drawing.Color.White;
            this.lblResultGameRounds.Location = new System.Drawing.Point(159, 21);
            this.lblResultGameRounds.Name = "lblResultGameRounds";
            this.lblResultGameRounds.Size = new System.Drawing.Size(24, 28);
            this.lblResultGameRounds.TabIndex = 4;
            this.lblResultGameRounds.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(15, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(147, 28);
            this.label2.TabIndex = 3;
            this.label2.Text = "Game Rounds:";
            // 
            // btnEndGame
            // 
            this.btnEndGame.Animated = true;
            this.btnEndGame.BackColor = System.Drawing.Color.Transparent;
            this.btnEndGame.BorderColor = System.Drawing.Color.White;
            this.btnEndGame.BorderRadius = 5;
            this.btnEndGame.BorderThickness = 1;
            this.btnEndGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEndGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEndGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEndGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEndGame.FillColor = System.Drawing.Color.Transparent;
            this.btnEndGame.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEndGame.ForeColor = System.Drawing.Color.White;
            this.btnEndGame.Location = new System.Drawing.Point(368, 489);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.PressedColor = System.Drawing.Color.White;
            this.btnEndGame.Size = new System.Drawing.Size(127, 46);
            this.btnEndGame.TabIndex = 12;
            this.btnEndGame.Text = "Ok";
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // frmShowFinalGameResultsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rock_paper_scissors.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(871, 582);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.label1);
            this.Name = "frmShowFinalGameResultsScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmShowFinalGameResultsScreen";
            this.Load += new System.EventHandler(this.frmShowFinalGameResultsScreen_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblDrawTimes;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblComputerWonTimes;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblPlayerWonTimes;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblResultGameRounds;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblFinalWinner;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnEndGame;
    }
}