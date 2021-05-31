using Lib;
using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }

    public class Demo : Shape
    {
        public void GetGoing()
        {
            //  Only gets access to Draw(); (protected applies here)

            //  Doesn't have the access to GetZIndex() as this is outside the assembly
            base.Draw();
        }
    }
}
