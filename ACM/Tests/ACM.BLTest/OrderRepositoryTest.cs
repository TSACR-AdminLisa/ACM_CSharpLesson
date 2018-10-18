using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.BLTest
{
    public class OrderRepositoryTest
    {
        [Fact]
        public void RetrieveExisting()
        {
            //--Arrange
            var orderRepository = new OrderRepository();
            var expected = new Order(10)
            {
                OrderDate = new DateTimeOffset(2016, 10, 02, 22, 15, 20, new TimeSpan(-6, 0, 0))
            };

            //--Act
            var actual = orderRepository.Retrieve(10);

            //--Assert
            Assert.Equal(expected.OrderId, actual.OrderId);
            Assert.Equal(expected.OrderDate, actual.OrderDate);

        }
    }
}
