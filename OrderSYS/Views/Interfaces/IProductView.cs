using System;

namespace OrderSYS.Views.Interfaces
{
    /// <summary>
    /// Defines the contract for the view responsible for displaying and managing product details.
    /// </summary>
    public interface IProductView
    {
        /// <summary>
        /// Gets or sets the unique identifier of the product.
        /// </summary>
        /// <value>
        /// An integer representing the product ID.
        /// </value>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the brand of the product.
        /// </summary>
        /// <value>
        /// A string representing the brand of the product.
        /// </value>
        string Brand { get; set; }

        /// <summary>
        /// Gets or sets the model of the product.
        /// </summary>
        /// <value>
        /// A string representing the model of the product.
        /// </value>
        string Model { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        /// <value>
        /// A string providing a detailed description of the product.
        /// </value>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        /// <value>
        /// A decimal value representing the price of the product.
        /// </value>
        decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the stock quantity of the product.
        /// </summary>
        /// <value>
        /// An integer representing the number of items in stock for the product.
        /// </value>
        int Stock { get; set; }

        /// <summary>
        /// Gets or sets the current status of the product.
        /// </summary>
        /// <value>
        /// A string representing the status of the product (e.g., available, discontinued).
        /// </value>
        string Status { get; set; }

        /// <summary>
        /// Gets or sets the category of the product.
        /// </summary>
        /// <value>
        /// A string representing the category to which the product belongs.
        /// </value>
        string Category { get; set; }

        /// <summary>
        /// Occurs when the user saves the product details.
        /// </summary>
        event EventHandler SaveProduct;

        /// <summary>
        /// Associates view events with their respective event handlers and raises those events.
        /// </summary>
        /// <remarks>
        /// This method should be implemented to ensure that user interactions with the view 
        /// are correctly managed and processed.
        /// </remarks>
        void AssociateAndRaiseViewEvents();
    }
}
