using OrderSYS.Models;
using OrderSYS.Repository;
using OrderSYS.Views;
using OrderSYS.Views.Interfaces;
using System;
using System.Collections.Generic;

namespace OrderSYS.Presenters
{
    public class ManageProductsPresenter
    {
        private readonly IManageProductsView _view;
        private readonly IProductRepository _productRepository;

        public ManageProductsPresenter(IManageProductsView view, IProductRepository productRepository)
        {
            _view = view;
            _productRepository = productRepository;

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
                var newProduct = _view.GetProductDetailsFromInput();
                if (newProduct == null)
                {
                    _view.ShowErrorMessage("Invalid product details.");
                    return;
                }

                _productRepository.Add(newProduct);
                LoadProducts();
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessage("An error occurred while adding the product: " + ex.Message);
            }
        }

        private void UpdateProduct()
        {
            try
            {
                var updatedProduct = _view.GetProductDetailsFromInput();
                if (updatedProduct == null)
                {
                    _view.ShowErrorMessage("Invalid product details.");
                    return;
                }

                _productRepository.Update(updatedProduct);
                LoadProducts();
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessage("An error occurred while updating the product: " + ex.Message);
            }
        }

        private void DeleteProduct()
        {
            try
            {
                Product product = _view.GetSelectedProduct();
                if (product.Id == 0)
                {
                    _view.ShowErrorMessage("No product selected.");
                    return;
                }

                _productRepository.Discontinue(product);
                LoadProducts();
            }
            catch (Exception ex)
            {
                _view.ShowErrorMessage("An error occurred while deleting the product: " + ex.Message);
            }
        }
    }
}
