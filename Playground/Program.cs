using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        { 
            Shape t = new Triangle();        
            Shape t2 = new RightTriangle();   


            t.Draw();   //  Triangle's implementation
            t2.Draw();  //  RightTriangle's implemenation
        }
    }
}
