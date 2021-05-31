using System;

namespace Lib
{
    public class Shape
    {
        //  private protected access-modifier is added in C# 7.2
        //  This member is only accessible to derived classes within the assembly
        private protected int GetZIndex()
        {
            return 10;
        }

        //  this member is internal for the assembly and protected outside the assembly
        protected internal void Draw()
        {
            Console.WriteLine("Shape drawing...");
        }
    }

    //  Sample doesn't inherit from Shape
    public class Sample
    {
        public void DoStuff()
        {
            var shape = new Shape();
            shape.Draw();   //  Draw() is accessible (internal applies here)
        }
    }

    public class Square : Shape
    {
        public void DrawSquare()
        {
            //  GetZIndex() is accessible because Square is a derived class within the assembly
            Console.WriteLine($"Z-Index of the shape is {base.GetZIndex()}");
        }
    }
}
