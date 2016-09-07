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
using System.Media;

namespace Tom_Russian_Roulette_Assignment
{
    public partial class RouletteForm : Form
    {
        Random rdmChamber = new Random();
        int Result;
        int FireCount = 1;
        int ShootOpponentCount = 1;
        int ShootOpponentTotal = 2;
        int Score = 0;
        int wins = 0;
        int loses = 0;
        int ChamberLoad = 0;
        string path;

        public RouletteForm()
        {
            InitializeComponent();
        }

        public RouletteForm(string txtName)
        {
            InitializeComponent();
            lblPlayerName.Text = txtName;
        }
        
        private void RouletteForm_Load(object sender, EventArgs e)
        {
            //Loading Combo Box Names

            cmbOpponent.Items.Add("Kurt");
            cmbOpponent.Items.Add("Kanye");
            cmbOpponent.Items.Add("Drake");
            cmbOpponent.Items.Add("Ghostface");
            cmbOpponent.Items.Add("Miley");
            cmbOpponent.Items.Add("Joker");
            cmbOpponent.Items.Add("Adolf");
            cmbOpponent.Items.Add("Lil Wayne");

            // Loading Default images and default Combo Box Setting
            cmbOpponent.SelectedIndex = 0;
            pbPlayer.Image = Properties.Resources.Batman;
            pbOpponent.SizeMode = PictureBoxSizeMode.Zoom;
            
            btnShootSelf.Enabled = false;
            btnShootOpponent.Enabled = false;

            pbBulletHeader.Image = Properties.Resources.bullet_roulette_form;
            pbBulletHeader.SizeMode = PictureBoxSizeMode.Zoom;
            pbLogo.Image = Properties.Resources.side_pic;
            pbLogo.SizeMode = PictureBoxSizeMode.Zoom;
        }

