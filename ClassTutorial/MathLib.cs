using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTutorial
{
	class MathLib
	{
		//public MathLib(int i) { }

		public int Mod(int a, int b)
		{
			return a - (a / b * b);
		}
		public int Inc(int a)
		{
			return a + 1;
		}
		public int Add(int a, int b)
		{
			return a + b;
		}
		public int Sub(int a, int b)
		{
			return a - b;
		}
		public int Mult(int a, int b)
		{
			return a * b;
		}
		public int Div(int a, int b)
		{
			if(b == 0)
			{
				Console.WriteLine("Cannot divide by zero -- EVER!!!!");
				return 0;
			}
			return a / b;
		}
	}
}
