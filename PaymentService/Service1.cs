using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PaymentService
{
    public class Service1 : IService1
    {
        public bool Pay(CreatePaymentModel createPaymentModel)
        {
            // Payment işlemi
            if (createPaymentModel.Price > 100)
                return false;
            return true;
        }
    }
}
