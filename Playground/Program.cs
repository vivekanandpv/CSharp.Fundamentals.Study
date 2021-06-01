using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Sunil";
            string anotherName = name;

            name = "Vikram";    //  this is not mutation, but rebinding (re-assignment)

            //  this also means, the original string is never changed by using the string API
            name.ToUpper(); //  name is intact

            Console.WriteLine(name);

            //  if we wish, we can rebind the result
            name = name.ToUpper();  //  is exactly equal to name = "VIKRAM";
            Console.WriteLine(name);
        }
    }
}
