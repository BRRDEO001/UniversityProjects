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


namespace WGame___Prototype_1

    
{
    public partial class MDIParent1 : Form
    {
       
        private LanguageSelect LanguageSelectForm = new LanguageSelect();
        private LanguageSelect child;

        language l = language.English;

        public LanguageSelect Child { get => child; set => child = value; }

        enum language { English, Afrikaans}     
        public MDIParent1()
        {
            InitializeComponent();
            LanguageSelectForm.mdi = this;
        }

        public void toEnglish()
        {
            welcome_label.Text = "Welcome To WGame!";
            btnSettings.Text = "⚙️ Settings";
            Play_button.Text = "Play!";
        }

        public void toAfrikaans()
        {
            welcome_label.Text = "Welkom by WGame!";
            btnSettings.Text = "⚙️Instellings";
            Play_button.Text = "Speel!";
        }
       
        private void button1_Click(object sender, EventArgs e)

        {

            Categories cat = new Categories();
            this.Hide();
            cat.Show();
         
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateLanguageSelectForm() {
         

        }

        private void btnSettings_Click(object sender, EventArgs e)
        {

            
            LanguageSelectForm.Show();
            this.Hide();
        }
    }
}
