using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    public class Sample
    {
        private int score { get; }  //  this is a readonly property
        private readonly string name = "Default Name";  //  initialization is allowed
        private readonly string city;

        public Sample(int score, string name, string city)
        {
            this.score = score;  //  either initialization or constructor assignment
            this.name = name;   //  this is allowed; this wins over the initialization; NB: this is an error in Java
            this.city = city;
        }

        //  if method parameters (order or type, or both) differ, we can have method overloads
        //  this is part of compile-time-polymorphism, as the decision about which overload to call
        //  happens at the compile-time
        //  Method overloading is allowed in interfaces and abstract classes as well

        //  Please note that the return type is not part of the method overloading

        //  overload (no parameter)
        public void PrintMessage()
        {
            Console.WriteLine($"Score: {score}; Name: {name}; City: {city}");
        }

        //  overload (1 parameter)
        public void PrintMessage(Selection selection)
        {
            //  enum can be used for switch
            switch (selection)
            {
                case Selection.Score:
                    Console.WriteLine($"Score: {score}");
                    break;
                case Selection.Name:
                    Console.WriteLine($"Name: {name}");
                    break;
                case Selection.City:
                    Console.WriteLine($"City: {city}");
                    break;
                default:
                    PrintMessage(); //  using the overload within
                    break;
            }
            
        }

        
    }

    //  an enum is used to represent named constants
    public enum Selection
    {
        Score = 0,  //  default value starts from 0
        Name = 10,  //  custom assignement; duplicate assignments are allowed
        City,       //  continues with an increment to the earlier value; 11 in this case
        None,       //  trailing comma is allowed
    }
}
