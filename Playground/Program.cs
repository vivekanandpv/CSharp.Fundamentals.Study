using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"Static access to Name: {Sample.Name}");
            Console.WriteLine($"Const access to SCORE: {Sample.SCORE}");

            //  static method access
            Sample.PrintMessage();

            //  instance member access
            var sample = new Sample();
            Console.WriteLine($"Instance access to Today: {sample.Today}");
            Console.WriteLine($"Instance access to GetYear: {sample.GetYear()}");
            Console.WriteLine($"Instance access to GetNameFromInstance: {sample.GetNameFromInstance()}");
        }
    }
}
