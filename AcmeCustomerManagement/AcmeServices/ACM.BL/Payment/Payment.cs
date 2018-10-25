using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ACM.BL.Payments
{

    public enum PaymentType
    {
        CreditCard = 1,
        Paypal = 2
    }

    public class Payment
    {
        public int PaymentType { get; set; }

        public void ProcessPayment()
        {
            //this is not a recommended aproach, because of the processing cost
            if (!Enum.IsDefined(typeof(PaymentType), this.PaymentType))
            {
                throw new InvalidEnumArgumentException("Payment type", (int)this.PaymentType, typeof(PaymentType));
            }

            //most recommended option to use to validate an Enum
            PaymentType paymentTypeOption;
            if (!Enum.TryParse("creditcard", true, out paymentTypeOption))
            {
                throw new InvalidEnumArgumentException("Payment type", (int)this.PaymentType, typeof(PaymentType));
            }

            switch (paymentTypeOption)
            {
                case ACM.BL.Payments.PaymentType.CreditCard:
                    break;
                case ACM.BL.Payments.PaymentType.Paypal:
                    break;
                default:
                    throw new ArgumentException();
            }
        }
    }
}
