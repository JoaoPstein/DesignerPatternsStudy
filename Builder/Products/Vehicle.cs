using Builder.Components;

namespace Builder.Products
{
    public class Vehicle
    {
        public Vehicle()
        {

        }

        public Vehicle(VehicleType vehicleType, int seats,
            Engine engine, Transmission transmission, Airbag airbag)
        {
            this.vehicleType = vehicleType;
            Seats = seats;
            Engine = engine;
            Transmission = transmission;
            Airbag = airbag;
        }

        public VehicleType vehicleType { get; set; }
        public int Seats { get; set; }
        public Engine Engine { get; set; }
        public Transmission Transmission { get; set; }
        public Airbag Airbag { get; set; }
    }
}
