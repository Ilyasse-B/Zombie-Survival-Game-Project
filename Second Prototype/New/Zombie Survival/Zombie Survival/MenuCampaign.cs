using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Zombie_Survival
{
    public partial class frmMenuCampaign : Form
    {
        public SoundPlayer Music = new SoundPlayer(Zombie_Survival.Properties.Resources.Menu_Music);
        public frmMenuCampaign()
        {
            InitializeComponent();
        }

        private void btnLvlOne_Click(object sender, EventArgs e)
        {
            lvlOne newLvlOne = new lvlOne();
            this.Hide();
            Music.Stop();
            newLvlOne.ShowDialog();
            this.Close();
        }

        private void frmMenuCampaign_Load(object sender, EventArgs e)
        {
            Music.PlayLooping();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            frmMenu newMainMenu = new frmMenu("", false, false);
            this.Hide();
            Music.Stop();
            newMainMenu.ShowDialog();
            this.Close();
        }
    }
}
