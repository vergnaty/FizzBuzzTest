using System;
using FizzBuzz.Common;

namespace FizzBuzz.Step2
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("*************************************************");
			Console.WriteLine("************* REAL FIZZBUZZ STEP 2 **************");
			Console.WriteLine("*************************************************");


			string fizzBuzz = FizzBuzzHelper.GetLabels(20, new CustomFizzBuzz());

			Console.WriteLine(fizzBuzz);
			Console.ReadLine();
        }
    }
}
