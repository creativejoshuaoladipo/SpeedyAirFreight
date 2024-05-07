using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAirFreight.Models
{

    public class Flight
    {
        public int FlightNumber { get; set; }
        public string DepartureCity { get; set; } = "YUL"; // Montreal is the fixed departure city.
        public string ArrivalCity { get; set; }
        public int Day { get; set; }
        public List<Order> Orders { get; } = new List<Order>(); // Stores orders assigned to this flight

        public Flight(int flightNumber, string arrivalCity, int day)
        {
            FlightNumber = flightNumber;
            ArrivalCity = arrivalCity;
            Day = day;
        }
    }


}
