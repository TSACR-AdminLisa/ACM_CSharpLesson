using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderItem
    {
        #region "Constructor"
        public OrderItem() : this(0)
        {

        }

        public OrderItem(int orderItemId)
        {
            this.OrderItemId = orderItemId;
            this.PurchasePrice = 0;
            this.ProductId = 0;
            this.OrderQuantiy = 0;
        }
        #endregion

        #region "Properties"

        public int OrderItemId { get; private set; }
        public int OrderQuantiy { get; set; }
        public int ProductId { get; set; }
        public decimal? PurchasePrice { get; set; }

        #endregion

        #region "Functions and Methods"
        public OrderItem Retrieve(int orderItemId)
        {
            return new OrderItem();
        }

        public bool Save()
        {
            return true;
        }

        public bool Validate()
        {
            var isValid = true;

            if (OrderQuantiy <= 0) isValid = false;
            if (ProductId <= 0) isValid = false;
            if (PurchasePrice <= 0) isValid = false;

            return isValid;
        }
        #endregion
    }
}
