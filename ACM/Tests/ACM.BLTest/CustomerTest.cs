using System;
using Xunit;
using ACM.BL;

namespace ACM.BLTest
{
    public class CustomerTest
    {
        [Fact]
        public void FullNameTestValid()
        {
            //--Arrange
            Customer customer = new Customer()
            {
              FirstName = "Bilbo", LastName = "Baggins"
            };

            string expected = "Baggins, Bilbo";

            //--Act
            string actual = customer.FullName;


            //--Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void FullNameFirstNameEmptyTest()
        {
            //--Arrange
            Customer customer = new Customer()
            {
                FirstName = "Baggins"
            };

            string expected = "Baggins";

            //--Act
            string actual = customer.FullName;


            //--Assert
            Assert.Equal(expected, actual);

        }

        [Fact]
        public void FullNameLastNameEmptyTest()
        {
            //--Arrange
            Customer customer = new Customer()
            {
                LastName = "Bilbo"
            };

            string expected = "Bilbo";

            //--Act
            string actual = customer.FullName;


            //--Assert
            Assert.Equal(expected, actual);

        }
    }
}
