using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters.Abstracts
{
    public interface IAuthAdapter
    {
        void Login(string username, string password);
    }
}
