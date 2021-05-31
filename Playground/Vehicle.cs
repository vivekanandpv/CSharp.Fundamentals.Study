using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    
    //  We now say, Vehicle implements the IDrivable interface
    //  Now, the Vehicle must implement the abstract member Drive()
    //  As far as Honk(), it is optional
    public class Vehicle : IDrivable
    {
        private double _mileage;
        private string _owner;
        private bool _isDriving;

        
        public Vehicle(double mileage, string owner)
        {
            _mileage = mileage; 
            _owner = owner;
        }

        public void Start()
        {
            _isDriving = true;
        }

        public void Stop()
        {
            _isDriving = false;
        }

        public string GetOwnerName()
        {
            return _owner;
        }

        public void Drive()
        {
            Console.WriteLine("Vehicle driving");
        }
    }
}
