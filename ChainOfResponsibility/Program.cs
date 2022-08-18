using System;
using ChainOfResponsibility.Handlers;
using ChainOfResponsibility.Models;

namespace ChainOfResponsibility
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AuthenticationHandler chain = new BasicAuthenticationHandler();
            chain.SetNext(new ClientCertificateAuthenticationHandler()).SetNext(new DigestAuthenticationHandler());

            var response1 = chain.HandleRequest("ClientCertificate");
            var response2 = chain.HandleRequest("Digest");
            var response3 = chain.HandleRequest("Basic");

            Console.WriteLine(response1?.Answer);
            Console.WriteLine(response2?.Answer);
            Console.WriteLine(response3?.Answer);
        }
    }
}