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
            var output = new List<string>{};
            for (int num = 1; num <= 100; num++)
            {
                output.Add(num.ToString());
            }
            var result = string.Join(" ", output);
            return result;
        }
    }
}