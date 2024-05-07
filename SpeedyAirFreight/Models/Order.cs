namespace SpeedyAirFreight.Models
{
    public class Order
    {
        public string OrderNumber { get; set; }
        public string Destination { get; set; }
        public bool IsScheduled { get; set; } = false;  // Flag to check if the order is scheduled

        public Order(string orderNumber, string destination)
        {
            OrderNumber = orderNumber;
            Destination = destination;
        }
    }


}