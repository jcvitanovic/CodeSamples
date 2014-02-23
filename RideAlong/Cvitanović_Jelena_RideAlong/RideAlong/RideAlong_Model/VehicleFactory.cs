using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlong
{
    public static class VehicleFactory
    {
        public static Vehicle CreateVehicleWithInfoAdress(VehicleType type, string model, int c, float consum, City city, string s)
        {
            return new Vehicle(type, model, c, consum, city, s);
        }

        public static Vehicle CreateVehicleWithNoInfoAdress(VehicleType type, string model, int c, float consum, City city)
        {
            return new Vehicle(type, model, c, consum, city);
        }
    }
}
