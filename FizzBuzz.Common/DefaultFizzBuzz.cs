using System;

namespace FizzBuzz.Common
{
    public class DefaultFizzBuzz
    {
        
        /// <summary>
        /// Get Label Fizz, Buzz, fizzbuzz or number by Given number 
        /// [APPLYING OPEN CLOSE PRINCIPAL] this methedo should not be open for modification
        /// </summary>
        /// <returns>The label.</returns>
        /// <param name="value">Value.</param>
        public virtual string GetLabel(int value)
        {
            if (value % 15 == 0) return "fizzbuzz";
			if (value % 5 == 0) return "buzz";
			if (value % 3 == 0) return "fizz";

            return value.ToString();

        }
    }
}
