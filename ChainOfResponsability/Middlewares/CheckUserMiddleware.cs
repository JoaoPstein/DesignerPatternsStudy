﻿using ChainOfResponsability.Midllewares;
using ChainOfResponsability.Services;

namespace ChainOfResponsability.Middlewares
{
    internal class CheckUserMiddleware : Middleware
    {
        private Server _server;

        public CheckUserMiddleware(Server server)
        {
            _server = server;
        }
        

        public override bool Check(string email, string password)
        {
            if(!_server.HasEmail(email))
            {
                Console.WriteLine("E-mail inválido!");
                return false;
            }

            if(!_server.IsValidPassword(email, password))
            {
                Console.WriteLine("E-mail e/ou senha inválidos!");
                return false;
            }

            return CheckNext(email, password);
        }
    }
}
