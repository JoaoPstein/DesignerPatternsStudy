using ChainOfResponsability.Middlewares;
using ChainOfResponsability.Midllewares;
using ChainOfResponsability.Services;

static void Init(Server server)
{

    server = new Server();

    server.RegisterUsers("user@teste.com.br", "1234");

    server.RegisterUsers("teste@user.com.br", "1234");

    Middleware middleware = new CheckUserMiddleware(server);

    middleware.LinkWith(new CheckPermissionMiddleware());

    server.SetMiddleware(middleware);
}

Server server = new Server();

Init(server);

Boolean done;

do
{
    Console.WriteLine("Digite seu e-mail: ");
    string email = Console.ReadLine();

    Console.WriteLine("Digite sua senha: ");
    string senha = Console.ReadLine();

    done = server.LogIn(email, senha);

    Console.ReadLine();
}
while (!done);