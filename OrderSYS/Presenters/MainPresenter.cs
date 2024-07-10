using OrderSYS.Models;
using OrderSYS.Repository;
using OrderSYS.Views;
using System;

namespace OrderSYS.Presenters
{
    public class MainPresenter
    {
        private readonly frmMainMnu _mainView;
        private readonly string _sqlConnectionString;
        private readonly AccountModel _authenticatedUser;

        public MainPresenter(frmMainMnu mainView, string sqlConnectionString, AccountModel authenticatedUser)
        {
            _mainView = mainView;
            _sqlConnectionString = sqlConnectionString;
            _authenticatedUser = authenticatedUser;

            AssociateAndRaiseViewEvents();
        }

        public void AssociateAndRaiseViewEvents()
        {
            // Example event handlers for menu items or buttons
            _mainView.ManageOrdersEvent += (sender, e) => ManageOrders();
            _mainView.ManageProductsEvent += (sender, e) => ManageProducts();
            _mainView.ManageAccountsEvent += (sender, e) => ManageAccounts();
        }

        public void ManageOrders()
        {
            // var orderRepository = new OrderRepository(_sqlConnectionString);
            // var orders = orderRepository.GetOrders();
            // _mainView.DisplayOrders(orders);
        }

        public void ManageProducts()
        {
            ProductRepository productRepository = new ProductRepository(_sqlConnectionString);
            frmManageProducts manageProducts = new frmManageProducts();

            // Instantiate ManageProductsPresenter and inject dependencies
            ManageProductsPresenter _manageProductsPresenter = new ManageProductsPresenter(manageProducts, productRepository);

            // Show the manage products form
            manageProducts.Show();
        }

        public void ManageAccounts()
        {
            // Implement logic for managing accounts
            // Example:
            // var accountRepository = new AccountRepository(_sqlConnectionString);
            // var accounts = accountRepository.GetAccounts();
            // _mainView.DisplayAccounts(accounts);
        }
    }
}
