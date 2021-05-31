using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Because the method is not overridable, it depends on on which object it is getting called
            //  If Draw() is called on Shape, it will invoke Shape's implemenation
            //  If it is called on Triangle, it will invoke Triangle's implemenation
            //  Please remember, the left-hand type matters now, not the right-hand type
            
            Shape t = new Triangle();       //  type of t is Shape  
            Triangle t2 = new Triangle();   //  type of t2 is Triangle


            t.Draw();   //  Shape's implementation
            t2.Draw();  //  Triangl's implemenation
        }
    }
}
