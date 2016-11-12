using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace NumberValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите число: ");
            string numberString = Console.ReadLine();

            string patternCommon = @"[+-]?[0-9]+(\.[0-9]+)?";
            string patternExp = @"[+-]?[0-9]+(\.[0-9]+)?([eE][+-]?[0-9]+)";
        
            var commonMatches = Regex.Matches(numberString, patternCommon);
            var expMatches = Regex.Matches(numberString, patternExp);

            if (commonMatches.Count == 1 && commonMatches[0].Length == numberString.Length)
            {

                Console.WriteLine("Это число в обычной нотации");

            }
            else if (expMatches.Count == 1 && expMatches[0].Length == numberString.Length)
            {
                Console.WriteLine("Это число в научной нотации");
            }
            else
                Console.WriteLine("Это не число");        
          
        }
    }
}
