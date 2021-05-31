using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            //  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/floating-point-numeric-types#characteristics-of-the-floating-point-types

            float f = 3.1415f;      // 32-bits, System.Float, can use f or F as suffix
            double d = 3.1415;      // 64-bits, System.Double, doesn't require a suffix, can use d or D if so wish
            decimal dm = 3.1415m;   // 128-bits, System.Decimal, can use m or M as suffix

            //  Please read more about decimal type:
            //  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/language-specification/types#the-decimal-type
        }
    }
}
