using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    //  abstract classes cannot be directly instantiated
    //  they are meant to be derived
    //  like a normal class, it can contain fields, properties, constructors, methods, etc.
    //  optionally, they may contain abstract members like interfaces
    //  if there is at least one abstract member, the class must be marked abstract
    //  but an abstract class need not contain abstract members
    //  They are used to provide base implementation is complex hierarchies such as GUI frameworks
    //  Some design patterns such as Template Method, make use of abstract classes
    public abstract class Shape
    {
        //  an abstract member should not have a body
        public abstract void Draw();
    }

    //  Triangle inherits from Shape
    public class Triangle : Shape
    {
        //  this must now provide an override
        public override void Draw()
        {
            Console.WriteLine("Triangle drawing...");
        }
    }


    public class RightTriangle : Triangle
    {
        //  Overriding here is optional, as it doesn't directly inherit from an abstract class
        public override void Draw()
        {
            Console.WriteLine("Right-triangle drawing...");
        }
    }
}
