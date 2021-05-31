using System;
using System.Collections.Generic;
using System.Text;

namespace Playground
{
    //  public is an access modifier
    //  default is internal (public within the assembly)
    public class Vehicle
    {
        //  fields represent the state of the instance of this class
        private double _mileage;
        private string _owner;
        private bool _isDriving;

        //  constructor has the same name as the class, but doesn't have a return value
        //  use the constructor to set the class-invariants
        //  constructor can take parameters like a normal method

        public Vehicle(double mileage, string owner)
        {
            _mileage = mileage; //  within the class every member is public
            _owner = owner;
        }

        //  method is an action, usually works with state (read, project, update, set, reset, etc...)
        public void Start()
        {
            _isDriving = true;
        }

        public void Stop()
        {
            _isDriving = false;
        }

        //  manual getter is a method
        //  properties are favoured over method approach
        public string GetOwnerName()
        {
            return _owner;
        }
    }
}
