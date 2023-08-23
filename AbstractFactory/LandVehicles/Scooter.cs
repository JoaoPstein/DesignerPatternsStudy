using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory.LandVehicles
{
    public class Scooter : ILandVehicle
    {
        protected void CheckBatery()
        {
            Console.WriteLine("Bateria completa, disponivel para uso!");
        }

        public void GetCargo()
        {
            Console.WriteLine("Pegamos o patinet e vimos o local entrega!");
        }

        public void StarRoute()
        {
            CheckBatery();
            GetCargo();
            Console.WriteLine("Iniciamos a rota de entrega");
        }
    }
}
