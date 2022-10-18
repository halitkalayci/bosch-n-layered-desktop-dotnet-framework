using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace PaymentService
{

    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        bool Pay(CreatePaymentModel createPaymentModel);
    }

    // CreatePaymentModel model

    [DataContract]
    public class CreatePaymentModel
    {
        //propfull - Full Property
        private string creditCardNo = "";
        [DataMember]
        public string CreditCardNo
        {
            get { return creditCardNo; }
            set { creditCardNo = value; }
        }

        private int cvv;
        [DataMember]
        public int Cvv
        {
            get { return cvv; }
            set { cvv = value; }
        }

        private string expireDate;
        [DataMember]
        public string ExpireDate
        {
            get { return expireDate; }
            set { expireDate = value; }
        }

        private decimal price;
        [DataMember]
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }



    }
}
