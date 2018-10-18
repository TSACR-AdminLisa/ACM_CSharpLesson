using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class OrderDisplay
    {
        #region "Variables"
        #endregion

        #region "Constructors"
        #endregion

        #region "Properties"

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset? OrderDate { get; set; }
        public List<OrderDisplayItem> OrderDisplayItemList { get; set; }
        public int OrderId { get; set; }
        public Address ShippingAddress { get; set; }

        #endregion
    }
}
