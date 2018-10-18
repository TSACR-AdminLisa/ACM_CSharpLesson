using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Order
    {
        #region "Constructores"

        public Order() : this(0)
        {
        }

        public Order(int orderId)
        {
            this.OrderId = orderId;
        }

        #endregion

        #region "Properties"

        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; }

        #endregion

        #region "Functions"

        public Order Retrieve(int orderId)
        {
            return new Order();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        #endregion
    }
}
