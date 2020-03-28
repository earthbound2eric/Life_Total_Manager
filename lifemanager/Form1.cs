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
using System.Threading;
namespace lifemanager
{
    public partial class Form1 : Form
    {
        public static string gametype = "empty";
        
        public Form1()
        {
            InitializeComponent();
            textBox2.PasswordChar = '*';
            textBox4.PasswordChar = '*';
            textBox6.PasswordChar = '*';
            textBox8.PasswordChar = '*';
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox1.Enabled = false;
            textBox2.Enabled = false;
            textBox3.Enabled = false;
            textBox4.Enabled = false;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
        }
        //magic game option button
        private void button1_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Main_Page___Magic;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
        }

        //yugioh game option button
        private void button28_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Main_Page___Yu_Gi_Oh;
            gametype = "yugioh";
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;

        }

        //1v1 game option button
        private void button2_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Main_Page___1v1;
            gametype = "1v1";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = false;
            textBox6.Enabled = false;
            textBox7.Enabled = false;
            textBox8.Enabled = false;
        }

        //2HG game option button
        private void button3_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Main_Page___Commander;
            gametype = "2HG";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
        }

        //commander game option button
        private void button4_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Main_Page___Free_for_All;
            gametype = "commander";
            textBox1.Enabled = true;
            textBox2.Enabled = true;
            textBox3.Enabled = true;
            textBox4.Enabled = true;
            textBox5.Enabled = true;
            textBox6.Enabled = true;
            textBox7.Enabled = true;
            textBox8.Enabled = true;
        }
        //submit button
        private void button5_Click(object sender, EventArgs e)
        {
            Form2 frm2 = new Form2();
            Form3 frm3 = new Form3();
            Form4 frm4 = new Form4();
            StreamWriter playerOneName = new StreamWriter("D:\\ProgramDocuments\\playerOneName.txt");
            playerOneName.Write(textBox1.Text.ToString().ToUpper());
            playerOneName.Close();
            StreamWriter playerOneDeck = new StreamWriter("D:\\ProgramDocuments\\playerOneDeck.txt");
            playerOneDeck.Write(textBox2.Text.ToString().ToUpper());
            playerOneDeck.Close();
            StreamWriter playerTwoName = new StreamWriter("D:\\ProgramDocuments\\playerTwoName.txt");
            playerTwoName.Write(textBox3.Text.ToString().ToUpper());
            playerTwoName.Close();
            StreamWriter playerTwoDeck = new StreamWriter("D:\\ProgramDocuments\\playerTwoDeck.txt");
            playerTwoDeck.Write(textBox4.Text.ToString().ToUpper());
            playerTwoDeck.Close();
            if (gametype == "yugioh")
            {
                this.Hide();
                frm2.ShowDialog();
                this.Close();
            } 
            else if (gametype == "1v1")
            {
               this.Hide();
               frm3.ShowDialog();
               this.Close();

            } 
            else if (gametype == "2HG")
            {
                System.Windows.Forms.MessageBox.Show("This function does not currently work :(");
            } 
            else if (gametype == "commander")
            {
                System.Windows.Forms.MessageBox.Show("This function does not currently work :(");
            }

            
            
        }

        private void button6_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Program Developed by Eric Ruxton (Eruxton@outlook.com)\nGraphics by Josh Lacroix @Nerdz Cafe");
        }
    }
}
