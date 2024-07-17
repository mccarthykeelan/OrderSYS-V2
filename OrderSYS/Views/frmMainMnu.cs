using OrderSYS.Models;
using OrderSYS.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace OrderSYS.Views
{
    public partial class frmMainMnu : Form, IMainView
    {
        // Field to store authenticated account information
        private AccountModel _authenticatedAccount;

        public frmMainMnu()
        {
            InitializeComponent();
        }

        public AccountModel AuthenticatedAccount
        {
            get { return _authenticatedAccount; }
            set
            {
                _authenticatedAccount = value;
                // Update UI to reflect authenticated account details if needed
            }
        }

        public event EventHandler ManageOrdersEvent;
        public event EventHandler ManageProductsEvent;
        public event EventHandler ManageAccountsEvent;
        public event EventHandler RevenueAnalysisEvent;
        public event EventHandler GenerateStatementEvent;
        public event EventHandler LogoutEvent;

        // Method to associate and raise view events
        public void AssoicateAndRaiseViewEvents()
        {
            btnManageOrders.Click += (sender, e) => ManageOrdersEvent?.Invoke(this, EventArgs.Empty);
            btnManageProducts.Click += (sender, e) => ManageProductsEvent?.Invoke(this, EventArgs.Empty);
            btnManageAccounts.Click += (sender, e) => ManageAccountsEvent?.Invoke(this, EventArgs.Empty);
            btnRevenueAnalysis.Click += (sender, e) => RevenueAnalysisEvent?.Invoke(this, EventArgs.Empty);
            btnGenerateStatement.Click += (sender, e) => GenerateStatementEvent?.Invoke(this, EventArgs.Empty);
            btnLogout.Click += (sender, e) => LogoutEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
