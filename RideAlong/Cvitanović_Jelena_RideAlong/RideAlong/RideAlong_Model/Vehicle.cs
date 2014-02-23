using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlong
{
    public class Vehicle
    {
        public int ID;
        static int lastID = 0;
        VehicleType Type { get; set; }
        public string Model { get; set; }
        public int Capacity { get; set; }
        public float Consumption { get; set; }
        public City BasicLocation { get; set; }
        string Adress { get; set; }
        public bool IsAvailable { get; set; }

        public Vehicle(VehicleType type, string model, int c, float consum, City city, string s)
        {
            this.ID = lastID;
            lastID++;
            this.Type = type;
            this.Model = model;
            this.Capacity = c;
            this.Consumption = consum;
            this.BasicLocation = city;
            this.Adress = s;
            this.IsAvailable = true;
        }

        //Vehicle(id, type, model, c, consum, city)


        public Vehicle(VehicleType type, string model, int c, float consum, City city)
        {
            this.ID = lastID;
            lastID++;
            this.Type = type;
            this.Model = model;
            this.Capacity = c;
            this.Consumption = consum;
            this.BasicLocation = city;
            this.Adress = "";
            this.IsAvailable = true;
        }






    }
}
