using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wordle_Clone_GUI
{
    public partial class Form1 : Form
    {
        private string guess = String.Empty;
        private int guesses = 5;
        private int guessesTaken = 0;
        private bool guessed = false;
        private string[] words = { "bezel", "banjo", "equip", "chuck", "field", "jokes", "joker", "adieu", "shoes", "water", "irate", "power" };
        private string wordToGuess = String.Empty ;
        List<Panel> panelList = new List<Panel>() ;
        List<Label> labelList = new List<Label>() ;


        public Form1()
        {
            InitializeComponent();
            #region dumb coder stuff
            panelList.Add(panel1);
            panelList.Add(panel2);
            panelList.Add(panel3);
            panelList.Add(panel4);
            panelList.Add(panel5);
            panelList.Add(panel6);
            panelList.Add(panel7);
            panelList.Add(panel8);
            panelList.Add(panel9);
            panelList.Add(panel10);
            panelList.Add(panel11);
            panelList.Add(panel12);
            panelList.Add(panel13);
            panelList.Add(panel14);
            panelList.Add(panel15);
            panelList.Add(panel16);
            panelList.Add(panel17);
            panelList.Add(panel18);
            panelList.Add(panel19);
            panelList.Add(panel20);
            panelList.Add(panel21);
            panelList.Add(panel22);
            panelList.Add(panel23);
            panelList.Add(panel24);
            panelList.Add(panel25);

            labelList.Add(label1);
            labelList.Add(label2);
            labelList.Add(label3);
            labelList.Add(label4);
            labelList.Add(label5);      
            labelList.Add(label6);
            
            labelList.Add(label7);
            labelList.Add(label8);
            labelList.Add(label9);
            labelList.Add(label10);
            labelList.Add(label11);
            labelList.Add(label12);
            labelList.Add(label13);
            labelList.Add(label14);
            labelList.Add(label15);
            labelList.Add(label16);
            labelList.Add(label17);
            labelList.Add(label18);
            labelList.Add(label19);
            labelList.Add(label20);
            labelList.Add(label21);
            labelList.Add(label22);
            labelList.Add(label23);
            labelList.Add(label24);
            labelList.Add(label26);
            #endregion
        }

        private void button1_Click(object sender, EventArgs e)
        {
            guess = textBox1.Text.ToLower();
            if(guess == wordToGuess)
            {
                for(int i = 0; i <5; i++)
                {
                    panelList[i + (guessesTaken * 5)].BackColor = Color.Green;
                }
                MessageBox.Show("You got it!");
            }

            for(int i = 0; i <guess.Length; i++)
            {
                if(guess.ToCharArray()[i] == wordToGuess.ToCharArray()[i])
                {
                    panelList[i + (guessesTaken * 5)].BackColor = Color.Green;
                }
                else if(wordToGuess.Contains(guess[i]))
                {
                    panelList[i + (guessesTaken * 5)].BackColor = Color.Orange;
                }
            }
            guessesTaken++;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Random random = new Random();
            wordToGuess = words[random.Next(words.Length)];
            MessageBox.Show(wordToGuess);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           for (int i = 0; i < 5; i++){
	  	       if(textBox1.Text.Length != i)
	   	        {
	   		        labelList[i+(guessesTaken * 5)].Text = textBox1.Text[i].ToString().ToUpper();
	  	        }
                else
		        {
			        labelList[i + (guessesTaken * 5)].Text = "";
                    break;
		        }
	        }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
