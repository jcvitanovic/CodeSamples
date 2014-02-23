using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlongUtil
{
    public interface IManagerEntryForm
    {
        void showForm();
        void closeForm();
        void setDisplayItem(string id, string departure, string date, string employee, string model, string cost);
        int getSelectedTripID();
        void setDisplayVehicle(string id, string model, string location, string available);
        void clearItems();



    }
}