        private void cmbOponent_SelectedIndexChanged(object sender, EventArgs e)
        {
           // Selects oponent on click of oponent name and Loads Image of Oponent

            if (cmbOpponent.SelectedItem.Equals("Kurt"))
            {
                pbOpponent.Image = Properties.Resources.Kurt;
                pbOpponent.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (cmbOpponent.SelectedItem.Equals("Kanye"))
            {
                pbOpponent.Image = Properties.Resources.kanye;
                pbOpponent.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (cmbOpponent.SelectedItem.Equals("Miley"))
            {
                pbOpponent.Image = Properties.Resources.miley;
                pbOpponent.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (cmbOpponent.SelectedItem.Equals("Drake"))
            {
                pbOpponent.Image = Properties.Resources.Drake;
                pbOpponent.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (cmbOpponent.SelectedItem.Equals("Ghostface"))
            {
                pbOpponent.Image = Properties.Resources.Ghostface;
                pbOpponent.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (cmbOpponent.SelectedItem.Equals("Joker"))
            {
                pbOpponent.Image = Properties.Resources.Joker;
                pbOpponent.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (cmbOpponent.SelectedItem.Equals("Adolf"))
            {
                pbOpponent.Image = Properties.Resources.Adolf;
                pbOpponent.SizeMode = PictureBoxSizeMode.Zoom;
            }
            else if (cmbOpponent.SelectedItem.Equals("Lil Wayne"))
            {
                pbOpponent.Image = Properties.Resources.Lil_wayne;
                pbOpponent.SizeMode = PictureBoxSizeMode.Zoom;
            }
          
        }

        private void btnSpinChamber_Click(object sender, EventArgs e)
        {
            //Generates the random number (Bullet in chamber)
            Result = rdmChamber.Next(1, 7);
            ShootOpponentCount = 1;
            FireCount = 1;

            timer1.Start();
            pbGun.Image = Properties.Resources.tumblr_mfau84YnIR1qdch9co1_500;
            pbGun.SizeMode = PictureBoxSizeMode.Zoom;
            btnSpinChamber.Enabled = false;
        }

        private void btnBiteBullet_Click(object sender, EventArgs e)
        {
            pbGun.Image = Properties.Resources.Revolver_Facing_right;
            pbGun.SizeMode = PictureBoxSizeMode.Zoom;


            if (FireCount < Result)
            {
                Stream str = Properties.Resources.Dry_Fire_Gun_SoundBible_com_2053652037;
                SoundPlayer snd = new SoundPlayer(str);
                snd.Play();

                lblLuck.Text = "You got Lucky";
                FireCount++;
                Score = Score + 15;
                lblScore.Text = "Score: " + Convert.ToString(Score);
            }
            else
            {
                if (Result == FireCount)
                {
                    Stream str = Properties.Resources.wpn_pistol_44magnum_fire_2d;
                    SoundPlayer snd = new SoundPlayer(str);
                    snd.Play();

                    MessageBox.Show("||| YOU LOSE |||");
                    lblLuck.Text = "You Shot Yourself";
                    MessageBox.Show("Final Score: " + Convert.ToString(Score));
                    loses++;
                    btnShootSelf.Enabled = false;
                    btnShootOpponent.Enabled = false;
                    btnSpinChamber.Enabled = true;
                  
                    //Writes To High Score File
                    try
                    {
                        path = "S:\\Software\\Submissions\\Tom McKay\\Highscores.txt";
                  
                        using (StreamWriter swriter = File.AppendText(path))
                        {
                          swriter.WriteLine(lblPlayerName.Text+","+ Score + "," + wins + "," + loses,"\n");                        
                        }
                        
                    }
                    catch (Exception exWrite)
                    {
                        MessageBox.Show("The file Could Not Be Writen");
                        MessageBox.Show(exWrite.Message);
                    }
                    Score = 0;
                    wins = 0;
                    loses = 0;
                }
            }
        }

        private void btnFireOponent_Click(object sender, EventArgs e)
        {
            pbGun.Image = Properties.Resources.Revolver_Facing_Left;
            pbGun.SizeMode = PictureBoxSizeMode.Zoom;

            if (FireCount < Result)
            //Plays dry Gunshot sound when Opponent Gets Shot
            {
                Stream str = Properties.Resources.Dry_Fire_Gun_SoundBible_com_2053652037;
                SoundPlayer snd = new SoundPlayer(str);
                snd.Play();

                lblLuck.Text = "Your Oponent Got Lucky";
                FireCount++;
            }
            else
            {
                if (Result == FireCount)
                    //Plays Gunshot sound when Opponent Gets Shot
                {
                    Stream str = Properties.Resources.wpn_pistol_44magnum_fire_2d;
                    SoundPlayer snd = new SoundPlayer(str);
                    snd.Play();

                    MessageBox.Show("||| YOU WIN THE ROUND |||");
                    lblLuck.Text = "You Shot " + cmbOpponent.SelectedItem;
                    //disables shoot buttons so they cannot continue without spinning the chamber again
                    btnShootSelf.Enabled = false;
                    btnShootOpponent.Enabled = false;
                    //adds score for every time you kill opponent & one win
                    Score = Score + 100;
                    wins++;
                    lblScore.Text = "Score: " + Convert.ToString(Score);
                    btnSpinChamber.Enabled = true;
                }
            }

            //Shoot Away Chances.

            if (ShootOpponentCount < ShootOpponentTotal)
            {
                ShootOpponentCount++;
            }
            else if (ShootOpponentCount == ShootOpponentTotal)
            {
                btnShootOpponent.Enabled = false;
                MessageBox.Show("You Have Used Your Chanes To Shoot Opponent");
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ChamberLoad += 1000;
            // Plays chamber spinning Sound at 1second 
            if (ChamberLoad == 1000)
            {
                Stream str = Properties.Resources.wpn_pistol44magnum_jam;
                SoundPlayer snd = new SoundPlayer(str);
                snd.Play();
            }
            //changes image after timer reaches 3seconds
            if (ChamberLoad == 3000)
            {
                btnShootSelf.Enabled = true;
                btnShootOpponent.Enabled = true;
                pbGun.Image = Properties.Resources.Revolver_Facing_right;
                pbGun.SizeMode = PictureBoxSizeMode.Zoom;
                timer1.Stop();
                ChamberLoad = 0;
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {   
            LoginForm FormLog1 = new LoginForm();
            this.Hide();
            FormLog1.ShowDialog();
        }

        private void btnExitRoulette_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
