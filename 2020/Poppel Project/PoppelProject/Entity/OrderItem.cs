using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelProject.Entity
{
    public class OrderItem
    {
        #region Fields
        string orderNum;
        int prodCode;
        int quantity;
        decimal subtot;
        #endregion

        #region Constructor
        public OrderItem(string orderN, int pCode, int qty, decimal subt)
        {
            orderNum = orderN;
            prodCode = pCode;
            quantity = qty;
            subtot = subt;
        }
        #endregion

        #region Property methods
        public string OrderNum
        {
            get { return orderNum; }
        }

        public int ProdCode
        {
            get { return prodCode; }
        }

        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public decimal Subtotal
        {
            get { return subtot; }
            set { subtot = value; }
        }
        #endregion
    }
}
