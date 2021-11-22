using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithGenericCollections
{
    static class UseGenericStack
    {
        static void UseGenericStackM()
        {
            Stack<Person> stackOfPerson = new Stack<Person>();
            stackOfPerson.Push(new Person("Lala", "Ivanchuk", 68));
            stackOfPerson.Push(new Person("Nikolai", "Ivanchuk", 70));
            stackOfPerson.Push(new Person { FirstName = "Olgha", LastName = "Borisova", Age = 33 });

            Console.WriteLine($"First person is: {stackOfPerson.Peek()}");
            Console.WriteLine($"Popped it off: {stackOfPerson.Pop()}");

            Console.WriteLine($"\nFirst is: {stackOfPerson.Peek()}");
            Console.WriteLine($"Popped it off: {stackOfPerson.Pop()}");

            Console.WriteLine($"\nFirst is: {stackOfPerson.Peek()}");
            Console.WriteLine($"Popped it off: {stackOfPerson.Pop()}");

            try
            {
                Console.WriteLine($"\nFirst is: {stackOfPerson.Peek()}");
                Console.WriteLine($"Popped it off: {stackOfPerson.Pop()}");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine($"Error!! {ex.Message}");
            }
        }
    }
}
