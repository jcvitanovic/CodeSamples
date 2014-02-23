using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlongUtil
{
    public interface IBrowseTripsForm
    {
        void showForm();
        void closeForm();
        int getSelectedTripID();
        void setDisplayItem(string id, string departure, string arrival, string name, string mobile, string email);
        string getSelectedCityDeparture();
        string getSelectedCountryDeparture();
        string getSelectedCityDestination();
        string getSelectedCountryDest();
    }

}
