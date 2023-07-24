using PoppelProject.Entity;
using PoppelProject.PresentationLayer;
using System;
using System.Collections;
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

namespace PoppelProject
{
    public partial class CaptureOrderForm : Form
    {
        decimal grandtotal = 0;
        Collection<OrderItem> orderItems = new Collection<OrderItem>();
        OrderItemController oic = new OrderItemController();
        productController pc = new productController();
      

        public CaptureOrderForm()
        {
            
            InitializeComponent();
     
 
            

        }

        private void Capture_Order_Load(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {   //get product code
            int prodCode = Int32.Parse(cmbProduct.Text);

            //get price of product

            decimal price = pc.pricePerItem(prodCode);

            //get rest of information

            string orderNumber = txtOrderNum.Text;
            int prodQty = Int32.Parse(productQty.Value.ToString());
            decimal subtotal = productQty.Value*price;
            productList.AppendText(Environment.NewLine);
            productList.AppendText( prodCode + "                    " + prodQty + "                    " + subtotal);
            txtSubtotal.Text = (subtotal).ToString();
            grandtotal += subtotal;
            txtGrandTotal.Text = grandtotal.ToString();



            //Add to database

            oic.addToDatabase(orderNumber, prodCode, prodQty, subtotal);

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/deony/Desktop/University/2020/Semester 2/INF2011S/Project/Poppel/Poppel.accdb;Persist Security Info=False;");
            myConn.Open();
            OleDbCommand myQuery = new OleDbCommand("SELECT [credit available] FROM Customer WHERE [customer code] = " + Int32.Parse(txtCustNum.Text) + " ;", myConn);
            OleDbDataReader myReader = myQuery.ExecuteReader();
            myReader.Read();
            if (myReader.HasRows)
            {
                decimal credit = myReader.GetDecimal(0);
                txtCredit.Text = credit.ToString();
                myConn.Close();
            }
            else
            {

                MessageBox.Show("Customer number not found. Please try again!", "Error");
                myConn.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)

        {
            
            
            int custNum = Int32.Parse(txtCustNum.Text);
            string orderN = txtOrderNum.Text;
            int grand = Int32.Parse(txtGrandTotal.Text);
            string address = cmbProvince.Text + " " + txtCity.Text + " " + txtSuburb.Text + " " + txtStreet.Text + " " + txtNum;
            string cDate = (confirmedDate.Value).ToString();
            string dDate = (deliveryDate.Value).ToString();

            if (Int32.Parse(txtCredit.Text) < Int32.Parse(txtGrandTotal.Text))
            {
                MessageBox.Show("Total exceeds customer credit", "Error");
               
            }
            else
            {
                Order order = new Order(custNum, orderN, grand, address, cDate, dDate, orderItems);
                OrderController oc = new OrderController();
                oc.AddToDataBase(custNum, orderN, grand, address, cDate, dDate);
                MessageBox.Show("Successfully created order!", "Success");
            }
        }
        

        private void txtOrderNum_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            mainF mainForm = new mainF();
            mainForm.Show();
            this.Close();
        }

        private void createCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateCustomer cc = new CreateCustomer();
            this.Hide();
            cc.Show();
            
        }

        private void generatePickingListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GeneratePickingList gpl = new GeneratePickingList();
            this.Hide();
            gpl.Show();
        }
    } 
}
