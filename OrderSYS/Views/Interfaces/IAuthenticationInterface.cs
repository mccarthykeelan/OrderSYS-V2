using OrderSYS.Models;
using System;

namespace OrderSYS.Views.Interfaces
{
    /// <summary>
    /// Defines the contract for authentication-related views.
    /// </summary>
    public interface IAuthenticationInterface
    {
        /// <summary>
        /// Occurs when a registration action is initiated by the user.
        /// </summary>
        event EventHandler RegisterEvent;

        /// <summary>
        /// Occurs when a login action is initiated by the user.
        /// </summary>
        event EventHandler LoginEvent;

        /// <summary>
        /// Gets or sets a value indicating whether the authentication operation was successful.
        /// </summary>
        /// <value>
        /// <c>true</c> if the authentication was successful; otherwise, <c>false</c>.
        /// </value>
        bool IsSuccessful { get; set; }

        /// <summary>
        /// Gets or sets a message associated with the authentication operation, such as an error or success message.
        /// </summary>
        /// <value>
        /// A string containing the message related to the authentication operation.
        /// </value>
        string Message { get; set; }

        /// <summary>
        /// Associates the view events with their respective handlers and raises view-specific events.
        /// </summary>
        void AssociateAndRaiseViewEvents();
    }
}
