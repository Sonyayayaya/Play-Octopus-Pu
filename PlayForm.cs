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
using WMPLib;

namespace Игра_про_осьминога
{
    public partial class PlayForm : Form
    {
        public PlayForm()
        {
            InitializeComponent();
        }

        WindowsMediaPlayer throwingCoral;
        WindowsMediaPlayer backgroundMusic;
        private Random random;
        int playerSpeed;
        PictureBox[] seaUrchins;
        int seaUrchinsSpeed;
        PictureBox[] bubble;
        int bubbleSpeed;
        PictureBox[] coral;
        int coralSpeed;
        Button playAgain;
        Button returnMenu;

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BackToMenuButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 form1 = new Form1();
            form1.Show();
            backgroundMusic.controls.stop();
        }

        private void PlayAgain(object sender, EventArgs e)
        {
            this.Hide();
            PlayForm playForm = new PlayForm();
            playForm.Show();
            backgroundMusic.controls.stop();
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
            backgroundMusic = new WindowsMediaPlayer();
            backgroundMusic.URL = "music\\background music.mp3";
            backgroundMusic.settings.setMode("loop", true);
            backgroundMusic.settings.volume = 15;

            throwingCoral = new WindowsMediaPlayer();
            throwingCoral.URL = "music\\throwing.mp3";
            throwingCoral.settings.volume = 100;

            random = new Random();
            playerSpeed = 25;
            coral = new PictureBox[1];
            Image corales = Image.FromFile("коралл.png");
            coralSpeed = 100;
            for(int i = 0; i < coral.Length; i++)
            {
                coral[i] = new PictureBox();
                coral[i].Image = corales;
                coral[i].BorderStyle = BorderStyle.None;
                coral[i].Size = new Size(18, 11);
                coral[i].BackColor = Color.Transparent;

                this.Controls.Add(coral[i]);
            }

            seaUrchinsSpeed = 5;
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

            backgroundMusic.controls.play();
        }
        private void PlayForm_KeyDown(object sender, KeyEventArgs e)
        {
            mainPlayer.Image = Image.FromFile("осьминог приседает.png");

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

            if(e.KeyCode == Keys.Space)
            {
                mainPlayer.Image = Image.FromFile("осьминог пуляется кораллом.png");
                throwingCoral.controls.play();
                
                for (int i = 0; i < coral.Length; i++)
                {
                    Collision();
                    if (coral[i].Left > 1280)
                    {
                        coral[i].Location = new Point(mainPlayer.Location.X + 100 + i * 50, mainPlayer.Location.Y + 50);
                    }
                }
            }
        }

        private void PlayForm_KeyUp(object sender, KeyEventArgs e)
        {
            mainPlayer.Image = Image.FromFile("осьминог.png");

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

                

                Collision();
            }

        }

        private void GoBubbles(PictureBox[] bubble, int speed)
        {
            for (int i = 0; i < bubble.Length; i++)
            {
                bubble[i].Left -= (int)(speed * Math.PI) + (int)(Math.Sin(bubble[i].Left * 20 + Math.PI * 100) * + Math.Cos(bubble[i].Left * 20 + Math.PI * 100));

                if (bubble[i].Left < 0)
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
        private void Collision()
        {
            for (int i = 0; i < seaUrchins.Length; i++)
            {
                if (mainPlayer.Bounds.IntersectsWith(seaUrchins[i].Bounds))
                {
                    mainPlayer.Visible = false;
                    GameOver();
                }

                if (coral[0].Bounds.IntersectsWith(seaUrchins[i].Bounds))
                {
                    seaUrchins[i].Location = new Point((i + 1) * random.Next(150, 250) + 1200, random.Next(120, 550));
                    coral[0].Location = new Point(2000, mainPlayer.Location.Y + 50);
                    int seaUrchinsSize = random.Next(50, 80);
                    seaUrchins[i].Size = new Size(seaUrchinsSize, seaUrchinsSize);
                    seaUrchins[i].Location = new Point((i + 1) * random.Next(150, 250) + 1000, random.Next(120, 550));
                   
                }

                if (seaUrchins[i].Location.X < 0)
                { 
                    mainPlayer.Visible = false;
                    GameOver();
                }
            }
        }

        private void GameOver()
        {
            playAgain = new Button();
            playAgain.Location = new Point(430, 200);
            playAgain.Size = new Size(120, 70);
            playAgain.BackColor = Color.Blue;
            playAgain.Text = "Play again";
            playAgain.Cursor = Cursors.Hand;
            playAgain.Click += new EventHandler(PlayAgain);

            this.Controls.Add(playAgain);

            returnMenu = new Button();
            returnMenu.Location = new Point(430, 360);
            returnMenu.Size = new Size(120, 70);
            returnMenu.BackColor = Color.Blue;
            returnMenu.Text = "Menu";
            returnMenu.Cursor = Cursors.Hand;
            returnMenu.Click += new EventHandler(BackToMenuButton_Click);

            this.Controls.Add(returnMenu);
        }

        private void GoCorals_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < coral.Length; i++)
            {
                coral[i].Left += coralSpeed;
            }
        }
    }
}
