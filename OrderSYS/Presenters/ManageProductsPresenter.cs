using OrderSYS.Repository;
using OrderSYS.Views;
using OrderSYS.Views.Interfaces;

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
        }

        private void AssociateAndRaiseViewEvents()
        {
            _view.AddProduct += (sender, e) => AddProduct();
            _view.UpdateProduct += (sender, e) => UpdateProduct();
            _view.DeleteProduct += (sender, e) => DeleteProduct();
        }

        private void LoadProducts()
        {
            //List<Product> products = _productRepository.GetProducts();
            //_view.DisplayProducts(products);
        }

        private void AddProduct()
        {
            /*// Example: Retrieve data from view and save to repository
            Product newProduct = new Product
            {
                Name = _view.NewProductName,
                Price = _view.NewProductPrice
                // Add other properties as needed
            };

            _productRepository.AddProduct(newProduct);
            LoadProducts(); // Reload products after adding*/
        }

        private void UpdateProduct()
        {
            /*// Example: Retrieve data from view and update in repository
            Product updatedProduct = new Product
            {
                Id = _view.SelectedProductId,
                Name = _view.SelectedProductName,
                Price = _view.SelectedProductPrice
                // Add other properties as needed
            };

            _productRepository.UpdateProduct(updatedProduct);
            LoadProducts(); // Reload products after updating*/
        }

        private void DeleteProduct()
        {
/*            // Example: Retrieve selected product ID from view and delete from repository
            int productIdToDelete = _view.SelectedProductId;
            _productRepository.DeleteProduct(productIdToDelete);
            LoadProducts(); // Reload products after deleting*/
        }
    }
}
