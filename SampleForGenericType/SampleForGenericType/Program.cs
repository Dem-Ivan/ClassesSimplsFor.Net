using SampleForGenericType.Modes;
using System;

namespace SampleForGenericType
{
    class Program
    {
        static void Main(string[] args)
        {
            var clientCat = new Animal() { Cost = 1 };
            var clientAutomobile = new Automobile() { Cost = 1000 };
            var clientHouse = new House() { Cost = 100_000 };

            var propClac = new PropertyCalculator();//<ICost>();
            propClac.Add(clientCat);
            propClac.Add(clientAutomobile);
            propClac.Add(clientHouse);


        }
    }
}
