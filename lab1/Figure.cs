using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figure
{
    internal class Trapezoid
    {
        public float x1, x2, y1 = 0, y2 = 0, a, leftSide, topSide, rightSide, bottomSide;

        public Trapezoid(float x1, float x2,float a)
        {
            this.x1 = x1;
            this.x2 = x2;
            this.a = a;
        }
        public bool isReal()
        {
            return x1 != x2;
        }
        public float[] getSides()
        {
            leftSide = (float)(Math.Abs(Math.Pow(a,x1)));
            topSide = (float)(Math.Abs(Math.Sqrt(1+Math.Pow((a*a),x2)*Math.Log(a))- (Math.Sqrt(1 + Math.Pow((a * a), x1) * Math.Log(a)))));
            rightSide = (float)(Math.Abs(Math.Pow(a, x2)));
            bottomSide = (float)(Math.Abs(x2-x1));
            float[] sides = { leftSide, topSide, rightSide, bottomSide};
            return sides;
        }
        public float getPerimeter()
        {
            return leftSide + topSide + rightSide + bottomSide;
        }
        public float getSquare()
        {
            return (float)(Math.Pow(a,x2)*Math.Log(a)- Math.Pow(a, x1) * Math.Log(a));
        }
    }
}
