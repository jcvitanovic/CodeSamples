using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlong
{
    public class CityRepository
    {
        private static CityRepository instance = null;
        List<City> listCities = new List<City>();

        public static CityRepository GetInstance()
        {
            if (instance == null)
                instance = new CityRepository();
            return instance;
        }

        public List<string> getCitiesList()
        {

            if (this.Count() == 0)
                return null;

            List<string> strings = new List<string>();
            string tmp = "";
            foreach (City c in this.listCities)
            {
                tmp = c.Name + " ( " + c.Country + " ) ";
                strings.Add(tmp);
                tmp = "";
                }

            return strings;
        }
        //služit će za padajući izbornik kod prikaza - korisnici će birati samo od ponuđenih gradova

        //gradove dodaje menadžer

        public void addCity(string cityName, string countryName)
        {
            City tmp = new City(cityName, countryName);
            listCities.Add(tmp);
        }

        int Count()
        {
            return this.listCities.Count();
        }

        public void clearAll()
        {
            this.listCities = new List<City>();
        }
    }
}
