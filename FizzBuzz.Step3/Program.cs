using System;
using System.Collections.Generic;
using System.Linq;

namespace FizzBuzz.Step3
{
    class Program
    {
        static void Main(string[] args)
        {
			Console.WriteLine("*************************************************");
			Console.WriteLine("************* REAL FIZZBUZZ STEP 3 **************");
			Console.WriteLine("*************************************************");


            FizzBuzzCounter fizzBuzzCounter = new FizzBuzzCounter();
            Dictionary<string,int> report = fizzBuzzCounter.GetReport(20);


            foreach (KeyValuePair<string,int> item in report)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.ReadLine();
        }
    }
}
