using System;
using System.Collections.Generic;
using FizzBuzz.Common;

namespace FizzBuzz.Step3
{
    public class FizzBuzzCounter : DefaultFizzBuzz
    {
        Dictionary<string, int> report;

        /// <summary>
        /// Initializes a new instance of the <see cref="FizzBuzzCounter"/> class.
        /// </summary>
        public FizzBuzzCounter()
        {
            report = new Dictionary<string, int>();
			report.Add("fizz", 0);
            report.Add("lucky",0);
            report.Add("buzz", 0);
            report.Add("fizzbuzz", 0);
			report.Add("integer", 0);
        }

        /// <summary>
        /// Gets the label.
        /// </summary>
        /// <returns>The label.</returns>
        /// <param name="value">Value.</param>
        public override string GetLabel(int value)
        {
			if (value.ToString().Contains("3")) return "lucky";
            return base.GetLabel(value);
        }

        /// <summary>
        /// Gets the report.
        /// </summary>
        /// <returns>The report.</returns>
        /// <param name="lastnumber">Lastnumber.</param>
        public Dictionary<string,int> GetReport(int lastnumber)
        {
            for (int i = 1; i <= lastnumber; i++)
            {
                string lable = this.GetLabel(i);

                if(report.TryGetValue(lable,out int count))
                {
                    report[lable]++;
                }
                else
                {
                    report["integer"]++;
                }

            }
            return report;
        }
    }
}
