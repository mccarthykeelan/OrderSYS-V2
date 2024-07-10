using System;

namespace OrderSYS.Views.Interfaces
{
    /// <summary>
    /// Interface for the login view, extending authentication-related operations.
    /// </summary>
    public interface ILoginView
    {
        /// <summary>
        /// Gets or sets the ID associated with the login operation.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the password associated with the login operation.
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// Event raised when a login action is triggered.
        /// </summary>
        event EventHandler LoginEvent;
    }
}
