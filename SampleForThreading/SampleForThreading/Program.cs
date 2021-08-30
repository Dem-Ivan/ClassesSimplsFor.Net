using System;
using System.Threading;

namespace SampleForThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            object locker = new object();
            var figureCalc = new FigureCalculator(locker);

            figureCalc.PryntFigures();

            SampleForDedlock sampleForDedlock = new SampleForDedlock();

            sampleForDedlock.GetDedlockSample();

            ThreadPool.QueueUserWorkItem(_ =>
            {

                for (int i = 0; i < 100; i++)
                {
                    lock (locker)
                    {
                        figureCalc.figures.Add(new Figure { SideCount = i });
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine(i);
                        Console.ResetColor();
                    }
                    Thread.Sleep(2000);
                }

            });

            Console.ReadLine();
        }
    }
}
