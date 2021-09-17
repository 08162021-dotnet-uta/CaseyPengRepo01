using System;
using Xunit;
using StoreApplication;
using StoreApplication.Singletons;

namespace StoreApplication.Tests
{
    public class UnitTest1
    {//test cust
        private static readonly CustomerSingleton _customerSingleton = CustomerSingleton.Instance;
        [Fact]
        public void getCutomers()
        {
            //
            var findcust =_customerSingleton.FindCust("ken", "1234");
            Assert.NotNull(findcust);
        }

        [Fact]
        public void getAllCutomers()
        {
            //get all custs
            var listAllCust = _customerSingleton.Customers;
            Assert.NotNull(listAllCust);
        }

        //test find cust

    }
}
