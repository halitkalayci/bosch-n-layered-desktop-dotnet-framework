using Business.Adapters.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Adapters.Concretes
{
    public class BoschAuthAdapter : IAuthAdapter
    {
        public void Login(string username, string password)
        {
            using(AuthService.AuthServiceSoapClient client = new AuthService.AuthServiceSoapClient())
            {
                client.Login(new AuthService.AuthUser() { Username = username, Password = password });
            }
        }
    }
}
