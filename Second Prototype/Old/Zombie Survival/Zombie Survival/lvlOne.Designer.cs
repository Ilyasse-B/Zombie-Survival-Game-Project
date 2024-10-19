namespace Zombie_Survival
{
    partial class lvlOne
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
            this.lblEnterToStart = new System.Windows.Forms.Label();
            this.pboLabelKills = new System.Windows.Forms.PictureBox();
            this.pboLabelAmmo = new System.Windows.Forms.PictureBox();
            this.pboLabelHealth = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.prgHealthBar = new System.Windows.Forms.ProgressBar();
            this.lblHealth = new System.Windows.Forms.Label();
            this.lblKills = new System.Windows.Forms.Label();
            this.lblAmmo = new System.Windows.Forms.Label();
            this.pboPlayer = new System.Windows.Forms.PictureBox();
            this.tmrGameTimer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pboLabelKills)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLabelAmmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLabelHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEnterToStart
            // 
            this.lblEnterToStart.AutoSize = true;
            this.lblEnterToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterToStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnterToStart.Location = new System.Drawing.Point(361, 199);
            this.lblEnterToStart.Name = "lblEnterToStart";
            this.lblEnterToStart.Size = new System.Drawing.Size(245, 25);
            this.lblEnterToStart.TabIndex = 7;
            this.lblEnterToStart.Text = "Click ENTER ↵ to start";
            this.lblEnterToStart.Click += new System.EventHandler(this.lblEnterToStart_Click);
            // 
            // pboLabelKills
            // 
            this.pboLabelKills.Image = global::Zombie_Survival.Properties.Resources.skull;
            this.pboLabelKills.Location = new System.Drawing.Point(647, 16);
            this.pboLabelKills.Name = "pboLabelKills";
            this.pboLabelKills.Size = new System.Drawing.Size(30, 34);
            this.pboLabelKills.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboLabelKills.TabIndex = 17;
            this.pboLabelKills.TabStop = false;
            // 
            // pboLabelAmmo
            // 
            this.pboLabelAmmo.Image = global::Zombie_Survival.Properties.Resources.ammo_label;
            this.pboLabelAmmo.Location = new System.Drawing.Point(456, 17);
            this.pboLabelAmmo.Name = "pboLabelAmmo";
            this.pboLabelAmmo.Size = new System.Drawing.Size(44, 33);
            this.pboLabelAmmo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboLabelAmmo.TabIndex = 16;
            this.pboLabelAmmo.TabStop = false;
            // 
            // pboLabelHealth
            // 
            this.pboLabelHealth.Image = global::Zombie_Survival.Properties.Resources.health_label;
            this.pboLabelHealth.Location = new System.Drawing.Point(222, 9);
            this.pboLabelHealth.Name = "pboLabelHealth";
            this.pboLabelHealth.Size = new System.Drawing.Size(58, 24);
            this.pboLabelHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboLabelHealth.TabIndex = 15;
            this.pboLabelHealth.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 14;
            this.label1.Text = "[ESC] - PAUSE";
            // 
            // prgHealthBar
            // 
            this.prgHealthBar.Location = new System.Drawing.Point(151, 36);
            this.prgHealthBar.Name = "prgHealthBar";
            this.prgHealthBar.Size = new System.Drawing.Size(280, 23);
            this.prgHealthBar.TabIndex = 13;
            this.prgHealthBar.Value = 100;
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.IndianRed;
            this.lblHealth.Location = new System.Drawing.Point(278, 9);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(76, 24);
            this.lblHealth.TabIndex = 12;
            this.lblHealth.Text = "Health:";
            // 
            // lblKills
            // 
            this.lblKills.AutoSize = true;
            this.lblKills.BackColor = System.Drawing.Color.Transparent;
            this.lblKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblKills.Location = new System.Drawing.Point(683, 18);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(71, 24);
            this.lblKills.TabIndex = 11;
            this.lblKills.Text = "Kills: 0";
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.BackColor = System.Drawing.Color.Transparent;
            this.lblAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAmmo.Location = new System.Drawing.Point(499, 18);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(93, 24);
            this.lblAmmo.TabIndex = 10;
            this.lblAmmo.Text = "Ammo: 0";
            // 
            // pboPlayer
            // 
            this.pboPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pboPlayer.Image = global::Zombie_Survival.Properties.Resources.up;
            this.pboPlayer.Location = new System.Drawing.Point(440, 317);
            this.pboPlayer.Name = "pboPlayer";
            this.pboPlayer.Size = new System.Drawing.Size(71, 100);
            this.pboPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboPlayer.TabIndex = 18;
            this.pboPlayer.TabStop = false;
            this.pboPlayer.WaitOnLoad = true;
            this.pboPlayer.Click += new System.EventHandler(this.pboPlayer_Click);
            // 
            // tmrGameTimer1
            // 
            this.tmrGameTimer1.Enabled = true;
            this.tmrGameTimer1.Interval = 20;
            this.tmrGameTimer1.Tick += new System.EventHandler(this.tmrGameTimer1_Tick);
            // 
            // lvlOne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.ClientSize = new System.Drawing.Size(923, 666);
            this.Controls.Add(this.pboPlayer);
            this.Controls.Add(this.pboLabelKills);
            this.Controls.Add(this.pboLabelAmmo);
            this.Controls.Add(this.pboLabelHealth);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgHealthBar);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblKills);
            this.Controls.Add(this.lblAmmo);
            this.Controls.Add(this.lblEnterToStart);
            this.Name = "lvlOne";
            this.Text = "Level One";
            this.Load += new System.EventHandler(this.lvlOne_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lvlOne_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.lvlOne_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pboLabelKills)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLabelAmmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLabelHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboPlayer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblEnterToStart;
        private System.Windows.Forms.PictureBox pboLabelKills;
        private System.Windows.Forms.PictureBox pboLabelAmmo;
        private System.Windows.Forms.PictureBox pboLabelHealth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ProgressBar prgHealthBar;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.Label lblKills;
        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.PictureBox pboPlayer;
        private System.Windows.Forms.Timer tmrGameTimer1;
    }
}