using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            //  structs follow the value semantics
            //  this means, the variable of a struct holds the complete value
            var struct1 = new SampleStruct("Struct 1");
            var struct2 = struct1;  //  the complete value is copied to the new variable

            var class1 = new SampleClass("Class 1");
            var class2 = class1;    //  only the reference to the object is copied

            struct1.Name = "Struct 1 name changed"; //  this has no impact on struct2
            class1.Name = "Class 1 name changed";   //  this impacts class2 as well

            Console.WriteLine($"Struct1: {struct1.Name}");
            Console.WriteLine($"Struct2: {struct2.Name}");
            Console.WriteLine($"Class1: {class1.Name}");
            Console.WriteLine($"Class2: {class2.Name}");
        }
    }
}
