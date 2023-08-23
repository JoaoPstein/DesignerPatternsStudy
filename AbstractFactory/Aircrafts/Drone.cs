namespace AbstractFactory.Aircrafts
{
    internal class Drone : IAircraft
    {
        public void CheckWind()
        {
            Console.WriteLine("Verificando vendo," +
                " aproximadamente 10km/h, aprovado subida do drone");
        }

        public void GetCargo()
        {
            Console.WriteLine("Encomenda adptada ao drone para entrega.");
        }

        public void StarRoute()
        {
            Console.WriteLine("Drone subiu e foi ao destino de entraga.");
        }
    }
}
