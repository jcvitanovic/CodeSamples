using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RideAlong;

namespace RideAlongModelTest
{
    [TestClass]
    public class RideAlongModelTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            //Dodajemo jedno vozilo u repozitorij, zatim testiramo hoće li na repozitorij ispravno vratiti kolko ima slobodnih vozila

            //isto provjeravamo nakon što dodamo zaposlenike na put

            //arrange

            Employee e1 = new Employee("12348501236", "Jelena", "Cvitanović", "Indirektna prodaja", "0989036876", "jcvitanovic@linkit.com");
            Employee e2 = new Employee("","Pero", "Perić", "Financije", "0977253426", "pperic@linkit.com");
            Employee e3 = new Employee("","Mirna", "Mirić", "IT", "0912542456", "mmiric@linkit.com");
            City city = new City("Zagreb", "Croatia");
            City city2 = new City("Ljubljana", "Slovenia");

            int expected = 0;
            Vehicle v = new Vehicle(VehicleType.car, "Toyota",2, 7, city);
            Trip t = new Trip(e1, v, DateTime.Today, city, city2, 100);
            TripRepository.GetInstance().addTrip(t);           


            //act

            VehicleRepository.GetInstance().AddNewVehicle(v);
            int actual = VehicleRepository.GetInstance().GetAvailableCount();

            t.addTraveller(e2);
            int actual2 = TripRepository.GetInstance().getNotFullOnesCount();

            //assert

