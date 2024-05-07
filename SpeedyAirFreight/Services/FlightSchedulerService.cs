using Newtonsoft.Json;
using SpeedyAirFreight.Interfaces;
using SpeedyAirFreight.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedyAirFreight.Services
{
   
    public class FlightSchedulerService: IFlightService
    {
        public List<Flight> CreateFlightSchedule()
        {
            var flights = new List<Flight>();

            // Flights to three destinations: Toronto, Calgary, Vancouver
            var destinations = new List<string> { "YYZ", "YYC", "YVR" };

            // Two days of flights
            for (int day = 1; day <= 2; day++) 
            {
                // Adjust flight number based on day
                int flightNumber = 1 + (day - 1) * 3; 
                foreach (var destination in destinations)
                {
                    flights.Add(new Flight(flightNumber++, destination, day));
                }
            }
            return flights;
        }

        public  List<Order> LoadOrders(string filePath)
        {
            var orders = new List<Order>();
            var json = File.ReadAllText(filePath);
            dynamic ordersData = JsonConvert.DeserializeObject(json);

            foreach (var orderData in ordersData)
            {
                orders.Add(new Order(orderData.Name, orderData.Value.destination.ToString()));
            }
            return orders;
        }

        public  void AssignOrdersToFlights(List<Order> orders, List<Flight> flights)
        {
            foreach (var order in orders)
            {
                var flight = flights.FirstOrDefault(f => f.ArrivalCity == order.Destination && f.Orders.Count < 20);
                if (flight != null)
                {
                    flight.Orders.Add(order);

                    // Mark the order as scheduled
                    order.IsScheduled = true;  
                }
            }

            // Handle unscheduled orders
            foreach (var unscheduledOrder in orders.Where(o => !o.IsScheduled))
            {
                Console.WriteLine($"Order: {unscheduledOrder.OrderNumber}, Flight Number: not scheduled");
            }
        }


        public  void DisplayFlights(List<Flight> flights)
        {
            foreach (var flight in flights)
            {
                Console.WriteLine($"Flight: {flight.FlightNumber}, Departure: {flight.DepartureCity}, Arrival: {flight.ArrivalCity}, Day: {flight.Day}");
                foreach (var order in flight.Orders)
                {
                    Console.WriteLine($"\tOrder: {order.OrderNumber}, Flight Number: {flight.FlightNumber}");
                }
            }
        }



    }


}
