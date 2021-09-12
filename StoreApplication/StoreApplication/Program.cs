using System;

using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using StoreApplication.Singletons;

namespace StoreApplication
{
    class Program
    {
        private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
        private static readonly StoreSingleton _storeSingleton = StoreSingleton.Instance;
        static void Main(string[] args)
        {
            #region
            /*
            ViewModelCustomer newCustomer  = new ViewModelCustomer();
            newCustomer.FirstName = "Mandy";
            newCustomer.LastName ="K";
            System.Console.WriteLine($"newCustomer: {newCustomer.FirstName}");*/
            #endregion


            /*  using (AstoreApplicationDBContext context = new AstoreApplicationDBContext())
              {

                  /*
                  var customers = context.Customers.FromSqlRaw<Customer>("SELECT * FROM Customer.Customer").ToList();
                  foreach(var cust in customers)
                  {
                      Console.WriteLine($"Customer firstName{cust.FirstName}, lastname LastName {cust.LastName}");
                  }*/



            //   }

            Console.WriteLine("Welcome,here are the customers!!!");

            foreach (var cus in _customerSingleton.Customers)
            {
                Console.WriteLine($"Customer firstName{cus.FirstName}, LastNAME{cus.LastName}");
            }


            Console.WriteLine("Welcome,here are the stores");
            foreach (var store in _storeSingleton.Stores)
            {
                Console.WriteLine($" {store.StoreName} , {store.StoreLocation}");

            }

            foreach(var storeInventory in _storeSingleton.GetInventory(1))
            {
                Console.WriteLine($"{storeInventory.ProductName} , {storeInventory.ProductDescription},{storeInventory.ProductPrice}");
            }

            ViewModelOrder newOrder = new ViewModelOrder {
                CustomerId = 1,
                OrderDate = DateTime.Now,
                StoreId = 1,
                OrderTotal = 20
            };
            newOrder.OrderProducts = new List<ViewModelOrderProduct>();
            newOrder.OrderProducts.Add(new ViewModelOrderProduct {ProductId = 1, Quantity = 2 });
            newOrder.OrderProducts.Add(new ViewModelOrderProduct { ProductId = 3, Quantity = 50 });

            _storeSingleton.PlaceOrder(newOrder);
        }
    }
}
