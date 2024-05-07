using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using SpeedyAirFreight.Interfaces;
using SpeedyAirFreight.Services;
using System;

var builder = Host.CreateDefaultBuilder(args);

// Configure services
builder.ConfigureServices((hostContext, services) =>
{
    services.AddTransient<IFlightService, FlightSchedulerService>();
});

var host = builder.Build();

await RunApplication(host);

async Task RunApplication(IHost host)
{
    using (var scope = host.Services.CreateScope())
    {
        var services = scope.ServiceProvider;
        try
        {
            var flightService = services.GetRequiredService<IFlightService>();
            var flights = flightService.CreateFlightSchedule();
            var orders = flightService.LoadOrders("C:\\Users\\Joshua OLADIPO\\source\\repos\\SpeedyAirFreight\\SpeedyAirFreight\\order.json");
            flightService.AssignOrdersToFlights(orders, flights);
            flightService.DisplayFlights(flights);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An error occurred: {ex.Message}");
        }
    }
}

await host.RunAsync();
