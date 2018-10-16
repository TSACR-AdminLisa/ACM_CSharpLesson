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
                if (!String.IsNullOrEmpty(FirstName) && !String.IsNullOrEmpty(LastName))
                    return LastName + ", " + FirstName;
                else if (!String.IsNullOrEmpty(LastName) && String.IsNullOrEmpty(FirstName))
                    return LastName;
                else
                    return FirstName;
            }
        }
        #endregion
    }
}
 