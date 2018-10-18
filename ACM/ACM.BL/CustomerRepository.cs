using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.BL
{
    public class CustomerRepository
    {

        #region "Properties"

        private AddressRepository addressRepository { get; set; }

        #endregion

        #region "Constructors"

        public CustomerRepository()
        {
            addressRepository = new AddressRepository();
        }

        #endregion

        #region "Functions"

        public Customer Retrieve(int customerId)
        {
            Customer customer = new Customer(customerId);
            customer.AddressList = addressRepository.RetrieveByCustomerId(customerId).ToList();

            if (customerId == 1)
            {
                customer.EmailAddress = "fbaggins@hobbiton.me";
                customer.FirstName = "Frodo";
                customer.LastName = "Baggins";
            }

            return customer;
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save(Customer customer)
        {
            var success = true;

            if (customer.HasChanges && customer.IsValid)
            {
                if (customer.IsNew)
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
