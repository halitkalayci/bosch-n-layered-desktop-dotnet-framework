using Business.Adapters.Abstracts;
using Business.KPSService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters.Concretes
{
    public class KPSIdentityAdapter : IIdentityAdapter
    {
        public bool CheckIdentityNumber(long identityNumber, string name, string surname, int birthYear)
        {
            using(KPSPublicSoapClient client = new KPSPublicSoapClient())
            {
                return client.TCKimlikNoDogrula(identityNumber, name, surname, birthYear);
            }
        }
    }
}
