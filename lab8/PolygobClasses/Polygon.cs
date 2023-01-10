using System.Drawing;

namespace PolygobClasses
{
    public abstract class Polygon : IComparable
    {

        public Polygon(int[] vertices, Color color)
        {
            this.vertices = vertices;
            this.color = color;
            square = GetSquare();
        }

        protected int[] vertices { get; set; }
        public Color color { get; set; }

        public double square { get; set; }

        public abstract double GetSquare();
        public abstract string GetObjectInfo();
        public abstract bool IsBelongsToOneQuarter();

        public int CompareTo(object? obj)
        {

            if (obj is Polygon otherPolygon)
            {
                return this.GetSquare().CompareTo(otherPolygon.GetSquare());
            }
            else
            {
                throw new Exception("Can't compare two objects");
            }
        }
    }
}