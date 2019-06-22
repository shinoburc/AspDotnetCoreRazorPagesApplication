# AspDotnetCoreRazorPagesApplication

## Dependencies

- .NET Core 2.2
- PostgreSQL

## Run

```sh

$ git clone https://github.com/shinoburc/AspDotnetCoreRazorPagesApplication.git
$ cd AspDotnetCoreRazorPagesApplication
$ vi AspDotnetCoreRazorPagesApplication/appsettings.json
```

```csharp
    "PostgreSQLConnection": "Host=localhost; Database=asp_dotnet_core_razor_pages; Username=postgres; Password=postgres"
```

```sh
$ dotnet restore
$ dotnet ef database update
$ dotnet run

```
