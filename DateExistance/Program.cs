using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DateExistance
{
    public class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите текст, содержащий дату в формате dd-mm-yyyy:");
            string text = Console.ReadLine();

            string pattern = @"\b(?:0[1-9]|[12][0-9]|3[0-1])-(?:0[1-9]|1[0-2])-\d{4}\b";
            if (Regex.IsMatch(text, pattern))
            {
                Console.WriteLine($"В тексте \"{text}\" содержится дата.");
            }
            else
            {
                Console.WriteLine($"В тексте \"{text}\" не содержится дата.");
            }

        }
    }
}
