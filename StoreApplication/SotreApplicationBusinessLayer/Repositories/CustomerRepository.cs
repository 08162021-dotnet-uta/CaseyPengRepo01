using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StoreApplicationDbContext.Models;
using SotreApplicationBusinessLayer;
using Microsoft.EntityFrameworkCore;

namespace SotreApplicationBusinessLayer
{
    public class CustomerRepository: IRpository<Customer>
    { 
        private  AstoreApplicationDBContext context;

        public CustomerRepository()
        {

            context = new AstoreApplicationDBContext();
        }

        public bool Delete(int Id)
        {
            throw new System.NotImplementedException();
        }
        public bool Insert(Customer entry )
        {
            throw new System.NotImplementedException();
        }

        public List<Customer> Load()
        {
            return context.Customers.FromSqlRaw("SELECT*FROM Customer.Customer").ToList();
    }
        public bool Update()
        {
            throw new System.NotImplementedException();
        }


    }
}