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
        public void StaticTest()
        {
            //--Arrange
            Customer customer1 = new Customer();
            customer1.FirstName = "Baggins";
            Customer.InstanceCount += 1;

            Customer customer2 = new Customer();
            customer2.FirstName = "Frodo";
            Customer.InstanceCount += 1;

            Customer customer3 = new Customer();
            customer3.FirstName = "Rosie";
            Customer.InstanceCount += 1;

            //string expected1 = "Baggins";

            //--Act
            //string actual = customer.FullName;


            //--Assert
            Assert.Equal(3, Customer.InstanceCount);

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
