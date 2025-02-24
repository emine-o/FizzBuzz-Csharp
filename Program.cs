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
                result = $"{result} {num}";
            }
            return result;
        }
    }
}