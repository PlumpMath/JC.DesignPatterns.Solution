using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.DesignPatterns.Lib
{
    //Factory Method:
    //Define an interface for creating an object, but let subclasses decide which class to instantiate. Various subclasses might implement the interface; 
    //the Factory Method instantiates the appropriate subclass based on information supplied by the client.

    //Use when
    //Flexibility is important.
    //Objects can be extended in subclasses
    public abstract class Product
    {
        public double Price { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }

    public class ElectronicProduct : Product
    {
        public ElectronicProduct(double price, string name, string description)
        {
            base.Price = price;
            base.Name = name;
            base.Description = description;
        }
    }

    public class FurnitureProduct : Product
    {
        public FurnitureProduct(double price, string name, string description)
        {
            base.Price = price;
            base.Name = name;
            base.Description = description;
        }
    }

    public abstract class ProductSupplier
    {
        public abstract Product SupplyProduct(double price, string name, string description);//abstract factory method, defines an interface for creating an object
    }

    public class ElectronicProductSupplier : ProductSupplier // let subclasses decide which class to instantiate. 
    {
        public override Product SupplyProduct(double price, string name, string description)
        {
            return new ElectronicProduct( price,  name,  description);
        }
    }

    public class FurnitureProductSupplier : ProductSupplier
    {
        public override Product SupplyProduct(double price, string name, string description)
        {
            return new FurnitureProduct( price,  name,  description);
        }
    }
}
