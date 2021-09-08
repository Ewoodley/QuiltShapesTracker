using System;
using System.Collections.Generic;



namespace QuiltShapesTracker
{
    class Program
    {
        
        private List<Patterns> patterns = new List<Patterns>();
        static void Main(string[] args)
        {

            /*var square;
            var triangle;
            var rectangle;
            string input1 = "s";
            string input2 = "t";
            string input3 = "r";
            string input4 = "L";
           commenting out the input strings for the time being, may not be needed */

            while (true)

            {
                Console.WriteLine("Welcome to the quilt shape tracker");
                Console.WriteLine("Please select a shape option:");
                Console.WriteLine("s for square patterns");
                Console.WriteLine("r for triangle patterns");
                Console.WriteLine("t for rectangle patterns");
                Console.WriteLine("Use L to list the patterns already entered ");

                if (Console.ReadLine() == "s")
                {
                    var square = new Square();
                    
                    Console.WriteLine("You are creating a Square Pattern, please enter the color");
                    var color = 

                    
                }
                if (Console.ReadLine() == "r")
                {
                    var rectangle = new Rectangle();
                    Console.WriteLine("You are creating a Rectangle Pattern");
                }
                if (Console.ReadLine() == "t")
                {
                    var triangle = new Triangle();
                    Console.WriteLine("You are creating a Triangle Pattern");
                }
                //Following lines of code are placeholders and are currently commented out until they can be added without breaking anything
               // if (Console.ReadLine() == "L")
                //{foreach(pattern in Patterns())
                //}
            }
        }
    }
}
            
                


            


        
    

