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
        void Add(OrderModel order);
        void Update(OrderModel order);
        void Discontinue(OrderModel order);
        OrderModel GetById(int orderId);
        IEnumerable<OrderModel> GetAll();
        IEnumerable<ProductModel> SearchBy(string productName);
    }
}
