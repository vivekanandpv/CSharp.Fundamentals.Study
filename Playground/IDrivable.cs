using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    //  interfaces are used to define a contract
    //  we always program to an interface, hence interfaces are very important
    //  in .NET interfaces are typically named with 'I' prefix
    //  interfaces in a sense describe the ability to perform certain actions
    //  that's the reason, usually the interfaces are named with -able suffix
    public interface IDrivable
    {
        //  the methods in an interface are abstract
        //  cannot define a field in the interface
        //  but can define a const
        
        public void Drive();

        //  starting with C# 8, we can provide default implmentations
        //  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/proposals/csharp-8.0/default-interface-methods#concrete-methods-in-interfaces
        //  If the implementing class doesn't provide a implementation, this will be invoked
        //  The rationale is to make it easier for interface evolution

        public void Honk()
        {
            Console.WriteLine("Default honk from interface");
        }
    }
}
