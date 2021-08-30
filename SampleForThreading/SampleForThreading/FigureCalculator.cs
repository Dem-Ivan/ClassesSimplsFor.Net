using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace SampleForThreading
{
    public class FigureCalculator
    {
        private object _locker;
        public List<Figure> figures = new List<Figure>();

        public FigureCalculator(object locker)
        {
            _locker = locker;
        }

        public void PryntFigures()
        {
            ThreadPool.QueueUserWorkItem(_ => 
            {
                while (true)
                {
                    lock (_locker)
                    {
                        foreach (var item in figures)
                        {
                            Console.WriteLine($"{item.SideCount}");
                        }
                    }
                    Thread.Sleep(500);
                }
            });
        }
    }
}
