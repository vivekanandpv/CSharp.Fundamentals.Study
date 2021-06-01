using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 100;

            //  boxing: value type variable is boxed in an object
            //  object is a reference type (class)
            object obj = i;

            //  unboxing: boxed object is converted to a value type
            //int j = (int)obj;   //  explicit case is required

            int k = Convert.ToInt32(obj);   //  defaults to 0 in this case if obj is null;
                                            //  in other cases for example with strings, an exception is thrown
        }
    }
}
