using Microsoft.EntityFrameworkCore;
using StoreApplication;
using StoreApplicationDbContext.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SotreApplicationBusinessLayer
{
   
   public class StoreRepository : IRpository<Store>
    {
 private AstoreApplicationDBContext context;
        public StoreRepository()
        {
            context = new AstoreApplicationDBContext();
        }

        public bool Delete(int Id)
        {
            throw new System.NotImplementedException();
        }


        public bool Insert(Customer entry)
        {
            throw new System.NotImplementedException();
        }


        public List<Store> Load()
        {
            return context.Stores.FromSqlRaw("SELECT*FROM Store.Store").ToList();
        }
        public bool Update()
        {
            throw new System.NotImplementedException();
        }
        public bool Update(int storeId, List<ViewModelOrderProduct> orderProducts)
        {
            /*
            Dictionary<int, int> prodQuant = new Dictionary<int, int>();
            foreach (var oProd in orderProducts)
                prodQuant.Add(oProd.ProductId, oProd.Quantity);

            var Inventories = context.Inventories.Where(i => i.StoreId == storeId && prodQuant.ContainsKey(i.ProductId)).ToList();
            Inventories.ForEach(i => {
                if (i.Quantity < prodQuant[i.ProductId])
                    throw new Exception($"The inventory for productId {i.Quantity} is not enough to create a order.");
                i.Quantity -= prodQuant[i.ProductId]; 
            });
            */
            foreach (var orderProd in orderProducts)
            {
                int numAffected = context.Database.ExecuteSqlRaw(@$"
                UPDATE i 
                    SET Quantity -= {orderProd.Quantity}
                FROM Store.Inventory i
                WHERE StoreId = {storeId} 
                AND ProductId = {orderProd.ProductId}
                AND Quantity > {orderProd.Quantity}");

                if(numAffected == 0)
                    throw new Exception($"The inventory for productId {orderProd.ProductId}  is not enough to create a order.");
            }

            return true;
        }
        public bool Insert(Store entry)
        {
            throw new System.NotImplementedException();
        }

       public List<ViewModelInventory> GetInventory(int storeId)
        {//entity 
            // context.Set<Stores>() = context.Stores
            return context.Set<ViewModelInventory>().FromSqlRaw(@$"
                select Store.Product.ProductId , Store.Product.ProductName, Store.Product.ProductDescription,Store.Product.ProductPrice, Store.Inventory.Quantity  from Store.Product
                left join  Store.Inventory
                    on Store.Product.ProductId = Store.Inventory.ProductId
                where Store.Inventory.StoreId = {storeId} ")
                .ToList();

        }
    }
}
