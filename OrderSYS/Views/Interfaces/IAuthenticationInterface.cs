using OrderSYS.Models;
using System;

namespace OrderSYS.Views.Interfaces
{
    /// <summary>
    /// Interface for handling authentication-related operations.
    /// </summary>
    public interface IAuthenticationInterface
    {
        /// <summary>
        /// Event raised when a registration action is triggered.
        /// </summary>
        event EventHandler RegisterEvent;

        /// <summary>
        /// Gets or sets a value indicating whether the authentication operation was successful.
        /// </summary>
        bool IsSuccessful { get; set; }

        /// <summary>
        /// Gets or sets a message associated with the authentication operation.
        /// </summary>
        string Message { get; set; }

        void AssociateAndRaiseViewEvents();
    }
}
