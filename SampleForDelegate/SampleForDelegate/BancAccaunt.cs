using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForDelegate
{
	public class BancAccaunt
	{
		public delegate void AccountMessageHandler(string message);
		public int Sum { get; private set; }
		private AccountMessageHandler _messageHandler;

		public void DeligateRegister(AccountMessageHandler messageHandler)
		{
			_messageHandler = messageHandler;
		}

		public void Add(int sum)
		{
			Sum = Sum + sum;
			_messageHandler.Invoke("На ваш счет пришла сумма {sum}");			
		}
	}
}
