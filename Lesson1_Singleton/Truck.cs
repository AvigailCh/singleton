using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1_Singleton
{
    internal class Vehicle
    {
        public int Num { get; set; }

    }

    class Car: Vehicle
    {

    }

    class Truck: Vehicle
    {

    }

    class FactoryVehicle
    {
        public static Vehicle GetVehicle(string   name) {

            if (name=="Car")
            {
                return new Car();
            }
            if (name=="Truck")
            { 
                return new Truck();
            }
            return null;
        }
    }
}
