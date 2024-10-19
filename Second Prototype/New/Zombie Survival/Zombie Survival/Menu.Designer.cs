
namespace Zombie_Survival
{
    partial class frmMenu
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
            this.btnStart = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblScore = new System.Windows.Forms.Label();
            this.btnCampaign = new System.Windows.Forms.Button();
            this.lblGameTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnStart
            // 
            this.btnStart.BackColor = System.Drawing.Color.Ivory;
            this.btnStart.BackgroundImage = global::Zombie_Survival.Properties.Resources.btnSurvival;
            this.btnStart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStart.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(12, 12);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(217, 77);
            this.btnStart.TabIndex = 0;
            this.btnStart.UseVisualStyleBackColor = false;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Ivory;
            this.btnExit.BackgroundImage = global::Zombie_Survival.Properties.Resources.btnExit;
            this.btnExit.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExit.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(12, 208);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(217, 77);
            this.btnExit.TabIndex = 1;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Algerian", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(274, 208);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 54);
            this.label1.TabIndex = 2;
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.BackColor = System.Drawing.Color.Transparent;
            this.lblScore.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScore.ForeColor = System.Drawing.Color.SteelBlue;
            this.lblScore.Location = new System.Drawing.Point(254, 205);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(183, 67);
            this.lblScore.TabIndex = 3;
            this.lblScore.Text = "Score:";
            // 
            // btnCampaign
            // 
            this.btnCampaign.BackColor = System.Drawing.Color.Ivory;
            this.btnCampaign.BackgroundImage = global::Zombie_Survival.Properties.Resources.btnCampaign;
            this.btnCampaign.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCampaign.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCampaign.Location = new System.Drawing.Point(12, 108);
            this.btnCampaign.Name = "btnCampaign";
            this.btnCampaign.Size = new System.Drawing.Size(217, 76);
            this.btnCampaign.TabIndex = 4;
            this.btnCampaign.UseVisualStyleBackColor = false;
            this.btnCampaign.Click += new System.EventHandler(this.btnCampaign_Click);
            // 
            // lblGameTitle
            // 
            this.lblGameTitle.AutoSize = true;
            this.lblGameTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblGameTitle.Font = new System.Drawing.Font("Cooper Black", 48F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGameTitle.ForeColor = System.Drawing.Color.DarkRed;
            this.lblGameTitle.Location = new System.Drawing.Point(253, 28);
            this.lblGameTitle.Name = "lblGameTitle";
            this.lblGameTitle.Size = new System.Drawing.Size(312, 148);
            this.lblGameTitle.TabIndex = 5;
            this.lblGameTitle.Text = "Zombie\r\nSurvival";
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(577, 294);
            this.Controls.Add(this.lblGameTitle);
            this.Controls.Add(this.btnCampaign);
            this.Controls.Add(this.lblScore);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnStart);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Menu";
            this.Load += new System.EventHandler(this.frmMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Button btnCampaign;
        private System.Windows.Forms.Label lblGameTitle;
    }
}