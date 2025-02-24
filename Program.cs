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
            string result = "";
            for (int num = 1; num <= 100; num++)
            {
                if (num % 3 == 0)
                {
                    result = $"{result} Fizz";
                }
                else if (num % 5 == 0)
                {
                    result = $"{result} Buzz";
                }
                else
                {
                    result = $"{result} {num}";
                }
            }
            return result;
        }
    }
}