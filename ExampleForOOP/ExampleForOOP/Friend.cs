using System;

namespace ExampleForOOP
{
    public class Friend : Person
    {
        public override void Display()
        {
            Console.WriteLine($"Friend name = {Name}");
        }
    }
}
