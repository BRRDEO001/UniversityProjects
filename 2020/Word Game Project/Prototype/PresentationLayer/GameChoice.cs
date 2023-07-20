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
    public partial class GameChoice : Form
    {
        private MatchingGame MatchingGameForm = new MatchingGame();
        private GuessingGame GuessingGameForm = new GuessingGame();
        private HangMan HangManForm = new HangMan();
        public GameChoice()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void fontDialog1_Apply(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MatchingGameForm.Visible = true ;
            this.Hide();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void GameChoice_Load(object sender, EventArgs e)
        {

        }

        private void guess_label_Click(object sender, EventArgs e)
        {
            GuessingGameForm.Visible = true;
            this.Hide();
        }

        private void hangman_label_Click(object sender, EventArgs e)
        {
            HangManForm.Visible = true;
            this.Hide();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Categories cat = new Categories();
            this.Hide();
            cat.Show();
        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIParent1 home = new MDIParent1();
            this.Hide();
            home.Show();
        }

        private void progressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgressScreen ps = new ProgressScreen();
            this.Hide();
            ps.Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure that you want to exit?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            MessageBox.Show(dr.ToString());
                
                Application.Exit();
        }
    }
}
