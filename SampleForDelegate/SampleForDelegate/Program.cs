using System;

namespace SampleForDelegate
{
	class Program
	{
		static void Main(string[] args)
		{
			var bankAccount = new BancAccaunt();
			var messHandler = new BancAccaunt.AccountMessageHandler(SendMessage);
			messHandler += SendRedMessage;
			bankAccount.DeligateRegister(messHandler);
			bankAccount.Add(100);

			//_____________________________

			var test = new Test();

			for (int i = 0; i < 10; i++)
			{
				test.Devide(10, i);
			}
		}

		public static void SendMessage(string message)
		{			
			Console.WriteLine(message);			
		}
		public static void SendRedMessage(string message)
		{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine(message);
			Console.ResetColor();
		}
	}

}
