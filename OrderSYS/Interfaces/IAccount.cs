using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSYS.Interfaces
{
    public interface IAccount
    {
        int Id { get; set; }
        string Title { get; set; }
        string FirstInitial { get; set; }
        string Surname { get; set; }
        string Phone { get; set; }
        string Email { get; set; }
        string Address1 { get; set; }
        string Address2 { get; set; }
        string City { get; set; }
        string County { get; set; }
        string Eircode { get; set; }
        string Password { get; set; }
    }
}
