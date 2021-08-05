using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForGenericType.Modes
{
    public class Automobile : ICost
    {
        public string Model{get;set;}
        public long Miles { get; set; }
        public double Cost { get; set; }

    }
}
