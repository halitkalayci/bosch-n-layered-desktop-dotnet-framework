using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
using System.Xml.Linq;

namespace AuthService
{
    /// <summary>
    /// Summary description for AuthService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AuthService : System.Web.Services.WebService
    {
        public AuthUser AuthUser;
        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }
        [WebMethod]
        [SoapHeader("AuthUser",Required =true)]
        public string SayHi(string name)
        {
            //admin
            if(AuthUser == null || !AuthUser.IsAuthenticated(new string[] {"hi"}))
            {
                throw new HttpException(401, "Unauthorized");
            }
            return $"Hello {name}";
        }

        [WebMethod]
        [SoapHeader("AuthUser",Required=true)]
        public bool Login()
        {
            if (AuthUser == null || !AuthUser.IsAuthenticated())
            {
                throw new HttpException(401, "Unauthorized");
            }
            return true;
        }

        // WebMethod oluştur.
        // Sipariş oluşturmak için "sales" rolü gereksin.
        // login page
        // return true;


    }
}
