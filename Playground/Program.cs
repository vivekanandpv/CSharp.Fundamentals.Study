using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Interface cannot be instantiated directly
            //  There must be an implementer on the rvalue
            IDrivable car = new Vehicle(14.25, "Krishnan");   //  car is an instance of IDrivable

            //  Vehicle-specific methods are not accessible now, even though we have Vehicle implementation
            //  car.Start();
            //  car.Stop();
            //  var owner = car.GetOwnerName();

            car.Drive();    //  Vehicle's implementation will be invoked: polymorphism
            car.Honk();     //  default implementation will be invoked
        }
    }
}
