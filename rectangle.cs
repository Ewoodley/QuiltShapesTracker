using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltShapesTracker
{

    public class Rectangle : Patterns
    {
        public Rectangle(string color, int legnth, int height)
        {
            
            Color = color;
            side1 = legnth;
            side2 = height;
        }
        public override int GetArea()
        {
            return side1 * side2;
        }

        public class rectangle
        {
            public float RectLegnth { get; set; }
            public float RectHeight { get; set; }

        }

        public Rectangle()
        {
            Name = "Rectangle Pattern";
        }
    }
}
