using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Shape();
            Triangle t = new Triangle();
            RightTriangle rt = new RightTriangle();


            s.Draw();
            t.Draw();   //  Triangle inherits from Shape
            rt.Draw();  //  Right inherits from Triangle
        }
    }
}
