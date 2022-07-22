using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EZInput;
using System.Drawing.Imaging;

namespace car_game_2
{
    public partial class Form1 : Form
    {
        int carSpeed = 5;
        int roadSpeed = 5;
        bool carLeft;
        bool carRight;
        int trafficSpeed = 5;
        int Score = 0;
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
            Reset();
        }
        private void Reset()
        {

            button1.Enabled = false; // disable the button when game is running

            explosion.Visible = false; // hide the explosion image

            trafficSpeed = 5; // set the traffic back to default

            roadSpeed = 5; // set the road speed back to default

            Score = 0; // reset score to 0

            Player.Left = 161; // reset player left
            Player.Top = 286; // reset player top

            carLeft = false; // reset the moving left to false
            carRight = false; // reset the moving right to false


            // move the AI to default position this will be off the screen
            AI1.Left = 66;
            AI1.Top = -120;

            AI2.Left = 294;
            AI2.Top = -185;

            //reset the road to their default position
            roadtrack2.Left = -3;
            roadtrack2.Top = -222;
            roadtrack1.Left = -2;
            roadtrack1.Top = -638;

            //start the timer
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Score++; 

            distance.Text = "" + Score;

            roadtrack1.Top += roadSpeed;
            roadtrack2.Top += roadSpeed; 

            if (roadtrack1.Top > 630)
            {
                roadtrack1.Top = -630;
            }
            if (roadtrack2.Top > 630)
            {
                roadtrack2.Top = -630;
            }
            // end of track animation.
            if (carLeft)
            { 
                Player.Left -= carSpeed;
            } // move the car left if the car left is true
            if (carRight)
            {
                Player.Left += carSpeed; 
            } // move the car right if the car right is true

            // end of car moving

            //bounce the car off the boundaries of the panel
            if (Keyboard.IsKeyPressed(Key.LeftArrow) && Player.Left > 1)
            {
                Player.Left = Player.Left - 5;
                carLeft = false; // stop the car from going off screen
            }
            else if (Keyboard.IsKeyPressed(Key.RightArrow) && Player.Left + Player.Width < 380)
            {
                Player.Left = Player.Left + 5;
                carRight = false;
            }
            // end of the boundaries checks

            //move the AI cars down
            AI1.Top += trafficSpeed;
            AI2.Top += trafficSpeed;

            //respawn the AIs and change the their images
            if (AI1.Top > panel1.Height)
            {
                changeAI1(); // change the AI car images once they left the scene
                AI1.Left = rand.Next(2, 160); // random numbers where they appear on the left
                AI1.Top = rand.Next(100, 200) * -1; // random numbers where they appear on top
            }

            if (AI2.Top > panel1.Height)
            {
                changeAI2(); // change the AI car images once they left the scene
                AI2.Left = rand.Next(185, 327); // random numbers where they appear on the left
                AI2.Top = rand.Next(100, 200) * -1; // random numbers where they appear on top
            }
            if (Player.Bounds.IntersectsWith(AI1.Bounds) || Player.Bounds.IntersectsWith(AI2.Bounds))
            {
                gameOver(); // this will run when the player hits an AI object
            }
        }
        private void changeAI1()
        {
            int num = rand.Next(1, 8);
            if(num == 1)
            {
                AI1.Image = Properties.Resources.carGreen;
            }
            else if (num == 2)
            {
                AI1.Image = Properties.Resources.carGrey;
            }
            else if (num == 3)
            {
                AI1.Image = Properties.Resources.carOrange;
            }
            else if (num == 4)
            {
                AI1.Image = Properties.Resources.carPink;
            }
            else if (num == 5)
            {
                AI1.Image = Properties.Resources.CarRed;
            }
            else if (num == 6)
            {
                AI1.Image = Properties.Resources.TruckBlue;
            }
            else if (num == 7)
            {
                AI1.Image = Properties.Resources.TruckWhite;
            }
            else if (num == 8)
            {
                AI1.Image = Properties.Resources.Mini_truck;
            }
        }
        private void changeAI2()
        {
            int num = rand.Next(1, 8);
            if (num == 1)
            {
                AI2.Image = Properties.Resources.carGreen;
            }
            else if (num == 2)
            {
                AI2.Image = Properties.Resources.carGrey;
            }
            else if (num == 3)
            {
                AI2.Image = Properties.Resources.carOrange;
            }
            else if (num == 4)
            {
                AI2.Image = Properties.Resources.carPink;
            }
            else if (num == 5)
            {
                AI2.Image = Properties.Resources.CarRed;
            }
            else if (num == 6)
            {
                AI2.Image = Properties.Resources.TruckBlue;
            }
            else if (num == 7)
            {
                AI2.Image = Properties.Resources.TruckWhite;
            }
            else if (num == 8)
            {
                AI2.Image = Properties.Resources.Mini_truck;
            }
        }
        private void gameOver()
        {
            timer1.Stop(); // stop the timer

            button1.Enabled = true; // enable the button so we can use it now

            //showing the explosion image on top of the car image
            explosion.Visible = true; // make the image visible
            Player.Controls.Add(explosion); // add the explosion image on top of the player image
            explosion.Location = new System.Drawing.Point(-8, 5); // we are moving the image so its suitably positioned
            explosion.BackColor = Color.Transparent; // change the background to transparent
            explosion.BringToFront();
            playSound();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void playSound()
        {
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"hit.wav");
            player.Play();
        }
    }  
}
