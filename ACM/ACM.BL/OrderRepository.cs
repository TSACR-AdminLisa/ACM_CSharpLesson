using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderRepository
    {
        #region "Functions"

        public Order Retrieve(int orderId)
        {
            Order order = new Order(orderId);

            if (orderId == 10)
            {
                order.OrderDate = new DateTimeOffset(2016, 10, 02, 22, 15, 20, new TimeSpan(-6,0,0));
            }

            return order;
        }

        public bool Save()
        {
            return true;
        }
        
        #endregion
    }
}
