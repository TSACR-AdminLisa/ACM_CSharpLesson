using ACM.BL.Customers;
using ACM.BL.Inventories;
using ACM.BL.Payments;
using Core.Common;
using System;
using System.Collections.Generic;
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

        public void PlaceOrder(Customer customer, Order order, Payment payment, bool allowSplitOrders, bool emailReceipt)
        {
            var customerRepository = new CustomerRepository();
            customerRepository.Add(customer);

            var orderRepository = new OrderRepository();
            orderRepository.Add(order);

            var inventoryRepository = new InventoryRepository();
            inventoryRepository.OrderItems(order, allowSplitOrders);

            payment.ProcessPayment(payment);

            if (emailReceipt)
            {
                var result = customer.ValidateEmailObject();
                if (result.Success)
                {
                    customerRepository.Update();

                    var emailLibrary = new EmailLibrary();
                    emailLibrary.SendEmail(customer.EmailAddress, "Her is your receipt!");
                }
            }
        }

    }
}
