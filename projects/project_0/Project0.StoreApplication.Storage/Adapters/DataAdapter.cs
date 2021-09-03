using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Project0.StoreApplication.Domain.Abstracts;
using Project0.StoreApplication.Domain.Models;

namespace Project0.StoreApplication.Storage.Adapters
{
  public class DataAdapter : DbContext
  {
    public DbSet<Customer> Customers { get; set; }
    public DbSet<Order> Orders { get; set; }
    public DbSet<Product> Products { get; set; }
    public DbSet<Store> Stores { get; set; }

//DbContextOptionsBuilder : use to create options fot the contest. define methods in this obj to configure the context
//pass potions to constructor=> easy to pass configiration via dbcontext constructor 
    protected override void OnConfiguring(DbContextOptionsBuilder builder)
    {
    //  Configures the context to connect to a Microsoft SQL Server database
      builder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=StoreApplicationDB;Trusted_Connection=true;");
    }
  }
}