using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    //  A struct implicitly inherits from ValueType
    //  There cannot be explicit inheritance (not even from other structs)
    //  But structs can implement interfaces
    //  objects of structs follow value-semantics
    //  Use structs for light-weight user-defined types where value-semantics is required
    //  For exmple, complex number, token, etc...
    public struct Sample : ISample
    {
        public string Name { get; set; }

        //  structs can have constructors, but writing a parameter-less constructor is not allowed
        //  Here in this case, Name must be initialized in the constructor
        public Sample(string name)
        {
            Name = name;
        }

        public void PrintMessage()
        {
            Console.WriteLine($"Struct printing Name: {Name}");
        }
    }

    public interface ISample
    {
        void PrintMessage();
    }
}
