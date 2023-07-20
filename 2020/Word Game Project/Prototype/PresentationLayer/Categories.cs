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
    public partial class Categories : Form
    {
        private GameChoice GameChoiceForm = new GameChoice();
        
        public Categories()
        {
            InitializeComponent();
        }

        private void Categories_Title_Click(object sender, EventArgs e)
        {

        }

        private void Common_Obj_button_Click(object sender, EventArgs e)
        {

        }

        private void Animal_button_Click(object sender, EventArgs e)
        {
            GameChoiceForm.Show();
            this.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void playGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MDIParent1 home = new MDIParent1();
            this.Close();
            home.Show();
        }

        private void progressToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProgressScreen ps = new ProgressScreen();
            this.Close();
            ps.Show();
        }

        private void resetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            String display = "Pick a category and then one of the following games:"+ Environment.NewLine+
                "MATCHING GAME " + Environment.NewLine +
                "This is a picture - word matching game, you will be given a picture and will need to click on a word that matches it, you will be given 3 possible answers, try click the correct one !"
                + Environment.NewLine +
                Environment.NewLine +
                "GUESSING GAME" + Environment.NewLine +
                "In this game you will be given a word in Afrikaans and need to type in the same word in English, when you think you've typed in the correct answer, click Submit ! You will be given a message displaying if you were correct or not."
            +Environment.NewLine +
           Environment.NewLine +
           "HANGMAN GAME "+
            "Feeling tired of learning ? Play HangMan !You have 7 chances, each chance you can simply submit a letter, if the letter exists in the word it will be unveiled where it is in the word, making it easier to guess the word. Try to figure it out before it's too late...";

       MessageBox.Show(display, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }
    }
}
