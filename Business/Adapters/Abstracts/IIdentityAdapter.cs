using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters.Abstracts
{
    public interface IIdentityAdapter
    {
        bool CheckIdentityNumber(long identityNumber,string name,string surname, int birthYear);
    }
}
