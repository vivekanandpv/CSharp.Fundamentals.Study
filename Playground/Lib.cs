using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public struct SampleStruct
    {
        public string Name { get; set; }

        public SampleStruct(string name)
        {
            Name = name;
        }
    }

    public class SampleClass
    {
        public string Name { get; set; }

        public SampleClass(string name)
        {
            Name = name;
        }
    }
}
