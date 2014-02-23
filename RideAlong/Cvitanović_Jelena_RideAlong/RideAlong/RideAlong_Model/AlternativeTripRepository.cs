using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlong
{
    class AlternativeTripRepository
    {
        private static AlternativeTripRepository instance = null;
        List<AlternativeTripInfo> listAltTrips = new List<AlternativeTripInfo>();

        public static AlternativeTripRepository GetInstance()
        {
            if (instance == null)
                instance = new AlternativeTripRepository();
            return instance;
        }


        public void Load()
        {
            //TO DO
        }


        public void addAltTrip(AlternativeTripInfo altTrip)
        {
            this.listAltTrips.Add(altTrip);
        }


        public List<AlternativeTripInfo> getNotApprovedOnes()
        {
            List<AlternativeTripInfo> tmp = new List<AlternativeTripInfo>();

            foreach (AlternativeTripInfo a in listAltTrips)
            {
                if (a.isAprooved() == false)
                    tmp.Add(a);
            }

            if (tmp.Count() == 0)
                return null;

            return tmp;
        }


        public int getNotApprovedNum()
        {
            List<AlternativeTripInfo> tmp = new List<AlternativeTripInfo>();

            foreach (AlternativeTripInfo a in listAltTrips)
            {
                if (a.isAprooved() == false)
                    tmp.Add(a);
            }

            return tmp.Count(); 
        }


    }
}
