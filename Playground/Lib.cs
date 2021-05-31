using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class Sample
    {
        private int zIndex;

        public Sample(int zIndex)
        {
            //  this keyword is to qualify the current object
            //  in most cases it is implicit
            //  here, we need to use this to disambiguate zIndex (parameter) with zIndex (field)
            this.zIndex = zIndex;
        }
    }

    public abstract class Shape
    {
        public virtual void Draw()
        {
            Console.WriteLine("Shape drawing...");
        }
    }

    public class Square : Shape
    {
        public override void Draw()
        {
            //  base keyword refers to the immediate base-class, Shape in this case
            base.Draw();
        }
    }
}
