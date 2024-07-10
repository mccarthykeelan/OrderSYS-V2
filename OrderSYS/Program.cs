using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using OrderSYS.Repository;
using OrderSYS.Views;
using OrderSYS.Presenters;

namespace OrderSYS
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Replace with Oracle connection string
            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User ID=c##ordersys;Password=123123;";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // Create instances of views and repository
            frmLogin loginForm = new frmLogin();
            frmRegisterAccount registerForm = new frmRegisterAccount();
            AccountRepository accountRepository = new AccountRepository(connectionString);

            // Create an instance of AuthenticationPresenter with dependencies injected
            AuthenticationPresenter presenter = new AuthenticationPresenter(loginForm, registerForm, accountRepository);

            // Start the application with frmLogin
            Application.Run(loginForm);
        }
    }
}
