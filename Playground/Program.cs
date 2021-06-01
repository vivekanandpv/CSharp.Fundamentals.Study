using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            //  using named arguments, the position doesn't matter
            PrintGreeting(lastName: "Patil", firstName: "Vinayak");

            Console.WriteLine($"Square, without n: {Square()}");
            Console.WriteLine($"Square, with n: {Square(n: 3.1415)}");
        }

        static void PrintGreeting(string firstName, string lastName)
        {
            Console.WriteLine($"Greetings {firstName} {lastName}");
        }

        //  n is optional
        //  or 0 is the default (in case caller doesn't pass)
        static double Square(double n = 0)
        {
            return n * n;
        }
    }
}
