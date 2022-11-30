using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab42regexp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string searchPhone = @"[+][0-9]{7}";
            Console.Write("Введите предложение: ");
            string consoleEnter = Console.ReadLine();
            StringBuilder stringToCheck = new StringBuilder();
            stringToCheck.AppendLine(Regex.Replace(consoleEnter, searchPhone, ""));
            Console.WriteLine(stringToCheck);
            Console.ReadLine();
        }
    }
}
