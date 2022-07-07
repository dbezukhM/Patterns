using System;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    public class BasicAuthenticationHandler : AuthenticationHandler
    {
        private const string Type = "Basic";

        public BasicAuthenticationHandler(AuthenticationHandler next) : base(next)
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
            return new Response { Answer = "Handling basic authentication request" };
        }
    }
}