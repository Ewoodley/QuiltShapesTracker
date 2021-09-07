using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltShapesTracker
{
    public class Triangle : Patterns
    {
        public Triangle(string color, int sidex, int sidey, int sidez)
        {
            Name = "Triangle Pattern";
            Color = color;
            side1 = sidex;
            side2 = sidey;
            side3 = sidez;
        }
        public override int GetArea()
        {
            int h = (side1 + side2 + side3) / 2
        }
    }
}
