using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topshelf;

namespace TestService
{
    class Program
    {
        static void Main(string[] args)
        {

            HostFactory.Run(x =>
            {
                x.Service<HttpApiService>(s =>
                {                   
                    s.ConstructUsing(name => new HttpApiService(new Uri("http://localhost:8080")));        
                    s.WhenStarted(tc => tc.Start());
                    s.WhenStopped(tc => tc.Stop());
                });
                x.RunAsLocalSystem();
                x.StartManually();
                x.SetDescription("Sample Web API Windows service");
                x.SetDisplayName("Znachor.WebApiTopShelfService");
                x.SetServiceName("Znachor.WebApiTopShelfService");
            });
        }
    }
}
