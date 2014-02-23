using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace RideAlongUtil
{
    public interface IAddVehicleForm
    {
        void showForm();
        void closeForm();
        string  getVehicleType();
        string getVehicleModel();
        float getConsumption();
        int getCapacity();
        string getCity();
        string getCountry();
        string getAddress();
       
    }
}
