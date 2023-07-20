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
    public partial class ProgressScreen : Form
    {
        private Form parentForm1;

        public Form ParentForm1 { get => parentForm1; set => parentForm1 = value; }

        public ProgressScreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            HangMan hm = new HangMan();
            this.Hide();
            hm.Show();

        }

        private void ProgressScreen_Load(object sender, EventArgs e)
        {

        }
    }
}
