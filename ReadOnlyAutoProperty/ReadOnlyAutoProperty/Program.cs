using System;

namespace ReadOnlyAutoProperty
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer("firstName", "lastName");
            Console.WriteLine(customer.FirstName + " " + customer.LastName);
            Console.ReadLine();
        }
    }

    public class Customer
    {
        // Readonly properties
        // Can only be set in the constructor
        public string FirstName { get; }
        public string LastName { get; }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void ChangeName(string newFirstName)
        {   
            // This generates an error cuz its readonly
            //FirstName = newFirstName;
        }
    }
}
