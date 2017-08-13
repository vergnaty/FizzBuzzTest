﻿using System;
using FizzBuzz.Common;

namespace FizzBuzz.Step2
{
    public class CustomFizzBuzz : DefaultFizzBuzz
    {
        /// <summary>
        /// Get Fizz Buzz Lable with custom behavior 
        /// If the number containes 3 returns LUCKY otherwise default response label 
        /// </summary>
        /// <returns>The label.</returns>
        /// <param name="value">Value.</param>
        public override string GetLabel(int value)
        {
            if (value.ToString().Contains("3")) return "lucky";
            return base.GetLabel(value);
        }
    }
}
