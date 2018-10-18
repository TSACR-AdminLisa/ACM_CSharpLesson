using System;
using System.Collections.Generic;
using System.Text;

namespace ACM.BL
{
    public class AddressRepository
    {
        #region "Functionality"
        public Address Retrieve(int addressId)
        {
            Address address = new Address(addressId);

            if (addressId == 1)
            {
                address.StreetLine1 = "Bag End";
                address.StreetLine2 = "Bagshot row";
                address.City = "Hobbiton";
                address.State = "Shire";
                address.Country = "Middle Earth";
                address.PostalCode = "144";
            }

            return address;
        }

        public IEnumerable<Address> RetrieveByCustomerId(int customerId)
        {
            var addressList = new List<Address>();
            Address address = new Address(1)
            {
                AddressType = 1, StreetLine1 = "Bag End", StreetLine2 = "Bagshot row",
                City = "Hobbiton", State = "Shire",
                Country = "Middle Earth", PostalCode = "144"
            };

            addressList.Add(address);

            address = new Address(2)
            {
                AddressType = 2, StreetLine1 = "Green Dragon", City = "Bywater",
                State = "Shire", Country = "Middle Earth", PostalCode = "144"
            };

            addressList.Add(address);

            return addressList;
        }

        public bool Save(Address address)
        {
            var success = true;

            if (address.HasChanges && address.IsValid)
            {
                if (address.IsNew)
                {

                }
                else
                {

                }
            }
            return success;
        }

        #endregion
    }
}
