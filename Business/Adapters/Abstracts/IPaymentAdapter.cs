using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters.Abstracts
{
    public interface IPaymentAdapter
    {
        bool Pay(string cardNumber, string expireDate,int cvv,decimal price);
    }
}
