using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Hangman.Classes;


namespace Hangman
{
    public partial class Form1 : Form
    {
        Words keys = new Words();
        Game start = new Game();
        draw drawelement = new draw();
        Label[] labels1;


        
        public Form1()
        {
            var rand = new Random();
            start.Word = keys.words[rand.Next(0,5)];     
            labels1 = new Label[start.Word.Length];

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void getComponents()
        {
            int length = start.Word.Length;

            
            
            for(int i = 0; i < length; i++)
            {
                labels1[i]= new Label()
                {
                    Size = new Size(40, 40),
                    BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle,
                    Location = new Point(100 + (50 * i), 150),
                    TextAlign = ContentAlignment.MiddleCenter,
                    Text = "__",
                    Name = "Label" + Convert.ToString(i)                                                       
               
                };
                
                Controls.Add(labels1[i]);
            }
        }

      

        private void guessBtn_Click(object sender, EventArgs e)
        {
            drawelement.graph = this.CreateGraphics();

            
            start.KeyControl(Convert.ToChar(guessChar.Text));
            drawelement.drawMan(start.Guesscount);
            keyWord();


            if (start.Trueguesscount == start.Word.Length)
            {
                result.Text = "Kazandınız";
                result.Visible = true;
                result.BackColor = Color.Green;
            }
            else if (start.Guesscount == 6)
            {
                result.Text = "Kaybettiniz";
                result.Visible = true;
                result.BackColor = Color.Red;
            }        
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            drawelement.graph = this.CreateGraphics();
            drawelement.gallows();
            getComponents();
            guessBtn.Visible = true;
            guessChar.Visible = true;
        }

        private void keyWord()
        {
            for(int k = 0; k < start.Word.Length; k++)
            {
                if (Convert.ToChar(guessChar.Text) == start.Word[k])
                {
                    if (labels1[k].Text == guessChar.Text)
                        start.Trueguesscount -= 1;
                    else
                        labels1[k].Text = guessChar.Text;
                }
            }
        }

        
    }
    
}
