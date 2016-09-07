using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Tom_Russian_Roulette_Assignment
{
    public partial class LoginForm : Form
    {
        public static string name;

        public LoginForm()
        {
            InitializeComponent();
        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            //Setting the Login screen Background
            pbLog.Image = Properties.Resources.Revolver_login_screen;
            pbLog.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogin2.Image = Properties.Resources.bullets;
            pbLogin2.SizeMode = PictureBoxSizeMode.Zoom;

            lblTitle.Parent = pbLog;
            lblTitle.BackColor = Color.Transparent;
            this.Text = Properties.Resources.LoginForm;
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //ensures the text box cannot be left blank, As it automatically applies the name Anonymous if there is no user input 
            if (txtName.Text != "")
            {
                RouletteForm FormRoulette = new RouletteForm(txtName.Text);
                name = txtName.Text; this.Hide();
                FormRoulette.ShowDialog();
            }
            else
            {
                name = "Anonymous";
                MessageBox.Show("Welcome: " + name);
                RouletteForm FormRoulette = new RouletteForm(name);
                this.Hide();
                FormRoulette.ShowDialog();
            }
        }

        private void btnScore_Click(object sender, EventArgs e)
        {

            HighScoreForm FormHigh = new HighScoreForm();
            FormHigh.ShowDialog();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}

