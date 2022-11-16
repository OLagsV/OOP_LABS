using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ArrLib;
namespace Lab2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr1 = { -4, -92, 0, 14, 22, 9, 2, 3, 4, 5, 6, 7 };
            int[] arr2 = { -4, 4, 0, 14, 22, 9, 12, 3, 4, 89, 6, 7 };
            ArrayOperations arrToOper = new ArrayOperations(arr1);
            int[] subtr = arrToOper.Subtractuion(arr2);
            int[] summ = arrToOper.Summ(arr2);
            for (int i = 0; i < subtr.Length; i++)
            {
                Console.WriteLine(subtr[i]);
            }
            for (int i = 0; i < summ.Length; i++)
            {
                Console.WriteLine(summ[i]);
            }
        }
    }
}
