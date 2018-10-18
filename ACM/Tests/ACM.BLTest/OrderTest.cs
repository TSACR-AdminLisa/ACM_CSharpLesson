using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.BLTest
{
    public class OrderTest
    {

        [Fact]
        public void ValidateValid()
        {
            //--Arrange
            Order order = new Order();
            order.OrderDate = DateTimeOffset.UtcNow;

            var expected = true;

            //--Act
            var actual = order.Validate();

            //--Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingOrderDateOffSet()
        {
            //--Arrange
            Order order = new Order();
            order.OrderDate = null;

            var expected = false;

            //--Act
            var actual = order.Validate();

            //--Assert
            Assert.Equal(expected, actual);
        }

    }
}
