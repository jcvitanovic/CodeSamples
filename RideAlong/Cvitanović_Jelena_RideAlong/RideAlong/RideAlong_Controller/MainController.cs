using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RideAlongUtil;
using RideAlong;

namespace RideAlong_Controller
{

    public class Match
    {
        public DateTime departure;
        public DateTime arrival;
        public Trip t;

        public Match(DateTime d, DateTime a, Trip t)
        {
            this.departure = d;
            this.arrival = a;
            this.t = t;
        }
        
    }
    public class MainController
    {
        public Employee ActiveUser { get; set; }

        private static MainController instance = null; //main kontroler neka bude jedinstven za sve forme

        public static MainController Do()
        {
            if (instance == null)
                instance = new MainController();
            return instance;
        }


        
        public void setActiveUser()
        {
            this.ActiveUser = EmployeeRepository.GetInstance().listEmployee[0];
        }
        public void sayHelloToUser(IEmployeeEntryForm form)
        {
            form.setHelloLabel(ActiveUser.Name + " " + ActiveUser.Surname);
        }
        public void openManagerEntryForm(IManagerEntryForm form)
        {
            form.showForm();
        }

        public void openNewTripForm(INewTripForm form)
        {
            form.showForm();
        }


        public void openBrowseForm(IBrowseTripsForm form)
        {
            form.showForm();
        }

        public void closeBrowseForm(IBrowseTripsForm form)
        {
            form.closeForm();
        }
        public void closeNewTripForm(INewTripForm form)
        {
            form.closeForm();
        }
        public void closeManagerEntryForm(IManagerEntryForm form)
        {
            form.closeForm();
        }

        public void openEmployeeEntryForm(IEmployeeEntryForm form)
        {
            form.showForm();
        }
        public void closeEmployeeEntryForm(IEmployeeEntryForm form)
        {
            form.closeForm();
        }

        public void openAddVehicleForm(IAddVehicleForm form)
        {
            form.showForm();
        }

        public void closeAddVehicleForm(IAddVehicleForm form)
        {
            form.closeForm();
        }

        public void approveSelectedTrips(IManagerEntryForm form)
        {
            int id = form.getSelectedTripID();
            Trip t = TripRepository.GetInstance().getTripByID(id);
            t.IsAprooved = true;
            form.clearItems();
        }
        public void displayMyTrips(IEmployeeEntryForm form)
        {
            List<Trip> trips = new List<Trip>();

            foreach(Trip t in TripRepository.GetInstance().getAcitveOnes())
            {
                if (t.TripOwner == ActiveUser)
                {
                    trips.Add(t);
                }
            }

            foreach (Trip t in trips)
            {
                string id = t.ID.ToString();
                string from = t.DepartureCity.Name + "," + t.DepartureCity.Country;
                string to = t.DestinationCity.Name + "," + t.DestinationCity.Country;
                string date = t.departureDate.ToString();
                string ap;
                if (t.IsAprooved == false)
                    ap = "NO";
                else
                    ap = "YES";

                form.setDisplayItem(id, from, to, date, ap);
            } 
        

            
        
        }

        public bool checkIfAnyAvailableVehicle()
        {
            if (VehicleRepository.GetInstance().GetAvailableCount() != 0)
                return true;
            else
                return false;
        }


        public void getAvailableVehicles(INewTripForm form)
        {
            List<Vehicle> tmp = VehicleRepository.GetInstance().GetAvailableOnes();
            foreach (Vehicle v in tmp)
            {
                string id = v.ID.ToString();
                string model = v.Model;
                string location = v.BasicLocation.Name + "," + v.BasicLocation.Country;
                string consumption = v.Consumption.ToString();
                form.getAvVehiclesDisplay(id, model, location, consumption);
            }

        }

