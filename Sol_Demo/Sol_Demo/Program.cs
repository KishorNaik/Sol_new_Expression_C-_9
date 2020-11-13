using System;

namespace Sol_Demo
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Person person = new()
            {
                FirstName = "Kishor",
                LastName = "Naik"
            };

            Display(person: new()
            {
                FirstName = "Eshaan",
                LastName = "Naik"
            });
        }

        private static void Display(Person person)
        {
            Console.WriteLine($"{person.FirstName} {person.LastName}");
        }
    }

    public class Person
    {
        public String FirstName { get; set; }

        public String LastName { get; set; }
    }
}