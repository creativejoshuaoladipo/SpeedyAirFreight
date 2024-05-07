# SpeedyAir.ly Freight Services

# Flight Scheduling System

## Overview
This project implements a flight scheduling system for SpeedyAirFreight, a simulated air freight company. The application is designed to load, schedule, and display flight orders effectively, utilizing .NET 7's built-in dependency injection to manage services and configurations.

## Problem Statement
The flight scheduling system needed to address the following challenges:
- **Dynamic Order Loading**: Load order details dynamically from a JSON file.
- **Flight Assignment**: Assign these orders to scheduled flights based on predefined criteria while ensuring no flight is overbooked.
- **Service Management**: Utilize .NET 7’s advanced features for dependency injection and service lifecycle management.

## Solution Description
The solution involves the creation of several key components structured to promote maintainability, scalability, and separation of concerns:

### Services
- `IFlightService`: Interface defining operations related to flight scheduling.
- `FlightSchedulerService`: Implements the `IFlightService` and handles the logic for creating flight schedules, loading orders, assigning them to flights, and displaying the assigned flights.

### Dependency Injection Setup
Dependency Injection is configured directly in the `Program.cs`, facilitating better testability and decoupling of components.

### Key Features
- **Flight Scheduling**: Schedule flights based on a static configuration that can easily be adjusted to dynamic data sources.
- **Order Processing**: Load and process orders from a JSON file, handling scenarios where flights might be overbooked or orders exceed the available flight capacities.
- **Console-based UI**: Display outputs directly on the console, suitable for debugging and straightforward administrative use.

## Technical Stack
- **.NET 7**: Utilized for its robust handling of dependency injection and console application configurations.
- **C#**: Programming language of choice, providing strong typing and object-oriented capabilities.

## Usage
To run this application:
1. Ensure you have .NET 7 SDK installed on your machine.
2. Clone this repository to your local machine.
3. Navigate to the project directory in your terminal.
4. Run `dotnet build` to build the project.
5. Run `dotnet run` to execute the application.


## Future Enhancements
- **Web API Integration**: Transform the console application into a Web API to allow remote handling and scheduling via HTTP requests.
- **Database Integration**: Implement a database to manage flights and orders dynamically.
- **Real-time Scheduling**: Enhance the scheduling logic to handle real-time order inputs and flight adjustments.

## Conclusion
This project demonstrates effective use of .NET 7's features to implement a robust flight scheduling system, serving as a foundational platform for future enhancements and scalability.

## License
This project is licensed under the MIT License - see the LICENSE file for details.

