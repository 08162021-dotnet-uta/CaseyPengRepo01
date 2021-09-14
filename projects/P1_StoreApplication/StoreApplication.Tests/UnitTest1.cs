using System;
using Xunit;
using StoreApplication;
using StoreApplication.Singletons;

namespace StoreApplication.Tests
{
    public class UnitTest1
    {
        private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
        [Fact]
        public void getCutomers()
        {
            //find cust by id
            var findcust = CustomerSingleton.Instance.FindCust("ken", "1234");
            Assert.NotNull(findcust);
        }

        [Fact]
        public void getAllCutomers()
        {
            //get all custs
            var listAllCust = CustomerSingleton.Instance.Customers;
            Assert.NotNull(listAllCust);
        }
    }
}
