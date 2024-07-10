using OrderSYS.Models;
using System;
using System.Collections.Generic;

namespace OrderSYS.Views.Interfaces
{
    public interface IMainView
    {
        // Property to hold authenticated account information
        AccountModel AuthenticatedAccount { get; set; }

        // Events for user interactions on the main menu
        event EventHandler ManageOrdersEvent;
        event EventHandler ManageProductsEvent;
        event EventHandler ManageAccountsEvent;
        event EventHandler RevenueAnalysisEvent;
        event EventHandler GenerateStatementEvent;
        event EventHandler LogoutEvent;

        void AssoicateAndRaiseViewEvents();
    }
}
