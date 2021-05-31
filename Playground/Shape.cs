using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class Shape
    {
        //  If the method is not marked as virutal in base-class
        //  there is no runtime polymorphism
        public void Draw()
        {
            Console.WriteLine("Shape drawing...");
        }
    }

    //  Triangle inherits from Shape
    public class Triangle : Shape
    {
        //  A non-virtual method cannot be overridden
        //  This hides the method, therefore a warning
        //  Please see the Program.cs for more explanation
        public void Draw()
        {
            Console.WriteLine("Triangle drawing...");
        }
    }


    public class RightTriangle : Triangle
    {  
        
    }
}
