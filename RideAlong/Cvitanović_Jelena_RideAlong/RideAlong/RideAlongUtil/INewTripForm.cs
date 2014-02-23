using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlongUtil
{
    public interface INewTripForm
    {
        void showForm();
        void closeForm();
         string[] getDepartureCity();
         string[] getDestinationCity();
         DateTime getDepartureDate();
         string[] getStop1();
         string[] getStop2();
         string[] getStop3();
         string[] getStop4();
         DateTime getStop1Date();
         DateTime getStop2Date();
         DateTime getStop3Date();
         DateTime getStop4Date();
         int getRouteLngth();
         void getAvVehiclesDisplay(string id, string model, string location, string consumption);
         int getSelectedVehicleID();
    }
}
