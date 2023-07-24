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
    class OrderItemController
    {
        Collection<OrderItem> allOrderItems;

        public OrderItemController()
        {
            allOrderItems = new Collection<OrderItem>();
        }

        public void addToDatabase(string orderN, int prodC, int qty, decimal sub)
        {
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/deony/Desktop/University/2020/Semester 2/INF2011S/Project/Poppel/Poppel.accdb;Persist Security Info=False;");
            myConn.Open();
            OleDbCommand myQuery = new OleDbCommand("INSERT INTO OrderItems VALUES ( '" + orderN + "', " + prodC + ", " +qty + ", " + sub + ");", myConn);
            myQuery.ExecuteNonQuery();
            myConn.Close();

           
        }
    }
}
