using AbstractFactory.Aircrafts;
using AbstractFactory.Factories;
using AbstractFactory.LandVehicles;

namespace AbstractFactory.App
{
    public class Application
    {
        private readonly IAircraft _aircraft;
        private readonly ILandVehicle _landVehicle;

        public Application(ITransportFactory factory)
        {
            _aircraft = factory.CreateTransportAircraft();
            _landVehicle = factory.CreateTransportVehicle();
        }

        public void StartRoute()
        {
            _landVehicle.StarRoute();
            _aircraft.StarRoute();
        }
    }
}
