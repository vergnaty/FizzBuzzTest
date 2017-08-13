﻿using System;
using FizzBuzz.Step3;
using Xunit;

namespace FizzBuzz.Test
{
	/// <summary>
	/// FizzBuzz test from 1 to 20 STEP3 test the total count for each fizzbuzz label
	/// </summary>
	public class Step3Test
    {
        FizzBuzzCounter fizzBuzzCounter;

		public Step3Test()
		{
			this.fizzBuzzCounter = new FizzBuzzCounter();
		}

        [Fact]
        public void GetFizzbuzz_Report_By_Given_Range_Returns_Four_Fizz_Lables()
        {
            var result = this.fizzBuzzCounter.GetReport(20);
            int actual = result["fizz"];
            Assert.Equal(4, actual);
        }


		[Fact]
		public void GetFizzbuzz_Report_By_Given_Range_Returns_Two_Lucky_Lables()
		{
			var result = this.fizzBuzzCounter.GetReport(20);
			int actual = result["lucky"];
			Assert.Equal(2, actual);
		}

		[Fact]
		public void GetFizzbuzz_Report_By_Given_Range_Returns_Three_Buzz_Lables()
		{
			var result = this.fizzBuzzCounter.GetReport(20);
			int actual = result["buzz"];
			Assert.Equal(3, actual);
		}

		[Fact]
		public void GetFizzbuzz_Report_By_Given_Range_Returns_One_Fizzbuzz_Lables()
		{
			var result = this.fizzBuzzCounter.GetReport(20);
			int actual = result["fizzbuzz"];
			Assert.Equal(1, actual);
		}

		[Fact]
		public void GetFizzbuzz_Report_By_Given_Range_Returns_Ten_Integer_Lables()
		{
			var result = this.fizzBuzzCounter.GetReport(20);
			int actual = result["integer"];
			Assert.Equal(10, actual);
		}
    }
}
