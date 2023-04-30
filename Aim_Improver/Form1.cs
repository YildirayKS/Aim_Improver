using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aim_Improver
{
    public partial class Form1 : Form
    {
        Point aim_image = new Point(251, 62);

        public Form1()
        {
            InitializeComponent();
        }

        float score;
        int time = 60;

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            score++;
            lbl_score.Text = "Score: " + score;

            change_position();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (time > 0)
            {
                lbl_time.Text = "Time: " + --time;

                if (time <= 10 && time % 2 == 0)
                {
                    lbl_time.ForeColor = Color.Red;
                }
                else
                {
                    lbl_time.ForeColor = Color.Black;
                }
            }
            else
            {
                lbl_time.ForeColor = Color.Black;

                timer1.Stop();

                pictureBox_aim.Location = aim_image;

                pictureBox_aim.Visible = true;
                lbl_title.Visible = true;

                lbl_score.Visible = false;
                lbl_time.Visible = false;

                if (MessageBox.Show("Score: " + score + "\nCPS(Click per second): " + (score / 60).ToString("0.00") + "\n\nDo you want to play again?", "Time is Over!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    startGame();
                }
                else
                {
                    Application.Exit();
                }
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            startGame();
        }

        void change_position()
        {
            Random randomX = new Random();
            Random randomY = new Random();

            Point aim_point = new Point();

            int random_X_LeftSide = randomX.Next(12, 367);
            int random_X_RightSide = randomX.Next(367, 730);

            int random_Y_LeftSide = randomX.Next(55, 205);
            int random_Y_RightSide = randomX.Next(205, 356);

            int[] random_X_Axis = { random_X_LeftSide, random_X_RightSide };
            int[] random_Y_Axis = { random_Y_LeftSide, random_Y_RightSide };

            aim_point.X = random_X_Axis[randomX.Next(0, 2)];
            aim_point.Y = random_Y_Axis[randomY.Next(0, 2)];

            pictureBox_aim.Location = aim_point;
        }

        void startGame()
        {
            time = 60;
            score = 0;

            lbl_time.Text = "Time: " + time.ToString();
            lbl_score.Text = "Score: " + score.ToString();
            timer1.Start();

            lbl_score.Visible = true;
            lbl_time.Visible = true;

            btn_start.Visible = false;
            lbl_title.Visible = false;

            change_position();
        }
    }
}
