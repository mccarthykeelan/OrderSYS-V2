using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSYS.Views.Interfaces
{
    public interface ILoginView
    {
        int Id { get; set; }
        string Password { get; set; }

        // Events
        event EventHandler LoginEvent;
        event EventHandler RegisterEvent;
    }
}
