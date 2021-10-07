using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Threading;
using System.Media;

namespace _2DGameApp
{
    public partial class gamescreen : UserControl
    {
        //Player properties
        Image Player = Properties.Resources._1;
        int pSize = 70;
        int pX = 50;
        int pY = 280;
        int pFrame = 1;
        int jumpcounter;
        int jumpSpeed = 35;
        bool jumpOK;
        bool jump = false;

        SoundPlayer jumpsound = new SoundPlayer(Properties.Resources.jump);
        SoundPlayer endsound = new SoundPlayer(Properties.Resources.end);

        //form properties
        public static int score;

        //obst properties
        int obsSpawn = 15;
        List<obstacle> obsList = new List<obstacle>();


        public gamescreen()
        {
            InitializeComponent();
        }

        private void gamescreen_Load(object sender, EventArgs e)
        {

        }


        //GAME ENGINE
        private void GameTimer_Tick(object sender, EventArgs e)
        {
            pFrame++;
            if (pFrame == 0)
            {
                Player = Properties.Resources._1;
            }
            if (pFrame == 2)
            {
                Player = Properties.Resources._2;
            }
            if (pFrame == 3)
            {
                Player = Properties.Resources._3;
            }
            if (pFrame == 4)
            {
                Player = Properties.Resources._4;
                pFrame = 0;
            }

            foreach (obstacle o in obsList)
            {
                o.Move();
            }

            obsSpawn++;

            //If obstacle spawner timer is at 40, spawn an obstacle
            if (obsSpawn == 35)
            {
                obstacle newOb = new obstacle();
                obsList.Add(newOb);
                Random randobs = new Random();
                obsSpawn = randobs.Next(0, 20);
            }

            //Remove obst from side of screen
            if (obsList.Count() == 2)
            {
                if (obsList[0].X <= -60)
                {
                    score++;
                    obsList.RemoveAt(0);
                }
            }

            //Player Jump
            if (pY == 280)
            {
                jumpOK = true;
            }

            if (jump == true && jumpOK == true)
            {

                jumpcounter++;
                if (jumpcounter < 5)
                {
                    pY -= jumpSpeed;

                    if (jumpcounter > 2)
                    {
                        jumpSpeed = 25;
                    }

                    if (jumpcounter > 4)
                    {
                        jumpSpeed = 10;
                    }

                    if (jumpcounter > 5)
                    {
                        jumpSpeed = 5;
                    }
                }


                if (jumpcounter > 7)
                {
                    jumpSpeed = 20;
                    pY += jumpSpeed;

                    if (pY >= 280)
                    {
                        pY = 280;
                        jumpcounter = 0;
                        jump = false;
                        jumpSpeed = 35;
                    }
                }

            }

            //Player and Obst Collision check
            Rectangle playerRec = new Rectangle(pX, pY, pSize, pSize);

            foreach (obstacle o in obsList)
            {
                Rectangle obstacleRec = new Rectangle(o.X, o.Y, o.width, o.height);

                if (playerRec.IntersectsWith(obstacleRec))
                {
                    endsound.Play();
                    Thread.Sleep(1000);
                    Refresh();
                    Form f = this.FindForm();
                    f.Controls.Remove(this);

                    endscreen es = new endscreen();
                    f.Controls.Add(es);

                    GameTimer.Enabled = false;
                }

            }

            currentscoreLabel.Text = $"{score}";
            Refresh();
        }

        private void gamescreen_Paint(object sender, PaintEventArgs e)
        {
            //Paint obst's to screen
            foreach (obstacle o in obsList)
            {
                e.Graphics.DrawImage(o.obsImage, o.X, o.Y, o.width, o.height);
                e.Graphics.DrawImage(Player, pX, pY, pSize, pSize);
            }
        }

        private void gamescreen_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {

            //check if jump is pressed. if so, set jump to true.
            switch (e.KeyCode)
            {
                case Keys.Up:
                    jump = true;
                    break;

           
            }
            if (jumpOK == true)
            {
                jumpsound.Play();
            }
        }

        private void gamescreen_KeyUp(object sender, KeyEventArgs e)
        {
        }

        private void jumpTimer_Tick(object sender, EventArgs e)
        {

        }
    }
}