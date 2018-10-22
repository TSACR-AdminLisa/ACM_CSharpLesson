using ACM.BL;
using ACM.BL.Customers;
using ACM.BL.Inventories;
using ACM.BL.Orders;
using ACM.BL.Payments;
using Core.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAppServices.Helpers
{
    public class CustomerHelper
    {

        public void PlaceOrder()
        {
            var customer = new Customer();
            //populate the customer instance

            var order = new Order();
            //populate the order instance

            var payment = new Payment();
            //populate the payment info from the UI

            var orderController = new OrderController();
            //this method has named parameteres like [parametername]:[parametervalue]
            orderController.PlaceOrder(customer, order, payment, allowSplitOrders:false, emailReceipt:true);
        }
    }
}
