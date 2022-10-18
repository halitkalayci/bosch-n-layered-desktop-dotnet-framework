using Business.Adapters.Abstracts;
using Business.PaymentService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters.Concretes
{
    public class BoschPaymentAdapter : IPaymentAdapter
    {
        public bool Pay(string cardNumber, string expireDate, int cvv, decimal price)
        {
            bool isSuccess = false;
            using (PaymentService.Service1Client paymentClient = new PaymentService.Service1Client())
            {
                CreatePaymentModel model = new CreatePaymentModel()
                {
                    CreditCardNo = cardNumber,
                    ExpireDate = expireDate,
                    Cvv = cvv,
                    Price = price
                };
                isSuccess = paymentClient.Pay(model);
            }
            return isSuccess;
        }
    }
}
