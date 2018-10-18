using Acme.Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using ACM.BL;
using Acme.Common;

namespace Acme.CommonTest
{
    public class LoggingServiceTest
    {
        [Fact]
        public void WriteToFileTest()
        {
            //-- Arrange
            var changedItems = new List<ILoggable>();

            var customer = new Customer(1)
            {
                EmailAddress = "fbaggins@hobbiton.me",
                FirstName = "Frodo",
                LastName = "Baggins",
                AddressList = null
            };
            changedItems.Add(customer as ILoggable);

            var product = new Product(2)
            {
                ProductName = "Rake",
                ProductDescription = "Garden Rake with Steel Head",
                CurrentPrice = 6M
            };
            changedItems.Add(product as ILoggable);

            //-- Act
            LoggingService.WriteToFile(changedItems);

            //-- Assert
            //Nothing here to assert
        }
    }
}
