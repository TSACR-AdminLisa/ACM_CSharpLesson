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

        [Fact]
        public void RetrieveOrderDisplayTest()
        {
            //--Arrange
            var orderRepository = new OrderRepository();
            var expected = new OrderDisplay()
            {
                FirstName = "Bilbo",
                LastName = "Baggins",
                OrderDate = new DateTimeOffset(2014, 4, 14, 10, 00, 00, new TimeSpan(-6, 0, 0)),
                ShippingAddress = new Address(1)
                {
                    AddressType = 1,
                    StreetLine1 = "Bag End",
                    StreetLine2 = "Bagshot row",
                    City = "Hobbiton",
                    State = "Shire",
                    Country = "Middle Earth",
                    PostalCode = "144"
                },
                OrderDisplayItemList = new List<OrderDisplayItem>()
                {
                    new OrderDisplayItem()
                    {
                        ProductName = "Sunflowers",
                        PurchacePrice = 15.96M,
                        OrderQuantity = 2
                    },
                    new OrderDisplayItem()
                    {
                        ProductName = "Rake",
                        PurchacePrice = 6M,
                        OrderQuantity = 1
                    }
                }
            };

            //--Act
            var actual = orderRepository.RetrieveOrderDisplay(10);

            //--Assert
            Assert.Equal(expected.FirstName, actual.FirstName);
            Assert.Equal(expected.LastName, actual.LastName);
            Assert.Equal(expected.OrderDate, actual.OrderDate);

            Assert.Equal(expected.ShippingAddress.AddressType, actual.ShippingAddress.AddressType);
            Assert.Equal(expected.ShippingAddress.StreetLine1, actual.ShippingAddress.StreetLine1);
            Assert.Equal(expected.ShippingAddress.StreetLine2, actual.ShippingAddress.StreetLine2);
            Assert.Equal(expected.ShippingAddress.City, actual.ShippingAddress.City);
            Assert.Equal(expected.ShippingAddress.State, actual.ShippingAddress.State);
            Assert.Equal(expected.ShippingAddress.Country, actual.ShippingAddress.Country);
            Assert.Equal(expected.ShippingAddress.PostalCode, actual.ShippingAddress.PostalCode);

            for (int i = 0; i < 1; i++)
            {
                Assert.Equal(expected.OrderDisplayItemList[i].OrderQuantity, actual.OrderDisplayItemList[i].OrderQuantity);
                Assert.Equal(expected.OrderDisplayItemList[i].ProductName, actual.OrderDisplayItemList[i].ProductName);
                Assert.Equal(expected.OrderDisplayItemList[i].PurchacePrice, actual.OrderDisplayItemList[i].PurchacePrice);
            }

        }
    }
}
