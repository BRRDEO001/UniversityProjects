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
    public partial class LanguageSubmission : Form
    {
        public LanguageSelect mdi;
        public LanguageSubmission()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for your input. We will review your request.", "Request Another Language", MessageBoxButtons.OK);
            this.Close();
            mdi.Show();
        }

        private void LanguageSubmission_Load(object sender, EventArgs e)
        {

        }
    }
}
