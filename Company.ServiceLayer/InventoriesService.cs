using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.ServiceContracts;
using Company.DataLayer;
using Company.DomainModels;

namespace Company.ServiceLayer
{
    public class InventoriesService : IInventoriesService
    {
        CompanyDbContext db;

        public InventoriesService()
        {
            this.db = new CompanyDbContext();
        }

        public List<Inventory> GetProducts()
        {
            List<Inventory> inventories = db.Inventories.ToList();
            return inventories;
        }

        public List<Inventory> SearchProducts(string ProductName)
        {
            List<Inventory> inventories = db.Inventories.Where(temp => temp.ProductName.Contains(ProductName)).ToList();
            return inventories;
        }

        public Inventory GetProductByProductID(long ProductID)
        {
            Inventory I = db.Inventories.Where(temp => temp.ProductID == ProductID).FirstOrDefault();
            return I;
        }
        public void InsertProduct(Inventory I)
        {
            db.Inventories.Add(I);
            db.SaveChanges();
        }
        public void UpdateProduct(Inventory I)
        {
            Inventory existingProduct = db.Inventories.Where(temp => temp.ProductID == I.ProductID).FirstOrDefault();
            existingProduct.ProductName = I.ProductName;
            existingProduct.Price = I.Price;
            existingProduct.AvailabilityStatus = I.AvailabilityStatus;
            db.SaveChanges();
        }
        public void DeleteProduct(long ProductID)
        {
            Inventory existingProduct = db.Inventories.Where(temp => temp.ProductID == ProductID).FirstOrDefault();
            db.Inventories.Remove(existingProduct);
            db.SaveChanges();
        }
    }
}
