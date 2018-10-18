using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Address
    {
        #region "Variables"
        #endregion

        #region "Constructors"
        public Address() : this(0)
        {

        }

        public Address(int addressId)
        {
            this.AddressId = addressId;
        }
        #endregion

        #region "Properties"

        public int AddressId { get; private set; }
        public int AddressType { get; set; }
        public string StreetLine1 { get; set; }
        public string StreetLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string PostalCode { get; set; }
        public string Country { get; set; }

        #endregion

        #region "Functions and Methods"
        #endregion
    }
}
