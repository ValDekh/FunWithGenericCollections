using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithGenericCollections
{
   public class Person
    {
        public int Age {get; set;}
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Person() { }
        public Person(string firstName, string lastName, int age)
        {
            this.Age = age;
            this.FirstName = firstName;
            this.LastName = lastName;
        }
        public override string ToString()
        {
            return $"Name: {FirstName} {LastName}, Age: {Age} ";
        }

    }
}
