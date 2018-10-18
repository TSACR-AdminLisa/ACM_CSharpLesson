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
            OrderItems = new List<OrderItem>();
        }

        #endregion

        #region "Properties"

        public int CustomerId { get; set; } //CustomerId Relationship
        public int ShippingAddressId { get; set; } //AddressId Relationship
        public DateTimeOffset? OrderDate { get; set; }
        public int OrderId { get; private set; } //OrderId Relationship
        public List<OrderItem> OrderItems { get; set; }

        #endregion

        #region "Functionality"
        
        public bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        #endregion
    }
}
