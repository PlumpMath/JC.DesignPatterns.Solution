using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using JC.DesignPatterns.Lib;
namespace JC.DesignPatterns.Console.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            /* AbstractFactory Test
            Factories factoryType = Factories.NokiaFactory;
            PhoneFactory factory;
            Type ftype = null;
            string phoneName = "";
            switch(factoryType)
            {
                case Factories.HTCFactory:
                    ftype = typeof(HTCFactory);
                    phoneName = "HTC 1100";
                    break;
                case Factories.NokiaFactory:
                    phoneName = "Nokia Lumina";
                    ftype = typeof(NokiaFactory);
                    break;
                case Factories.SamsungFactory:
                    phoneName = "Galaxy S4";
                    ftype = typeof(SamsungFactory);
                    break;
                default:
                    break;
            }

            factory = Activator.CreateInstance(ftype) as PhoneFactory;

            System.Console.WriteLine(factory.GetRegularPhone(phoneName).Talk());
            System.Console.WriteLine(factory.GetSmartPhone(phoneName).BrowseData());
             * */
            /* Singleton Test
            LoadBalancer b1 = LoadBalancer.UniqueInstance;
            LoadBalancer b2 = LoadBalancer.UniqueInstance;
            LoadBalancer b3 = LoadBalancer.UniqueInstance;
            LoadBalancer b4 = LoadBalancer.UniqueInstance;

            // Same instance?
            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                System.Console.WriteLine("Same instance\n");
            }

            // Load balance 15 server requests
            LoadBalancer balancer = LoadBalancer.UniqueInstance;
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                System.Console.WriteLine("Dispatch Request to: " + server);
            }
            System.Console.ReadKey();
             * */
            /* Facade Test */
            // Facade
            Mortgage mortgage = new Mortgage();

            // Evaluate mortgage eligibility for customer
            Customer customer = new Customer("Ann McKinsey");
            bool eligible = mortgage.IsEligible(customer, 125000);

            System.Console.WriteLine("\n" + customer.Name +
                " has been " + (eligible ? "Approved" : "Rejected"));

            // Wait for user
            System.Console.ReadKey();
        }
    }

    enum Factories
    {
        NokiaFactory,
        HTCFactory,
        SamsungFactory
    }
}
