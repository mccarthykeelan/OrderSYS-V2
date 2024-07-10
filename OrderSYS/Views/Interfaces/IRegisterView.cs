using System;

namespace OrderSYS.Views.Interfaces
{
    /// <summary>
    /// Interface for the registration view, extending authentication-related operations.
    /// </summary>
    public interface IRegisterView
    {
        /// <summary>
        /// Gets or sets the ID associated with the registration.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the user (Mr, Mrs, etc.).
        /// </summary>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the first initial of the user's first name.
        /// </summary>
        string FirstInitial { get; set; }

        /// <summary>
        /// Gets or sets the surname of the user.
        /// </summary>
        string Surname { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the user.
        /// </summary>
        string Phone { get; set; }

        /// <summary>
        /// Gets or sets the email address of the user.
        /// </summary>
        string Email { get; set; }

        /// <summary>
        /// Gets or sets the first line of the user's address.
        /// </summary>
        string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the second line of the user's address.
        /// </summary>
        string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the city where the user resides.
        /// </summary>
        string City { get; set; }

        /// <summary>
        /// Gets or sets the county where the user resides.
        /// </summary>
        string County { get; set; }

        /// <summary>
        /// Gets or sets the Eircode (Irish postal code) of the user's address.
        /// </summary>
        string Eircode { get; set; }

        /// <summary>
        /// Gets or sets the password associated with the user's registration.
        /// </summary>
        string Password { get; set; }

        /// <summary>
        /// Event raised when a cancel action is triggered.
        /// </summary>
        event EventHandler CancelEvent;
    }
}
