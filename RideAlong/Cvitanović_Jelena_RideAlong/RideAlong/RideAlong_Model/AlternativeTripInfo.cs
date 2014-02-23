using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlong
{
    public class AlternativeTripInfo
    {
        TripTypes TripType { get; set; }
        public float TripCost { get; set; }
        Employee Traveller;
        City DepartureCity {get; set;}
        City DestinationCity {get; set; }
        public bool Approved {get; set; }

        public AlternativeTripInfo(TripTypes type, float cost, Employee traveller, City departure, City destination)
        {
            this.TripType = type;
            this.TripCost = cost;
            this.Traveller = traveller;
            this.DepartureCity = departure;
            this.DestinationCity = destination;
            this.Approved = false;
        }

        public bool isAprooved()
        {
            return this.Approved;        
        }



    }
}
