using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlong
{
    public class VehicleRepository
    {
        private static VehicleRepository instance = null;
        public List<Vehicle> listVehicle = new List<Vehicle>();

        public static VehicleRepository GetInstance()
        {
            if (instance == null)
                instance = new VehicleRepository();
            return instance;
        }

        public void Load()
        {
            City city = new City("Zagreb", "Croatia");
            Vehicle v = VehicleFactory.CreateVehicleWithNoInfoAdress(VehicleType.caravan, "Toyota Auris", 6, 9, city);
            VehicleRepository.GetInstance().AddNewVehicle(v);

            city = new City("Karlovac", "Croatia");
            v = VehicleFactory.CreateVehicleWithNoInfoAdress( VehicleType.car, "Toyota Yaris", 4, 7, city);
            VehicleRepository.GetInstance().AddNewVehicle(v);


            city = new City("Gospić", "Croatia");
            v = VehicleFactory.CreateVehicleWithNoInfoAdress( VehicleType.car, "Toyota Yaris", 4, 7, city);
            VehicleRepository.GetInstance().AddNewVehicle(v);


            city = new City("Zagreb", "Croatia");
            v = VehicleFactory.CreateVehicleWithNoInfoAdress( VehicleType.car, "Toyota Yaris", 4, 7, city);
            VehicleRepository.GetInstance().AddNewVehicle(v);

        }

        public List<Vehicle> getVehicleByCityCountry(string city, string country)
        {
            List<Vehicle> tmp = new List<Vehicle>();


            foreach (Vehicle v in listVehicle)
            {
                if ((v.BasicLocation.Name.ToLower() == city.ToLower()) && (v.BasicLocation.Country.ToLower() == country.ToLower()))
                    tmp.Add(v);
            }

            return tmp;

        }
        public Vehicle getVehicleByID(int id)
        {
            foreach (Vehicle v in this.listVehicle)
            {
                if (v.ID == id)
                    return v;
            }

            return null;
        }

        public int Count()
        {
            return this.listVehicle.Count();
        }

        //vozila dodaje menadžer

        public void AddNewVehicle(Vehicle v)
        {
            this.listVehicle.Add(v);
        }

        public void RemoveVehicle(Vehicle v)
        {
            this.listVehicle.Remove(v);//vozilo ide u penziju
        }


        public List<Vehicle> GetAvailableOnes()
        {
            List<Vehicle> tmp = new List<Vehicle>();

            if (this.listVehicle.Count() == 0)
                return null;

            foreach (Vehicle v in this.listVehicle)
            {
                if (v.IsAvailable == true)
                {
                    tmp.Add(v);
                }
            }

            if (tmp.Count() == 0)
                return null;

            return tmp;
        }



        public int GetAvailableCount()
        {
            List<Vehicle> tmp = new List<Vehicle>();

            if (this.listVehicle.Count() == 0)
                return 0;

            foreach (Vehicle v in this.listVehicle)
            {
                if (v.IsAvailable == true)
                {
                    tmp.Add(v);
                }
            }
            return tmp.Count();

        }

        public void RemoveAllVehicles()
        {
            this.listVehicle = new List<Vehicle>();
        }

    }
}
