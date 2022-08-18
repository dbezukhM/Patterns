using System;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    public class BasicAuthenticationHandler : AuthenticationHandler
    {
        private const string Type = "Basic";

        public override Response HandleRequest(string requestType)
        {
            if (requestType == Type)
                return SomeAction();
            else
                return base.HandleRequest(requestType);
        }

        private Response SomeAction()
        {
            return new Response { Answer = "Handling basic authentication request" };
        }
    }
}