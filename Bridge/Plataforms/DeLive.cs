using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bridge.Plataforms
{
    public class DeLive : IPlatform
    {
        public DeLive()
        {
            ConfigureRMTP();
            Console.WriteLine("DeLive: Transmissão iniciada.");
        }

        public void AuthToken()
        {
            Console.WriteLine("DeLive: Autorizando aplicação.");
        }

        public void ConfigureRMTP()
        {
            AuthToken();
            Console.WriteLine("DeLive: Configurando servidor RMTP.");
        }
    }
}
