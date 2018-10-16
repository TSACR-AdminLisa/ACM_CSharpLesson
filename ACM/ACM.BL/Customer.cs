using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer
    {
        #region "Variables"

        private string _lastName;

        #endregion

        #region "Properties"

        public static int InstanceCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
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

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
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