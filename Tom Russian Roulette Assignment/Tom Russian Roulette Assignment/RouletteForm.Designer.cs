namespace Tom_Russian_Roulette_Assignment
{
    partial class RouletteForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RouletteForm));
            this.btnSpinChamber = new System.Windows.Forms.Button();
            this.btnShootOpponent = new System.Windows.Forms.Button();
            this.btnShootSelf = new System.Windows.Forms.Button();
            this.pbOpponent = new System.Windows.Forms.PictureBox();
            this.pbGun = new System.Windows.Forms.PictureBox();
            this.cmbOpponent = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pbPlayer = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblPlayerName = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnExitRoulette = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.lblLuck = new System.Windows.Forms.Label();
            this.pbBulletHeader = new System.Windows.Forms.PictureBox();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBulletHeader)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSpinChamber
            // 
            this.btnSpinChamber.Location = new System.Drawing.Point(292, 351);
            this.btnSpinChamber.Name = "btnSpinChamber";
            this.btnSpinChamber.Size = new System.Drawing.Size(121, 71);
            this.btnSpinChamber.TabIndex = 0;
            this.btnSpinChamber.Text = "Load && Spin Chamber";
            this.btnSpinChamber.UseVisualStyleBackColor = true;
            this.btnSpinChamber.Click += new System.EventHandler(this.btnSpinChamber_Click);
            // 
            // btnShootOpponent
            // 
            this.btnShootOpponent.Location = new System.Drawing.Point(429, 390);
            this.btnShootOpponent.Name = "btnShootOpponent";
            this.btnShootOpponent.Size = new System.Drawing.Size(113, 33);
            this.btnShootOpponent.TabIndex = 1;
            this.btnShootOpponent.Text = "Shoot Opponent";
            this.btnShootOpponent.UseVisualStyleBackColor = true;
            this.btnShootOpponent.Click += new System.EventHandler(this.btnFireOponent_Click);
            // 
            // btnShootSelf
            // 
            this.btnShootSelf.Location = new System.Drawing.Point(428, 351);
            this.btnShootSelf.Name = "btnShootSelf";
            this.btnShootSelf.Size = new System.Drawing.Size(114, 32);
            this.btnShootSelf.TabIndex = 3;
            this.btnShootSelf.Text = "Shoot Yourself";
            this.btnShootSelf.UseVisualStyleBackColor = true;
            this.btnShootSelf.Click += new System.EventHandler(this.btnBiteBullet_Click);
            // 
            // pbOpponent
            // 
            this.pbOpponent.Location = new System.Drawing.Point(28, 30);
            this.pbOpponent.Name = "pbOpponent";
            this.pbOpponent.Size = new System.Drawing.Size(190, 175);
            this.pbOpponent.TabIndex = 4;
            this.pbOpponent.TabStop = false;
            // 
            // pbGun
            // 
            this.pbGun.Location = new System.Drawing.Point(249, 12);
            this.pbGun.Name = "pbGun";
            this.pbGun.Size = new System.Drawing.Size(274, 263);
            this.pbGun.TabIndex = 5;
            this.pbGun.TabStop = false;
            // 
            // cmbOpponent
            // 
            this.cmbOpponent.FormattingEnabled = true;
            this.cmbOpponent.Location = new System.Drawing.Point(28, 211);
            this.cmbOpponent.Name = "cmbOpponent";
            this.cmbOpponent.Size = new System.Drawing.Size(190, 21);
            this.cmbOpponent.TabIndex = 6;
            this.cmbOpponent.SelectedIndexChanged += new System.EventHandler(this.cmbOponent_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Select Your Opponent";
            // 
            // pbPlayer
            // 
            this.pbPlayer.Location = new System.Drawing.Point(564, 28);
            this.pbPlayer.Name = "pbPlayer";
            this.pbPlayer.Size = new System.Drawing.Size(182, 210);
            this.pbPlayer.TabIndex = 8;
            this.pbPlayer.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(583, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Player : ";
            // 
            // lblPlayerName
            // 
            this.lblPlayerName.AutoSize = true;
            this.lblPlayerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlayerName.Location = new System.Drawing.Point(645, 9);
            this.lblPlayerName.Name = "lblPlayerName";
            this.lblPlayerName.Size = new System.Drawing.Size(0, 16);
            this.lblPlayerName.TabIndex = 10;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.Location = new System.Drawing.Point(505, 306);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(0, 20);
            this.lblScore.TabIndex = 11;
            // 
            // btnExitRoulette
            // 
            this.btnExitRoulette.Location = new System.Drawing.Point(666, 416);
            this.btnExitRoulette.Name = "btnExitRoulette";
            this.btnExitRoulette.Size = new System.Drawing.Size(80, 24);
            this.btnExitRoulette.TabIndex = 12;
            this.btnExitRoulette.Text = "Exit";
            this.btnExitRoulette.UseVisualStyleBackColor = true;
            this.btnExitRoulette.Click += new System.EventHandler(this.btnExitRoulette_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(665, 387);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(81, 23);
            this.btnBack.TabIndex = 13;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // lblLuck
            // 
            this.lblLuck.AutoSize = true;
            this.lblLuck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLuck.Location = new System.Drawing.Point(292, 306);
            this.lblLuck.Name = "lblLuck";
            this.lblLuck.Size = new System.Drawing.Size(0, 20);
            this.lblLuck.TabIndex = 14;
            // 
            // pbBulletHeader
            // 
            this.pbBulletHeader.Location = new System.Drawing.Point(249, 12);
            this.pbBulletHeader.Name = "pbBulletHeader";
            this.pbBulletHeader.Size = new System.Drawing.Size(274, 48);
            this.pbBulletHeader.TabIndex = 15;
            this.pbBulletHeader.TabStop = false;
            // 
            // pbLogo
            // 
            this.pbLogo.Location = new System.Drawing.Point(564, 239);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(198, 142);
            this.pbLogo.TabIndex = 16;
            this.pbLogo.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(3, 306);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(283, 134);
            this.textBox1.TabIndex = 17;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // RouletteForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(759, 445);
            this.Controls.Add(this.pbBulletHeader);
            this.Controls.Add(this.lblLuck);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnExitRoulette);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.lblPlayerName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pbPlayer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbOpponent);
            this.Controls.Add(this.pbGun);
            this.Controls.Add(this.btnShootSelf);
            this.Controls.Add(this.btnShootOpponent);
            this.Controls.Add(this.btnSpinChamber);
            this.Controls.Add(this.pbOpponent);
            this.Controls.Add(this.pbLogo);
            this.Controls.Add(this.textBox1);
            this.Name = "RouletteForm";
            this.Text = "gbhdjk";
            this.Load += new System.EventHandler(this.RouletteForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbOpponent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbGun)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBulletHeader)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSpinChamber;
        private System.Windows.Forms.Button btnShootOpponent;
        private System.Windows.Forms.Button btnShootSelf;
        private System.Windows.Forms.PictureBox pbOpponent;
        private System.Windows.Forms.PictureBox pbGun;
        private System.Windows.Forms.ComboBox cmbOpponent;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPlayerName;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnExitRoulette;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label lblLuck;
        private System.Windows.Forms.PictureBox pbBulletHeader;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.TextBox textBox1;
    }
}