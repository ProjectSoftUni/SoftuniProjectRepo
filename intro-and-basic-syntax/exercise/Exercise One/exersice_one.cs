using System;

namespace Exarcise_One
{
	class MainClass
	{
		public static void Main (string[] args)
		{
			int firstNumber = int.Parse (Console.ReadLine ());
			int SecondNumber = int.Parse (Console.ReadLine ());
			int thirdNumber = int.Parse (Console.ReadLine ());
			int forthNumber = int.Parse (Console.ReadLine ());

			Console.WriteLine ($"{firstNumber:0000} {SecondNumber:0000} {thirdNumber:0000} {forthNumber:0000}");
		}
	}
}
