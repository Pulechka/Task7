using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HtmlReplacer
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст:");
            string text = Console.ReadLine();

            string pattern = @"<.+?>";
            Console.WriteLine("Результат замены: "+ Regex.Replace(text, pattern, "_"));
        }
    }
}
