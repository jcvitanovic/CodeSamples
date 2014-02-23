using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlong
{
    public class TripStops
    {
        public City City { get; set; }
        public DateTime TripDate { get; set;}
        public int MaxHrsStay { get; set; }

        public TripStops(City city, DateTime date, int hrs)
        {
            this.City = city;
            this.TripDate = date;
            this.MaxHrsStay = hrs;
        }
    }
}
