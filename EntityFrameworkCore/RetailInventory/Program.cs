/*
 * Lab 2: Setting up Entity Framework Core
 * Author: Nilanjan Pradhan
 */

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RetailInventory.Data;

Console.WriteLine("Retail Inventory System");
Console.WriteLine("-----------------------");

IConfiguration config =
    new ConfigurationBuilder()
    .SetBasePath(Directory.GetCurrentDirectory())
    .AddJsonFile("appsettings.json")
    .Build();

string connectionString =
    config.GetConnectionString("RetailDb");

var options =
    new DbContextOptionsBuilder<AppDbContext>()
    .UseSqlServer(connectionString)
    .Options;

using AppDbContext db =
    new AppDbContext(options);

Console.WriteLine("Entity Framework Core configured successfully.");
Console.WriteLine("Connection String Loaded Successfully.");