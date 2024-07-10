using OrderSYS.Models;
using System;

namespace OrderSYS.Views.Interfaces
{
    public interface IRegisterView
    {
        AccountModel Account { get; set; }
        event EventHandler CancelEvent;
        event EventHandler RegisterEvent;
    }
}