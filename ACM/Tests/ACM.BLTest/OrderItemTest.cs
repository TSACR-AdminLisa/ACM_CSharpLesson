using ACM.BL;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ACM.BLTest
{
    public class OrderItemTest
    {
        [Fact]
        public void ValidateValid()
        {
            //--Arrange
            OrderItem orderItem = new OrderItem()
            {
               OrderQuantiy = 10, ProductId = 1, PurchasePrice = 100
            };

            var expected = true;

            //--Act
            var actual = orderItem.Validate();

            //--Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingProductId()
        {
            //--Arrange
            OrderItem orderItem = new OrderItem()
            {
                OrderQuantiy = 10,
                PurchasePrice = 100
            };

            var expected = false;

            //--Act
            var actual = orderItem.Validate();

            //--Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingOrderQuantity()
        {
            //--Arrange
            OrderItem orderItem = new OrderItem()
            {
                ProductId = 1,
                PurchasePrice = 100
            };

            var expected = false;

            //--Act
            var actual = orderItem.Validate();

            //--Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void ValidateMissingPurchasePrice()
        {
            //--Arrange
            OrderItem orderItem = new OrderItem()
            {
                OrderQuantiy = 10,
                ProductId = 1
            };

            var expected = false;

            //--Act
            var actual = orderItem.Validate();

            //--Assert
            Assert.Equal(expected, actual);
        }
    }
}
