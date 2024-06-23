using OrderSYS.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSYS.Interfaces
{
    public interface IOrder
    {
        int Id { get; set; }
        DateTime OrderDate { get; set; }
        string Status { get; set; }
        decimal Total { get; set; }
        int AccountId { get; set; }
        IEnumerable<ProductModel> Products { get; set; }
    }
}
