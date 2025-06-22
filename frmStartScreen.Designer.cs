namespace Rock_paper_scissors
{
    partial class frmStartScreen
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
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbRoundList = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnEnterGame = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.FillColor = System.Drawing.Color.Transparent;
            this.guna2PictureBox3.Image = global::Rock_paper_scissors.Properties.Resources.logo1;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(40, 31);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(205, 126);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 8;
            this.guna2PictureBox3.TabStop = false;
            this.guna2PictureBox3.UseTransparentBackground = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(162, 270);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(276, 28);
            this.label1.TabIndex = 9;
            this.label1.Text = "Choose Number of Rounds :";
            // 
            // cbRoundList
            // 
            this.cbRoundList.BackColor = System.Drawing.Color.Transparent;
            this.cbRoundList.BorderRadius = 5;
            this.cbRoundList.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbRoundList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbRoundList.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoundList.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbRoundList.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbRoundList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbRoundList.ItemHeight = 30;
            this.cbRoundList.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbRoundList.Location = new System.Drawing.Point(444, 270);
            this.cbRoundList.Name = "cbRoundList";
            this.cbRoundList.Size = new System.Drawing.Size(209, 36);
            this.cbRoundList.TabIndex = 10;
            // 
            // btnEnterGame
            // 
            this.btnEnterGame.Animated = true;
            this.btnEnterGame.BackColor = System.Drawing.Color.Transparent;
            this.btnEnterGame.BorderColor = System.Drawing.Color.White;
            this.btnEnterGame.BorderRadius = 5;
            this.btnEnterGame.BorderThickness = 1;
            this.btnEnterGame.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEnterGame.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEnterGame.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEnterGame.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEnterGame.FillColor = System.Drawing.Color.Transparent;
            this.btnEnterGame.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEnterGame.ForeColor = System.Drawing.Color.White;
            this.btnEnterGame.Location = new System.Drawing.Point(379, 395);
            this.btnEnterGame.Name = "btnEnterGame";
            this.btnEnterGame.PressedColor = System.Drawing.Color.White;
            this.btnEnterGame.Size = new System.Drawing.Size(127, 46);
            this.btnEnterGame.TabIndex = 11;
            this.btnEnterGame.Text = "Ok";
            this.btnEnterGame.Click += new System.EventHandler(this.btnEnterGame_Click);
            // 
            // frmStartScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Rock_paper_scissors.Properties.Resources.bg1;
            this.ClientSize = new System.Drawing.Size(903, 546);
            this.Controls.Add(this.btnEnterGame);
            this.Controls.Add(this.cbRoundList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2PictureBox3);
            this.Name = "frmStartScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmStartScreen";
            this.Load += new System.EventHandler(this.frmStartScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnEnterGame;
        public Guna.UI2.WinForms.Guna2ComboBox cbRoundList;
    }
}