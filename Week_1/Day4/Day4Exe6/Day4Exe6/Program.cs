using System;
using System.Collections.Generic;
using System.Linq;

namespace Day4Exe6
{
    internal class Program
    {
        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int Age { get; set; }

            public Person(string fname, string lname, int age)
            {
                FirstName = fname;
                LastName = lname;
                Age = age;
            }
        }

        static void Main(string[] args)
        {
            List<Person> people = new List<Person>
            {
                new Person("John", "Doe", 18),
                new Person("Alice", "Smith", 5),
                new Person("Bob", "Johnson", 22),
                new Person("Emily", "Brown", 16),
                new Person("Michael", "Davis", 28)
            };

            int minAge = 18;
            var filteredPeople = people.Where(p => p.Age >= minAge);
            Console.WriteLine("People above {0} years old:", minAge);
            foreach (var person in filteredPeople)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2}", person.FirstName, person.LastName, person.Age);
            }
            Console.WriteLine();

            var sortedPeopleByLastName = people.OrderBy(p => p.LastName);
            Console.WriteLine("People sorted by Last name:");
            foreach (var person in sortedPeopleByLastName)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2}", person.FirstName, person.LastName, person.Age);
            }
            Console.WriteLine();

            var sortedPeopleByFirstName = people.OrderBy(p => p.FirstName);
            Console.WriteLine("People sorted by First name:");
            foreach (var person in sortedPeopleByFirstName)
            {
                Console.WriteLine("Name: {0} {1}, Age: {2}", person.FirstName, person.LastName, person.Age);
            }

            Console.ReadLine();
        }
    }
}
