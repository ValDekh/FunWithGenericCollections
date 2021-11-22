using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithGenericCollections
{
    static class UserGenericIsQueque
    {
        static void UserGenericIsQuequeM()
        {
            Queue<Person> peopleQ = new Queue<Person>();
            peopleQ.Enqueue(new Person("Lala", "Ivanchuk", 68));
            peopleQ.Enqueue(new Person("Nikolai", "Ivanchuk", 70));
            peopleQ.Enqueue(new Person { FirstName = "Olgha", LastName = "Borisova", Age = 33 });

            static void GotCofee(Person p)
            {
                Console.WriteLine($"{p.FirstName} got coffee!");
            }

            for (int i = 0; i < peopleQ.Count; i++)
            {
                GotCofee(peopleQ.Dequeue());
            }

            try
            {
                GotCofee(peopleQ.Dequeue());
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error! {ex.Message}");
            }
        }
    }
}
