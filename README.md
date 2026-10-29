# Vehicles Management System

An ASP.NET Core MVC prototype for modeling vehicles and their components using **C#** and object-oriented design patterns.

The project explores how a company might organize its fleet of **cars, buses, and bikes**, track individual vehicle components, and extend vehicle behavior. It also outlines a future requirement for identifying compatible replacement engines based on a vehicle's supported engine-power range.

> **Project status:** Educational prototype. The current implementation focuses on demonstrating design patterns and component price calculation. Full fleet management, persistent vehicle records, and engine compatibility validation are not implemented.

## Features implemented

- **Vehicle creation:** Create `Car`, `Bus`, or `Bike` objects through a factory.
- **Component modeling:** Represent individual parts with a name, price, and manufacturer.
- **Component composition:** Add or remove components from a composite collection.
- **Price calculation:** Calculate the total price of components in a vehicle composite.
- **Vehicle customization example:** Demonstrate a sports-car decorator with sports-engine behavior.
- **MVC demo page:** Display a calculated component total in a Razor view.
- **Identity setup:** Configure ASP.NET Core Identity and Entity Framework Core with SQL Server.

## Technologies

| Technology | Use |
| --- | --- |
| C# / .NET 6 | Application language and runtime |
| ASP.NET Core MVC | Controllers and Razor-based web UI |
| Entity Framework Core | Data access infrastructure |
| SQL Server | Configured database provider |
| ASP.NET Core Identity | Authentication infrastructure |
| Bootstrap | UI styling |

## Design patterns

### 1. Factory pattern

[`VehicleFactory`](Models/VehicleFactory/VehicleFactory.cs) creates concrete vehicle types based on a requested name (`Car`, `Bus`, or `Bike`). Each type inherits from the abstract [`IVehicle`](Models/VehicleFactory/Vehicle/IVehicle.cs) base class and implements `CreateVehicle()`.

### 2. Composite pattern

[`IvehicleComponent`](Models/Vehicle/IvehicleComponent.cs) defines component operations. [`VehicleComponent`](Models/Vehicle/VehicleComponent.cs) is a *leaf* representing a single component, while [`VehicleComposite`](Models/Vehicle/VehicleComposite.cs) contains multiple components and sums their prices.

In the current [`CarController`](Controllers/CarController.cs) demo:

| Component | Example price |
| --- | ---: |
| Door | 100 |
| Glass | 5,000 |
| Lock | 1,000 |
| **Total** | **6,100** |

*The source code does not specify a currency.*

### 3. Decorator pattern

[`CarDecorater`](Models/VehicleFactory/decorater/CarDecorater.cs) and [`SportsCar`](Models/VehicleFactory/decorater/SportsCar.cs) demonstrate how car-specific behavior could be extended. The sports-car example currently returns a message about setting a sports engine; it does not perform a real engine swap.

## Project structure

```text
VehiclesManagementSystem/
├── Controllers/
│   ├── CarController.cs           # Vehicle/component demo
│   └── HomeController.cs
├── Data/
│   ├── ApplicationDbContext.cs    # Identity database context
│   └── Migrations/
├── Models/
│   ├── Vehicle/                  # Component and composite types
│   └── VehicleFactory/           # Vehicle types, factory, decorator
├── Views/
│   ├── Car/Index.cshtml          # Displays the component total
│   └── Home/
├── wwwroot/                       # Static assets
├── Program.cs                     # Service and middleware setup
└── VehiclesManagementSystem.csproj
```

## Getting started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0) for the project's existing target framework
- SQL Server or SQL Server Express / LocalDB
- Optional: EF Core CLI (`dotnet-ef`) for applying migrations

> .NET 6 is out of support. If you plan to maintain or deploy this project, consider upgrading to a supported .NET release.

### Run locally

1. Clone the repository:

   ```bash
   git clone https://github.com/T-King-00/VehiclesManagementSystem.git
   cd VehiclesManagementSystem
   ```

2. Configure the `DefaultConnection` SQL Server connection string. For local development, you can use .NET user secrets:

   ```bash
   dotnet user-secrets set "ConnectionStrings:DefaultConnection" "Server=(localdb)\\MSSQLLocalDB;Database=VehiclesManagementSystem;Trusted_Connection=True;MultipleActiveResultSets=true"
   ```

   Replace this example with a connection string appropriate for your SQL Server installation.

3. Restore packages:

   ```bash
   dotnet restore
   ```

4. Apply the existing Identity database migration, if you have the EF Core CLI installed:

   ```bash
   dotnet ef database update
   ```

5. Start the application:

   ```bash
   dotnet run
   ```

6. Open the local URL printed in the terminal and navigate to **`/Car`** to see the component-price demo.

**Note:** The database configuration and migration are for ASP.NET Core Identity. Vehicle and component data are currently created in memory in the controller, not stored in database tables.

## Future improvements

- Build CRUD pages for vehicles and their components.
- Add entity models and EF Core persistence for fleet records.
- Implement engine compatibility checks using supported power ranges.
- Add validation, service-layer abstractions, and automated tests.
- Replace hard-coded demo objects with user-managed data.
- Upgrade the target framework to a supported .NET version.

## Repository

[View the source code on GitHub](https://github.com/T-King-00/VehiclesManagementSystem)
