using ACM.BL.Customers;
using ACM.BL.Orders;
using ACM.BL.Payments;
using Core.Common;
using System;
using Xunit;

namespace ACM.BLTest.Orders
{
    public class OrderControllerTest
    {
        [Fact]
        public void PlaceOrderTest()
        {
            //--Arrange
            var orderController = new OrderController();
            var customer = new Customer() { EmailAddress = "liza.varela@indecomm.net" };
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };

            //--Act
            OperationResult op = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReceipt: true);

            //--Assert
            Assert.True(op.Success);
            Assert.Empty(op.MessageList);

        }

        [Fact]
        public void PlaceOrderTestInvalidEmail()
        {
            //--Arrange
            var orderController = new OrderController();
            var customer = new Customer() { EmailAddress = "" };
            var order = new Order();
            var payment = new Payment() { PaymentType = 1 };

            //--Act
            OperationResult op = orderController.PlaceOrder(customer, order, payment, allowSplitOrders: true, emailReceipt: true);

            //--Assert
            Assert.True(op.Success);
            Assert.Single(op.MessageList);
            Assert.Equal("Email address is null", op.MessageList[0]);

        }
    }
}
