using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            SampleStruct st;    //  this may be initialized or not
            PrintName(out st);
            //  access to members is allowed, since the method must assign to out parameter
            Console.WriteLine($"Struct After call: {st.Name}");
        }

        static void PrintName(out SampleStruct sample)
        {
            //  before assignment, member access is not allowed
            //  sample.Name = "Something";  //  Not allowed

            //  must assign to out parameter before leaving
            sample = new SampleStruct("Assigned within the method");
        }
    }
}
