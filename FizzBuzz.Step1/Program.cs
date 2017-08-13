using System;
using System.Text;
using FizzBuzz.Common;

namespace FizzBuzz.Step1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*************************************************");
			Console.WriteLine("************* REAL FIZZBUZZ STEP 1 **************");
			Console.WriteLine("*************************************************");


            string fizzBuzz = FizzBuzzHelper.GetLables(20,new DefaultFizzBuzz());

			Console.WriteLine(fizzBuzz);
			Console.ReadLine();
        }

    }
}
