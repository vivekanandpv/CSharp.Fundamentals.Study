using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var sample = new Sample(125, "C# Programming Language", "Bengaluru");
            sample.PrintMessage(Selection.City);
            sample.PrintMessage(Selection.None);
            sample.PrintMessage();  //  directly invoking the 0-param overload
        }
    }
}
