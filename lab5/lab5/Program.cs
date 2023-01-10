using Microsoft.VisualBasic;
using PhonesLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите предложение: ");
            string consoleEnter = Console.ReadLine();
            PhoneScaner test = new PhoneScaner(consoleEnter);
            Console.WriteLine(test.getShortPhone());
            Console.ReadLine();
        }
    }
}