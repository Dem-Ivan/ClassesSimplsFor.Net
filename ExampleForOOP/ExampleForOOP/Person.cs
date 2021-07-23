using System;


namespace ExampleForOOP
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"Name = {Name}");
        }
    }
}
