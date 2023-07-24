using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PoppelProject.Entity
{
    public class OrderController
    {
        #region Fields
        private Collection<Order> orders;
        #endregion 

        #region Constructor
        public OrderController()
        {
            orders = new Collection<Order>();
            ReadData();
        }
        #endregion

        #region Property Method
        public Collection<Order> Orders{
            get { return orders; }
        }
        #endregion

        #region CRUD Methods

        public void AddToDataBase(int cNum, string orderN, int tot, string Delivery, string confirmed, string deliveryDate)
        {
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/deony/Desktop/University/2020/Semester 2/INF2011S/Project/Poppel/Poppel.accdb;Persist Security Info=False;");
            myConn.Open();
            OleDbCommand myQuery = new OleDbCommand("INSERT INTO Orders  VALUES (" + cNum + ", '" + orderN  + "', " + tot  + ", '" + Delivery + "' , '" + confirmed + "', '" + deliveryDate + "');", myConn);
            myQuery.ExecuteNonQuery();
            myConn.Close();

            MessageBox.Show("Order Successfully created!", "Success");
        }

        #endregion

        #region Reader
        public  void ReadData()
        {
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/deony/Desktop/University/2020/Semester 2/INF2011S/Project/Poppel/Poppel.accdb;Persist Security Info=False;");
            myConn.Open();
            OleDbCommand myQuery = new OleDbCommand("SELECT * FROM Orders;", myConn);
            OleDbDataReader myReader = myQuery.ExecuteReader();
           
       
            while (myReader.Read())
            {
                Order order = new Order(myReader.GetInt32(0) ,myReader.GetString(0), myReader.GetInt32(1), myReader.GetString(1),myReader.GetString(2), myReader.GetString(3), new Collection<OrderItem>());
                orders.Add(order);  

            }
            myConn.Close();
        }
        #endregion
    }
}