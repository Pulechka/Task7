using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TimeCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите текст:");
            string text = Console.ReadLine();

            string pattern = @"\b(([0-9])|([0-1][0-9])|(2[0-3])):([0-5][0-9])\b";

            var matches = Regex.Matches(text, pattern);
            Console.WriteLine($"Время в тексте присутствует {matches.Count} раз.");
        }
    }
}
