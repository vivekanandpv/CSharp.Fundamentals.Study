using System;

namespace Playground
{
    class Program
    {
        static void Main(string[] args)
        {
            var sample = new Sample(125, "C# Programming Language", "Bengaluru");
            sample.PrintMessage(Selection.City);
            sample.PrintMessage(Selection.None);


            //  Conversion cases

            //  Enum to int

            var noneValue = (int)Selection.None;

            Console.WriteLine($"Selection.None has the value: {noneValue}");

            //  int to Enum

            Selection selectionValue = (Selection) 10;

            Console.WriteLine($"Value 10 is set for {selectionValue}");

            //  string to Enum

            Selection selectionFromString;

            var result = Enum.TryParse<Selection>("City", out selectionFromString);

            if (result) //  there can be failure as well
            {
                Console.WriteLine($"String converted to enum: {selectionFromString == Selection.City}");
            }
        }
    }
}
