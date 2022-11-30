using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string mainString = "дом шар гора дорога дом дорога квадрат машина овал земля";
            string wordToChange = "дом";
            string newWord = "ТАРЕЛКА";
            Console.WriteLine(mainString);
            Console.WriteLine(mainString.Replace(wordToChange, newWord));
            Console.ReadKey();
        }
    }
}
