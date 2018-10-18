using Acme.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public sealed class Order : EntityBase, ILoggable
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
        
        public override bool Validate()
        {
            var isValid = true;

            if (OrderDate == null) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return OrderDate.Value.Date + " (" + OrderId + ")";
        }

        public string Log()
        {
            return this.OrderId + ": " +
                   "Date: " + this.OrderDate.Value.Date + " " +
                   "Status: " + this.EntityState.ToString();
        }

        #endregion
    }
}
