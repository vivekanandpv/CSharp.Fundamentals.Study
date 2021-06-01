using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = new SampleClass("Class Default Name");
            Console.WriteLine($"Class Before call: {s.Name}");
            PrintName(s);
            Console.WriteLine($"Class After call: {s.Name}");


            var st = new SampleStruct("Struct Default Name");
            Console.WriteLine($"Struct Before call: {st.Name}");
            //  ref parameter must be passed as ref
            //  ref parameters must be initialized
            PrintName(ref st);
            Console.WriteLine($"Struct After call: {st.Name}");
        }

        static void PrintName(SampleClass sample)
        {
            Console.WriteLine(sample.Name);
            sample.Name = "Will this affect s?";
        }

        //  ref keyword implements the reference symantics for value types
        static void PrintName(ref SampleStruct sample)
        {
            Console.WriteLine(sample.Name);
            sample.Name = "Will this affect st?";
        }
    }
}
