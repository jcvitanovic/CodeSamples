using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlong
{
    public class Employee
    {
        public string OIB { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        string Department { get; set; }
        public string ContactPhone { get; set; }
        public string ContactEMail { get; set; }
        public List<Trip> InitiatedTripList = new List<Trip>();
        public List<Trip> ParticipatedTripList = new List<Trip>();


        public Employee(string oib, string name, string surname, string department, string phone, string mail)
        {
            this.OIB = oib;
            this.Name = name;
            this.Surname = surname;
            this.Department = department;
            this.ContactPhone = phone;
            this.ContactEMail = mail;
        }

        public bool checkIfAlreadyOnTrip(int id)
        {
            foreach (Trip t in this.ParticipatedTripList)
            {
                if (t.ID == id)
                    return true;
            }
            return false;
        }

        public void AddTripInit(Trip t)
        {
            this.InitiatedTripList.Add(t);
        }

        public void AddTripParticipated(Trip t)
        {
            if(this.checkIfAlreadyOnTrip(t.ID) == false)
                this.ParticipatedTripList.Add(t);
        }

        public void removeAllTrips()
        {
            this.ParticipatedTripList = new List<Trip>();
            this.InitiatedTripList = new List<Trip>();
        }

        public void removeInitTrip(Trip t)
        {
            this.InitiatedTripList.Remove(t);

        }

        public void removeParticipatedTrip(Trip t)
        {
            this.ParticipatedTripList.Remove(t);
        }

        //autorizacija? dodjela rola za korištenje?



    
    }
}
