using OrderSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSYS.Repository
{
    public interface IProductRepository
    {
        void Add(ProductModel product);
        void Update(ProductModel product);
        void Delete(ProductModel product);
        ProductModel GetById(int productId);
        IEnumerable<ProductModel> GetAll();
        IEnumerable<ProductModel> SearchByName(string productName);
    }
}
