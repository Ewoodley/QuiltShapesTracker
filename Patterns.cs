using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuiltShapesTracker
{
   public abstract class Patterns
    {
        
        public string Name { get; set; }
        public string Color { get; set; }
        public int side1 { get; set; }
        public int side2 { get; set; }
        public int side3 { get; set; }
        public abstract int GetArea();
    }
}
