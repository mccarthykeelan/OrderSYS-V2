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
        void Add(Product product);
        void Update(Product product);
        void Discontinue(Product product);
        Product GetById(int productId);
        IEnumerable<Product> GetAll();
        IEnumerable<Product> GetAvailable();
        IEnumerable<Product> SearchByName(string productName);
    }
}
