using ChainOfResponsibility.Models;

namespace ChainOfResponsibility.Handlers
{
    public abstract class AuthenticationHandler
    {
        private readonly AuthenticationHandler _next;

        protected AuthenticationHandler(AuthenticationHandler next)
        {
            _next = next;
        }

        public virtual Response handleRequest(string requestType)
        {
            return _next?.handleRequest(requestType);
        }
    }
}