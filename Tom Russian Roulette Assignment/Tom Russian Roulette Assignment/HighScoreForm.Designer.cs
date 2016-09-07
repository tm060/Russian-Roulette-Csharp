namespace Tom_Russian_Roulette_Assignment
{
    partial class HighScoreForm
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
            this.dgPlayerScore = new System.Windows.Forms.DataGridView();
            this.PlayerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PlayerScore = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Win = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lose = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayerScore)).BeginInit();
            this.SuspendLayout();
            // 
            // dgPlayerScore
            // 
            this.dgPlayerScore.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgPlayerScore.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.PlayerName,
            this.PlayerScore,
            this.Win,
            this.lose});
            this.dgPlayerScore.Location = new System.Drawing.Point(1, 3);
            this.dgPlayerScore.Name = "dgPlayerScore";
            this.dgPlayerScore.Size = new System.Drawing.Size(440, 185);
            this.dgPlayerScore.TabIndex = 0;
            // 
            // PlayerName
            // 
            this.PlayerName.HeaderText = "Name";
            this.PlayerName.Name = "PlayerName";
            this.PlayerName.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // PlayerScore
            // 
            this.PlayerScore.HeaderText = "Score";
            this.PlayerScore.Name = "PlayerScore";
            this.PlayerScore.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            // 
            // Win
            // 
            this.Win.HeaderText = "Wins";
            this.Win.Name = "Win";
            this.Win.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // lose
            // 
            this.lose.HeaderText = "Loses";
            this.lose.Name = "lose";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(149, 195);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(148, 29);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Go Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // HighScoreForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(441, 236);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.dgPlayerScore);
            this.Name = "HighScoreForm";
            this.Text = "HighScoreForm";
            this.Load += new System.EventHandler(this.HighScoreForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgPlayerScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgPlayerScore;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PlayerScore;
        private System.Windows.Forms.DataGridViewTextBoxColumn Win;
        private System.Windows.Forms.DataGridViewTextBoxColumn lose;
    }
}