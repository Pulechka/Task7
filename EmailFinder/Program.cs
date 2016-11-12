using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EmailFinder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите строку:");
            string text = Console.ReadLine();

            string pattern = @"\b[0-9a-z]([a-z0-9_.]*[0-9a-z])?@([0-9a-z]+\.)+[a-z]{2,6}\b";
            var matches = Regex.Matches(text, pattern);
            Console.WriteLine("Найденные адреса электронной почты:");
            foreach (var match in matches)
            {
                Console.WriteLine(match);
            }
        }
    }
}
