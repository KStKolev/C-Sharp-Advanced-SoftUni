using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
   public class Family
    {
        private List<Person> people = new List<Person>();


        public List<Person> People { get => people; set => people = value; }

       public void AddMember(Person person) 
        {
            People.Add(person);
        }

        public Person GetOldestMember() 
        {
            Person person = new Person();
            int oldestAge = int.MinValue;
            string oldestPersonName = string.Empty;
            foreach (var currentPerson in People)
            {
                if (currentPerson.Age > oldestAge)
                {
                    oldestAge = currentPerson.Age;
                    oldestPersonName = currentPerson.Name;
                }
            }
            person.Name = oldestPersonName;
            person.Age = oldestAge;
            return person;
        }
    }
}
