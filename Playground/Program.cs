using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Sample s1 = new Sample("Struct1");
            Sample s2 = s1; //  full value is copied, not just the reference
            s1.Name = "Struct1 Name changed";
            s2.Name = "This is Struct2";

            //  s2 = null;  cannot set null to a struct variable

            Console.WriteLine($"Name of struct1 {s1.Name}");
            Console.WriteLine($"Name of struct2 {s2.Name}");
        }
    }
}
