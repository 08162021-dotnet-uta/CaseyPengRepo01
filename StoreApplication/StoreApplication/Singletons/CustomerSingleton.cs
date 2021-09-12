using System.Collections.Generic;
//using ModelsLayer;
using SotreApplicationBusinessLayer;
using System.Linq;

namespace StoreApplication.Singletons
{
    public class CustomerSingleton
    {
        private static CustomerSingleton _customerSingleton;
        private static readonly CustomerRepository _customerRepo = new CustomerRepository();



        public static CustomerSingleton Instance
        {
            get
            {
                if (_customerSingleton == null)
                {
                    _customerSingleton = new CustomerSingleton();
                }
                return _customerSingleton;
            }
        }
        /*
        public List<ViewModelCustomer> Customers { get; private set; }
        public void LoadCustomers()
        {
            Customers = _customerRepo.Select().Select(c=> 
            new ViewModelCustomer() { 
                 FirstName = c.FirstName,
                 LastName = c.LastName,
            }
            ).ToList();
        }
                public void RefreshData()
        {
            _customers = null;
        }
        public List<ViewModelCustomer> _customers = null;
        public List<ViewModelCustomer> Customers
        {
            get
            {
                if (_customers == null)
                {
                    _customers = _customerRepo.Select().Select(c =>
                    new ViewModelCustomer()
                    {
                        FirstName = c.FirstName,
                        LastName = c.LastName,
                    }
                    ).ToList();
                }
                return _customers;
            }
        }
        */

        public List<ViewModelCustomer> Customers
        {
            get
            { 
                //select from linq:projects eachele of a sequence into a new form
                //here convert each entity to a list element
                return _customerRepo.Load().Select(c =>
                new ViewModelCustomer()
                {
                    FirstName = c.FirstName,
                    LastName = c.LastName,
                }
                ).ToList();
                
            }
        }

    }
}