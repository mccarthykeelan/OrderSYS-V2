using System;

namespace OrderSYS.Views.Interfaces
{
    /// <summary>
    /// Interface defining the view contract for a product.
    /// </summary>
    public interface IProductView
    {
        /// <summary>
        /// Gets or sets the product ID.
        /// </summary>
        int Id { get; set; }

        /// <summary>
        /// Gets or sets the brand of the product.
        /// </summary>
        string Brand { get; set; }

        /// <summary>
        /// Gets or sets the model of the product.
        /// </summary>
        string Model { get; set; }

        /// <summary>
        /// Gets or sets the description of the product.
        /// </summary>
        string Description { get; set; }

        /// <summary>
        /// Gets or sets the price of the product.
        /// </summary>
        decimal Price { get; set; }

        /// <summary>
        /// Gets or sets the stock quantity of the product.
        /// </summary>
        int Stock { get; set; }

        /// <summary>
        /// Gets or sets the status of the product.
        /// </summary>
        string Status { get; set; }

        /// <summary>
        /// Gets or sets the category of the product.
        /// </summary>
        string Category { get; set; }

        /// <summary>
        /// Event raised when the user saves the product.
        /// </summary>
        event EventHandler SaveProduct;
    }
}
