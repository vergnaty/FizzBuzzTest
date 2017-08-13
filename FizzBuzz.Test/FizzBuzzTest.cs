using System;
using FizzBuzz.Common;
using Xunit;

namespace FizzBuzz.Test
{
    /// <summary>
    /// FizzBuzz test from 1 to 20 
    /// </summary>
    public class FizzBuzzTest
    {
        const string FIZZ = "fizz";
        const string BUZZ = "buzz";
        const string FIZZBUZZ = "fizzbuzz";


        DefaultFizzBuzz defaultFizzBuzz;

        public FizzBuzzTest()
        {
            defaultFizzBuzz = new DefaultFizzBuzz();
        }

        [Fact]
        public void GetLabel_By_Given_Number_Equal_One_Returns_1()
        {
            string expected = "1";
            string result = defaultFizzBuzz.GetLabel(1);
            Assert.Equal(expected, result);
        }

		[Fact]
		public void GetLabel_By_Given_Number_Equal_two_Returns_2()
		{
			string expected = "2";
			string result = defaultFizzBuzz.GetLabel(2);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void GetLabel_By_Given_Number_Equal_Three_Returns_fizz()
		{
			string result = defaultFizzBuzz.GetLabel(3);
			Assert.Equal(FIZZ, result);
		}

		[Fact]
		public void GetLabel_By_Given_Number_Equal_Four_Returns_4()
		{
			string expected = "4";
			string result = defaultFizzBuzz.GetLabel(4);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void GetLabel_By_Given_Number_Equal_Five_Returns_buzz()
		{
			
			string result = defaultFizzBuzz.GetLabel(5);
			Assert.Equal(BUZZ, result);
		}

        [Fact]
        public void GetLabel_By_Given_Number_Equal_Six_Returns_fizz()
		{
			string result = defaultFizzBuzz.GetLabel(6);
			Assert.Equal(FIZZ, result);
		}

		[Fact]
		public void GetLabel_By_Given_Number_Equal_Seven_Returns_7()
		{
            string expected = "7";
			string result = defaultFizzBuzz.GetLabel(7);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void GetLabel_By_Given_Number_Equal_Eight_Returns_8()
		{
			string expected = "8";
			string result = defaultFizzBuzz.GetLabel(8);
			Assert.Equal(expected, result);
		}

        [Fact]
        public void GetLabel_By_Given_Number_Equal_Nine_Returns_fizz()
		{
			string result = defaultFizzBuzz.GetLabel(9);
			Assert.Equal(FIZZ, result);
		}


		[Fact]
		public void GetLabel_By_Given_Number_Equal_Ten_Returns_buzz()
		{
			string result = defaultFizzBuzz.GetLabel(10);
			Assert.Equal(BUZZ, result);
		}

		[Fact]
		public void GetLabel_By_Given_Number_Equal_Eleven_Returns_11()
		{
            string expected = "11";

			string result = defaultFizzBuzz.GetLabel(11);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void GetLabel_By_Given_Number_Equal_Twelve_Returns_fizz()
		{
		
			string result = defaultFizzBuzz.GetLabel(12);
			Assert.Equal(FIZZ, result);
		}

		[Fact]
		public void GetLabel_By_Given_Number_Equal_Thirteen_Returns_13()
		{
            string expected = "13";
			string result = defaultFizzBuzz.GetLabel(13);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void GetLabel_By_Given_Number_Equal_Fourteen_Returns_14()
		{
			string expected = "14";
			string result = defaultFizzBuzz.GetLabel(14);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void GetLabel_By_Given_Number_Equal_Fiveteen_Returns_fizzbuzz()
		{
			string result = defaultFizzBuzz.GetLabel(15);
			Assert.Equal(FIZZBUZZ, result);
		}

		[Fact]
		public void GetLabel_By_Given_Number_Equal_Sixteen_Returns_16()
		{
            string expected = "16";
			string result = defaultFizzBuzz.GetLabel(16);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void GetLabel_By_Given_Number_Equal_Seventeen_Returns_17()
		{
			string expected = "17";
			string result = defaultFizzBuzz.GetLabel(17);
			Assert.Equal(expected, result);
		}

		[Fact]
		public void GetLabel_By_Given_Number_Equal_Eightteen_Returns_fizz()
		{
			string result = defaultFizzBuzz.GetLabel(18);
			Assert.Equal(FIZZ, result);
		}

		[Fact]
		public void GetLabel_By_Given_Number_Equal_Nineteen_Returns_19()
		{
            string expected = "19";
			string result = defaultFizzBuzz.GetLabel(19);
			Assert.Equal(expected, result);
		}


		[Fact]
		public void GetLabel_By_Given_Number_Equal_Twenty_Returns_buzz()
		{
			string result = defaultFizzBuzz.GetLabel(20);
			Assert.Equal(BUZZ, result);
		}
    }
}
