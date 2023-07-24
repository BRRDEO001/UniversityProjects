using PoppelProject.PresentationLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoppelProject
{
    public partial class CreateCustomer : Form
    {
        public CreateCustomer()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int custCode = Int32.Parse(txtCustCode.Text);
            string id = txtId.Text;
            string name = txtName.Text;
            string sname = txtSname.Text;
            string email = txtEmail.Text;
            string gender = cmbGender.Text;
            string delivery = deliveryAddress.Text;
            string billing = billingAddress.Text;


            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/deony/Desktop/University/2020/Semester 2/INF2011S/Project/Poppel/Poppel.accdb;Persist Security Info=False;");
            myConn.Open();
            OleDbCommand myQuery = new OleDbCommand("INSERT INTO Customer  VALUES (" + custCode+ ", '" +id+ "',  '" + name + "'  , '" + sname + "', '"+ email + "', '" + gender+ "', '" + delivery+ "', '" + billing + " ' , " +2000 +"," +0 +","+ 2000 + ","+ "'NA'" + "," + 0 + ");", myConn);
            myQuery.ExecuteNonQuery();
            myConn.Close();

            MessageBox.Show("Customer Successfully created!", "Success");



        }

        private void button2_Click(object sender, EventArgs e)
        {

            mainF mainform = new mainF();
            mainform.Show();
            this.Hide();

        }
    }
}
