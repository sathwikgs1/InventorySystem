using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Company.DomainModels;

namespace Company.ServiceContracts
{
    public interface IInventoriesService
    {
        List<Inventory> GetProducts();
        List<Inventory> SearchProducts(string ProductName);
        Inventory GetProductByProductID(long ProductID);
        void InsertProduct(Inventory I);
        void UpdateProduct(Inventory I);
        void DeleteProduct(long ProductID);
    }
}
