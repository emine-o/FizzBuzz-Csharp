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
                if (num % 11 == 0)
                {
                    if (num % 13 == 0)
                    {
                        result = $"{result} FezzBong";
                    }
                    else
                    {
                        result = $"{result} Bong";
                    }
                }
                else if (num % 3 == 0)
                {
                    if (num % 5 == 0)
                    {
                        if (num % 7 == 0)
                        {
                            if (num % 13 == 0)
                            {
                                result = $"{result} FizzFezzBuzzBang";
                            }
                            else
                            {
                                result = $"{result} FizzBuzzBang";
                            }
                        }
                        else
                        {
                            result = $"{result} FizzBuzz";
                        }
                    }
                    else if (num % 7 == 0)
                    {
                        if (num % 7 == 0)
                        {
                            result = $"{result} FizzFezzBang";
                        }
                        else
                        {
                            result = $"{result} FizzBang";
                        }
                    }
                    else if (num % 13 == 0)
                    {
                        result = $"{result} FizzFezz";
                    }
                    else
                    {
                        result = $"{result} Fizz";
                    }
                }
                else if (num % 5 == 0)
                {
                    if (num % 7 == 0)
                    {
                        if (num % 13 == 0)
                        {
                            result = $"{result} FezzBuzzBang";
                        }
                        else
                        {
                            result = $"{result} BuzzBang";
                        }
                    }
                    else if (num % 13 == 0)
                    {
                        result = $"{result} FezzBuzz";
                    }
                    else
                    {
                        result = $"{result} Buzz";
                    }
                }
                else if (num % 7 == 0)
                {
                    if (num % 13 == 0)
                    {
                        result = $"{result} FezzBang";
                    }
                    else
                    {
                        result = $"{result} Bang";
                    }
                }
                else if (num % 13 == 0)
                {
                    result = $"{result} Fezz";
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