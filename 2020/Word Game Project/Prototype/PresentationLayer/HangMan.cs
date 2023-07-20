using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WGame___Prototype_1.PresentationLayer
{
    public partial class HangMan : Form
    {
        String word = "Leeu";
        String gameWord = "_ _ _ _";
       // int wrongGuesses = 0;
        public HangMan()
        {
            InitializeComponent();
        }

        public String replaceLetter( String w, char letter)
        {
            String nWord = "";

            for (int i = 0; i < w.Length; i++)
            {
                if (word[i].Equals(letter))
                {
                    nWord += " " + letter + " ";
                }
                else { 
                    nWord = nWord + " "+ gameWord[i*2] ; 
                }
            }
            gameWord = nWord;
            return nWord;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void menu_choosegame_Click(object sender, EventArgs e)
        {
            DialogResult dr3 = MessageBox.Show("Are you sure?", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            
            


            if (txtLetter.Text != "") { 
                char letter = txtLetter.Text[0];

                if (word.Contains(letter))
                {
                   
                    lblWord.Text = replaceLetter( word, letter);
                }
                else
                {
                    listIncorrect.Items.Add(letter);
                    txtLetter.Clear();
                   // wrongGuesses++;
                }
            }  
            else {
                if (txtWord.Text.Equals(word))
                {
                    MessageBox.Show("Congratulations! You got it!", "Congratulations", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    lblWord.Text = "_ _ _ _ _ _";
                }
                else
                {
                    //wrongGuesses++;
                    listIncorrect.Items.Add(txtWord.Text);
                    txtWord.Clear();
                }
           }
            
        }

        private void HangMan_Load(object sender, EventArgs e)
        {
            lblWord.Visible = false;
        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblWord.Visible = true;
        }

        private void progressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            ProgressScreen ps = new ProgressScreen();
          //  ps.ParentForm = this;
            this.Hide();
            ps.Show();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listIncorrect.Items.Clear();
            lblWord.Text = "_ _ _ _";

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIParent1 mdi = new MDIParent1();
            this.Hide();
            mdi.Show();
            
        }
    }
}
