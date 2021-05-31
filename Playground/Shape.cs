using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class Shape
    {
        //  When base class is substituted by one of the derived classes
        //  we still want the derived class' implementation be invoked, should they provide one

        //  In C# all methods are non-overridable by default (sealed by default)
        //  We explicitly allow the method in the base-class to be overridden in the derived classes
        //  by making it virtual
        public virtual void Draw()
        {
            Console.WriteLine("Shape drawing...");
        }
    }

    //  Triangle inherits from Shape
    public class Triangle : Shape
    {
        //  This class provides an implementation
        //  So it uses override in the method signature
        public override void Draw()
        {
            Console.WriteLine("Triangle drawing...");
        }
    }


    public class RightTriangle : Triangle
    {  
        //  There is no override provided here,
        //  So, this class will get it's base-class (Triangle) implementation
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
