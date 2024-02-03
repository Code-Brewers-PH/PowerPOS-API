
# PowerPOS API

This project is a Point of Sale (POS) system built using a .NET API. It provides businesses with a modern and flexible solution for managing sales, inventory, customers, and more.




## Features

- Built using .NET technology for performance and scalability.
- API-based architecture for easy integration with other applications.
- Will support product management, sales tracking, inventory control, customer management, reporting, etc. (work in progress)


## Deployment

Setup the database migrations by typing in the Package Console Manager (Infrastructure class library project):

```bash
  PM> Add-migration <migration-name>
  PM> Update-database 
```

To remove migrations:
```bash
  PM> Remove-migration
```

Populate data using SeedData method inside the RepositoryContext class and run the steps above.

To test API endpoints, use the URL:
```bash
  https://localhost:7124 (localhost)
  or
  dotnet run --host=0.0.0.0 --public-host=$skye0814-congenial-space-spork-7xgqqxp74vpcx6w4-7124.preview.app.github.dev (GitHub Codespaces)
```

## Authors

- [@skye0814](https://github.com/skye0814)
- [@Edson101014](https://github.com/Edson101014)

