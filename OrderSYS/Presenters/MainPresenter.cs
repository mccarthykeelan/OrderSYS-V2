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
        private readonly Account _authenticatedUser;

        public MainPresenter(frmMainMnu mainView, string sqlConnectionString, Account authenticatedUser)
        {
            _mainView = mainView ?? throw new ArgumentNullException(nameof(mainView));
            _sqlConnectionString = sqlConnectionString ?? throw new ArgumentNullException(nameof(sqlConnectionString));
            _authenticatedUser = authenticatedUser ?? throw new ArgumentNullException(nameof(authenticatedUser));

            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            _mainView.ManageOrdersEvent += (sender, e) => ManageOrders();
            _mainView.ManageProductsEvent += (sender, e) => ManageProducts();
            _mainView.ManageAccountsEvent += (sender, e) => ManageAccounts();
        }

        private void ManageOrders()
        {
            try
            {
                //var orderRepository = new OrderRepository(_sqlConnectionString);
                // var orders = orderRepository.GetOrders();
                // _mainView.DisplayOrders(orders);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error managing orders: {ex.Message}");
            }
        }

        private void ManageProducts()
        {
            try
            {
                var productRepository = new ProductRepository(_sqlConnectionString);
                var manageProducts = new frmManageProducts();

                var manageProductsPresenter = new ManageProductsPresenter(manageProducts, productRepository);

                // Show the manage products form
                manageProducts.Show();
                _mainView.Hide();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error managing products: {ex.Message}");
            }
        }

        private void ManageAccounts()
        {
            try
            {
                // var accountRepository = new AccountRepository(_sqlConnectionString);
                // var accounts = accountRepository.GetAccounts();
                // _mainView.DisplayAccounts(accounts);
            }
            catch (Exception ex)
            {
                // Handle exception (log it and/or display an error message to the user)
                Console.WriteLine($"Error managing accounts: {ex.Message}");
            }
        }
    }
}