        public void displayPartTrips(IEmployeeEntryForm form)
        {
            foreach (Trip t in ActiveUser.ParticipatedTripList)
            {
                string id = t.ID.ToString();
                string from = t.DepartureCity.Name + "," + t.DepartureCity.Country;
                string to = t.DestinationCity.Name + "," + t.DestinationCity.Country;
                string date = t.departureDate.ToString();
                string driver = t.TripOwner.Name + " " + t.TripOwner.Surname;
                form.setDisplayPartTrip(id, from, to, date, driver);

            }
        }

        public void displayContacts(IEmployeeEntryForm form)
        {
            int id = form.getSelectedPartTripID();
            Trip t = TripRepository.GetInstance().getTripByID(id);

            Employee e = t.TripOwner;

            form.setDisplayContacts(e.Name + " " + e.Surname, e.ContactPhone, e.ContactEMail);

            foreach(Employee em in t.getTravellers())
            {
                if(em!=ActiveUser && em != t.TripOwner)
                {
                    
                form.setDisplayContacts(em.Name + " " + em.Surname, em.ContactPhone, em.ContactEMail);
                }
            }



        }
        public void displayTripDetails(IEmployeeEntryForm form)
        {
            int id = form.getSelectedMyTripID();
            Trip t = TripRepository.GetInstance().getTripByID(id);

            form.setDisplayTripDetails("Stops:");

            foreach (TripStops ts in t.Stops)
            {
                string s = ts.City.Name + "," + ts.City.Country;
                s += "(" + ts.TripDate.ToString() + ")";
                form.setDisplayTripDetails(s);
            }

            form.setDisplayTripDetails("Travellers:");

            foreach (Employee e in t.getTravellers())
            {
                string s = e.Name + " " + e.Surname;
                form.setDisplayTripDetails(s);
            }


            form.setDisplayTripDetails("Cost:");

            form.setDisplayTripDetails(t.TripCost.ToString() + " € ");
        }

        public void cancelSelectedTrips(IEmployeeEntryForm form)
        {
            int id = form.getSelectedMyTripID();
            Trip t = TripRepository.GetInstance().getTripByID(id);
            TripRepository.GetInstance().removeTrip(t);
        }

        public void removeUserFromTrip(IEmployeeEntryForm form)
        {
            int id = form.getSelectedPartTripID();
            Trip t = TripRepository.GetInstance().getTripByID(id);
            t.removeTraveller(ActiveUser);
            ActiveUser.removeParticipatedTrip(t);
        }

        public void returnConfirmation(IEmployeeEntryForm form)
        {
            int id = form.getSelectedMyTripID();
            Trip t = TripRepository.GetInstance().getTripByID(id);
            t.isDone = true;
            t.Vehicle.IsAvailable = true;
        }

        public void registerUserForTheTrip(IBrowseTripsForm form)
        {
            Trip t = TripRepository.GetInstance().getTripByID(form.getSelectedTripID());

            if(ActiveUser.checkIfAlreadyOnTrip(t.ID)==false)
                t.addTraveller(ActiveUser);
        }


        public void getSearchedTrip(IBrowseTripsForm form)
        {
            bool destFound = false;
            bool depFound = false;

            DateTime depTime = new DateTime();
            DateTime destTime = new DateTime();

            List<Trip> trips = TripRepository.GetInstance().GetNotFullOnes();
            List<Match> matchList = new List<Match>();

            string departure = form.getSelectedCityDeparture().ToLower();
            departure += "," + form.getSelectedCountryDeparture().ToLower();

            string destination = form.getSelectedCityDestination().ToLower();
            destination += "," + form.getSelectedCountryDest().ToLower();

            foreach (Trip t in trips)
            {
                if (t.isDone == false)
                {
                    foreach (TripStops st in t.Stops)
                    {
                        string tmp1 = st.City.Name.ToLower();
                        tmp1 += "," + st.City.Country.ToLower();

                        if (tmp1 == departure)
                        {
                            depFound = true;
                            depTime = st.TripDate;
                        }

                        if (tmp1 == destination)
                        {
                            destFound = true;
                            destTime = st.TripDate;
                        }                   


                    }

                    if (destFound == true && depFound == true && destTime > depTime)
                    {
                        matchList.Add(new Match(depTime, destTime, t));                      
                    }                    
            }      
                }

            foreach (Match m in matchList)
            {
                string id = m.t.ID.ToString();
                string depart = m.departure.ToString();
                string arrival = m.arrival.ToString();
                string name = m.t.TripOwner.Name +" "+ m.t.TripOwner.Surname;
                string phone = m.t.TripOwner.ContactPhone;
                string mail = m.t.TripOwner.ContactEMail;

                form.setDisplayItem(id, depart, arrival, name, phone, mail);

            }
            
        }

