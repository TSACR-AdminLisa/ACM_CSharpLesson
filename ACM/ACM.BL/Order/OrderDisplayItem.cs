using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderDisplayItem
    {
        #region "Variables"
        #endregion

        #region "Constructors"
        #endregion

        #region "Properties"

        public int OrderItemId { get; set; }
        public int OrderQuantity { get; set; }
        public string ProductName { get; set; }
        public decimal? PurchacePrice { get; set; }

        #endregion
    }
}
