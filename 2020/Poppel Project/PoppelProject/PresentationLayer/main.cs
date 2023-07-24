using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoppelProject.PresentationLayer
{
    public partial class mainF : Form
    {
        public mainF()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            CaptureOrderForm cof = new CaptureOrderForm();
            cof.Show();
            this.Close();
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            CreateCustomer cc = new CreateCustomer();
            cc.Show();
            this.Close();
        }

        private void btnExpired_Click(object sender, EventArgs e)
        {
            ExpiredProducts ep = new ExpiredProducts();
            ep.Show();
            this.Close();
        }

        private void btnPicking_Click(object sender, EventArgs e)
        {
            GeneratePickingList gpl = new GeneratePickingList();
            gpl.Show();
            this.Close();
        }

        private void btnInvoices_Click(object sender, EventArgs e)
        {
            Orders orders = new Orders();
            orders.Show();
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LoginForm lf = new LoginForm();
            lf.Show();
            this.Close();
        }
    }
}
