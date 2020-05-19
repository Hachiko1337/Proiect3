using System;
using System.ServiceModel;
using System.ServiceModel.Description;
using Proiect2ObjectWCF;

namespace Proiect2Host
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Launching WCF Server...");
            ServiceHost host = new ServiceHost(typeof(FileMetadataProperty), new Uri("http://localhost:8000/PC"));
            foreach (ServiceEndpoint se in host.Description.Endpoints) Console.WriteLine(
                "A (address): {0} \nB (binding): {1} \nC (Contract): {2}\n", se.Address, se.Binding.Name,
                se.Contract.Name);
            host.Open();
            Console.WriteLine("Server is up. Awaiting connections...");
            Console.WriteLine("Press Enter to stop the server!");
            Console.ReadKey();
            host.Close();
        }
    }
}
