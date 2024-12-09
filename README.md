# Clean Architecture Project

This project is an implementation of the Clean Architecture pattern in .NET. It is designed to separate concerns across different layers, making the system more maintainable and testable.

## Project Structure

- **CleanArchitecture.Application**: Contains application logic and business rules.
- **CleanArchitecture.Domain**: Contains domain entities and aggregates.
- **CleanArchitecture.Persistence**: Manages data access and storage.
- **CleanArchitecture.WebAPI**: Exposes the application functionality via RESTful APIs.
- **CleanArchitecture.UnitTest**: Contains unit tests for the application.

## Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- [Entity Framework Core CLI](https://docs.microsoft.com/en-us/ef/core/cli/dotnet)

## Getting Started

### Clone the Repository

```bash
git clone https://github.com/your-repo/clean-architecture.git
cd clean-architecture
```

### Restore Dependencies

```bash
dotnet restore
```

### Build the Project

```bash
dotnet build
```

### Run the Application

Navigate to the `CleanArchitecture.WebAPI` directory and run:

```bash
dotnet run
```

The application will start and be accessible at `http://localhost:5000`.

### Running Migrations

To apply migrations, use the following command:

```bash
dotnet ef migrations add Initial --project CleanArchitecture.Persistence --startup-project CleanArchitecture.WebAPI
dotnet ef database update --project CleanArchitecture.Persistence --startup-project CleanArchitecture.WebAPI
```

### Running Unit Tests

To execute the unit tests, run the following command in the root directory:

```bash
dotnet test
```

## Contributing

Contributions are welcome! Please fork the repository and submit a pull request for review.

## License

This project is licensed under the MIT License.

This project based on https://github.com/juldhais/CleanArchitecture 
