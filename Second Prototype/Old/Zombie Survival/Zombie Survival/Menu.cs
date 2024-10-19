using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Media;

namespace Zombie_Survival
{
    public partial class frmMenu : Form
    {
        private string labelText;
        private bool paused;
        public SoundPlayer Music = new SoundPlayer(Zombie_Survival.Properties.Resources.Menu_Music);

        public frmMenu(string text, bool first, bool pause)
        {
            InitializeComponent();
            labelText = text;
            if (first == true)
            {
                lblScore.Hide();
            }
            if (pause == true)
            {
                paused = true;
                btnStart.Text = "Resume";
                btnCampaign.Hide();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (paused == true)
            {
                Music.Stop();
                this.Hide();
                this.Close();
            }
            else
            {
                Music.Stop();
                frmGame newGame = new frmGame();
                this.Hide();
                newGame.ShowDialog();
                this.Close();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + labelText;
            Music.PlayLooping();
        }

        private void btnCampaign_Click(object sender, EventArgs e)
        {
            Music.Stop();
            lvlOne newGame = new lvlOne();
            this.Hide();
            newGame.ShowDialog();
            this.Close();
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {

        }
    }
}
