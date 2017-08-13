using System;
using FizzBuzz.Common;
using Xunit;

namespace FizzBuzz.Test
{
	/// <summary>
	/// FizzBuzz test from 1 to 20 STEP1
	/// </summary>
	public class Step1Test
    {
		DefaultFizzBuzz defaultFizzBuzz;

		public Step1Test()
		{
			defaultFizzBuzz = new DefaultFizzBuzz();
		}

        [Fact]
        public void GetFizzbuzz_Lables_By_Given_Range_Returns_Correct_RealFizzBuzz()
        {
            string expected = "1 2 fizz 4 buzz fizz 7 8 fizz buzz 11 fizz 13 14 fizzbuzz 16 17 fizz 19 buzz";
			string actual  = FizzBuzzHelper.GetLables(20, defaultFizzBuzz);

            Assert.Equal(expected,actual);
        }
    }
}
