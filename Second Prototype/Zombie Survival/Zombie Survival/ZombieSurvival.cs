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
    public partial class frmGame : Form
    {
        //creates variables/attributes
        bool goUp, goDown, goLeft, goRight;
        bool gameOver = false;
        string facing = "up"; //used to guide bullets
        double playerHealth = 100;
        int playerSpeed = 10, ammo = 10, zombieSpeed = 4, score = 0;
        //variables for resizing controls when going fullscreen
        private Rectangle frmGameOriginal, lblKillsOriginal, lblHealthOriginal, lblAmmoOriginal,
            prgHealthOriginal, pboPlayerOriginal, lblEnterToStartOriginal, pboLabelAmmoOriginal,
            pboLabelKillsOriginal, pboLabelHealthOriginal;

        //Random variable used for spawning pickups
        Random rnd = new Random();

        private void frmGame_Resize(object sender, EventArgs e)
        {
            resizeControl(lblEnterToStartOriginal, lblEnterToStart);
            resizeControl(lblKillsOriginal, lblKills);
            resizeControl(lblHealthOriginal, lblHealth);   //This procedure will resize all of the controls on the screen
            resizeControl(lblAmmoOriginal, lblAmmo);          //when the user changes the size of the window
            resizeControl(prgHealthOriginal, prgHealthBar);
            resizeControl(pboPlayerOriginal, pboPlayer);
            resizeControl(pboLabelAmmoOriginal, pboLabelAmmo);
            resizeControl(pboLabelHealthOriginal, pboLabelHealth);
            resizeControl(pboLabelKillsOriginal, pboLabelKills); 
        }

        private void pboPlayer_Click(object sender, EventArgs e)
        {

        }

        private void resizeControl(Rectangle r, Control c)
        {
            float xRatio = (float)(this.Width) / (float)(frmGameOriginal.Width);
            float yRatio = (float)(this.Height) / (float)(frmGameOriginal.Height); //This gets the ratio of control sizes
                                                                                    //so that they can be expanded correctly
            int newX = (int)(r.Location.X * xRatio);
            int NewY = (int)(r.Location.Y * yRatio);

            int newWidth = (int)(r.Width * xRatio);
            int newHeight = (int)(r.Height * yRatio); //sets their new widths and location, using the the ratio

            c.Location = new Point(newX, NewY);
            c.Size = new Size(newWidth, newHeight); //completes the process
        }

        private void frmGame_Load(object sender, EventArgs e)
        {
            lblEnterToStartOriginal = new Rectangle(lblEnterToStart.Location.X, lblEnterToStart.Location.Y, lblEnterToStart.Width, lblEnterToStart.Height);
            frmGameOriginal = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height); ;
            lblKillsOriginal = new Rectangle(lblKills.Location.X, lblKills.Location.Y, lblKills.Width, lblKills.Height);
            lblHealthOriginal = new Rectangle(lblHealth.Location.X, lblHealth.Location.Y, lblHealth.Width, lblHealth.Height);
            lblAmmoOriginal = new Rectangle(lblAmmo.Location.X, lblAmmo.Location.Y, lblAmmo.Width, lblAmmo.Height);
            pboPlayerOriginal = new Rectangle(pboPlayer.Location.X, pboPlayer.Location.Y, pboPlayer.Width, pboPlayer.Height);
            prgHealthOriginal = new Rectangle(prgHealthBar.Location.X, prgHealthBar.Location.Y, prgHealthBar.Width, prgHealthBar.Height);
            pboLabelAmmoOriginal = new Rectangle(pboLabelAmmo.Location.X, pboLabelAmmo.Location.Y, pboLabelAmmo.Width, pboLabelAmmo.Height);
            pboLabelHealthOriginal = new Rectangle(pboLabelHealth.Location.X, pboLabelHealth.Location.Y, pboLabelHealth.Width, pboLabelHealth.Height);
            pboLabelKillsOriginal = new Rectangle(pboLabelKills.Location.X, pboLabelKills.Location.Y, pboLabelKills.Width, pboLabelKills.Height);
            //all above are saving all the control sizes and locations so that they can be changed when user resizes window

            this.WindowState = FormWindowState.Maximized;
            gameOver = true; //stops game from running
            lblEnterToStart.Show(); //Shows informational label so user can start by clicking enter
            tmrGameTimer.Stop(); //stops the game from running too
        }

        private void lblKills_Click(object sender, EventArgs e)
        {

        }

        List<PictureBox> zombiesList = new List<PictureBox>();//List of zombies to be added/removed
        public frmGame()
        {
            InitializeComponent();
            RestartGame();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {//left
            if (gameOver == false)//makes sure cant move when dead
            {
                if (e.KeyCode == Keys.Left)
                {
                    goLeft = true;
                    facing = "left";
                    pboPlayer.Image = Properties.Resources.left;//changes player image to left one
                }
                //right
                if (e.KeyCode == Keys.Right)
                {
                    goRight = true;
                    facing = "right";
                    pboPlayer.Image = Properties.Resources.right;//changes player image to right one
                }
                //up
                if (e.KeyCode == Keys.Up)
                {
                    goUp = true;
                    facing = "up";
                    pboPlayer.Image = Properties.Resources.up;//changes player image to up one
                }
                //down
                if (e.KeyCode == Keys.Down)
                {
                    goDown = true;
                    facing = "down";
                    pboPlayer.Image = Properties.Resources.down;//changes player image to down one
                }
            }
            if (gameOver == true)
            {
                if (e.KeyCode == Keys.Enter)
                {
                    RestartGame();
                    lblEnterToStart.Hide();
                }
            }
        }

        private void CollisionDetect()
        {//loops through every control in the form
            foreach (Control x in this.Controls)
            {//if its a pbo and has the ammo tag
                if (x is PictureBox && x.Tag == "ammo")
                {//check if it is hitting player pbo
                    if (((PictureBox)x).Bounds.IntersectsWith(pboPlayer.Bounds))
                    {//when player picks it up, the pbo will be removed from program and add 5 to ammo
                        this.Controls.Remove((PictureBox)x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                        //Plays reloading sound
                        SoundPlayer Reload = new SoundPlayer(Zombie_Survival.Properties.Resources.Reload_Sound);
                        Reload.Play();
                    }
                }
                if ( x is PictureBox && x.Tag == "zombie")
                {//if hits a zombie
                    if (((PictureBox)x).Bounds.IntersectsWith(pboPlayer.Bounds))
                    {//decreases health by 0.25
                        playerHealth -= 0.25;
                    }
                }
                foreach (Control j in this.Controls)
                {//nested loop to differentiate zombie from player
                    if ((j is PictureBox && j.Tag == "bullet") && (x is PictureBox && x.Tag == "zombie"))
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {//if bullet hits zombie, increment score, remove bullet and zombie and add another zombie
                            score++;
                            this.Controls.Remove(j);
                            j.Dispose();
                            this.Controls.Remove(x);
                            x.Dispose();
                            makeZombies();
                        }
                    }
                }
            }
        }

        private void chasePlayer()
        {//method for zombies to chase the player around the screen
            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "zombie")
                {//moves zombie toward player pbo

                    if (((PictureBox)x).Left > pboPlayer.Left)
                    {
                        ((PictureBox)x).Left -= zombieSpeed; //moves toward left of player
                        ((PictureBox)x).Image = Properties.Resources.zleft;//make zombie face left
                    }
                    if (((PictureBox)x).Top > pboPlayer.Top)
                    {
                        ((PictureBox)x).Top -= zombieSpeed; //moves toward left of player
                        ((PictureBox)x).Image = Properties.Resources.zup;//make zombie face left
                    }
                    if (((PictureBox)x).Left < pboPlayer.Left)
                    {
                        ((PictureBox)x).Left += zombieSpeed; //moves toward left of player
                        ((PictureBox)x).Image = Properties.Resources.zright;//make zombie face left
                    }
                    if (((PictureBox)x).Top < pboPlayer.Top)
                    {
                        ((PictureBox)x).Top += zombieSpeed; //moves toward left of player
                        ((PictureBox)x).Image = Properties.Resources.zdown;//make zombie face left
                    }
                }
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            //left
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            //right
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            //up
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            //down
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            else
            {
                //pause game (1st)
                //closes game (2nd)
                if (e.KeyCode == Keys.Escape)
                {
                    tmrGameTimer.Stop();
                    frmMenu pauseMenu = new frmMenu(Convert.ToString(score), false, true); //score, first time?, pausing?
                    pauseMenu.ShowDialog();
                    tmrGameTimer.Start();
                    //this.Close();
                }
            }

            if (gameOver == false)//makes sure can't shoot when dead
            {
                //When space bar is released shoot a bullet
                if (e.KeyCode == Keys.Space && ammo > 0)//checks if not out of ammo
                {
                    SoundPlayer ShotSound = new SoundPlayer(Zombie_Survival.Properties.Resources.Shot_Sound);
                    ShotSound.Play();
                    ammo--;//decreases ammo
                           //Will shoot the bullet in the direction the player is facing
                    ShootBullet(facing);
                    if (ammo < 1)
                    {//when ammo is low an ammo box is dropped
                        DropAmmo();
                    }
                }
            }
        }

        private void DropAmmo()
        {//will create an image of ammo 
            PictureBox ammo = new PictureBox();//creates instance of pbo
            ammo.Image = Properties.Resources.ammo_Image;//ammo immage assigned to the pbo
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = rnd.Next(10, this.ClientSize.Width - ammo.Width);//sets x to random value
            ammo.Top = rnd.Next(80, this.ClientSize.Height - ammo.Height);//sets y to random value
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);//adds it to the screen
            ammo.BringToFront();
            pboPlayer.BringToFront();
        }

        private void makeZombies()
        {//when called it makes zombies
            PictureBox zombie = new PictureBox();
            zombie.Tag = "zombie";
            zombie.Image = Properties.Resources.zdown;//default facing down
            zombie.Left = rnd.Next(0, this.ClientSize.Width - zombie.Width);//sets x to random value
            zombie.Top = rnd.Next(0, this.ClientSize.Height - zombie.Height - 80);//sets y to random value
            zombie.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombie);//adds to list of zombies
            this.Controls.Add(zombie);//adds the pbo to the screen
            pboPlayer.BringToFront();
        }

        private void RestartGame()
        {//used when game starts or is restarted
            playerHealth = 100;
            gameOver = false;
            pboPlayer.Image = Properties.Resources.up;//makes sure player is facing up
            ammo = 10;
            score = 0;
            tmrGameTimer.Start();
            foreach (PictureBox i in zombiesList)
            {//removes any zombies from previous game
                this.Controls.Remove(i);
            }
            zombiesList.Clear();
            for (int i = 0; i < 3; i++)
            {//spawns 3 zombies on screen
                makeZombies();
            }
            //makes player still
            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
        }

        private async void GameLoopEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {//asssings the progress bar to the playerHealth
                prgHealthBar.Value = Convert.ToInt32(playerHealth);
            }
            else
            {//when the player's health is below 1
                //Play death sound
                SoundPlayer DeathSound = new SoundPlayer(Zombie_Survival.Properties.Resources.Player_Death_Sound);
                DeathSound.Play();
                pboPlayer.Image = Properties.Resources.dead;//player dead image shows
                prgHealthBar.Value = 0;
                gameOver = true;
                tmrGameTimer.Stop();
                await Task.Delay(3000);//Pauses entire program for 3 seconds. (Shows dead player and full death
                frmMenu newMenu = new frmMenu(Convert.ToString(score),false, false);//sound can be played
                this.Hide();
                newMenu.ShowDialog();
                this.Close();
            }

            lblAmmo.Text = "Ammo: " + ammo;//Updates ammo
            lblKills.Text = "Kills " + score;//updates kill count

            if (goLeft && pboPlayer.Left > 0)
            {//moves player left
                pboPlayer.Left -= playerSpeed;
            }
            if (goRight && pboPlayer.Left + pboPlayer.Width < this.ClientSize.Width)
            {//moves player right
                pboPlayer.Left += playerSpeed;
            }
            if (goUp && pboPlayer.Top > 100)
            {//moves player up
                pboPlayer.Top -= playerSpeed;
            }
            if (goDown && pboPlayer.Top + pboPlayer.Height < this.ClientSize.Height)
            {//moves player down
                pboPlayer.Top += playerSpeed;
            }

            CollisionDetect();
            chasePlayer();
        }

        private void ShootBullet(string direction)
        {//creates new bullet
            //sets direction, x and y coordinate
            if (direction == "right" || direction == "up")
            {
                Bullet shootBullet = new Bullet(direction,
                    pboPlayer.Left + (pboPlayer.Width - (pboPlayer.Width / 3)),
                    pboPlayer.Top + (pboPlayer.Height - (pboPlayer.Height / 3)));
                shootBullet.MakeBullet(this);
            }
            if (direction == "down" || direction == "left")
            {
                Bullet shootBullet = new Bullet(direction,
                    pboPlayer.Left + (pboPlayer.Width / 3),
                    pboPlayer.Top + (pboPlayer.Height / 3));
                shootBullet.MakeBullet(this);
            }
            //adds it to the form
        }
    }
    class Bullet
    {
        //attributes
        private string direction;
        private int bulletLeft, bulletTop, speed = 20;
        private PictureBox bullet = new PictureBox();
        private Timer bulletTimer = new Timer();
        //constructor
        public Bullet(string direct, int left, int top)
        {
            direction = direct;
            bulletLeft = left;
            bulletTop = top;
        }

        //methods
        public void MakeBullet(Form form)
        {
            //Creates picture box for bullet
            bullet.BackColor = Color.White;
            bullet.Size = new Size(5, 5);
            bullet.Tag = "bullet";
            bullet.Left = bulletLeft;
            bullet.Top = bulletTop;
            bullet.BringToFront();
            //adds the created pbo to the form
            form.Controls.Add(bullet);
            //Uses timer to control bullet actions
            bulletTimer.Interval = speed;
            bulletTimer.Tick += new EventHandler(BulletTimerEvent);
            bulletTimer.Start();
        }
        private void BulletTimerEvent(object sender, EventArgs e)
        {//controls bullets timer 
            //control direction
            if (direction == "left")
            {
                bullet.Left -= speed;
            }
            if (direction == "right")
            {
                bullet.Left += speed;
            }
            if (direction == "up")
            {
                bullet.Top -= speed;
            }
            if (direction == "down")
            {
                bullet.Top += speed;
            }

            //makes bullet dissapear when reaches edge
            if (bullet.Left < 1 || bullet.Left > frmGame.ActiveForm.Width || bullet.Top < 1 || bullet.Top > frmGame.ActiveForm.Height)
            {
                bulletTimer.Stop();
                bulletTimer.Dispose();
                //removes from ram
                bulletTimer = null;
                bullet = null;
            }
        }
    }

    class Zombie
    {
        //atributes
        private int level, speed, health, damage;
        private PictureBox image;
        Random rnd = new Random();
        //constructor
        public Zombie(int setLevel)
        {
            if (setLevel == 1)
            {
                level = 1;
                speed = 5;
                health = 100;
                damage = 5;
            }
            else if (setLevel == 2)
            {
                level = 2;
                speed = 7;
                health = 50;
                damage = 15;
            }
            else if (setLevel == 3)
            {
                level = 3;
                speed = 3;
                health = 200;
                damage = 40;
            }
            else if (setLevel == 4)
            {
                level = 4;
                speed = 5;
                health = 250;
                damage = 25;
            }
        }
        //methods
        public void makeZombie(int Level)
        {//when called it makes a zombie of corresponding level
            Zombie zombie = new Zombie(Level);

            zombie.image = new PictureBox();
            zombie.image.Tag = "zombie";
            zombie.image.Image = Zombie_Survival.Properties.Resources.zdown; //default facing down
            zombie.image.Left = rnd.Next(0, frmGame.ActiveForm.Width - zombie.image.Width);//sets x to random value
            zombie.image.Top = rnd.Next(0, frmGame.ActiveForm. - zombie.image.Height - 80);//sets y to random value
            zombie.image.SizeMode = PictureBoxSizeMode.AutoSize;
            zombiesList.Add(zombie);//adds to list of zombies
            this.Controls.Add(zombie);//adds the pbo to the screen
            pboPlayer.BringToFront();
        }
    }
}