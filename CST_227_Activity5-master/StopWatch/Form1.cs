using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace StopWatch
{
    public partial class Form1 : Form
    {
        public static Stopwatch watch = new Stopwatch();

        public static Random rnd = new Random();

        private int hits = 0;


        public Form1()
        {
            InitializeComponent();
            timer1.Interval = 1000;

            btn_missClick.SendToBack();

            pic_falseTarget.BackgroundImage = new Bitmap(@"C:\Users\zcham\OneDrive\Desktop\GCU - School\redx.png");
            pic_falseTarget1.BackgroundImage = new Bitmap(@"C:\Users\zcham\OneDrive\Desktop\GCU - School\redx.png");
            pic_falseTarget2.BackgroundImage = new Bitmap(@"C:\Users\zcham\OneDrive\Desktop\GCU - School\redx.png");
            pic_falseTarget3.BackgroundImage = new Bitmap(@"C:\Users\zcham\OneDrive\Desktop\GCU - School\redx.png");
            pic_target.BackgroundImage = new Bitmap(@"C:\Users\zcham\OneDrive\Desktop\GCU - School\target.png");
        }

        private void btn_start_Click(object sender, EventArgs e)
        {
            watch.Start();
        }

        private void btn_stop_Click(object sender, EventArgs e)
        {
            watch.Stop();
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            watch.Reset();
            label4.Text = "0";
        }

        private void gameRunning()
        {
            
            if (watch.IsRunning)
            {
                pic_target.Left = rnd.Next(0, this.Width);
                pic_target.Top = rnd.Next(0, this.Height);
                pic_falseTarget.Left = rnd.Next(0, this.Width);
                pic_falseTarget.Top = rnd.Next(0, this.Height);
                pic_target.Visible = true;
                pic_falseTarget.Visible = true;
                btn_missClick.BackgroundImage = new Bitmap(@"C:\Users\zcham\OneDrive\Desktop\GCU - School\background.png");

            }

            if (watch.IsRunning && hits >= 10)
            {
                pic_falseTarget1.Left = rnd.Next(0, this.Width);
                pic_falseTarget1.Top = rnd.Next(0, this.Height);
                pic_falseTarget1.Visible = true;
                btn_missClick.BackgroundImage = new Bitmap(@"C:\Users\zcham\OneDrive\Desktop\GCU - School\background.png");
            }

            if (watch.IsRunning && hits >= 20)
            {
                pic_falseTarget2.Left = rnd.Next(0, this.Width);
                pic_falseTarget2.Top = rnd.Next(0, this.Height);
                pic_falseTarget2.Visible = true;
                btn_missClick.BackgroundImage = new Bitmap(@"C:\Users\zcham\OneDrive\Desktop\GCU - School\background.png");
            }

            if (watch.IsRunning && hits >= 30)
            {
                pic_falseTarget3.Left = rnd.Next(0, this.Width);
                pic_falseTarget3.Top = rnd.Next(0, this.Height);
                pic_falseTarget3.Visible = true;
                btn_missClick.BackgroundImage = new Bitmap(@"C:\Users\zcham\OneDrive\Desktop\GCU - School\background.png");
            }

            if (hits == 40 || hits == -1)
            {
                watch.Stop();
                timer1.Stop();
                pic_target.Visible = false;
                pic_falseTarget.Visible = false;
                pic_falseTarget1.Visible = false;
                pic_falseTarget2.Visible = false;
                pic_falseTarget3.Visible = false;

                string score = ("Your score is: " + hits + " and your time was: " + label1.Text);
                string scoreMessage = ("GAME OVER.\n" + " Your score is: " + hits + "\nYour time was: " + label1.Text);
                MessageBox.Show(scoreMessage);
                ScoreList.scoreList.Add(score);
                Form2 f2 = new Form2();
                f2.Show();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = watch.Elapsed;
            string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}", ts.Minutes, ts.Seconds, ts.Milliseconds / 10);
            label1.Text = elapsedTime;

            gameRunning();
           
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pic_target.Visible = false;
            hits++;
            label4.Text = hits.ToString();
        }

        private void pic_falseTarget_Click(object sender, EventArgs e)
        {
            pic_falseTarget.Visible = false;
            hits--;
            label4.Text = hits.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pic_target.Visible = false;
            pic_falseTarget.Visible = false; 
            pic_falseTarget1.Visible = false;
            pic_falseTarget2.Visible = false;
            pic_falseTarget3.Visible = false;
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            hits--;
            label4.Text = hits.ToString();
        }

        private void pic_falseTarget1_Click(object sender, EventArgs e)
        {
            pic_falseTarget1.Visible = false;
            hits--;
            label4.Text = hits.ToString();
        }

        private void pic_falseTarget2_Click(object sender, EventArgs e)
        {
            pic_falseTarget2.Visible = false;
            hits--;
            label4.Text = hits.ToString();
        }

        private void pic_falseTarget3_Click(object sender, EventArgs e)
        {
            pic_falseTarget3.Visible = false;
            hits--;
            label4.Text = hits.ToString();
        }

        private void btn_missClick_Click(object sender, EventArgs e)
        {
            hits--;
            label4.Text = hits.ToString();
        }

        private void btn_playAgain_Click(object sender, EventArgs e)
        {
            watch.Restart();
            watch.Start();
            timer1.Start();
            hits = 0;
            label4.Text = hits.ToString();
            gameRunning();
        }
    }
}
