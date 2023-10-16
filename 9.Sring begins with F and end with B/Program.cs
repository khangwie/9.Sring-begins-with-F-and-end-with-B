using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace _9.Sring_begins_with_F_and_end_with_B
{
    internal class Program
    {
        static string FizzBuzzCheck(string input)
        {
            if (input.StartsWith("F") && input.EndsWith("B"))
            {
                return "FizzBuzz";
            }
            else if (input.StartsWith("F"))
            {
                return "Fizz";
            }
            else if (input.EndsWith("B"))
            {
                return "Buzz";
            }
            else
            {
                return input;
            }
        }

        static void Main(string[] args)
        {
            string[] testCases = {
            "FizzBuzz",
            "Fizz",
            "Buzz",
            "Founder"
        };

            foreach (string testCase in testCases)
            {
                string result = FizzBuzzCheck(testCase);
                Console.WriteLine(result);
                Console.ReadLine();
            }
        }
    }
}
