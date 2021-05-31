using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class Shape
    {
        //  protected members are only accessible to derived classes
        protected int ZIndex { get; set; } = 10;
        
        protected void Color()
        {
            Console.WriteLine("Shape coloring...");
        }

        public void Draw()
        {
            Console.WriteLine("Shape drawing...");
        }
    }

    public class Triangle : Shape
    {
        public void ColorRelay()
        {
            Console.WriteLine($"Triangle: ZIndex of Shape is: {base.ZIndex}");
            Console.WriteLine("Triangle: Relaying to Shape.Color()");
            base.Color();   //  base represents the immediate base-class, in this case, Shape
        }
    }


    public class RightTriangle : Triangle
    {

    }
}
