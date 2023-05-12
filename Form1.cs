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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RulesButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            RulesForm rulesForm = new RulesForm();
            rulesForm.Show();
        }

        private void CloseBbutton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ButtonPlay_MouseEnter(object sender, EventArgs e)
        {
            ButtonPlay.BackColor = Color.Aqua;
        }

        private void ButtonPlay_MouseLeave(object sender, EventArgs e)
        {
            ButtonPlay.BackColor = Color.FromArgb(128, 255, 255);
        }

        Point lastPoint;
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            SettingsForm settingsForm = new SettingsForm();
            settingsForm.Show();
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            this.Hide();
            PlayForm playForm = new PlayForm();
            playForm.Show();
        }
    }
}
