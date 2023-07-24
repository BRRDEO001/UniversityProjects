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
    public partial class ExpiredProducts : Form
    {
        public ExpiredProducts()
        {
            InitializeComponent();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            string Expdate = txtDate.Value.ToString();

            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/deony/Desktop/University/2020/Semester 2/INF2011S/Project/Poppel/Poppel.accdb;Persist Security Info=False;");
            myConn.Open();
            OleDbCommand myQuery = new OleDbCommand(" SELECT [batch number], [product code], [expiry date] FROM Inventory WHERE [expiry date] < '" + Expdate + " ';", myConn);
            OleDbDataReader myReader = myQuery.ExecuteReader();
         

            while (myReader.Read())
            {
                expiredproductList.AppendText(Environment.NewLine);
                expiredproductList.AppendText(myReader.GetValue(0) + "         " + myReader.GetValue(1) + "           " + myReader.GetValue(2));
                
                

            }



            myConn.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {

            mainF mainform = new mainF();
            mainform.Show();
            this.Hide();
        }
    }
}
