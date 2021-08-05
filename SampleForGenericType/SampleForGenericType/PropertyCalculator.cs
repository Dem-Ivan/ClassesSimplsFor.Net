using SampleForGenericType.Modes;
using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForGenericType
{
  public  class PropertyCalculator //<T> where T : ICost
    {
        public double TotalCost { get; set; }

        public void Add<T>(T property) where T: ICost 
        {
            TotalCost = TotalCost + property.Cost;
        }
    }
}
