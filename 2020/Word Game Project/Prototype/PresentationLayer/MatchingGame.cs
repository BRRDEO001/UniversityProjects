using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WGame___Prototype_1.PresentationLayer;

namespace WGame___Prototype_1.PresentationLayer
{
    
    public partial class MatchingGame : Form
    {
        int seconds = 10;
        //private GameChoice GameChoiceForm2 = new GameChoice();
        public MatchingGame()
        {
            InitializeComponent();
        }

        private void word2_label_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Well Done !", "Correct Answer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            timer1.Stop();
        }

        private void word1_button_Click(object sender, EventArgs e)
        {
            DialogResult dr2 = MessageBox.Show("Oh No !", "Incorrect Answer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void word3_label_Click(object sender, EventArgs e)
        {
            DialogResult dr3 = MessageBox.Show("Oh No !", "Incorrect Answer", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //GameChoiceForm2.Visible = true;
            //this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void matchinggame_title_Click(object sender, EventArgs e)
        {

        }

        private void MatchingGame_Load(object sender, EventArgs e)
        {
            img.Visible = false;
            btnWord1.Visible = false;
            btnWord2.Visible = false;
            btnWord3.Visible = false;
        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            

            img.Visible = true;
            btnWord1.Visible =true;
            btnWord2.Visible = true;
            btnWord3.Visible = true;

            timer1.Start();
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
                btnWord1.Enabled = false;
                btnWord2.Enabled = false;
                btnWord3.Enabled = false;
            }
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
            seconds = 10;
            lblTime.Text = "10";
            img.Visible = false;
            btnWord1.Visible = false;
            btnWord2.Visible = false;
            btnWord3.Visible = false;
        }

        private void backToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GameChoice gc = new GameChoice();
            this.Hide();
            gc.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIParent1 mdp = new MDIParent1();
            this.Hide();
            mdp.Show();
        }
    }
}
