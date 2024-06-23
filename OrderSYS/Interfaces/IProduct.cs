using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSYS.Interfaces
{
    public interface IProduct
    {
        int Id { get; set; }
        string Brand { get; set; }
        string Model { get; set; }
        string Description { get; set; }
        string Price { get; set; }
        int Stock { get; set; }
        string Status { get; set; }
        string Category { get; set; }
    }
}
