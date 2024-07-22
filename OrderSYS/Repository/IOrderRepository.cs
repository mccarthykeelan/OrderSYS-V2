using OrderSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSYS.Repository
{
    public interface IOrderRepository
    {
        void Add(Order order);
        void Update(Order order);
        void Discontinue(Order order);
        Order GetById(int orderId);
        IEnumerable<Order> GetAll();
        IEnumerable<Product> SearchBy(string productName);
    }
}
