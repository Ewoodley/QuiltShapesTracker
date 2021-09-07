using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltShapesTracker
{
    public class Square : Patterns
    {
       public Square(string color, int side)
        {
            Name = "Square Pattern";
            Color = color;
            side1 = side;
                  
        }
        public override int GetArea()
        {
            return side1 * side1;
        }
        
    }


}
