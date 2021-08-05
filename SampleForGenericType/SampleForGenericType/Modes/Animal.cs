using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForGenericType.Modes
{
    public class Animal : ICost
    {
        public string Name { get; set; }
        public double Cost { get; set; }
    }
}
