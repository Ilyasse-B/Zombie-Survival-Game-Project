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

namespace Zombie_Survival
{
    public partial class frmMenu : Form
    {
        private string labelText;
        
        public frmMenu(string text, bool first)
        {
            InitializeComponent();
            labelText = text;
            if (first == true)
            {
                lblScore.Hide();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            frmGame newGame = new frmGame();
            this.Hide();
            newGame.ShowDialog();
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmMenu_Load(object sender, EventArgs e)
        {
            lblScore.Text = "Score: " + labelText;
        }
    }
}
