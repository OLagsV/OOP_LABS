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
            
            /*try
            {*/
                Console.Write("Введите размер исходного массива: ");
                int baseAmount = Convert.ToInt32(Console.ReadLine());
                int[] baseArr = new int[baseAmount];
                for (int i = 0; i < baseAmount; i++)
                {
                    Console.Write($"A[{i + 1}] = ");
                    baseArr[i] = Convert.ToInt32(Console.ReadLine());
                }
                Console.Write("Введите размер массива для операции: ");
                int opAmount = Convert.ToInt32(Console.ReadLine());
                int[] opArr = new int[opAmount];
                for (int i = 0; i < opAmount; i++)
                {
                    Console.Write($"A[{i + 1}] = ");
                    baseArr[i] = Convert.ToInt32(Console.ReadLine());
                }
                ArrOperations arrToOper = new ArrOperations(baseArr);
                int[] test = { 1, 2, 3, 4, 5 };
                int[] result = arrToOper.Subtractuion(test);
            /*}
            catch (ArrException exception)
            {
                Console.Write(exception.Message);
            }*/
        }
    }
}
