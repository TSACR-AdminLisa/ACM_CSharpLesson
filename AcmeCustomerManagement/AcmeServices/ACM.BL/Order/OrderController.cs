using ACM.BL.Customers;
using ACM.BL.Inventories;
using ACM.BL.Payments;
using Core.Common;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ACM.BL.Orders
{
    public class OrderController
    {
        #region "Properties"
        private CustomerRepository customerRepository { get; set; }
        private OrderRepository orderRepository { get; set; }
        private InventoryRepository inventoryRepository { get; set; }
        private EmailLibrary emailLibrary { get; set; }
        #endregion

        #region "Constructor"
        public OrderController()
        {
            customerRepository = new CustomerRepository();
            orderRepository = new OrderRepository();
            inventoryRepository = new InventoryRepository();
            emailLibrary = new EmailLibrary();
        }
        #endregion

        public OperationResult PlaceOrder(Customer customer, Order order, Payment payment, bool allowSplitOrders, bool emailReceipt)
        {
            //assert values just for debug configuration
            Debug.Assert(customerRepository == null, "Missing customer repository instance");
            Debug.Assert(orderRepository == null, "Missing order repository instance");
            Debug.Assert(inventoryRepository == null, "Missing inventory repository instance");
            Debug.Assert(emailLibrary == null, "Missing email library instance");

            //validates parameter object instances
            if (customer == null) throw new ArgumentException("Customer instance is null");
            if (order == null) throw new ArgumentException("Order instance is null");
            if (payment == null) throw new ArgumentException("Payment instance is null");

            var op = new OperationResult();

            customerRepository.Add(customer);

            orderRepository.Add(order);

            inventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProcessPayment();

            if (emailReceipt)
            {
                var result = customer.ValidateEmailObject();
                if (result.Success)
                {
                    var emailLibrary = new EmailLibrary();
                    emailLibrary.SendEmail(customer.EmailAddress, "Her is your receipt!");
                }
                else
                {
                    if (result.MessageList.Any())
                    {
                        op.AddMessage(result.MessageList[0]);
                    }
                }
            }

            return op;
        }

    }
}
