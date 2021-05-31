using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            //  protected member is not accessible directly
            //  it is only accessible to derived classes
            //  Shape s = new Shape();
            //  s.Color();  //  doesn't work
            //  int zIndex = s.ZIndex;   //  doesn't work

            Triangle t = new Triangle();
            t.ColorRelay(); //  has access to Shape.ZIndex and Shape.Color() internally
        }
    }
}
