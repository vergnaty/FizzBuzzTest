using System;
using System.Text;

namespace FizzBuzz.Common
{
    public class FizzBuzzHelper
    {
        public static string GetLables(int lastNumber, DefaultFizzBuzz defaultFizzbuzz)
        {
			StringBuilder sb = new StringBuilder();
			for (int i = 1; i <= lastNumber; i++)
			{
				sb.Append(defaultFizzbuzz.GetLabel(i) + " ");
			}
			return sb.ToString().Trim();
        }
    }
}
