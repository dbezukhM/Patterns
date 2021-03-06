using System;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    public class ClientCertificateAuthenticationHandler : AuthenticationHandler
    {
        private const string Type = "ClientCertificate";

        public ClientCertificateAuthenticationHandler(AuthenticationHandler next) : base(next)
        {
        }

        public override Response handleRequest(string requestType)
        {
            if (requestType == Type)
                return SomeAction();
            else
                return base.handleRequest(requestType);
        }

        private Response SomeAction()
        {
            return new Response { Answer = "Handling client certificate authentication request" };
        }
    }
}