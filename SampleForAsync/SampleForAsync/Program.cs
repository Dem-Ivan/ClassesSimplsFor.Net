using SampleForAsync.BrecfastProducts;
using System;
using System.Threading.Tasks;

namespace SampleForAsync
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Готовим завтрак: ");
            
            Task coffeeTask = PrepareCoffe();

            Task toastTask = PrepareToastWithAjam();
            Task<Egg> eggTask = FryEgg();

            await toastTask;
            var egg = await eggTask;

            await coffeeTask;

            Console.WriteLine("Завтрак готов");
            Console.ReadLine();
        }

        private static async Task PrepareCoffe()
        {
            Console.WriteLine("Завариваем коффе...");
            await Task.Delay(20000);
            Console.WriteLine("Коффе готов_________");
        }

        private static async Task<Toast> ToastBred()
        {
            Console.WriteLine("Жарим хлеб...");
            await Task.Delay(5000);
            Console.WriteLine("Кладем тосты на тарелку..");
            return new Toast();
        }

        private static void AddJam(Toast toast)
        {
            Console.WriteLine("Намажем джем...");
            Task.Delay(5000).Wait();
            Console.WriteLine("Кладем тосты на тарелку.");
        }

        private static async Task<Egg> FryEgg()
        {
            Console.WriteLine("Жарим яйца..");
            await Task.Delay(5000);
            Console.WriteLine("Яйца готовы");

            return new Egg();
        }

        private static async Task PrepareToastWithAjam()
        {
            var toast = await ToastBred();
            AddJam(toast);
        }

    }
}
