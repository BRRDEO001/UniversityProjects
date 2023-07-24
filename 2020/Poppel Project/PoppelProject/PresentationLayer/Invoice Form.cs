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


namespace PoppelProject.PresentationLayer
{
    public partial class Invoice_Form : Form
    {
        public int custNum;
        public string orderNum;
        public Invoice_Form()
        {
            InitializeComponent();
        }

        public Invoice_Form(int cNum, string order)
        {
            orderNum = order;
            custNum = cNum;

            InitializeComponent();
        }

        public int CustNum
        {
            set { custNum = value; }
        }
        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void Invoice_Form_Onclose(object sender, EventArgs e)
        {


        }

            private void Invoice_Form_Load(object sender, EventArgs e)
        {
            //Invoice number
            lblInvoice.Text = orderNum;

            //Invoice date
            lblDate.Text = (DateTime.Now).ToString();

            //Get billing address
            
             OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/deony/Desktop/University/2020/Semester 2/INF2011S/Project/Poppel/Poppel.accdb;Persist Security Info=False;");
             myConn.Open();
            OleDbCommand myQuery = new OleDbCommand(" SELECT [billing address] FROM Customer WHERE [customer code] = " + custNum + " ;", myConn);
            OleDbDataReader myReader = myQuery.ExecuteReader();
            myReader.Read();
            lblAddress.Text = myReader.GetValue(0).ToString();
       

            //Get Total
            myQuery = new OleDbCommand(" SELECT Total FROM Orders WHERE [order number] = '" + orderNum + "' ;", myConn);
            myReader = myQuery.ExecuteReader();
            myReader.Read();
         //   lblTotal.Text="R "+( myReader.GetValue(0)).ToString();



            #region Display products
            myQuery = new OleDbCommand(" SELECT Products.description FROM(OrderItems INNER JOIN Products ON OrderItems.[product code] = Products.[product code]) WHERE(OrderItems.[order number] = '" +orderNum + "');", myConn);
            myReader = myQuery.ExecuteReader();
            
            string display = "";
           
            while (myReader.Read())
            {
              
               display += display + myReader.GetValue(0)+ Environment.NewLine;

            }
            lblProducts.Text = display;
            #endregion

            #region Display prices per item
            myQuery = new OleDbCommand(" SELECT Products.[price per item] FROM (OrderItems INNER JOIN Products ON OrderItems.[product code] = Products.[product code]) WHERE(OrderItems.[order number] = '" + orderNum + "');", myConn);
            myReader = myQuery.ExecuteReader();

            display = "";

            while (myReader.Read())
            {

                display += display + myReader.GetValue(0) + Environment.NewLine;

            }
            lblPrices.Text = display;
            #endregion


            #region Prices
            myQuery = new OleDbCommand(" SELECT OrderItems.Subtotal FROM OrderItems WHERE ([order number] = '" + orderNum + "');", myConn);
            myReader = myQuery.ExecuteReader();
   
            display = "";

            while (myReader.Read())
            {

                display += display + myReader.GetValue(0) + Environment.NewLine;

            }
            lblSub.Text = display;

            #endregion

            #region Quantities
            myQuery = new OleDbCommand("SELECT quantity FROM OrderItems WHERE ([order number] = '" + orderNum + "');", myConn);
            myReader = myQuery.ExecuteReader();

            display = "";

            while (myReader.Read())
            {

                display += display + myReader.GetValue(0) + Environment.NewLine;

            }
            lblQty.Text = display;
            #endregion


            myConn.Close();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
