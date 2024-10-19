
namespace Zombie_Survival
{
    partial class frmGame
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
            this.lblAmmo = new System.Windows.Forms.Label();
            this.lblKills = new System.Windows.Forms.Label();
            this.lblHealth = new System.Windows.Forms.Label();
            this.tmrGameTimer = new System.Windows.Forms.Timer(this.components);
            this.prgHealthBar = new System.Windows.Forms.ProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.pboPlayer = new System.Windows.Forms.PictureBox();
            this.pboLabelHealth = new System.Windows.Forms.PictureBox();
            this.pboLabelAmmo = new System.Windows.Forms.PictureBox();
            this.pboLabelKills = new System.Windows.Forms.PictureBox();
            this.lblEnterToStart = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pboPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLabelHealth)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLabelAmmo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLabelKills)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAmmo
            // 
            this.lblAmmo.AutoSize = true;
            this.lblAmmo.BackColor = System.Drawing.Color.Transparent;
            this.lblAmmo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmmo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblAmmo.Location = new System.Drawing.Point(507, 22);
            this.lblAmmo.Name = "lblAmmo";
            this.lblAmmo.Size = new System.Drawing.Size(93, 24);
            this.lblAmmo.TabIndex = 0;
            this.lblAmmo.Text = "Ammo: 0";
            // 
            // lblKills
            // 
            this.lblKills.AutoSize = true;
            this.lblKills.BackColor = System.Drawing.Color.Transparent;
            this.lblKills.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKills.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.lblKills.Location = new System.Drawing.Point(686, 22);
            this.lblKills.Name = "lblKills";
            this.lblKills.Size = new System.Drawing.Size(71, 24);
            this.lblKills.TabIndex = 1;
            this.lblKills.Text = "Kills: 0";
            this.lblKills.Click += new System.EventHandler(this.lblKills_Click);
            // 
            // lblHealth
            // 
            this.lblHealth.AutoSize = true;
            this.lblHealth.BackColor = System.Drawing.Color.Transparent;
            this.lblHealth.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHealth.ForeColor = System.Drawing.Color.IndianRed;
            this.lblHealth.Location = new System.Drawing.Point(275, 7);
            this.lblHealth.Name = "lblHealth";
            this.lblHealth.Size = new System.Drawing.Size(76, 24);
            this.lblHealth.TabIndex = 2;
            this.lblHealth.Text = "Health:";
            // 
            // tmrGameTimer
            // 
            this.tmrGameTimer.Enabled = true;
            this.tmrGameTimer.Interval = 14;
            this.tmrGameTimer.Tick += new System.EventHandler(this.GameLoopEvent);
            // 
            // prgHealthBar
            // 
            this.prgHealthBar.Location = new System.Drawing.Point(148, 33);
            this.prgHealthBar.Name = "prgHealthBar";
            this.prgHealthBar.Size = new System.Drawing.Size(280, 23);
            this.prgHealthBar.TabIndex = 4;
            this.prgHealthBar.Value = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(3, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "[ESC] - PAUSE\r\n\r\n";
            // 
            // pboPlayer
            // 
            this.pboPlayer.BackColor = System.Drawing.Color.Transparent;
            this.pboPlayer.Image = global::Zombie_Survival.Properties.Resources.up;
            this.pboPlayer.Location = new System.Drawing.Point(437, 334);
            this.pboPlayer.Name = "pboPlayer";
            this.pboPlayer.Size = new System.Drawing.Size(71, 100);
            this.pboPlayer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pboPlayer.TabIndex = 3;
            this.pboPlayer.TabStop = false;
            this.pboPlayer.WaitOnLoad = true;
            this.pboPlayer.Click += new System.EventHandler(this.pboPlayer_Click);
            // 
            // pboLabelHealth
            // 
            this.pboLabelHealth.Image = global::Zombie_Survival.Properties.Resources.health_label;
            this.pboLabelHealth.Location = new System.Drawing.Point(219, 7);
            this.pboLabelHealth.Name = "pboLabelHealth";
            this.pboLabelHealth.Size = new System.Drawing.Size(58, 24);
            this.pboLabelHealth.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboLabelHealth.TabIndex = 7;
            this.pboLabelHealth.TabStop = false;
            // 
            // pboLabelAmmo
            // 
            this.pboLabelAmmo.Image = global::Zombie_Survival.Properties.Resources.ammo_label;
            this.pboLabelAmmo.Location = new System.Drawing.Point(464, 21);
            this.pboLabelAmmo.Name = "pboLabelAmmo";
            this.pboLabelAmmo.Size = new System.Drawing.Size(44, 33);
            this.pboLabelAmmo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboLabelAmmo.TabIndex = 8;
            this.pboLabelAmmo.TabStop = false;
            // 
            // pboLabelKills
            // 
            this.pboLabelKills.Image = global::Zombie_Survival.Properties.Resources.skull;
            this.pboLabelKills.Location = new System.Drawing.Point(650, 20);
            this.pboLabelKills.Name = "pboLabelKills";
            this.pboLabelKills.Size = new System.Drawing.Size(30, 34);
            this.pboLabelKills.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pboLabelKills.TabIndex = 9;
            this.pboLabelKills.TabStop = false;
            // 
            // lblEnterToStart
            // 
            this.lblEnterToStart.AutoSize = true;
            this.lblEnterToStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterToStart.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblEnterToStart.Location = new System.Drawing.Point(355, 228);
            this.lblEnterToStart.Name = "lblEnterToStart";
            this.lblEnterToStart.Size = new System.Drawing.Size(245, 25);
            this.lblEnterToStart.TabIndex = 6;
            this.lblEnterToStart.Text = "Click ENTER ↵ to start";
            // 
            // frmGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(66)))), ((int)(((byte)(66)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(923, 666);
            this.Controls.Add(this.pboLabelKills);
            this.Controls.Add(this.pboLabelAmmo);
            this.Controls.Add(this.pboLabelHealth);
            this.Controls.Add(this.lblEnterToStart);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prgHealthBar);
            this.Controls.Add(this.pboPlayer);
            this.Controls.Add(this.lblHealth);
            this.Controls.Add(this.lblKills);
            this.Controls.Add(this.lblAmmo);
            this.Name = "frmGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Zombie Survival Game";
            this.Load += new System.EventHandler(this.frmGame_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            this.Resize += new System.EventHandler(this.frmGame_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.pboPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLabelHealth)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLabelAmmo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pboLabelKills)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAmmo;
        private System.Windows.Forms.Label lblKills;
        private System.Windows.Forms.Label lblHealth;
        private System.Windows.Forms.PictureBox pboPlayer;
        private System.Windows.Forms.Timer tmrGameTimer;
        private System.Windows.Forms.ProgressBar prgHealthBar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pboLabelHealth;
        private System.Windows.Forms.PictureBox pboLabelAmmo;
        private System.Windows.Forms.PictureBox pboLabelKills;
        private System.Windows.Forms.Label lblEnterToStart;
    }
}

