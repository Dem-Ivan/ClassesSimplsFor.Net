using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForDelegate
{
	public class Test
	{
		public void Devide(int a, int b)
		{
			try
			{
				int c = a / b;
				if (b >= 5)
				{
					throw new NumberOver5Exception("Число b превысило 5");
				}
			}
			catch (NumberOver5Exception e)
			{
				Console.WriteLine(e);
			}
			catch (DivideByZeroException e)
			{
				Console.WriteLine(e);
			}
			catch (Exception e)
			{
				Console.WriteLine(e);
			}
			finally
			{
				Console.WriteLine("Блок finally выполнен");
			}
			
		}
	}
}
