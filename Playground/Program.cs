using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            //  this is instantiating a class object
            var car = new Vehicle(14.25, "Krishnan");   //  car is an instance of Vehicle class

            //  var uses auto-type inference (a.k.a implicit typing)
            //  More about var: https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/var

            //  invoking a method on the object
            car.Start();
            car.Stop();
            var owner = car.GetOwnerName();

            //  using string interpolation (C# 6)
            //  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/tokens/interpolated
            Console.WriteLine($"Owner of the vehicle is: {owner}");
        }
    }
}
