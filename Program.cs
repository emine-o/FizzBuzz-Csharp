using System.Xml.XPath;

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
            for (int num = 1; num <= 255; num++)
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
                if (num % 7 == 0)
                {
                    output += "Bang";
                }
                if (num % 11 == 0)
                {
                    output = "Bong";
                }
                if (num % 13 == 0)
                {
                    if (!output.Contains('B'))
                    {
                        output += "Fezz";
                    }
                    else
                    {
                        int indexOfB = output.IndexOf('B');
                        output = output.Insert(indexOfB, "Fezz");
                    }
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