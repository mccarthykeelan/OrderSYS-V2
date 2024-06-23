using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSYS.Models
{
    public class AccountModel
    {
        public string Id { get; set; }
        public string Title { get; set; }
        public string FirstInitial {  get; set; }
        public string Surname { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string Eircode { get; set; }
        public string Password { get; set; }
    }
}
