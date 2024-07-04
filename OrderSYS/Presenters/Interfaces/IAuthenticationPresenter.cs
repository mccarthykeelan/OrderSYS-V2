using OrderSYS.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSYS.Presenters.Interfaces
{
    public interface IAuthenticationPresenter
    {
        IAccount account { get; set; }
    }
}
