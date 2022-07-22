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

namespace Space_Shooter
{
    public partial class Form1 : Form
    {
        List<PictureBox> firelist = new List<PictureBox>();
        PictureBox EnemyBlack;
        PictureBox EnemyRed;
        string blackDirection = "MovingRight";
        string redDirection = "MovingTop";
        Random rand = new Random();
        public Form1()
        {
            InitializeComponent();
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            if (Keyboard.IsKeyPressed(Key.RightArrow))
            {
                Player.Left = Player.Left + 3;
            }
            if (Keyboard.IsKeyPressed(Key.LeftArrow))
            {
                Player.Left = Player.Left - 3;
            }
            if (Keyboard.IsKeyPressed(Key.Space))
            {
                fireBullet();
            }
            foreach(PictureBox bullent in firelist)
            {
                bullent.Top = bullent.Top - 20;
            }
            for(int i = 0; i < firelist.Count; i++)
            {
                if (firelist[i].Bottom < 0)
                {
                    firelist.Remove(firelist[i]);
                }
            }
            moveEnemy(EnemyRed, ref redDirection);
            moveEnemy(EnemyBlack, ref blackDirection);
        }
        private void fireBullet()
        {
            PictureBox fire = new PictureBox();
            Image fireImge = Space_Shooter.Properties.Resources.laserGreen;
            fire.Image = fireImge;
            fire.Width = fireImge.Width;
            fire.Height = fireImge.Height;
            fire.BackColor = Color.Transparent;
            System.Drawing.Point firelocation = new System.Drawing.Point();
            firelocation.X = Player.Left + (Player.Width / 2) - 5;
            firelocation.Y = Player.Top - 40;
            fire.Location = firelocation;
            firelist.Add(fire);
            this.Controls.Add(fire);
        }
        private PictureBox createEnemy(Image img)
        {
            PictureBox pbenemy = new PictureBox();
            int left = rand.Next(30, this.Width);
            int top = rand.Next(5, img.Height + 20);
            pbenemy.Left = left;
            pbenemy.Top = top;
            pbenemy.Height = img.Height;
            pbenemy.Width = img.Width;
            pbenemy.BackColor = Color.Transparent;
            pbenemy.Image = img;
            return pbenemy;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            EnemyBlack = createEnemy(Space_Shooter.Properties.Resources.enemyShip);
            EnemyRed = createEnemy(Space_Shooter.Properties.Resources.meteorBig);
            this.Controls.Add(EnemyBlack);
            this.Controls.Add(EnemyRed);

        }
        private void moveEnemy(PictureBox enemy,ref string direction)
        {
            if(direction == "MovingRight")
            {
                enemy.Left = enemy.Left + 10;
            }
            if (direction == "MovingLeft")
            {
                enemy.Left = enemy.Left - 10;
            }
            if (direction == "MovingTop")
            {
                enemy.Top = enemy.Top + 10;
            }
            if(enemy.Left + enemy.Width > this.Width)
            {
                direction = "MovingLeft";
            }
            if (enemy.Left <= 2)
            {
                direction = "MovingRight";
            }
            if(enemy.Bottom > this.Bottom)
            {
                EnemyRed = createEnemy(Space_Shooter.Properties.Resources.meteorBig);
                this.Controls.Add(EnemyRed);
            }
        }
    }
}
