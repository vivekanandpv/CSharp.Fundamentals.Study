using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Nullable<double> d = 3.1415;    //  verbose way
            //  Nullable can only work with structs
            double? d = 3.1415; //  short form
            DateTime? today = DateTime.Now;

            Console.WriteLine(today is DateTime?);  //  True only when it is not null; false when null
        }
    }
}
