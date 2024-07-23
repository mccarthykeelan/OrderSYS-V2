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
        private Account _authenticatedAccount;

        public frmMainMnu()
        {
            InitializeComponent();
            AssoicateAndRaiseViewEvents();
        }

        public Account AuthenticatedAccount
        {
            get { return _authenticatedAccount; }
            set
            {
                _authenticatedAccount = value;
            }
        }

        public event EventHandler ManageOrdersEvent;
        public event EventHandler ManageProductsEvent;
        public event EventHandler ManageAccountsEvent;
        public event EventHandler RevenueAnalysisEvent;
        public event EventHandler GenerateStatementEvent;
        public event EventHandler LogoutEvent;

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
