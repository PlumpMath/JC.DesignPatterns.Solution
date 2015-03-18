using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JC.DesignPatterns.Lib
{
    //Facade pattern provides a unified interface to a set of interfaces in a subsystem.
    //It knows which subsystem classes are responsible for a request and delegates client requests to appropriate subsystem objects.
    //Subsystem classes handle work assigned by the Facade object and they have no knowledge of the facade and keep no reference to it.
    //Hiding detail is a key programming concept. What makes the Façade pattern different from

    /// <summary>
    /// The 'Subsystem Class' class
    /// </summary>
    class Bank
    {
        public bool HasSufficientSavings(Customer c, int amount)
        {
            Console.WriteLine("Check bank for " + c.Name);
            return true;
        }
    }

    /// <summary>
    /// The 'Subsystem Class' class
    /// </summary>
    class Credit
    {
        public bool HasGoodCredit(Customer c)
        {
            Console.WriteLine("Check credit for " + c.Name);
            return true;
        }
    }

    /// <summary>
    /// The 'Subsystem Class' class
    /// </summary>
    class Loan
    {
        public bool HasNoBadLoans(Customer c)
        {
            Console.WriteLine("Check loans for " + c.Name);
            return true;
        }
    }
    public class Customer
    {
        private string _name;

        // Constructor
        public Customer(string name)
        {
            this._name = name;
        }

        // Gets the name
        public string Name
        {
            get { return _name; }
        }
    }

    /// <summary>
    /// The 'Facade' class
    /// </summary>
    public class Mortgage
    {
        private Bank _bank = new Bank();
        private Loan _loan = new Loan();
        private Credit _credit = new Credit();

        public bool IsEligible(Customer cust, int amount)
        {
            Console.WriteLine("{0} applies for {1:C} loan\n",
              cust.Name, amount);

            bool eligible = true;

            // Check creditworthyness of applicant
            if (!_bank.HasSufficientSavings(cust, amount))
            {
                eligible = false;
            }
            else if (!_loan.HasNoBadLoans(cust))
            {
                eligible = false;
            }
            else if (!_credit.HasGoodCredit(cust))
            {
                eligible = false;
            }

            return eligible;
        }
    }
}
