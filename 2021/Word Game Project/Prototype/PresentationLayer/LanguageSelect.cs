using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WGame___Prototype_1;
using WGame___Prototype_1.PresentationLayer;

namespace WGame___Prototype_1.PresentationLayer
{
    public partial class LanguageSelect : Form
    {
        private Categories CategoriesForm = new Categories();
        private LanguageSubmission LanguageSubmissionForm = new LanguageSubmission();
        public MDIParent1 mdi;
        public LanguageSelect()
        {
            InitializeComponent();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            LanguageSubmissionForm.Visible = true;
            this.Hide();
        }

        private void english_button_Click(object sender, EventArgs e)
        {
            //DialogResult dr2 = MessageBox.Show("Are you sure?", "Title", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            CategoriesForm.Show();
            this.Close();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (cboLang.SelectedIndex == 0)
            {
                language_selection_title.Text = "Please select your home language:";
                btnAccept.Text = "Accept";
                btnCancel.Text = "Cancel";
                lblOther.Text = "Langauge Not On List? Click HereLangauge Not On List? Click Here";
                cboLang.Text = "Select Language";
                mdi.toEnglish();

            }
            else if (cboLang.SelectedIndex == 1)
            {
                language_selection_title.Text = "Kies jou huistaal:";
                btnAccept.Text = "Bevestig";
                btnCancel.Text = "Kanselleer";
                lblOther.Text = "Taal nie op lys? Kliek hier";
                cboLang.Text = "Kies Taal";
                mdi.toAfrikaans();
            }
            else
            {
                MessageBox.Show("Select a language or click cancel", "Invalid Selection", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            mdi.Show();
;        }

        private void language_selection_title_Click(object sender, EventArgs e)
        {

        }

        private void LanguageSelect_Load(object sender, EventArgs e)
        {
            mdi.Child = this;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            mdi.Show();
        }

        private void lblOther_Click(object sender, EventArgs e)
        {
            LanguageSubmissionForm.mdi = this;
            this.Hide();
            LanguageSubmissionForm.Show();

        }
    }
}
