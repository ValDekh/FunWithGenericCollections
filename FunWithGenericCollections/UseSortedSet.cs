using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithGenericCollections
{
    static class UseSortedSet
    {
        public static void UseSortedSedM()
        {
            SortedSet<Person> setOfpeople = new SortedSet<Person>(new SortPeopleByAge())
            {
            new Person {FirstName = "Homer", LastName = "Simpson", Age = 48},
            new Person {FirstName= "Marge", LastName="Simpson", Age=45},
            new Person {FirstName= "Lisa", LastName="Simpson", Age=9},
            new Person {FirstName= "Bart", LastName="Simpson", Age=8}
            };
            foreach (Person p in setOfpeople)
            {
                Console.WriteLine(p);
            }

            setOfpeople.Add(new Person("Siake", "Jhobes", 1));
            setOfpeople.Add(new Person("Vitovt", "Armande", 32));
            foreach (Person p in setOfpeople)
            {
                Console.WriteLine(p);
            }
        }

    }
}
