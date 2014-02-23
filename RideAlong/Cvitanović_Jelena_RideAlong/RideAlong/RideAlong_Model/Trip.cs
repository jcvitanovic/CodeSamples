using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlong
{
    public class Trip
    {
        public int ID { get; set; }
        static int lastID = 0;
        static float avgCost = (float)1.34;
        public DateTime departureDate { get; set; }
        public City DepartureCity { get; set; }
        public City DestinationCity { get; set; }
        public List<TripStops> Stops { get; set; }
        public Employee TripOwner { get; set; }
        public Vehicle Vehicle { get; set; }
        List<Employee> Travellers { get; set; }
        public bool IsAprooved { get; set; }
        public bool isFull { get; set; }
        public float TripCost;
        public long TripLength { get; set; }
        public bool isDone { get; set; }


        public Trip(Employee init, Vehicle v, DateTime date, City departure, City destination, long length)
        {
            this.ID = lastID;
            lastID++;
            this.TripOwner = init;
            this.departureDate = date;
            this.DepartureCity = departure;
            this.DestinationCity = destination;
            this.IsAprooved = false;
            this.Vehicle = v;
            this.Travellers = new List<Employee>();
            this.Stops = new List<TripStops>();
            this.isFull = false; //nijedno vozilo nije kapaciteta točno jedan
            this.TripLength = length;
            this.TripCost = length * v.Consumption * avgCost; //informacija za menadžera
            TripStops tmp = new TripStops(DepartureCity, date, 1);
            this.addStop(tmp); //što s destinationom? što je s povratnom rutom? razraditi!
            this.addTraveller(init);
            TripStops tmpStop = new TripStops(DestinationCity, departureDate.AddDays(1),1);
            this.addStop(tmpStop);
            this.Vehicle.IsAvailable = false; //zauzmi vozilo
            this.TripOwner.AddTripInit(this);
            this.isDone = false;
        }

        public void addTraveller(Employee e)
        {
            this.Travellers.Add(e);
            if (e != this.TripOwner)
            { e.ParticipatedTripList.Add(this); }

            if (this.Travellers.Count == this.Vehicle.Capacity)
            {
                this.isFull = true;
            }



        }

        public void addStop(TripStops stop)
        {

            this.Stops.Add(stop);

        }

        public List<Employee> getTravellers()
        {
            return this.Travellers;
        }

        public int getTravellersCount()
        {
            return this.Travellers.Count();
        }

        public void getTravellersInfo()
        {
            //TO DO - kako ovo?
        }

        public void removeTraveller(Employee e)
        {
            this.Travellers.Remove(e);
        }





    

    }
}
