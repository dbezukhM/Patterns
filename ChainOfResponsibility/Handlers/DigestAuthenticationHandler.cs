using System;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    public class DigestAuthenticationHandler : AuthenticationHandler
    {
        private const string Type = "Diges";

        public DigestAuthenticationHandler(AuthenticationHandler next) : base(next)
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
            return new Response { Answer = "Handling digest authentication request" };
        }
    }
}