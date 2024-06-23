using OrderSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSYS.Repository
{
    public class ProductRepository : IProductRepository
    {
        public void Add(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public void Delete(ProductModel product)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public ProductModel GetById(int productId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> SearchByName(string productName)
        {
            throw new NotImplementedException();
        }

        public void Update(ProductModel product)
        {
            throw new NotImplementedException();
        }
    }
}
