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

        public void PrintMessage()
        {
            Console.WriteLine($"Score: {score}; Name: {name}; City: {city}");
        }
    }
}
