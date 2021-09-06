using DemoStoreDbContext.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Cust = DemoStoreDbContext.Models.Customer;

namespace _08162021batchDemoStore
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer firstCustomer = new Customer();
            firstCustomer.Fname="Jannie";
            firstCustomer.Lname="Chan";
            Customer secondCustomer = new Customer("Sunday" ,"Always");
            Console.WriteLine($"{firstCustomer.Fname} {firstCustomer.Lname} {secondCustomer.Fname} {secondCustomer.Lname}");
            //using statement create a scope
            //create a intancE of Demo_0816..gives you access to the db
            using (Demo_08162021batchContext context = new Demo_08162021batchContext())
            {
     // without  using Cust =  DemoStoreDbContext.Models.Customer; you need to do the following
               // var customers = context.Customers.FromSqlRaw<DemoStoreDbContext.Models.Customer>("SELECT* FROM Customers").ToList();
           
                //you can replace line 24 with 
                
                 var customers = context.Customers.FromSqlRaw<Cust>("SELECT* FROM Customers").ToList();
                foreach ( var cust in customers)
                {
                    Console.WriteLine($"Customer's first name is {cust.FirstName}, last Name is {cust.LastName}");
                }
                Cust newCustomer =  new Cust()
                {
                    FirstName = "Heroine",
                    LastName = "Wonder"
                };
                //insert the new customer to the db and save it 
                context.Add(newCustomer);
                context.SaveChanges();
                //if you pull out one one person, you dont need to do ToList(), default is null
                //context.Customers is the customer from demo 08162021batchContext.Customers{get;set;}
                var newCust = context.Customers.FromSqlRaw<Cust>("SELECT * FROM Customers WHERE Customers.FirstName= 'Heroine' ").FirstOrDefault();
                Console.WriteLine($"The new Customer you just ADDED is {newCust.FirstName} {newCust.LastName}");

            }
        }
    }
}
