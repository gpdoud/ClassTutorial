using System;

namespace ClassTutorial
{
	class Program
	{
		static void Main(string[] args)
		{

			var mathlib = new MathLib();
			var a = 10;
			var b = 4;
			var mod = mathlib.Mod(a, b);
			Console.WriteLine($"{a} mod {b} is {mod}");
			//var result = mathlib.Add(a, b);
			//Console.WriteLine($"Answer is {result}");
			//result = mathlib.Sub(a, b);
			//Console.WriteLine($"Answer is {result}");
			//result = mathlib.Mult(a, b);
			//Console.WriteLine($"Answer is {result}");
			//result = mathlib.Div(a, b);
			//Console.WriteLine($"Answer is {result}");

			//var fred = new Student();
			//fred.Name = "Fred";
			//fred.SAT = 1000;
			//var wilma = new Student();
			//wilma.Name = "Wilma";
			//wilma.SAT = 2000;

			//var message = wilma.Print(1);
			//Console.WriteLine(message);

			//message = fred.Print(2);
			//Console.WriteLine(message);

			//var barney = new Student();

			//barney.Name = "Barney";
			//barney.SAT = 1200;
			//barney.Print(3);
			//barney.SAT = barney.SAT + 20;
			//barney.Print(4);

		}
	}
}
