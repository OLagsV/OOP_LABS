using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customArrsLib;
namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            OdnomerMass A = new OdnomerMass();
            OdnomerMass B = new OdnomerMass();
            OdnomerMass C = new OdnomerMass();
            Console.WriteLine("Введите имя массива, количество элментов и сами элементы массива 1");
            A.enterArr();
            Console.WriteLine("Введите имя массива, количество элментов и сами элементы массива 2");
            B.enterArr();
            Console.WriteLine("Введите имя массива, количество элментов и сами элементы массива 3");
            C.enterArr();
            Console.WriteLine("Массивы:");
            Console.WriteLine(OdnomerMass.convertToString(A));
            Console.WriteLine(OdnomerMass.convertToString(B));
            Console.WriteLine(OdnomerMass.convertToString(C));
            Console.WriteLine(string.Join(" ", OdnomerMass.delenie(A.getArr(), B.getArr())));
            int[] indexUmnozh = { 1, 4, 6, 9, 11 };
            Console.WriteLine(B.summOrUmnozh(indexUmnozh));
            Console.WriteLine(C.summOrUmnozh());
        }
    }
}
