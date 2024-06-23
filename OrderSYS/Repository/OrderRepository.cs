using OrderSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSYS.Repository
{
    public class OrderRepository : IOrderRepository
    {
        public void Add(OrderModel order)
        {
            throw new NotImplementedException();
        }

        public void Discontinue(OrderModel order)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OrderModel> GetAll()
        {
            throw new NotImplementedException();
        }

        public OrderModel GetById(int orderId)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProductModel> SearchBy(string productName)
        {
            throw new NotImplementedException();
        }

        public void Update(OrderModel order)
        {
            throw new NotImplementedException();
        }
    }
}
