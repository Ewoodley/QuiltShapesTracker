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
            
            Color = color;
            side1 = sidex;
            side2 = sidey;
            side3 = sidez;
        }
        public override int GetArea()
        {
            int h = (side1 + side2 + side3) / 2;
            int x = h - side1;
            int y = h - side2;
            int z = h - side3;
            int a = Convert.ToInt32(Math.Sqrt(h * x * y * z));
            return a;

        }

        public class triangle
        {
            public float TriSide1 { get; set; }
            public float TriSide2 { get; set; }
            public float TriSide3 { get; set; }

        }
        public Triangle()
        {
            Name = "Triangle Pattern";
        }


    }
}
