using System;
using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AuthenticationHandler chain =
                new BasicAuthenticationHandler(
                    new ClientCertificateAuthenticationHandler(new DigestAuthenticationHandler(null)));

            var response1 = chain.handleRequest("ClientCertificate");
            var response2 = chain.handleRequest("Diges");
            var response3 = chain.handleRequest("Basic");

            Console.WriteLine(response1?.Answer);
            Console.WriteLine(response2?.Answer);
            Console.WriteLine(response3?.Answer);
        }
    }
}