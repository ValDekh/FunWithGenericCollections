using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithGenericCollections
{
    static class UseGenericList
    {
        static void UseGenericListM()
        {
            List<Person> people = new List<Person>()
                {
                    new Person {FirstName = "Lala", LastName = "Ivanchuk", Age = 68 },
                    new Person {FirstName = "Nikolai", LastName = "Ivanchuk", Age = 70 },
                    new Person {FirstName = "Olgha", LastName = "Borisova", Age = 33},
                    new Person {FirstName = "Boris", LastName = "Borisov", Age = 36}
                };
            Console.WriteLine($"Items in the list {people.Count}");

            foreach (Person p in people)
            {
                Console.WriteLine(p);
            }

            people.Insert(3, new Person { FirstName = "Jerar", LastName = "Viljan", Age = 35 });
            Console.WriteLine($"Itens in the list {people.Count}");
            Person[] arrayOfPeople = people.ToArray();
            foreach (Person p in arrayOfPeople)
            {
                Console.WriteLine($"{p.FirstName} is their First Name");
            }
        }
    }
}
