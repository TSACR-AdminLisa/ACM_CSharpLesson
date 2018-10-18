using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        #region "Variables"

        #endregion

        #region "Constructors"
        public Customer():this(0)
        {
            //Default Constructor
        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            this.AddressList = new List<Address>();
        }
        #endregion

        #region "Properties"

        public static int InstanceCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public List<Address> AddressList { get; set; }
        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get
            {
                if (!String.IsNullOrEmpty(FirstName) && !String.IsNullOrEmpty(LastName))
                    return LastName + ", " + FirstName;
                else if (!String.IsNullOrEmpty(LastName) && String.IsNullOrEmpty(FirstName))
                    return LastName;
                else
                    return FirstName;
            }
        }
        #endregion

        #region "Functions"

        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        public bool Validate()
        {
            var isValid = true;

            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        #endregion
    }
}