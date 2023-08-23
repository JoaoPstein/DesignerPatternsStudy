using AbstractFactory.App;
using AbstractFactory.Factories;

Application ConfigureApplication()
{
    Application app;

    ITransportFactory transportFactory;

    string company = "Line";

    if (company == "Uber")
        transportFactory = new UberTransport();
    else if(company == "Nine")
        transportFactory = new NineNineTransport();
    else
        transportFactory = new LineTransport();

    app = new Application(transportFactory);

    return app;
}

Application app = ConfigureApplication();

app.StartRoute();

Console.ReadLine();