using System;
using System.Collections.Generic;
using FunWithGenericCollections;

namespace FunWithGenericCollections
{
    class Program
    {
        private static void UseDictionaryM()
        {
            Dictionary<string, Person> peopleA = new Dictionary<string, Person>();
            peopleA.Add("Homer", new Person { FirstName = "Homer", LastName = "Simpson", Age = 47 });
            peopleA.Add("Marge", new Person("Marge", "Simpson", 45));
            peopleA.Add("Lisa", new Person("Lisa", "Simpson", 12));

            Person homer = peopleA["Homer"];
            Console.WriteLine(homer);
            Dictionary<string, Person> peopleB = new Dictionary<string, Person>()
            {
                {"Homer", new Person ("Homer", "Simpson", 47)},
                {"Marge",new Person("Marge", "Simpson", 45)},
                {"Lisa",  new Person("Lisa", "Simpson", 12)}
            };

            Person lisa = peopleB["Lisa"];
            Console.WriteLine(lisa);
        }
        static void Main(string[] args)
        {
            //  UseGenericList();
            // UseGenericStack();
           // UseSortedSet.UseSortedSedM();
            UseDictionaryM();
        }
    }
}
