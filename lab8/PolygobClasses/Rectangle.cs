using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolygobClasses
{
    public class Rectangle : Polygon
    {
        public Rectangle(int[] vertices, Color color) : base(vertices, color)
        {
        }

        public override string GetObjectInfo()
        {
            return $"{this.color}, Square: {this.square}, p1=({vertices[0]},{vertices[1]}), " +
                $"p2=({vertices[2]},{vertices[3]}), p3=({vertices[4]},{vertices[5]}), p4=({vertices[6]},{vertices[7]})";
        }

        public override double GetSquare()
        {
            return 0.5 * (Math.Abs(vertices[0] * vertices[3] - vertices[2] * vertices[1])
                + Math.Abs(vertices[2] * vertices[5] - vertices[4] * vertices[3])
                + Math.Abs(vertices[4] * vertices[7] - vertices[6] * vertices[5])
                + Math.Abs(vertices[6] * vertices[1] - vertices[0] * vertices[7]));
        }
        public override bool IsBelongsToOneQuarter()
        {
            bool x = false, y = false;
            if ((vertices[0] > 0 && vertices[2] > 0 && vertices[4] > 0 && vertices[6] > 0) ||
                (vertices[0] < 0 && vertices[2] < 0 && vertices[4] < 0 && vertices[6] > 0)) x = true;
            if ((vertices[1] > 0 && vertices[3] > 0 && vertices[5] > 0 && vertices[7] > 0) ||
                (vertices[1] < 0 && vertices[3] < 0 && vertices[5] < 0 && vertices[7] > 0)) y = true;
            return x && y;
        }
    }
}
