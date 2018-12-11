using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace TestService
{
   public class ServiceController : ApiController
    {

        public string Hello()
        {
            return "Cześc co sie szczypiesz?";
        }


        //http://localhost:8080/api/service?tekst=dupa
        public string get(string tekst)
        {
            return $"Hmm ... {tekst}? Nieźle niezle!";
        }

    }
}
