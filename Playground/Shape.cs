using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class Shape
    {
        public void Draw()
        {
            Console.WriteLine("Shape drawing...");
        }
    }

    //  Triangle inherits from Shape
    public class Triangle : Shape
    {

    }


    public class RightTriangle : Triangle
    {

    }


    //  In UML

    //  Shape
    //    ^
    //    |
    //  Triangle
    //    ^
    //    |
    //  RightTriangle


}
