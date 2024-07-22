using System;

namespace OrderSYS.Views.Interfaces
{
    /// <summary>
    /// Defines the contract for the login view, handling login-related operations.
    /// </summary>
    public interface ILoginView
    {
        /// <summary>
        /// Gets or sets the unique identifier (ID) associated with the login operation.
        /// </summary>
        /// <value>
        /// An integer representing the ID used for login.
        /// </value>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the password used for authentication during the login process.
        /// </summary>
        /// <value>
        /// A string containing the password for the login operation.
        /// </value>
        string Password { get; set; }

        /// <summary>
        /// Occurs when a login action is initiated by the user.
        /// </summary>
        event EventHandler LoginEvent;

        /// <summary>
        /// Associates view events with their corresponding event handlers and raises the events.
        /// </summary>
        void AssociateAndRaiseViewEvents();
    }
}
