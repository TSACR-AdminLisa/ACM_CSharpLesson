using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.BLTest
{
    public class AddressRepositoryTest
    {
        [Fact]
        public void RetrieveExisting()
        {
            //--Arrange
            var addressRepository = new AddressRepository();
            var expected = new Address(1)
            {
                StreetLine1 = "Bag End", StreetLine2 = "Bagshot row",
                City = "Hobbiton", State = "Shire",
                Country = "Middle Earth", PostalCode = "144"
            };

            //--Act
            var actual = addressRepository.Retrieve(1);

            //--Assert
            Assert.Equal(expected.AddressId, actual.AddressId);
            Assert.Equal(expected.StreetLine1, actual.StreetLine1);
            Assert.Equal(expected.StreetLine2, actual.StreetLine2);
            Assert.Equal(expected.City, actual.City);
            Assert.Equal(expected.State, actual.State);
            Assert.Equal(expected.Country, actual.Country);
            Assert.Equal(expected.PostalCode, actual.PostalCode);
        }
    }
}
