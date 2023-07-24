using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PoppelProject.Entity;

namespace PoppelProject.PresentationLayer
{
    public partial class Orders : Form
    {
        public Orders()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            OrderController ordercontroller = new OrderController();
            Collection<Order> orders = ordercontroller.Orders;
            int c = 0;
            while ( c < orders.Count)
            {
                orderList.AppendText((orders[c].CustNum).ToString() + "        " + orders[c].OrderNum + "        " + (orders[c].Total).ToString() + "       " + orders[c].Address + "       " + orders[c].Confirmed + "        " + orders[c].DeliveryDate);
                orderList.AppendText(Environment.NewLine);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string orderNum = txtOrderNum.Text;
            int custNum=0;

            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/deony/Desktop/University/2020/Semester 2/INF2011S/Project/Poppel/Poppel.accdb;Persist Security Info=False;");
            myConn.Open();
            OleDbCommand myQuery = new OleDbCommand(" SELECT [customer number] FROM Orders WHERE [order number] = '" + orderNum + " ';", myConn);
            OleDbDataReader myReader = myQuery.ExecuteReader();
            myReader.Read();
            if (!myReader.HasRows)
            {
                MessageBox.Show("Order number not found", "Error");
            }
            else { 
            custNum = myReader.GetInt32(0);
            }

            Invoice_Form ivf = new Invoice_Form(custNum, orderNum);
            ivf.Show();
            this.Close();
            

        }
    }
}
