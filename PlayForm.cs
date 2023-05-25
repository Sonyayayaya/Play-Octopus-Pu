using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Игра_про_осьминога
{
    public partial class PlayForm : Form
    {
        public PlayForm()
        {
            InitializeComponent();
        }

        private Random random;

        //int backgroundspeed;
        //Random random;
        int playerSpeed;
        PictureBox[] seaUrchins;
        int seaUrchinsSpeed;
        PictureBox[] bubble;
        int bubbleSpeed;

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void GoLeftTimer_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.Left > 10)
            {
                mainPlayer.Left -= playerSpeed;
            }
        }

        private void GoRightTimer_Tick(object sender, EventArgs e)
        {
            if (mainPlayer.Left < 1430)
            {
                mainPlayer.Left += playerSpeed;
            }
        }

        private void GoUpTimer_Tick(object sender, EventArgs e)
        {
            mainPlayer.Top -= playerSpeed;
        }

        private void GoDownTimer_Tick(object sender, EventArgs e)
        {
            mainPlayer.Top += playerSpeed;
        }
        private void PlayForm_Load(object sender, EventArgs e)
        {
            random = new Random();
            playerSpeed = 15;

            seaUrchinsSpeed = 8;
            seaUrchins = new PictureBox[3];
            int seaUrchinsSize = random.Next(60,90);
            Image urchins = Image.FromFile("ёж.png");
            for (int i = 0; i < seaUrchins.Length; i++)
            {
                seaUrchins[i] = new PictureBox
                {
                    Image = urchins,
                    Size = new Size(seaUrchinsSize, seaUrchinsSize),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.Transparent,
                    Location = new Point((i + 1) * random.Next(150, 250) + 1000, random.Next(120, 550))
                };

                this.Controls.Add(seaUrchins[i]);
            }

            bubbleSpeed = 5;
            bubble = new PictureBox[20];
            int bubbleSize = random.Next(50, 80);
            Image bubbles = Image.FromFile("пузырёк.png");
            for (int i = 0; i < bubble.Length; i++)
            {
                bubble[i] = new PictureBox
                {
                    Image = bubbles,
                    Size = new Size(bubbleSize, bubbleSize),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    BackColor = Color.Transparent,
                    Location = new Point((i + 1) * random.Next(150, 250) + 1000, random.Next(120, 550))
                };

                this.Controls.Add(bubble[i]);
            }

        }
        private void PlayForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                GoLeftTimer.Start();
            }

            if (e.KeyCode == Keys.Right)
            {
                GoRightTimer.Start();
            }

            if (e.KeyCode == Keys.Down)
            {
                GoDownTimer.Start();
            }

            if (e.KeyCode == Keys.Up)
            {
                GoUpTimer.Start();
            }
        }

        private void PlayForm_KeyUp(object sender, KeyEventArgs e)
        {
            GoLeftTimer.Stop();
            GoRightTimer.Stop();
            GoDownTimer.Stop();
            GoUpTimer.Stop();
        }

        private void GoUrchisTimer_Tick(object sender, EventArgs e)
        {
            GoUrchins(seaUrchins, seaUrchinsSpeed);
        }

        private void GoUrchins(PictureBox[] seaUrchins, int speed)
        {
            for (int i = 0; i < seaUrchins.Length; i++)
            {
                seaUrchins[i].Left -= (int)(speed*Math.PI) + (int)(Math.Sin(seaUrchins[i].Left * 20 + Math.PI*100)* + Math.Cos(seaUrchins[i].Left*20 + Math.PI * 100));

                if (seaUrchins[i].Left< this.Left)
                {
                    int seaUrchinsSize = random.Next(50, 80);
                    seaUrchins[i].Size = new Size(seaUrchinsSize, seaUrchinsSize);
                    seaUrchins[i].Location = new Point((i + 1)* random.Next(150,250) + 1000, random.Next(120, 550));
                }

                CollisionWithSeaUrchin();
            }

        }

        private void GoBubbles(PictureBox[] bubble, int speed)
        {
            for (int i = 0; i < bubble.Length; i++)
            {
                bubble[i].Left -= (int)(speed * Math.PI) + (int)(Math.Sin(bubble[i].Left * 20 + Math.PI * 100) * + Math.Cos(bubble[i].Left * 20 + Math.PI * 100));

                if (bubble[i].Left < this.Left)
                {
                    int bubbleSize = random.Next(50, 80);
                    bubble[i].Size = new Size(bubbleSize, bubbleSize);
                    bubble[i].Location = new Point((i + 1) * random.Next(150, 250) + 1000, random.Next(120, 550));
                }
            }

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            GoBubbles(bubble, bubbleSpeed);
        }
        private void CollisionWithSeaUrchin()
        {
            for (int i = 0; i < seaUrchins.Length; i++)
            {
                if (mainPlayer.Bounds.IntersectsWith(seaUrchins[i].Bounds))
                {
                    mainPlayer.Visible = false;
                }
            }

        }
    }
}
