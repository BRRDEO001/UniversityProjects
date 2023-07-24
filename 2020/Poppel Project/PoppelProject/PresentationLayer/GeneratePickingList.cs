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
using PoppelProject.PresentationLayer;

namespace PoppelProject
{
    public partial class GeneratePickingList : Form
    {
        public GeneratePickingList()
        {
            InitializeComponent();
            pickingList.AppendText("Product code    "+"Quantity     "+ "Subtotal" +Environment.NewLine);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string orderNum = txtOrderNum.Text;

            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/deony/Desktop/University/2020/Semester 2/INF2011S/Project/Poppel/Poppel.accdb;Persist Security Info=False;");
            myConn.Open();
            OleDbCommand myQuery = new OleDbCommand(" SELECT [product code], quantity, subtotal FROM OrderItems WHERE [order number] = '" + orderNum + " ';", myConn);
            OleDbDataReader myReader = myQuery.ExecuteReader();
            myReader.Read();
            if (myReader.HasRows)
                while (myReader.Read()) {

                    pickingList.AppendText(myReader.GetValue(0) + "                     " + myReader.GetValue(1) + "                      " + myReader.GetValue(2));
                    pickingList.AppendText(Environment.NewLine);


                }
            else {

                MessageBox.Show("Order number not found", "Error");

            }


            myConn.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainF mainform = new mainF();
            mainform.Show();
            this.Hide();
        }
    }
}
