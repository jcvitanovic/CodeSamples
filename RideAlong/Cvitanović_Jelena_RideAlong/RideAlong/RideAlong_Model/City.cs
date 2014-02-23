using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace RideAlong
{
    public class City
    {
        public string Name {get; set; }
        public string Country {get; set;}

        public City(string name, string countryName)
        {
            this.Name = name;
            this.Country = countryName;
        }

    }
}
