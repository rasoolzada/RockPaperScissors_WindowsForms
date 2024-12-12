using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors_WindowsForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        void guessWin(int randomNo)
        {
            switch (randomNo)
            {
                case 1:
                    {
                        this.textBox1.Text = "Rock";
                        this.textBox1.ForeColor = Color.White;
                        this.textBox1.BackColor = SystemColors.HotTrack;
                    }
                    break;
                case 2:
                    {
                        this.textBox1.Text = "Paper";
                        this.textBox1.ForeColor = Color.White;
                        this.textBox1.BackColor = Color.DarkGreen;
                    }
                    break;
                case 3:
                    {
                        this.textBox1.Text = "Scissors";
                        this.textBox1.ForeColor = Color.White;
                        this.textBox1.BackColor = Color.Red;
                    }
                    break;
            }
        }
        
        private void rock_Click(object sender, EventArgs e)
        {
            Random Random = new Random();
            int rn=Random.Next(3)+1;
            if (rn == 3)
            {
                this.textBox2.Text = "Aha! You Won!";
                this.textBox2.ForeColor = Color.DarkGreen;
            }
            else if(rn==2)
            {
                this.textBox2.Text = "You Lose!";
                this.textBox2.ForeColor = Color.Red;
            }
            else
            {
                this.textBox2.Text = "The Game Tied!";
                this.textBox2.ForeColor = Color.Black;
            }
            guessWin(rn);
        }

        private void paper_Click(object sender, EventArgs e)
        {
            Random Random = new Random();
            int rn = Random.Next(3) + 1;
            if (rn == 1)
            {
                this.textBox2.Text = "Aha! You Won!";
                this.textBox2.ForeColor= Color.DarkGreen;
            }
            else if(rn==3)
            {
                this.textBox2.Text = "You Lose!";
                this.textBox2.ForeColor = Color.Red;
            }
            else
            {
                this.textBox2.Text = "The Game Tied!";
                this.textBox2.ForeColor=Color.Black;
            }
            guessWin(rn);
        }

        private void scissors_Click(object sender, EventArgs e)
        {
            Random Random = new Random();
            int rn = Random.Next(3) + 1;
            if (rn == 2)
            {
                this.textBox2.Text = "Aha! You Won!";
                this.textBox2.ForeColor = Color.DarkGreen;
            }
            else if(rn==1)
            {
                this.textBox2.Text = "You Lose!";
                this.textBox2.ForeColor = Color.Red;
            }
            else
            {
                this.textBox2.Text = "The Game Tied!";
                this.textBox2.ForeColor = Color.Black;
            }
            guessWin(rn);
        }
    }
}
