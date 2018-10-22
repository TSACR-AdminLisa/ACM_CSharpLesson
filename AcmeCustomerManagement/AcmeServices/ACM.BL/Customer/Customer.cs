using System;

namespace ACM.BL.Customers
{
    public class Customer
    {
        #region "Properties"

        public int CustomerId { get; set; }
        public string EmailAddress { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public void ValidateEmail()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
