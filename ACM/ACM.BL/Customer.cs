using System;

namespace ACM.BL
{
    public class Customer
    {
        #region "Variables"

        private string _lastName;

        #endregion

        #region "Properties"

        public string FirstName { get; set; }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
            }
        }

        public string EmailAddress { get; set; }
        public int CustomerId { get; private set; }
        public string FullName
        {
            get
            {
                return LastName + "," + FirstName;
            }
        }
        #endregion
    }
}
