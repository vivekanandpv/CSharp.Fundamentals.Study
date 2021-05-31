using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            //  A derived class can substitute itself wherever any of its base-classes (up the hierarchy) are required
            //  This is polymorphism

            Shape s = new Shape();
            Shape t = new Triangle();       //  Triangle is a Shape
            Shape rt = new RightTriangle(); //  RightTriangle is a Triangle, which is a Shape


            s.Draw();
            t.Draw();   //  Triangle inherits from Shape
            rt.Draw();  //  Right inherits from Triangle
        }
    }
}
