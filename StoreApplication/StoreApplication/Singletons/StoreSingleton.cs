using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SotreApplicationBusinessLayer;
using System.Linq;
using ModelsLayer;
using StoreApplicationDbContext.Models;

namespace StoreApplication.Singletons
{
    public class StoreSingleton
    {
        private static StoreSingleton _storeSingleton;
        private static readonly StoreRepository _storeRepo = new StoreRepository();
        private static readonly OrderRepository _orderRepo = new OrderRepository();
        public static StoreSingleton Instance
        {
            get
            {
               if(_storeSingleton==null)
                {
                    _storeSingleton = new StoreSingleton();
                }
                return _storeSingleton;
            }
        }
        public List<ViewModelStore> Stores
        {
            get
            {
                //select from linq:projects eachele of a sequence into a new form
                //here convert each entity to a list element
                return _storeRepo.Load().Select(s=>
                new ViewModelStore()
                {
             StoreId = s.StoreId,
             StoreName= s.StoreName,
             StoreLocation= s.StoreLocation



                }
                ).ToList();

            }
        }

        public List<ViewModelInventory> GetInventory(int storeId)
        {
            return _storeRepo.GetInventory(storeId);
        }
        public bool PlaceOrder(ViewModelOrder order)
        {
            _storeRepo.Update(order.OrderId, order.OrderProducts);
            Order newOrder = new Order {
                CustomerId = order.CustomerId,
                OrderDate = order.OrderDate,
                OrderTotal = order.OrderTotal,
                StoreId = order.StoreId,
                OrderProducts = order.OrderProducts.Select(o =>
                    new OrderProduct { ProductId = o.ProductId, Quantity = o.Quantity }).ToList()
            };
            _orderRepo.Insert(newOrder);
            return true;
        }


    }
}
