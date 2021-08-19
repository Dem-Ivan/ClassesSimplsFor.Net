using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForReflection
{
   public class Figure
    {
        public string Name { get; set; }
        public int SideCount { get; set; }
        public double SideLenght{ get; set; }

        public void Display(string name)
        {
            Console.WriteLine(name);
        }

    }
}
