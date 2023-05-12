using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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

        //PictureBox[] bubble;
        //int backgroundspeed;
        //Random random;
        int playerSpeed;
        PictureBox[] seaUrchins;
        int seaUrchinsSpeed;


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
            //backgroundspeed = 5;
            //bubble = new PictureBox[20];
            random = new Random();
            playerSpeed = 15;
            seaUrchins = new PictureBox[3];
            int seaUrchinsSize = random.Next(60,90);
            seaUrchinsSpeed = 3;
            Image urchins = Image.FromFile("Debug\\ёж.png");
            for (int i = 0; i < seaUrchins.Length; i++)
            {
                seaUrchins[i] = new PictureBox();
                seaUrchins[i].Image = urchins;
                seaUrchins[i].Size = new Size(seaUrchinsSize, seaUrchinsSize);
                seaUrchins[i].SizeMode = PictureBoxSizeMode.Zoom;
                seaUrchins[i].BackColor = Color.Black;
                seaUrchins[i].Location = new Point((i+1)*random.Next(90,160) + 1000, random.Next(450,600));
                

                this.Controls.Add(seaUrchins[i]);
            }
            //for (int i = 0; i < bubble.Length; i++)
            //{
            //    bubble[i] = new PictureBox();
            //    bubble[i].BorderStyle = BorderStyle.None;
            //    bubble[i].Location = new Point(random.Next(-1000,1280), random.Next(140,320));
            //    if (i % 2 == 0)
            //    {
            //        bubble[i].Size = new Size(random.Next(50,50), random.Next(50,50));
            //        bubble[i].BackColor = Color.FromArgb(random.Next(50,125), 255, 200, 200);
            //    }
            //    else
            //    {
            //        bubble[i].Size = new Size(55,45);
            //        bubble[i].BackColor = Color.FromArgb(random.Next(50, 125), 255, 202, 202);
            //    }

            //    this.Controls.Add(bubble[i]);
            //}

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
    }
}
