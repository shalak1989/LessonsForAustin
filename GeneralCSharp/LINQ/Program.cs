using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ
{
    class Program
    {
        static List<Customer> customers = new List<Customer>
        {
            new Customer {Name = "bob", Age = 18, Gender = "male", Income = 40000, State = "florida"},
            new Customer {Name = "joe", Age = 32, Gender = "male", Income = 60000, State = "tennessee"},
            new Customer {Name = "sue", Age = 44, Gender = "female", Income = 32000, State = "maryland"},
            new Customer {Name = "mary", Age = 28, Gender = "female", Income = 25000, State = "ohio"},
            new Customer {Name = "issac", Age = 55, Gender = "male", Income = 50000, State = "ohio"},
            new Customer {Name = "samantha", Age = 38, Gender = "female", Income = 80000, State = "florida"},
        };

        static void Main(string[] args)
        {
            //bob and samantha
            var floridaPeople = customers.Where(x => x.State == "florida").ToList();
            PrintNames(floridaPeople, "The following people live in florida");

            //Will find everyone with an e in there name
            var peopleWithE = customers.Where(x => x.Name.Contains("e")).ToList();
            PrintNames(peopleWithE, "These people have e in their name");
            

            //People who make over 40,000
            var over40000 = customers.Where(x => x.Income > 40000).ToList();
            PrintNames(over40000, "These people make over 40,000");

            //Average income of all people
            var averageIncome = customers.Average(x => x.Income);
            Console.WriteLine("\n\nAverage income of all customers: " + averageIncome);

            //Highest income
            var highestIncome = customers.Max(x => x.Income);
            Console.WriteLine("\n\nHighest Income: " + highestIncome);

            //Select all of the names to a list and print them out
            var names = customers.Select(x => x.Name).ToList();
            Console.WriteLine("\n\nAll customer names:");
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }

            //Do all people make over 20,000?
            var everyoneMakesOver20000 = customers.All(x => x.Income > 20000);
            Console.WriteLine($"\n\nEveryone makes over $20,000: {everyoneMakesOver20000}");

            //Order customers by highest to lowest income and take the top three
            var topThreeEarners = customers.OrderByDescending(x => x.Income).Take(3);
            Console.WriteLine("\n\nTop three income earners\n");
            foreach (var earner in topThreeEarners)
            {
                Console.WriteLine($"Name: {earner.Name} Income: {earner.Income}");
            }

            Console.ReadLine();
        }

        public static void PrintNames(List<Customer> customers, string message)
        {
            Console.WriteLine("\n\n" + message);

            foreach (var person in customers)
            {
                Console.WriteLine(person.Name);
            }
        }
    }
}
