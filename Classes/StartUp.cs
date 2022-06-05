using System;
using System.Collections.Generic;
using System.Linq;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string input = string.Empty;
            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] splitted = Console.ReadLine().Split();
                string name = splitted[0];
                int age = int.Parse(splitted[1]);

                Person person = new Person(name, age);
                people.Add(person);
            }

            List<Person> modified = people.Where(p => p.Age > 30).OrderBy(n => n.Name).ToList();
            foreach (var item in modified)
            {


                Console.WriteLine($"{item.Name} - {item.Age}");
            }

        }
    }
}