using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PoppelProject.Entity
{
    
    public class Order
    {
        #region Fields
        private int custNum;
        private string orderNum;
        private int total;
        private string address;
        private string confirmed;
        private string deliveryDate;
        private Collection<OrderItem> orderItems;
      
        #endregion

        #region Constructor
        public Order(int cnum, string onum, int tot, string addr, string cdate, string ddate, Collection<OrderItem> orderI)
        {   
            custNum = cnum;
            orderNum = onum;
            total = tot;
            address = addr;
            confirmed = cdate;
            deliveryDate = ddate;
            orderItems = orderI;
        }
        #endregion

        #region Property Methods
        public int CustNum
        {
            get { return custNum;  }
        }

        public string OrderNum
        {
            get { return orderNum; }
        }

        public int Total
        {
            get { return total; }
        }

        public string Address
        {
            get { return address; }
        }

        public string Confirmed
        {
            get { return confirmed; }
        }

        public string DeliveryDate
        {
            get { return deliveryDate; }
        }

        #endregion

        #region Methods

        public void AddOrderItem(OrderItem oi)
        {
            orderItems.Add(oi);
        }

        public void CreateOrder()
        {

        }

        #endregion

















    }
}
