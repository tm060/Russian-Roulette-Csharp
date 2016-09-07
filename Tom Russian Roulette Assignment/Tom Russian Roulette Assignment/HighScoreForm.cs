using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Tom_Russian_Roulette_Assignment
{
    public partial class HighScoreForm : Form
    {
        string path;
        public HighScoreForm()
        {
            InitializeComponent();
        }

        private void HighScoreForm_Load(object sender, EventArgs e)
        {
            path = "S:\\Software\\Submissions\\Tom McKay\\Highscores.txt";

            //Reading HighScores From a txt File and splitting Data Accordingly
            try
            {
                using (StreamReader Highreader = new StreamReader(path))

                {
                    String Line;
                    while ((Line = Highreader.ReadLine()) != null)
                    {
                        String[] RouletteScore = Line.Split(',');
                        dgPlayerScore.Rows.Add(RouletteScore[0], Convert.ToInt16(RouletteScore[1]), RouletteScore[2], RouletteScore[3]);
                    }
                }
                dgPlayerScore.Sort(dgPlayerScore.Columns[1], ListSortDirection.Descending);

            }
            catch (Exception exread)
            {
                MessageBox.Show("FileCouldnt Read" + exread.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
