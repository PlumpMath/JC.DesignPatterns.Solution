using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.DesignPatterns.Lib
{

    //Singleton pattern ensures a class has only one instance and provide a global point of access to it.The purpose of the Singleton pattern is to ensure that there is 
    //only one instance of a class, and that there is a global access point to that object. The pattern ensures that the class is instantiated only once and that all 
    //requests are directed to that one and only object. Moreover, the object should not be created until it is actually needed. In the Singleton pattern, it is the 
    //class itself that is responsible for ensuring this constraint, not the clients of the class.
    //Use When
    //You need to ensure there is only one instance of a class.
    //Controlled access to that instance is essential.
    public class LoadBalancer
    {
        private static LoadBalancer _instance;
        private List<string> _servers = new List<string>();
        private Random _random = new Random();


        // Constructor (private), so you won't be able to create an instance of it directly, instead you need to use static instance.
        LoadBalancer()
        {
            // List of available servers
            _servers.Add("ServerI");
            _servers.Add("ServerII");
            _servers.Add("ServerIII");
            _servers.Add("ServerIV");
            _servers.Add("ServerV");
        }

        // Nested class for lazy instantiation
        class LoadBalancerCreator
        {
            static LoadBalancerCreator() { }
            // Private object instantiated with private constructor
            internal static readonly
              LoadBalancer uniqueInstance = new LoadBalancer();
        }

        // Public static property to get the object
        public static LoadBalancer UniqueInstance
        {
            get { return LoadBalancerCreator.uniqueInstance; }
        }

        
        // Simple, but effective random load balancer
        public string Server
        {
            get
            {
                int r = _random.Next(_servers.Count);
                return _servers[r].ToString();
            }
        }
    }

}
