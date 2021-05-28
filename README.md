# Dr. Sillystringz's Factory

By Cassandra Copp

## Description
This MVC web application allows the user to add machines and engineers to the factory database.  The user can add machines to engineers and engineers to machines, representing a many-to-many relationship.  Migrations are used in this project to allow the database structure to be easily set up upon downloading the program.

## Technologies Used

* C#
* ASP.NET Core
* Entity Framework
* MySQL

### System Requirements 
1. [.NET 5.0](https://dotnet.microsoft.com/download)  
1. [MySQL Community Server](https://dev.mysql.com/downloads/file/?id=484914)
1. [MySQL Workbench](https://dev.mysql.com/downloads/file/?id=484391) (optional, can be used to view and edit the database outside of the application)

### Installation
1. Clone the [Factory.Solution](https://github.com/cass1618/Factory.Solution) Repository

    ### Set Up Required Database
    1. To update the database, dotnet-ef must be installed.  Run the following command in terminal, in any directory:
    ```sh
    dotnet tool install --global dotnet-ef
    ```
    2. To create the database, run the following command in the Factory.Solution/Factory directory:
    ```sh
    dotnet ef database update
    ```
    3. If you would like to view the database you may do so in MySQL Workbench.  The database will be titled cassandra_copp (or whatever the database name in appsettings.json)

2. Add an `appsettings.json` file to the `Factory.Solution/Factory` directory and add the following:
```json
{
  "ConnectionStrings": {
      "DefaultConnection": "Server=localhost;Port=3306;database=cassandra_copp;uid=root;pwd=YourPassword;"
  }
}
```
3. Replace YourPassword with your own MySQL password
4. To run the app in terminal, navigate to `Factory.Solution/Factory` directory and enter the command:
```cs
$ dotnet run
```
6. If the server does not automatically open enter localhost:5000 in the address bar of your web browser

## Known bugs

This application has no known bugs.

## License

[MIT](https://opensource.org/licenses/MIT)

Copywrite (c) Cassandra Copp 2021.

## Contact Information

[github.com/cass1618](http://github.com/cass1618)