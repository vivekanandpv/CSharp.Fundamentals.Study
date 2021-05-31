using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class Sample
    {
        //  const and static members are accessed from the type, not from the object
        public const int SCORE = 25;

        public static string Name = "Sample";

        //  Instance member
        public DateTime Today { get; set; } = DateTime.Now;


        //  static methods do not get access to instance members
        public static void PrintMessage()
        {
            Console.WriteLine("Static message...");
        }

        //  Instance members get access to other instance members as well as static members
        public int GetYear()
        {
            return Today.Year;
        }

        public string GetNameFromInstance()
        {
            return Name;    //  static member access is allowed from instance method
        }
    }
}
