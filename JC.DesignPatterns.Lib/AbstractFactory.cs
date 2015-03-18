using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.DesignPatterns.Lib
{
    //Abstract Factory
    //Provide an interface for creating families of related or dependent objects without specifying their concrete classes.
    #region Abstract and Concrete Products

    public abstract class RegularPhone
    {
        public abstract string Name{get;set;}
        public abstract string Talk();
    }

    public class NokiaR : RegularPhone
    {
        public NokiaR(string name)
        {
            Name = name;
        }
        public override string Name { get; set; }
        public override string Talk()
        {
            return Name + " can talk now";
        }
    }
    public class HTCR : RegularPhone
    {
        public HTCR(string name)
        {
            Name = name;
        }
        public override string Name { get; set; }
        public override string Talk()
        {
            return Name + " can talk now";
        }
    }
    public class SamsungR : RegularPhone
    {
        public SamsungR(string name)
        {
            Name = name;
        }
        public override string Name { get; set; }
        public override string Talk()
        {
            return Name + " can talk now";
        }
    }

    public abstract class SmartPhone
    {
        public abstract string Name{get;set;}
        public abstract string Talk();
        public abstract string BrowseData();
    }

    public class NokiaS : SmartPhone
    {
        public NokiaS(string name)
        {
            Name = name;
        }
        public override string Name { get; set; }
        public override string Talk()
        {
            return Name + " can talk now";
        }
        public override string BrowseData()
        {
            return Name + " can browse data now";
        }
    }

    public class HTCS : SmartPhone
    {
        public HTCS(string name)
        {
            Name = name;
        }
        public override string Name { get; set; }
        public override string Talk()
        {
            return Name + " can talk now";
        }
        public override string BrowseData()
        {
            return Name + " can browse data now";
        }
    }

    public class SamsungS : SmartPhone
    {
        public SamsungS(string name)
        {
            Name = name;
        }
        public override string Name { get; set; }
        public override string Talk()
        {
            return Name + " can talk now";
        }
        public override string BrowseData()
        {
            return Name + " can browse data now";
        }
    }
    #endregion
    
    #region Abstract and Concrete Factory

    public abstract class PhoneFactory
    {
        public abstract SmartPhone GetSmartPhone(string name);
        public abstract RegularPhone GetRegularPhone(string name);
    }

    public class NokiaFactory : PhoneFactory
    {
        public override SmartPhone GetSmartPhone(string name)
        {
            return new NokiaS(name);
        }

        public override RegularPhone GetRegularPhone(string name)
        {
            return new NokiaR(name);
        }
    }

    public class HTCFactory : PhoneFactory
    {
        public override SmartPhone GetSmartPhone(string name)
        {
            return new HTCS(name);
        }

        public override RegularPhone GetRegularPhone(string name)
        {
            return new HTCR(name);
        }
    }

    public class SamsungFactory : PhoneFactory
    {
        public override SmartPhone GetSmartPhone(string name)
        {
            return new SamsungS(name);
        }

        public override RegularPhone GetRegularPhone(string name)
        {
            return new SamsungR(name);
        }
    }
    #endregion
}
