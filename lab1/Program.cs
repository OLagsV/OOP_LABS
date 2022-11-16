using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figure;

namespace lab113
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Figure.Trapezoid p1 = new Figure.Trapezoid(4,6,3);
            float[] sides = p1.getSides();
            if (p1.isReal())
            {
                Console.WriteLine("It's real");
                Console.WriteLine("Square " + p1.getSquare());
                Console.WriteLine("Perimetr " + p1.getPerimeter());
                Console.WriteLine("Sides:");
                for (int i = 0; i < sides.Length; i++)
                {
                    Console.WriteLine(sides[i]);
                }
            }
            else
            {
                Console.WriteLine("It's not real");
            }

            Console.ReadKey();
        }
    }
}