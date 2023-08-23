using Builder.Builders;
using Builder.Directors;
using Builder.Products;

VehicleBuilder builder = new VehicleBuilder();

Director director = new Director(builder);

director.ConstrutorSUV();

Vehicle vehicle = builder.GetVehicle();

Console.WriteLine($"Tipo do veiculo: {vehicle.vehicleType} Contém airbags: {vehicle.Airbag.IsAirbag}");

Console.ReadLine();