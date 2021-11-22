using System;
using System.Collections.Generic;
using System.Text;

namespace FunWithGenericCollections
{
    class SortPeopleByAge : IComparer<Person>
    {
        public int Compare(Person firstObj, Person secondObj)
        {
            if (firstObj.Age > secondObj.Age)
            {
                return 1;
            }

            if (firstObj.Age < secondObj.Age)
            {
                return -1;
            }
            return 0;
        }
    }
}