            Assert.AreEqual(expected, actual, "Repozitorij ne prepoznaje ispravno slobodna vozila.");
            Assert.AreEqual(0, actual2, "Repozitorij ne prepoznaje ispravno slobodna vozila2.");
            

        }

        //provjera da li se dobro registrira tko je inicirao putovanje
        [TestMethod]
        public void TestMethod2()
        {
            //arrange

            Employee e1 = new Employee("12348501236","Jelena", "Cvitanović", "Indirektna prodaja", "0989036876", "jcvitanovic@linkit.com");
            Employee e2 = new Employee("","Pero", "Perić", "Financije", "0977253426", "pperic@linkit.com");
            City city = new City("Zagreb", "Croatia");
            City city2 = new City("Ljubljana", "Slovenia");

            Vehicle v = new Vehicle(VehicleType.car, "Toyota", 2, 7, city);
            Trip t = new Trip(e1, v, DateTime.Today, city, city2, 100);
            TripRepository.GetInstance().addTrip(t);


            //act

            VehicleRepository.GetInstance().AddNewVehicle(v);
            t.addTraveller(e2);

            string name = t.TripOwner.Name;
            string expected = "Jelena";

            //assert

            Assert.AreEqual(expected, name, "Neispravno registriran inicijator puta.");

        }


        //provjera da li repozitorij ispravno 'vraća' vozila u slobodno stanje
        [TestMethod]
        public void TestMethod3()
        {
            //arrange

            Employee e1 = new Employee("12348501236", "Jelena", "Cvitanović", "Indirektna prodaja", "0989036876", "jcvitanovic@linkit.com");
            City city = new City("Zagreb", "Croatia");
            City city2 = new City("Ljubljana", "Slovenia");

            Vehicle v = new Vehicle(VehicleType.car, "Toyota", 2, 7, city);
            Trip t = new Trip(e1, v, DateTime.Today, city, city2, 100);
            VehicleRepository.GetInstance().AddNewVehicle(v);
            TripRepository.GetInstance().addTrip(t);

            t.Vehicle.IsAvailable = true; //ovo će inače kontroler raditi 
            int expected = 1;           


            //act
            int actual = VehicleRepository.GetInstance().GetAvailableCount();

            //assert
            Assert.AreEqual(expected, actual, "Vozilo nije vraćeno u slobodne");


        }


        [TestMethod]
        public void TestMethod4()
        {
            //arrange

            Employee e3 = new Employee("12348501236", "Jelena", "Cvitanović", "Indirektna prodaja", "0989036876", "jcvitanovic@linkit.com");
            Employee e2 = new Employee("","Pero", "Perić", "Financije", "0977253426", "pperic@linkit.com");
            City city = new City("Zagreb", "Croatia");
            City city2 = new City("Ljubljana", "Slovenia");

            Vehicle v = new Vehicle(VehicleType.car, "Toyota", 2, 7, city);
            Vehicle v2 = new Vehicle(VehicleType.car, "Toyota", 4, 7, city);
            Vehicle v3 = new Vehicle(VehicleType.caravan, "Toyota", 8, 12, city);

            VehicleRepository.GetInstance().RemoveAllVehicles();

            VehicleRepository.GetInstance().AddNewVehicle(v);
            VehicleRepository.GetInstance().AddNewVehicle(v2);
            VehicleRepository.GetInstance().AddNewVehicle(v3);


            Trip t = new Trip(e3, v, DateTime.Today, city, city2, 100);
            //što kada pokušaš zauzeti već zauzeti auto? - dodati provjeru i/li exception!
            Trip t1 = new Trip(e3, v2, DateTime.Today, city, city2, 100);
            Trip t2 = new Trip(e3, v3, DateTime.Today, city, city2, 100);

            t2.addTraveller(e2);


            //act
            int actual = VehicleRepository.GetInstance().GetAvailableCount();
            int initiCnt = e3.InitiatedTripList.Count();
            int partCnt = e3.ParticipatedTripList.Count();
            int initCnt1 = e2.InitiatedTripList.Count();
            int tripCnt = t.getTravellersCount();
            int trip2Cnt = t2.getTravellersCount();
    

            //assert
            Assert.AreEqual(0, actual, "Neispravan broj slobodnih vozila");
            Assert.AreEqual(3, initiCnt, "Neispravan broj iniciranih putovanja");
            Assert.AreEqual(0, partCnt, "Neispravan broj putovanja na kojima je zaposlenik sudjelovao");
            Assert.AreEqual(0, initCnt1, "Neispravan broj iniciranih putovanja2");
            Assert.AreEqual(1, tripCnt, "Neispravan broj putnika");
            Assert.AreEqual(2, trip2Cnt, "Neispravan broj putnika2");
        }

        [TestMethod]
        public void TestMethod5()
        {
            //arrange

            Employee e1 = new Employee("12348501236","Jelena", "Cvitanović", "Indirektna prodaja", "0989036876", "jcvitanovic@linkit.com");
            Employee e2 = new Employee("","Pero", "Perić", "Financije", "0977253426", "pperic@linkit.com");
            City city = new City("Zagreb", "Croatia");
            City city2 = new City("Ljubljana", "Slovenia");
            e1.removeAllTrips();
            e2.removeAllTrips();
            Vehicle v = new Vehicle(VehicleType.car, "Toyota", 2, 7, city);

            VehicleRepository.GetInstance().RemoveAllVehicles();
            VehicleRepository.GetInstance().AddNewVehicle(v);


            Trip t = new Trip(e1, v, DateTime.Today, city, city2, 100);
            t.addTraveller(e2);

            //act

            int check = e2.ParticipatedTripList.Count();
            int check2 = e2.InitiatedTripList.Count();

            //assert

            Assert.AreEqual(1, check, "Nesipravno bilježnjenje putovanja na kojem je zaposlenik sudjelovao");
            Assert.AreEqual(0, check2, "Nesipravno bilježnjenje putovanja koje je zaposlenik inicirao");     
        }


        [TestMethod]
        public void TestMethod6()
        {
            //arrange

            Employee e1 = new Employee("12348501236","Jelena", "Cvitanović", "Indirektna prodaja", "0989036876", "jcvitanovic@linkit.com");
            Employee e2 = new Employee("", "Pero", "Perić", "Financije", "0977253426", "pperic@linkit.com");
            City city = new City("Zagreb", "Croatia");
            City city2 = new City("Ljubljana", "Slovenia");
            e1.removeAllTrips();
            e2.removeAllTrips();
            Vehicle v = new Vehicle(VehicleType.car, "Toyota", 2, 7, city);
            VehicleRepository.GetInstance().RemoveAllVehicles();
            VehicleRepository.GetInstance().AddNewVehicle(v);

            Trip t = new Trip(e1, v, DateTime.Today, city, city2, 100);
            t.addTraveller(e2);
            TripStops stop1 = new TripStops(new City("Karlovac", "Croatia"), DateTime.Today, 4);
            t.addStop(stop1);

            //act

            int check = t.Stops.Count();

            //assert

            Assert.AreEqual(2, check, "Nesipravno bilježnjenje rute");

        }



    }
}
