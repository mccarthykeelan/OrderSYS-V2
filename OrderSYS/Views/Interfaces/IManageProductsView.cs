using System;
using System.Collections.Generic;
using OrderSYS.Models;

namespace OrderSYS.Views.Interfaces
{
    /// <summary>
    /// Interface defining the view contract for managing products.
    /// </summary>
    public interface IManageProductsView
    {
        /// <summary>
        /// Event raised when products need to be loaded.
        /// </summary>
        event EventHandler LoadProducts;

        /// <summary>
        /// Event raised when a new product needs to be added.
        /// </summary>
        event EventHandler AddProduct;

        /// <summary>
        /// Event raised when an existing product needs to be updated.
        /// </summary>
        event EventHandler UpdateProduct;

        /// <summary>
        /// Event raised when a product needs to be deleted.
        /// </summary>
        event EventHandler DeleteProduct;

        /// <summary>
        /// Method to associate and raise view events.
        /// </summary>
        void AssociateAndRaiseViewEvents();

        /// <summary>
        /// Displays a list of products in the view.
        /// </summary>
        /// <param name="products">The list of products to display.</param>
        void DisplayProducts(IEnumerable<ProductModel> products);

        /// <summary>
        /// Displays an error message in the view.
        /// </summary>
        /// <param name="message">The error message to display.</param>
        void ShowErrorMessage(string message);

        /// <summary>
        /// Retrieves details of the selected product from the view.
        /// </summary>
        /// <returns>The selected product details as a ProductModel object.</returns>
        ProductModel GetSelectedProduct();

        /// <summary>
        /// Retrieves details of a new or updated product from input fields in the view.
        /// </summary>
        /// <returns>The product details entered by the user as a ProductModel object.</returns>
        ProductModel GetProductDetailsFromInput();
    }
}
