using OrderSYS.Models;
using OrderSYS.Repository;
using OrderSYS.Views;
using OrderSYS.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderSYS.Presenters
{
    public class ManageProductsPresenter
    {
        private readonly frmManageProducts _view;
        private readonly IProductRepository _productRepository;

        public ManageProductsPresenter(frmManageProducts view, IProductRepository productRepository)
        {
            _view = view;
            _productRepository = productRepository ?? throw new ArgumentNullException(nameof(productRepository));

            AssociateAndRaiseViewEvents();
            LoadProducts();
        }

        private void AssociateAndRaiseViewEvents()
        {
            _view.AddProduct += (sender, e) => AddProduct();
            _view.UpdateProduct += (sender, e) => UpdateProduct();
            _view.DeleteProduct += (sender, e) => DeleteProduct();
            _view.LoadProducts += (sender, e) => LoadProducts();
        }

        private void LoadProducts()
        {
            try
            {
                IEnumerable<Product> products = _productRepository.GetAll();
                _view.DisplayProducts(products);
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessage("An error occurred while loading products: " + ex.Message);
            }
        }

        private void AddProduct()
        {
            try
            {
                var registerProduct = new frmRegisterProduct();
                // Show the manage products form
                registerProduct.Show();
                _view.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error managing products: {ex.Message}");
            }
        }

        private void UpdateProduct()
        {
            try
            {
                var updateProduct = new frmUpdateProduct();
                // Show the manage products form
                updateProduct.Show();
                _view.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error managing products: {ex.Message}");
            }
        }

        private void DeleteProduct()
        {

        }
    }
}
