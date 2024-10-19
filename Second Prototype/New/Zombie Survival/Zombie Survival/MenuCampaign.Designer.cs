
namespace Zombie_Survival
{
    partial class frmMenuCampaign
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
            this.lblTitleCampaign = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnLvlOne = new System.Windows.Forms.Button();
            this.btnLvlTwo = new System.Windows.Forms.Button();
            this.btnLvlThree = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitleCampaign
            // 
            this.lblTitleCampaign.AutoSize = true;
            this.lblTitleCampaign.BackColor = System.Drawing.Color.Transparent;
            this.lblTitleCampaign.Font = new System.Drawing.Font("Cooper Black", 27.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleCampaign.ForeColor = System.Drawing.Color.DarkRed;
            this.lblTitleCampaign.Location = new System.Drawing.Point(21, 9);
            this.lblTitleCampaign.Name = "lblTitleCampaign";
            this.lblTitleCampaign.Size = new System.Drawing.Size(267, 42);
            this.lblTitleCampaign.TabIndex = 6;
            this.lblTitleCampaign.Text = "Select a level:";
            // 
            // btnReturn
            // 
            this.btnReturn.BackColor = System.Drawing.Color.Ivory;
            this.btnReturn.BackgroundImage = global::Zombie_Survival.Properties.Resources.btnReturn;
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReturn.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(44, 313);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(217, 77);
            this.btnReturn.TabIndex = 7;
            this.btnReturn.UseVisualStyleBackColor = false;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnLvlOne
            // 
            this.btnLvlOne.BackColor = System.Drawing.Color.Ivory;
            this.btnLvlOne.BackgroundImage = global::Zombie_Survival.Properties.Resources.btnLvlOne;
            this.btnLvlOne.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLvlOne.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvlOne.Location = new System.Drawing.Point(44, 64);
            this.btnLvlOne.Name = "btnLvlOne";
            this.btnLvlOne.Size = new System.Drawing.Size(217, 77);
            this.btnLvlOne.TabIndex = 8;
            this.btnLvlOne.UseVisualStyleBackColor = false;
            this.btnLvlOne.Click += new System.EventHandler(this.btnLvlOne_Click);
            // 
            // btnLvlTwo
            // 
            this.btnLvlTwo.BackColor = System.Drawing.Color.Ivory;
            this.btnLvlTwo.BackgroundImage = global::Zombie_Survival.Properties.Resources.btnLvlTwo;
            this.btnLvlTwo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLvlTwo.Enabled = false;
            this.btnLvlTwo.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvlTwo.Location = new System.Drawing.Point(44, 147);
            this.btnLvlTwo.Name = "btnLvlTwo";
            this.btnLvlTwo.Size = new System.Drawing.Size(217, 77);
            this.btnLvlTwo.TabIndex = 9;
            this.btnLvlTwo.UseVisualStyleBackColor = false;
            // 
            // btnLvlThree
            // 
            this.btnLvlThree.BackColor = System.Drawing.Color.Ivory;
            this.btnLvlThree.BackgroundImage = global::Zombie_Survival.Properties.Resources.btnLvlThree;
            this.btnLvlThree.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLvlThree.Enabled = false;
            this.btnLvlThree.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLvlThree.Location = new System.Drawing.Point(44, 230);
            this.btnLvlThree.Name = "btnLvlThree";
            this.btnLvlThree.Size = new System.Drawing.Size(217, 77);
            this.btnLvlThree.TabIndex = 10;
            this.btnLvlThree.UseVisualStyleBackColor = false;
            // 
            // frmMenuCampaign
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 396);
            this.Controls.Add(this.btnLvlThree);
            this.Controls.Add(this.btnLvlTwo);
            this.Controls.Add(this.btnLvlOne);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.lblTitleCampaign);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.Name = "frmMenuCampaign";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Campaign Menu";
            this.Load += new System.EventHandler(this.frmMenuCampaign_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitleCampaign;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnLvlOne;
        private System.Windows.Forms.Button btnLvlTwo;
        private System.Windows.Forms.Button btnLvlThree;
    }
}