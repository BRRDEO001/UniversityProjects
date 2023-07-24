using PoppelProject.PresentationLayer;
using System;
using System.Collections.ObjectModel;
using System.Data.OleDb;
using System.Windows.Forms;

namespace PoppelProject
{
    public partial class LoginForm : Form
    {
        
        public LoginForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userId = txtUsername.Text;
            string password = txtPassword.Text;
           

            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/deony/Desktop/University/2020/Semester 2/INF2011S/Project/Poppel/Poppel.accdb;Persist Security Info=False;");
            myConn.Open();
            OleDbCommand myQuery = new OleDbCommand("select password from Employees where username = '" + userId + "';", myConn);
            OleDbDataReader myReader = myQuery.ExecuteReader();

            if (myReader.HasRows) //check if any corresponding username has been found
            {
                myReader.Read();
                string passwordDB = myReader.GetValue(0).ToString();

                if (string.Equals(passwordDB, password)) //check if password entered matches with password entered
                {

                    CaptureOrderForm cf = new CaptureOrderForm();
                        
                        MessageBox.Show("Successfully logged in!", "Success");

                    

                    myConn.Close();


                }
                else
                {
                    MessageBox.Show("Incorrect username", "Error");
                }
            }
            else
            {
                MessageBox.Show("Customer number not found. Please try again!", "Error");
            }

            myConn.Close();


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
