using System;
using System.Linq;
using System.Collections.Generic;
using Newtonsoft.Json;


namespace SampleForSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            var triangle = new Figure() { Name = "Triangle", SideCount = 3, SideLenght = 1 };
            triangle.Figure1 = triangle;
            string serTriangle = JsonConvert.SerializeObject(triangle);

            Figure desTriangle = JsonConvert.DeserializeObject<Figure>(serTriangle);
        }
    }
}
