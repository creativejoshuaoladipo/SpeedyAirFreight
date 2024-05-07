using SpeedyAirFreight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAirFreight.Interfaces
{
    public interface IFlightService
    {
        List<Flight> CreateFlightSchedule();
        List<Order> LoadOrders(string filePath);
        void AssignOrdersToFlights(List<Order> orders, List<Flight> flights);
        void DisplayFlights(List<Flight> flights);
    }

}
