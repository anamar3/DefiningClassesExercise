using System;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < num; i++)
            {
                string[] input = Console.ReadLine().Split();
                int age = int.Parse(input[1]);
                string name = input[0];
                Person person = new Person(name, age);
                family.AddMember(person);

            }

            Person oldest = family.GetOldestMember();
            Console.WriteLine(oldest.Name + " " + oldest.Age);
            //var person = new Person()
            //{
            //    Name = "Peter",
            //Age = 20,
            //};

            //Person anotherPerson = new Person();

            //Person thirdPerson = new Person(2);
            //Person Sam = new Person("Sam", 3);
        }
    }
}