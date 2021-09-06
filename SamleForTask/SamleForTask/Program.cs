using System;
using System.Threading;
using System.Threading.Tasks;

namespace SamleForTask
{
    class Program
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cancellationTokenSource = new CancellationTokenSource();
            CancellationToken cancellationToken = cancellationTokenSource.Token;

            //var task1 = new Task(Print);
            //task1.Start();
            //task1.Wait();

            //var task2 = Task.Factory.StartNew(()=> Console.WriteLine("Print task2"));
            //task2.Wait();

            //var task3 = Task.Run(() => Console.WriteLine("Print task3"));
            //task3.Wait();


            var task4 = Task.Factory.StartNew(() =>
            {
                Console.WriteLine("Старт Внешней задачи");

                var task5 = Task.Factory.StartNew(() =>
                {
                    Console.WriteLine("Старт внутренней задачи");
                    Thread.Sleep(5000);

                    cancellationTokenSource.Cancel();
                    Console.WriteLine("Завершение внутренней задачи");
                });
               ;

                Console.WriteLine("Завершение Внешней задачи");
            });
            

            var task6 = Task.Run(() => GetSum(5,3));
            Console.WriteLine(task6.Result);

            Test(cancellationToken);

            Console.WriteLine(" Заверщение метода Main");

            Console.ReadLine();

        }

        private static void Print()
        {
            Console.WriteLine("Print task 1");
        }

        private static int GetSum(int a, int b)
        {
            return a + b;
        }

        private static void Test(CancellationToken cancellationToken)
        {
            var task7 = Task.Factory.StartNew(() => 
            {
                while (!cancellationToken.IsCancellationRequested)
                {
                    Thread.Sleep(200);
                    Console.WriteLine("x");
                }
            });
        }

    }
}
