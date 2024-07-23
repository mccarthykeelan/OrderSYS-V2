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
        private readonly ProductRepository _productRepository;

        public ManageProductsPresenter(frmManageProducts view, ProductRepository productRepository)
        {
            _view = view;
            _productRepository = productRepository;

            AssociateAndRaiseViewEvents();
            LoadProducts();
        }

        private void AssociateAndRaiseViewEvents()
        {
            _view.AddProduct += (sender, e) => RegisterProduct();
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

        private void RegisterProduct()
        {
            try
            {
                var registerProductForm = new frmRegisterProduct();
                registerProductForm.ProductRegistered += (sender, e) =>
                {
                    var product = (Product)sender;
                    _productRepository.Add(product);
                    LoadProducts(); // Refresh the product list
                    registerProductForm.Close();
                    _view.Show(); // Show the main view again
                };
                registerProductForm.Show();
                _view.Hide();
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessage("Error adding product: " + ex.Message);
            }
        }

        private void UpdateProduct()
        {
            try
            {
                var updateProductForm = new frmUpdateProduct();
                updateProductForm.Update += (sender, e) =>
                {
                    var product = (Product)sender;
                    _productRepository.Update(product);
                    LoadProducts(); // Refresh the product list
                    updateProductForm.Close();
                    _view.Show(); // Show the main view again
                };
                updateProductForm.Show();
                _view.Hide();
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessage("Error updating product: " + ex.Message);
            }
        }

        private void DeleteProduct()
        {
            try
            {
                var selectedProduct = _view.GetSelectedProduct();
                if (selectedProduct != null)
                {
                    _productRepository.Delete(selectedProduct.Id);
                    LoadProducts(); // Refresh the product list
                }
                else
                {
                    _view.ShowErrorMessage("No product selected for deletion.");
                }
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessage("Error deleting product: " + ex.Message);
            }
        }
    }
}
