using System;

namespace Algorithm
{
    public class Pair
    {
        public Person YongerPerson { get; set; }
        public Person OlderPerson { get; set; }
        public TimeSpan Delta { get { return OlderPerson.BirthDate - YongerPerson.BirthDate; } }

        public Pair(Person person1, Person person2)
        {
            if (person1.IsOlderThan(person2))
            {
                OlderPerson = person1;
                YongerPerson = person2;
            }
            else {
                OlderPerson = person2;
                YongerPerson = person1;            
            }        
        }

        public Pair()
        {
            YongerPerson = OlderPerson = null;
        }

    }
}