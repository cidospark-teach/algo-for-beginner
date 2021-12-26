using System;
using System.Collections.Generic;

namespace SolutionLib
{
    public class Challenge
    {
        public static double Evaluate(string str)
        {
            if (string.IsNullOrWhiteSpace(str))
                return 0.0;

            var splittedStr = str.Split(" ");

            var result = new List<double>();

            foreach(var item in splittedStr)
            {
                double number;

                var isNumeric = double.TryParse(item, out number);
                if (isNumeric)
                {
                    result.Add(number);
                }
                
            }
        }
    }
}
