using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace lifemanager
{
    public partial class Form2 : Form
    {
        double TimerTime = 3000;
        public Form2()
        {
            InitializeComponent();
            
            //timer2.Start();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //use this for any information that you may need from form 1
            if (Form1.gametype == "yugioh")
            {
                this.BackgroundImage = Properties.Resources.The_YuGiOhs;
            }
            timer2.Start();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            if (LeftPlayersName.ToString() != File.ReadAllText("D:\\ProgramDocuments\\playerOneName.txt").ToString())
            {
                this.LeftPlayersName.Text = File.ReadAllText("D:\\ProgramDocuments\\playerOneName.txt").ToString();
                this.LeftPlayersDeck.Text = File.ReadAllText("D:\\ProgramDocuments\\playerOneDeck.txt").ToString();
                this.RightPlayersName.Text = File.ReadAllText("D:\\ProgramDocuments\\playerTwoName.txt").ToString();
                this.RightPlayersDeck.Text = File.ReadAllText("D:\\ProgramDocuments\\playerTwoDeck.txt").ToString();
                timer2.Stop();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text.ToString()) - 10).ToString();
            StreamWriter playerOneLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerOneLifeTotal.txt");
            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text.ToString()) - 50).ToString();
            StreamWriter playerOneLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerOneLifeTotal.txt");
            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text.ToString()) - 100).ToString();
            StreamWriter playerOneLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerOneLifeTotal.txt");
            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button21_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text.ToString()) - 500).ToString();
            StreamWriter playerOneLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerOneLifeTotal.txt");
            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button19_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text.ToString()) - 1000).ToString();
            StreamWriter playerOneLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerOneLifeTotal.txt");
            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text.ToString()) + 10).ToString();
            StreamWriter playerOneLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerOneLifeTotal.txt");
            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text.ToString()) + 50).ToString();
            StreamWriter playerOneLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerOneLifeTotal.txt");
            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text.ToString()) + 100).ToString();
            StreamWriter playerOneLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerOneLifeTotal.txt");
            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text.ToString()) + 500).ToString();
            StreamWriter playerOneLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerOneLifeTotal.txt");
            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            label1.Text = (int.Parse(label1.Text.ToString()) + 1000).ToString();
            StreamWriter playerOneLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerOneLifeTotal.txt");
            playerOneLifeTotal.Write(label1.Text);
            playerOneLifeTotal.Close();
        }

        private void button35_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(label2.Text.ToString()) - 10).ToString();
            StreamWriter playerTwoLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerTwoLifeTotal.txt");
            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button33_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(label2.Text.ToString()) - 50).ToString();
            StreamWriter playerTwoLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerTwoLifeTotal.txt");
            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button31_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(label2.Text.ToString()) - 100).ToString();
            StreamWriter playerTwoLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerTwoLifeTotal.txt");
            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button29_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(label2.Text.ToString()) - 500).ToString();
            StreamWriter playerTwoLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerTwoLifeTotal.txt");
            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button27_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(label2.Text.ToString()) - 1000).ToString();
            StreamWriter playerTwoLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerTwoLifeTotal.txt");
            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button34_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(label2.Text.ToString()) + 10).ToString();
            StreamWriter playerTwoLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerTwoLifeTotal.txt");
            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button32_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(label2.Text.ToString()) + 50).ToString();
            StreamWriter playerTwoLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerTwoLifeTotal.txt");
            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button30_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(label2.Text.ToString()) + 100).ToString();
            StreamWriter playerTwoLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerTwoLifeTotal.txt");
            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button28_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(label2.Text.ToString()) + 500).ToString();
            StreamWriter playerTwoLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerTwoLifeTotal.txt");
            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void button26_Click(object sender, EventArgs e)
        {
            label2.Text = (int.Parse(label2.Text.ToString()) + 1000).ToString();
            StreamWriter playerTwoLifeTotal = new StreamWriter("D:\\ProgramDocuments\\playerTwoLifeTotal.txt");
            playerTwoLifeTotal.Write(label2.Text);
            playerTwoLifeTotal.Close();
        }

        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (LeftPlayersName.ToString() != File.ReadAllText("D:\\ProgramDocuments\\playerOneName.txt").ToString())
            {
                this.LeftPlayersName.Text = File.ReadAllText("D:\\ProgramDocuments\\playerOneName.txt").ToString();
                this.LeftPlayersDeck.Text = File.ReadAllText("D:\\ProgramDocuments\\playerOneDeck.txt").ToString();
                this.RightPlayersName.Text = File.ReadAllText("D:\\ProgramDocuments\\playerTwoName.txt").ToString();
                this.RightPlayersDeck.Text = File.ReadAllText("D:\\ProgramDocuments\\playerTwoDeck.txt").ToString();
                timer2.Stop();
            }
        }

        private void MainMenuButton_Click(object sender, EventArgs e)
        {
            Form1 frm1 = new Form1();
            this.Hide();
            frm1.ShowDialog();
            this.Close();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(LeftGamesWon.Text);
            temp--;
            LeftGamesWon.Text = temp.ToString();
            StreamWriter playerOneWins = new StreamWriter("D:\\ProgramDocuments\\playerOneWins.txt");
            playerOneWins.Write(RightGamesWon.Text);
            playerOneWins.Close();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(LeftGamesWon.Text);
            temp++;
            LeftGamesWon.Text = temp.ToString();
            StreamWriter playerOneWins = new StreamWriter("D:\\ProgramDocuments\\playerOneWins.txt");
            playerOneWins.Write(RightGamesWon.Text);
            playerOneWins.Close();
        }

        private void button16_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(RightGamesWon.Text);
            temp--;
            RightGamesWon.Text = temp.ToString();
            StreamWriter playerTwoWins = new StreamWriter("D:\\ProgramDocuments\\playerTwoWins.txt");
            playerTwoWins.Write(RightGamesWon.Text);
            playerTwoWins.Close();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            double temp = int.Parse(RightGamesWon.Text);
            temp++;
            RightGamesWon.Text = temp.ToString();
            StreamWriter playerTwoWins = new StreamWriter("D:\\ProgramDocuments\\playerTwoWins.txt");
            playerTwoWins.Write(RightGamesWon.Text);
            playerTwoWins.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimerText.Text = TimeSpan.FromSeconds(double.Parse(TimerTime.ToString())).ToString();
            TimerTime--;
            StreamWriter TimerDoc = new StreamWriter("D:\\ProgramDocuments\\Timer.txt");
            TimerDoc.Write(TimerText.Text);
            TimerDoc.Close();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}