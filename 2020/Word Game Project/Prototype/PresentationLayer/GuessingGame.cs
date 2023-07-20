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
    public partial class GuessingGame : Form
    {
        int seconds = 30;
        public GuessingGame()
        {
            InitializeComponent();
        }

        private void GuessGameSubmit_button_Click(object sender, EventArgs e)
        {
            if ((txtInput.Text).ToLower() == "dog")
            {
                MessageBox.Show("Well Done !", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                timer1.Stop();
            }
            else
            {
                MessageBox.Show("Ahh no!", "Inorrect Answer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (seconds > 0)
            {
                seconds--;
                lblTime.Text = seconds.ToString();
            }
            else
            {
                timer1.Stop();
                MessageBox.Show("You have run out of time!", "Time out", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtInput.Enabled = false;
            }
        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lblWord.Visible = true;
            timer1.Start();
            txtInput.Enabled = true;
             
          
        }

        private void GuessingGame_Load(object sender, EventArgs e)
        {
            lblWord.Visible = false;
        }

        private void progressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgressScreen ps = new ProgressScreen();
            this.Hide();
            ps.Show();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            seconds = 30;
            lblTime.Text = "30";
            lblWord.Visible = false;
            txtInput.Clear();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIParent1 mdp = new MDIParent1();
            this.Hide();
            mdp.Show();
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameChoice gc = new GameChoice();
            this.Hide();
            gc.Show();
        }
    }
}
