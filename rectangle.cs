using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltShapesTracker
{
<<<<<<< HEAD
    public class Rectangle : Patterns
    {
        public Rectangle( string color, int legnth, int height)
        {
            Name = "Rectangle Pattern";
            Color = color;
            side1 = legnth;
            side2 = height;
        }
        public override int GetArea()
        {
            return side1 * side2;
        }
=======
    public class rectangle
    {
        public float RectLegnth { get; set; }
        public float RectHeight { get; set; }
>>>>>>> 7acc37f047a0fb33363b4f84524ebb1e08d37440
    }
}
