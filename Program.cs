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
            for (int num = 1; num <= 105; num++)
            {
                if (num % 3 == 0)
                {
                    if (num % 5 == 0)
                    {
                        if (num % 7 == 0)
                        {
                            result = $"{result} FizzBuzzBang";
                        }
                        result = $"{result} FizzBuzz";
                    }
                    else if (num % 7 == 0)
                    {
                        result = $"{result} FizzBang";
                    }
                    result = $"{result} Fizz";
                }
                else if (num % 5 == 0)
                {
                    if (num % 7 == 0)
                    {
                        result = $"{result} BuzzBang";
                    }
                    result = $"{result} Buzz";
                }
                else if (num % 7 == 0)
                {
                    result = $"{result} Bang";
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