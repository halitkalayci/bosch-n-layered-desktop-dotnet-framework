using Business.Adapters.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters.Concretes
{
    public class TCKNIdentityAdapter : IIdentityAdapter
    {
        public bool CheckIdentityNumber(long identityNumber, string name, string surname, int birthYear)
        {
            return false;
        }
    }
}
