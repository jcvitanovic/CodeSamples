using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlong
{
    public class TripRepository
    {
        private static TripRepository instance = null;
        List<Trip> listTrips = new List<Trip>();

        public static TripRepository GetInstance()
        {
            if (instance == null)
                instance = new TripRepository();
            return instance;
        }

        //dodati get trip by id

        public void Load()
        {
            City c = new City("Karlovac","Croatia");
            TripStops t = new TripStops(c,new DateTime(2013, 3, 15, 18, 30, 00), 2);
            Trip trip = new Trip(EmployeeRepository.GetInstance().getEmployeeByOib("10257841210"), VehicleRepository.GetInstance().getVehicleByID(1),new DateTime(2013, 3, 15, 17, 30, 00), new City("Zagreb", "Croatia"), new City("Gospić", "Croatia"),100);
            trip.addStop(t);
            TripRepository.GetInstance().addTrip(trip);



            c = new City("Zaprešić", "Croatia");
            t = new TripStops(c, DateTime.Today, 2);
            trip = new Trip(EmployeeRepository.GetInstance().getEmployeeByOib("10778125367"), VehicleRepository.GetInstance().getVehicleByID(1), new DateTime(2012, 4, 10, 18, 50, 0), new City("Zagreb", "Croatia"), new City("Gospić", "Croatia"), 100);
            trip.addStop(t);
            trip.addTraveller(EmployeeRepository.GetInstance().getEmployeeByOib("77812541042"));
            TripRepository.GetInstance().addTrip(trip);



            c = new City("Zagreb", "Croatia");
            t = new TripStops(c, DateTime.Today, 2);
            trip = new Trip(EmployeeRepository.GetInstance().getEmployeeByOib("77812541042"), VehicleRepository.GetInstance().getVehicleByID(2), new DateTime(2013,4,5,10,30,0), new City("Osijek", "Croatia"), new City("Gospić", "Croatia"), 200);
            trip.addStop(t);
            //10234781881
            trip.addTraveller(EmployeeRepository.GetInstance().getEmployeeByOib("10257841210"));
            trip.addTraveller(EmployeeRepository.GetInstance().getEmployeeByOib("10234781881"));
            TripRepository.GetInstance().addTrip(trip);
        }

        public Trip getTripByID(int id)
        {
            foreach (Trip t in listTrips)
            {
                if (t.ID == id)
                    return t;
            }
            return null;
        }

        public void addTrip(Trip t)
        {
            this.listTrips.Add(t);
        }

        public void removeTrip(Trip t)
        {
            this.listTrips.Remove(t);
        }

        public int Count()
        {
            return this.listTrips.Count();
        }

        public List<Trip> GetNotFullOnes()
        {
            List<Trip> tmp = new List<Trip>();

            foreach (Trip t in listTrips)
            {
                if (t.isFull == false)
                {
                    tmp.Add(t);
                }
            }

            if (tmp.Count() == 0)
                return null;

            return tmp;
        }

        public List<Trip> getAcitveOnes()
        {
            List<Trip> tmp = new List<Trip>();

            foreach (Trip t in listTrips)
            {
                if (t.isDone == false)
                {
                    tmp.Add(t);
                }
            }

            return tmp; //pazi da nije null!
        }


        public int getNotFullOnesCount()
        {
            List<Trip> tmp = this.GetNotFullOnes();
            if (tmp == null)
                return 0;
            else
                return tmp.Count();
        }

        public void updateTrip()
        {
            //kako ćeš updejtati? observeri? razraditi!
        }

        public void removeAllTrips()
        {
            this.listTrips = new List<Trip>();
        }

        public List<Trip> getNotApprovedOnes()
        {
            List<Trip> tmp = new List<Trip>();

            foreach (Trip t in this.listTrips)
            {
                if (t.IsAprooved == false)
                    tmp.Add(t);
            }

            return tmp;
        }

        public int getNotApprovedCnt()
        {
            List<Trip> tmp = this.getNotApprovedOnes();
            if (tmp == null)
                return 0;
            else
                return tmp.Count();
        }
    }
}
