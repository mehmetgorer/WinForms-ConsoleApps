using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird_Windows_Forms
{
	public partial class Form1 : Form
	{
		int boruHizi = 8;
		int gravity = 10;
		int score = 0;

		bool gameOver = false;
		public Form1()
		{
			InitializeComponent();
		}

		private void gameTimerEvent(object sender, EventArgs e)
		{
			flappyBird.Top += gravity;
			BoruAlt.Left -= boruHizi;
			BoruUst.Left -= boruHizi;
			scoreText.Text = "Score: " + score;

            if (BoruAlt.Left < -150)
            {
				BoruAlt.Left = 800;
				score++;
                
            }
            if (BoruUst.Left < -180)
            {
				BoruUst.Left = 1200;
				score++;
                
            }
			if (flappyBird.Bounds.IntersectsWith(BoruAlt.Bounds) || flappyBird.Bounds.IntersectsWith(BoruUst.Bounds) || flappyBird.Bounds.IntersectsWith(Zemin.Bounds))
			{
				endGame();
			}
            if (score>5)
            {
				boruHizi = 15;
                
            }
            if (flappyBird.Top<-25)
            {
				endGame();
            }

        }

		private void Form1_Load(object sender, EventArgs e)
		{

		}

		private void gamekeyisdown(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				gravity = -10;
			}
            if (e.KeyCode == Keys.R && gameOver)
            {
				RestartGame();
            }

        }

		private void gameekeyisup(object sender, KeyEventArgs e)
		{
			if (e.KeyCode == Keys.Space)
			{
				gravity = 10;
			}

		}
		private void endGame()
		{
			gameTimer.Stop();
			scoreText.Text = "Game Over! Press R to Restart the Game";
			gameOver = true;
		}

		private void RestartGame()
		{
			gameOver = false;
			flappyBird.Location = new Point(67, 220);
			BoruUst.Left = 800;
			BoruAlt.Left = 1200;

			score = 0;
			boruHizi = 5;
			scoreText.Text = "Score : 0";
			gameTimer.Start();
		}

		private void RestartClickEvent(object sender, EventArgs e)
		{
			RestartGame();
		}
	}
}
