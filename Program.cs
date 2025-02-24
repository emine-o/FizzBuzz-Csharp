﻿using System.Xml.XPath;

namespace FizzBuzz
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine(GetFizzBuzz());
        }
        public static string GetFizzBuzz()
        {
            var result = new List<string>{};
            for (int num = 1; num <= 100; num++)
            {
                string output = "";
                if (num % 3 == 0)
                {
                    output = "Fizz";
                }
                if (num % 5 == 0)
                {
                    output += "Buzz";
                }
                if (output == "")
                {
                    output = num.ToString();
                }
                result.Add(output);
            }
            return string.Join(",", result);
        }
    }
}