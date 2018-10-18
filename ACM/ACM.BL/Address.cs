using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class Address : EntityBase
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

        public override bool Validate()
        {
            var isValid = true;

            if (AddressType <= 0) isValid = false;
            if (String.IsNullOrWhiteSpace(StreetLine1)) isValid = false;
            if (String.IsNullOrWhiteSpace(StreetLine2)) isValid = false;
            if (String.IsNullOrWhiteSpace(City)) isValid = false;
            if (String.IsNullOrWhiteSpace(State)) isValid = false;
            if (String.IsNullOrWhiteSpace(PostalCode)) isValid = false;
            if (String.IsNullOrWhiteSpace(Country)) isValid = false;

            return isValid;
        }

        #endregion
    }
}
