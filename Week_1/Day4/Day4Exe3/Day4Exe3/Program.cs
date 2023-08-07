using System;
namespace Day4Exe3
{
    internal class Program
    {
        public class Person
        {
            public string Name;
            public int Age;
            public string Country;
        }
        static void Main(string[] args)
        {
            // Create a list of Person objects
            List<Person> people = new List<Person>
        {
            new Person { Name = "Ram", Age = 25, Country = "India" },
            new Person { Name = "Arjun", Age = 30, Country = "Canada" },
            new Person { Name = "Bali", Age = 22, Country = "USA" },
            new Person { Name = "Edra", Age = 35, Country = "UK" },
            new Person { Name = "Mrug", Age = 28, Country = "India" }
        };

            // Filter the list to retrieve people above a certain age (e.g., 25)
            int minAge = 25;
            var filteredPeople = people.Where(p => p.Age > minAge);
            Console.WriteLine("People above {0} years old:", minAge);
            foreach (var person in filteredPeople)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Country: {2}", person.Name, person.Age, person.Country);
            }
            Console.WriteLine();

            // Sort the list by name in ascending order
            var sortedPeople = people.OrderBy(p => p.Name);
            Console.WriteLine("People sorted by name:");
            foreach (var person in sortedPeople)
            {
                Console.WriteLine("Name: {0}, Age: {1}, Country: {2}", person.Name, person.Age, person.Country);
            }
            Console.WriteLine();

            // Project the list into a new list of objects with only Name and Country properties
            var projectedPeople = people.Select(p => new { p.Name, p.Country });
            Console.WriteLine("Projected list of people (Name and Country):");
            foreach (var person in projectedPeople)
            {
                Console.WriteLine("Name: {0}, Country: {1}", person.Name, person.Country);
            }
        }
    }
}