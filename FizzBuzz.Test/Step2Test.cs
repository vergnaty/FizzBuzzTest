﻿using System;
using FizzBuzz.Common;
using FizzBuzz.Step2;
using Xunit;

namespace FizzBuzz.Test
{
	/// <summary>
	/// FizzBuzz test from 1 to 20 STEP2
	/// </summary>
	public class Step2Test
    {

        DefaultFizzBuzz defaultFizzBuzz;

        public Step2Test()
        {
            defaultFizzBuzz = new CustomFizzBuzz();
        }

        [Fact]
        public void GetFizzbuzz_Lables_By_Given_Range_Returns_Correct_RealFizzBuzz()
        {
            string expected = "1 2 lucky 4 buzz fizz 7 8 fizz buzz 11 fizz lucky 14 fizzbuzz 16 17 fizz 19 buzz";
            string actual = FizzBuzzHelper.GetLables(20, defaultFizzBuzz);

            Assert.Equal(expected, actual);
        }

        [Fact]
        public void GetFizzbuzz_Lable_By_Given_Number_Equal_Three_Returns_lucky()
        {
            string expected = "lucky";
            string actual = defaultFizzBuzz.GetLabel(3);

            Assert.Equal(expected, actual);
        }

		[Fact]
		public void GetFizzbuzz_Lable_By_Given_Number_Equal_Thirteen_Returns_lucky()
		{
			string expected = "lucky";
			string actual = defaultFizzBuzz.GetLabel(13);

			Assert.Equal(expected, actual);
		}
    }
}
