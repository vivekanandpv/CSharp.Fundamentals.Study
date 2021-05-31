using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    //  A static class can only contain static or const members
    //  static classes cannot be inherited, nor can be instantiated
    //  They are generally used to provide some global functionality and constants
    //  throughout the application
    public static class MathLib
    {
        //  const members are usually written in all caps, separated by underscores
        public const int YEAR = 2021;

        public static string Name = "Math"; //  possible, but bad idea

        //  const can only be applied to compile time constants
        //  static readonly will make something effectively constant
        //  Once, assigned, Today cannot be reassigned
        public static readonly DateTime Today = DateTime.Now;

        public static double Square(double number)
        {
            return number * number;
        }
    }
}
