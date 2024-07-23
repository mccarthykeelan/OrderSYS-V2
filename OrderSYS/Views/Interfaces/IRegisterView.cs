using System;

namespace OrderSYS.Views.Interfaces
{
    /// <summary>
    /// Defines the contract for the registration view, responsible for handling user registration details and actions.
    /// </summary>
    public interface IRegisterView
    {
        /// <summary>
        /// Gets or sets the unique identifier associated with the registration.
        /// </summary>
        /// <value>
        /// An integer representing the unique ID for the registration process.
        /// </value>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the title of the user (e.g., Mr, Mrs, Ms).
        /// </summary>
        /// <value>
        /// A string representing the title of the user.
        /// </value>
        string Title { get; set; }

        /// <summary>
        /// Gets or sets the first initial of the user's first name.
        /// </summary>
        /// <value>
        /// A string representing the first initial of the user's first name.
        /// </value>
        string FirstInitial { get; set; }

        /// <summary>
        /// Gets or sets the surname (last name) of the user.
        /// </summary>
        /// <value>
        /// A string representing the surname of the user.
        /// </value>
        string Surname { get; set; }

        /// <summary>
        /// Gets or sets the phone number of the user.
        /// </summary>
        /// <value>
        /// A string representing the phone number of the user.
        /// </value>
        string Phone { get; set; }

        /// <summary>
        /// Gets or sets the email address of the user.
        /// </summary>
        /// <value>
        /// A string representing the email address of the user.
        /// </value>
        string Email { get; set; }

        /// <summary>
        /// Gets or sets the first line of the user's address.
        /// </summary>
        /// <value>
        /// A string representing the first line of the user's address.
        /// </value>
        string Address1 { get; set; }

        /// <summary>
        /// Gets or sets the second line of the user's address, if applicable.
        /// </summary>
        /// <value>
        /// A string representing the second line of the user's address (optional).
        /// </value>
        string Address2 { get; set; }

        /// <summary>
        /// Gets or sets the city where the user resides.
        /// </summary>
        /// <value>
        /// A string representing the city where the user lives.
        /// </value>
        string City { get; set; }

        /// <summary>
        /// Gets or sets the county where the user resides.
        /// </summary>
        /// <value>
        /// A string representing the county where the user lives.
        /// </value>
        string County { get; set; }

        /// <summary>
        /// Gets or sets the Eircode (Irish postal code) of the user's address.
        /// </summary>
        /// <value>
        /// A string representing the Eircode of the user's address.
        /// </value>
        string Eircode { get; set; }

        /// <summary>
        /// Gets or sets the password associated with the user's registration.
        /// </summary>
        /// <value>
        /// A string representing the password for the user's registration.
        /// </value>
        string Password { get; set; }

        /// <summary>
        /// Gets or sets the type of the account (e.g., Customer, Admin).
        /// </summary>
        /// <value>
        /// A string representing the type of account being registered.
        /// </value>
        string Type { get;}

        /// <summary>
        /// Gets or sets the status of the account (e.g., Active, Inactive).
        /// </summary>
        /// <value>
        /// A string representing the current status of the account.
        /// </value>
        string Status { get;}

        /// <summary>
        /// Occurs when the user triggers a cancel action.
        /// </summary>
        event EventHandler CancelEvent;

        /// <summary>
        /// Associates view events with their respective event handlers and raises those events.
        /// </summary>
        /// <remarks>
        /// This method should be implemented to wire up event handlers for the view,
        /// allowing user interactions to be managed appropriately.
        /// </remarks>
        void AssociateAndRaiseViewEvents();
    }
}
