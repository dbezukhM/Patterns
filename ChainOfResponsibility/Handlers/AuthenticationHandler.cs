using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    public abstract class AuthenticationHandler
    {
        private AuthenticationHandler _next;

        public AuthenticationHandler SetNext(AuthenticationHandler next)
        {
            _next = next;
            return next;
        }

        public virtual Response HandleRequest(string requestType)
        {
            return _next?.HandleRequest(requestType);
        }
    }
}