        public void displayAllVehicles(IManagerEntryForm form)
        {
            List<Vehicle> vehicles = VehicleRepository.GetInstance().listVehicle;

            foreach (Vehicle v in vehicles)
            {
                string id = v.ID.ToString();
                string model = v.Model;
                string location = v.BasicLocation.Name + "," + v.BasicLocation.Country;
                string av;
                if (v.IsAvailable == true)
                    av = "YES";
                else
                    av = "NO";
                form.setDisplayVehicle(id, model, location, av);


            }
        }

        public void addTripToRepository(INewTripForm form)
        {
            Vehicle v = VehicleRepository.GetInstance().getVehicleByID(form.getSelectedVehicleID());

            Trip trip = new Trip(ActiveUser, v, form.getDepartureDate(), new City(form.getDepartureCity()[0], form.getDepartureCity()[1]), new City(form.getDestinationCity()[0], form.getDestinationCity()[1]), form.getRouteLngth());

            if (form.getStop1() != null)
            {
                trip.addStop(new TripStops(new City(form.getStop1()[0],form.getStop1()[1]),form.getStop1Date(), 1));
            }


            if (form.getStop2() != null)
            {
                trip.addStop(new TripStops(new City(form.getStop2()[0], form.getStop2()[1]), form.getStop2Date(), 1));
            }

            if (form.getStop3() != null)
            {
                trip.addStop(new TripStops(new City(form.getStop3()[0], form.getStop3()[1]), form.getStop3Date(), 1));
            }

            if (form.getStop4() != null)
            {
                trip.addStop(new TripStops(new City(form.getStop4()[0], form.getStop4()[1]), form.getStop4Date(), 1));
            }

            TripRepository.GetInstance().addTrip(trip);

        }

        public void displayUnapprovedTrips(IManagerEntryForm form)
        {
            List<Trip> trips = TripRepository.GetInstance().getNotApprovedOnes();

            foreach (Trip t in trips)
            {
                string id = t.ID.ToString();
                string departure = t.DepartureCity.Name;
                departure += ","  +t.DepartureCity.Country;
                string date = t.departureDate.ToString();
                string employee = t.TripOwner.Name;
                employee += " " + t.TripOwner.Surname;
                string model = t.Vehicle.Model;
                string cost = t.TripCost.ToString();

                form.setDisplayItem(id, departure, date, employee, model, cost);
            }
        }
        public void addVehicleToRepository(IAddVehicleForm form)
        {
            VehicleType type = VehicleType.other; //default
            Vehicle newVehicle;
            switch (form.getVehicleType()) 
            {
                case "Car":
                    type = VehicleType.car;
                    break;
                case "Minivan":
                    type = VehicleType.minivan;
                    break;
                case "Caravan":
                    type = VehicleType.caravan;
                    break;
                case "Other":
                    type = VehicleType.other;
                    break;
            }

            if(form.getAddress() == "")
            {
                newVehicle = VehicleFactory.CreateVehicleWithNoInfoAdress(type,form.getVehicleModel(),form.getCapacity(), form.getConsumption(), new City(form.getCity(), form.getCountry()));
                       
            }
            else
            {
                 newVehicle = VehicleFactory.CreateVehicleWithInfoAdress(type,form.getVehicleModel(),form.getCapacity(), form.getConsumption(), new City(form.getCity(), form.getCountry()),form.getAddress());

            }
            VehicleRepository.GetInstance().AddNewVehicle(newVehicle);
            form.closeForm();
                
        }
    }
}
