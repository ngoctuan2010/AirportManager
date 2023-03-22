using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class FlightServices
    {
        public static List<Flight> LoadFlight()
        {
            List<Flight> flightList;
            using (var db = new AirportManager())
            {
                flightList = db.Flights.ToList();
            }
            return flightList;
        }


        public static DbSet<Flight> AddFlight(int flightId, int planeId, string departure, DateTime dateOfDeparture, string destination, DateTime dateOfDestination, string airline)
        {
            DbSet<Flight> flights;
            using (var db = new AirportManager())
            {
                flights = db.Set<Flight>();
                flights.Add(new Flight() { FlightID = flightId, PlaneID = planeId, Departure = departure, DateOfDeparture = dateOfDeparture, Destination = destination, DateOfDestination = dateOfDestination, Airline = airline});

                db.SaveChanges();
            }
            return flights;
        }

        public void UpdateFlight()
        {
           
        }
        public static DbSet<Flight> DeleteFlight(int FlightID)
        {
            DbSet<Flight> flights;
            using (var db = new AirportManager())
            {
                flights = db.Set<Flight>();
                flights.Remove(new Flight() { FlightID = FlightID });
                db.SaveChanges();
            }
            return flights;
        }
      
    }
}
