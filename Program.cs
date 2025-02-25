using System.Xml.XPath;

namespace FizzBuzz
{
    class Program
    {
        public static void Main()
        {
            Console.WriteLine("Enter a number to FizzBuzz:");
            int userNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(GetFizzBuzz(userNumber));
        }
        public static string GetFizzBuzz(int maxNumber)
        {
            var result = new List<string>{};
            for (int num = 1; num <= maxNumber; num++)
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
                if (num % 17 == 0)
                {
                    if (output.Length >= 8)
                    {
                        var prints = new List<string>{};
                        for (int index = 0; index < output.Length; index += 4)
                        {
                            prints.Add(output.Substring(index, 4));
                        }
                        prints.Reverse();
                        output = string.Join("", prints);
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