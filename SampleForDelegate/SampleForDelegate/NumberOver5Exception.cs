using System;
using System.Collections.Generic;
using System.Text;

namespace SampleForDelegate
{
	public class NumberOver5Exception : Exception
	{
		public NumberOver5Exception(string message) : base(message)
		{

		}
	}
}
