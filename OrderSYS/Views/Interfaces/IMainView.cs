using OrderSYS.Models;
using System;
using System.Collections.Generic;

namespace OrderSYS.Views.Interfaces
{
    /// <summary>
    /// Interface defining the main view of the application, responsible for displaying menu options and handling user interactions.
    /// </summary>
    public interface IMainView
    {
        /// <summary>
        /// Property to hold information about the authenticated account.
        /// </summary>
        AccountModel AuthenticatedAccount { get; set; }

        /// <summary>
        /// Event raised when the user selects to manage orders.
        /// </summary>
        event EventHandler ManageOrdersEvent;

        /// <summary>
        /// Event raised when the user selects to manage products.
        /// </summary>
        event EventHandler ManageProductsEvent;

        /// <summary>
        /// Event raised when the user selects to manage accounts.
        /// </summary>
        event EventHandler ManageAccountsEvent;

        /// <summary>
        /// Event raised when the user selects to view revenue analysis.
        /// </summary>
        event EventHandler RevenueAnalysisEvent;

        /// <summary>
        /// Event raised when the user selects to generate a statement.
        /// </summary>
        event EventHandler GenerateStatementEvent;

        /// <summary>
        /// Event raised when the user logs out.
        /// </summary>
        event EventHandler LogoutEvent;

        /// <summary>
        /// Method to associate and raise view events.
        /// </summary>
        void AssoicateAndRaiseViewEvents();
    }
}
