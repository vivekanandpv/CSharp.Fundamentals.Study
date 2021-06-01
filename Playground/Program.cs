using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintNames("Vijay");
            PrintNames("Vijay", "Krishnan", "Ahmed");
        }

        //  params must be applied to a single-dimension array
        //  only one params per method allowed
        //  params must be the last in the list of parameters
        //  you may have other parameters before params
        static void PrintNames(params string[] names)
        {
            foreach (var name in names)
            {
                Console.WriteLine(name);
            }
        }
    }
}
