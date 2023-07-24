using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelProject.Entity
{
    public class productController
    {
        public decimal pricePerItem(int prodCode)
        {
            OleDbConnection myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/deony/Desktop/University/2020/Semester 2/INF2011S/Project/Poppel/Poppel.accdb;Persist Security Info=False;");
            myConn.Open();
            OleDbCommand myQuery = new OleDbCommand("SELECT [price per item] FROM Products WHERE [product code] = " + prodCode + ";", myConn);
            OleDbDataReader myReader = myQuery.ExecuteReader();

            myReader.Read();
            decimal price = myReader.GetDecimal(0);
            myConn.Close();

            return price;
        }
    }
}
