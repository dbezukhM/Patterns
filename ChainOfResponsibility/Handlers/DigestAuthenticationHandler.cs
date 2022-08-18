using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    public class DigestAuthenticationHandler : AuthenticationHandler
    {
        private const string Type = "Digest";
        
        public override Response HandleRequest(string requestType)
        {
            if (requestType == Type)
                return SomeAction();
            else
                return base.HandleRequest(requestType);
        }

        private Response SomeAction()
        {
            return new Response { Answer = "Handling digest authentication request" };
        }
    }
}