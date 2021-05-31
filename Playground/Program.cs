using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            //  https://docs.microsoft.com/en-us/dotnet/csharp/language-reference/builtin-types/integral-numeric-types#characteristics-of-the-integral-types

            byte b = 100;       //  unsigned, 8-bits, System.Byte
            sbyte sb = 100;     //  signed, 8-bits, System.SByte
            short sh = 125;     //  signed, 16-bits, System.Short
            ushort ush = 135;   //  unsigned, 16-bits, System.UShort
            int i = 100;        //  signed, 32-bits, System.Int32
            uint ui = 100;      //  unsigned, 32-bits, System.UInt32
            long l = 154;       //  signed, 64-bits, System.Int64
            ulong ul = 147;     //  unsigned, 64-bits, System.UInt64
        }
    }
}
