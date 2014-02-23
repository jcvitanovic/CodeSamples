using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlongUtil
{
    public interface IEmployeeEntryForm
    {
        void showForm();
        void closeForm();
        void setDisplayItem(string id, string from, string to, string date, string approved);
        void setHelloLabel(string s);
        int getSelectedMyTripID();
        void setDisplayTripDetails(string s);
        void setDisplayPartTrip(string id, string from, string to, string date, string driver);
        int getSelectedPartTripID();
        void setDisplayContacts(string name, string mobile, string email);
       // void setDisplayRides(string id, string from, string to, string date, string initiator, string approved);

    }
}
