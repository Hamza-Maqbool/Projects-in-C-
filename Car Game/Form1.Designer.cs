
namespace car_game_2
{
    partial class Form1
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.score = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Player = new System.Windows.Forms.PictureBox();
            this.AI2 = new System.Windows.Forms.PictureBox();
            this.explosion = new System.Windows.Forms.PictureBox();
            this.AI1 = new System.Windows.Forms.PictureBox();
            this.roadtrack2 = new System.Windows.Forms.PictureBox();
            this.roadtrack1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // score
            // 
            this.score.AutoSize = true;
            this.score.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.score.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.score.Location = new System.Drawing.Point(141, 482);
            this.score.Name = "score";
            this.score.Size = new System.Drawing.Size(90, 23);
            this.score.TabIndex = 0;
            this.score.Text = "SCORE:";
            // 
            // distance
            // 
            this.distance.AutoSize = true;
            this.distance.Font = new System.Drawing.Font("Mongolian Baiti", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.distance.Location = new System.Drawing.Point(237, 482);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(34, 23);
            this.distance.TabIndex = 1;
            this.distance.Text = "00";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Mongolian Baiti", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(148, 543);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 44);
            this.button1.TabIndex = 2;
            this.button1.Text = "START";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.Player);
            this.panel1.Controls.Add(this.AI2);
            this.panel1.Controls.Add(this.explosion);
            this.panel1.Controls.Add(this.AI1);
            this.panel1.Controls.Add(this.roadtrack2);
            this.panel1.Controls.Add(this.roadtrack1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 424);
            this.panel1.TabIndex = 3;
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Transparent;
            this.Player.Image = global::car_game_2.Properties.Resources.carYellow;
            this.Player.Location = new System.Drawing.Point(161, 286);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(50, 101);
            this.Player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Player.TabIndex = 5;
            this.Player.TabStop = false;
            // 
            // AI2
            // 
            this.AI2.BackColor = System.Drawing.Color.Transparent;
            this.AI2.Image = global::car_game_2.Properties.Resources.carGreen;
            this.AI2.Location = new System.Drawing.Point(294, 84);
            this.AI2.Name = "AI2";
            this.AI2.Size = new System.Drawing.Size(50, 101);
            this.AI2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI2.TabIndex = 4;
            this.AI2.TabStop = false;
            // 
            // explosion
            // 
            this.explosion.BackColor = System.Drawing.Color.Transparent;
            this.explosion.Image = global::car_game_2.Properties.Resources.explosion;
            this.explosion.Location = new System.Drawing.Point(153, 234);
            this.explosion.Name = "explosion";
            this.explosion.Size = new System.Drawing.Size(64, 64);
            this.explosion.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.explosion.TabIndex = 3;
            this.explosion.TabStop = false;
            // 
            // AI1
            // 
            this.AI1.BackColor = System.Drawing.Color.Transparent;
            this.AI1.Image = global::car_game_2.Properties.Resources.carGrey;
            this.AI1.Location = new System.Drawing.Point(66, 19);
            this.AI1.Name = "AI1";
            this.AI1.Size = new System.Drawing.Size(50, 101);
            this.AI1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AI1.TabIndex = 2;
            this.AI1.TabStop = false;
            // 
            // roadtrack2
            // 
            this.roadtrack2.Image = global::car_game_2.Properties.Resources.roadTrack;
            this.roadtrack2.Location = new System.Drawing.Point(-2, -210);
            this.roadtrack2.Name = "roadtrack2";
            this.roadtrack2.Size = new System.Drawing.Size(385, 632);
            this.roadtrack2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadtrack2.TabIndex = 1;
            this.roadtrack2.TabStop = false;
            // 
            // roadtrack1
            // 
            this.roadtrack1.Image = global::car_game_2.Properties.Resources.roadTrack;
            this.roadtrack1.Location = new System.Drawing.Point(-2, -638);
            this.roadtrack1.Name = "roadtrack1";
            this.roadtrack1.Size = new System.Drawing.Size(385, 632);
            this.roadtrack1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.roadtrack1.TabIndex = 0;
            this.roadtrack1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(399, 656);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.score);
            this.Name = "Form1";
            this.Text = "Car Game";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.explosion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AI1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roadtrack1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label score;
        private System.Windows.Forms.Label distance;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox roadtrack2;
        private System.Windows.Forms.PictureBox roadtrack1;
        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox AI2;
        private System.Windows.Forms.PictureBox explosion;
        private System.Windows.Forms.PictureBox AI1;
    }
}

