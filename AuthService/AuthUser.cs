using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace AuthService
{
    public class AuthUser : SoapHeader
    {
        public string Username { get; set; }
        public string Password { get; set; }


        public bool IsAuthenticated(string[] roles=null)
        {
            // DB bağlantısı yapılır, db'den kullanıcı çekilir.
            // DB'den kullanıcıyı getir, db'den rolleri getir.
            string[] userRoles = new string[] { "admin", "create" };

            
            if(Username != "halit" || Password != "123")
            {
                return false;
            }

            if (roles != null)
            {
                var hasRole = false;
                foreach(string role in roles)
                {
                    if (userRoles.Contains(role))
                    {
                        hasRole = true;
                    }
                }
                return hasRole;
            }

            return true;
        }
    }
}