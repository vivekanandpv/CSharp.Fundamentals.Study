using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Static classes cannot be instantiated, but used directly
            var square = MathLib.Square(2.0);
            MathLib.Name = "Math2"; //  possible
            //  MathLib.Today = new DateTime(2010, 1, 1);   //  not possible (readonly)
            Console.WriteLine($"Name is: {MathLib.Name}; Year is {MathLib.YEAR}; Square is {square}");   //  accessign const
        }
    }
}
