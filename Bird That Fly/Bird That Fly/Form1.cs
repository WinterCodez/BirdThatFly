using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bird_That_Fly
{
    public partial class Form1 : Form
    {

       int pipespeed = 8;
       int gravity = 15;
       int score = 0;

       bool gameOver = false;



        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void gameTimeEvent(object sender, EventArgs e)
        {
            Bird.Top += gravity;
            PIPE1.Left -= pipespeed;
            PIPE2.Left -= pipespeed;
            PIPE3.Left -= pipespeed;
            PIPE4.Left -= pipespeed;
            Score.Text = "score: " + score;
            if(PIPE1.Left < -150) 
            {
                PIPE1.Left = 800;
                score++;
            }
            if(PIPE2.Left < -170)
            {
                PIPE2.Left = 800;
                score++;
            }
            if (PIPE3.Left < -170)
            {
                PIPE3.Left = 900;
                score++;
            }
            if (PIPE4.Left < -180 )
            {
                PIPE4.Left = 850;
                score++;
            }
            if (Bird.Bounds.IntersectsWith(PIPE1.Bounds)||
               Bird.Bounds.IntersectsWith(PIPE2.Bounds) ||
               Bird.Bounds.IntersectsWith(Ground.Bounds) || Bird.Top < -25
               ) 
            {
                endGame();
            }
            


            if(score > 5)
            {
                pipespeed = 15;
            }
        } 




        private void gamekeyisup(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Space)
            {
                gravity = 8;
            }


        }

        private void gamekeyisdown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Space)
            {
                gravity = -8;
            }
            
        

        }

        private void endGame()
        {
            gameTimer.Stop();
            Score.Text += " Game over!!!";
        }
    }
}
