using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForGenericType.Modes
{
    public class House : ICost
    {
        public string Location { get; set; }
        public int Sqare { get; set; }
        public double Cost { get; set ; }
    }
}
