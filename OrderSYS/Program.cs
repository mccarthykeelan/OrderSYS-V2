using System;
using System.Windows.Forms;
using Oracle.ManagedDataAccess.Client;
using OrderSYS.Repository;
using OrderSYS.Views;
using OrderSYS.Presenters;
using OrderSYS.Models;

namespace OrderSYS
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            string connectionString = "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User ID=c##ordersys;Password=123123;";

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            frmLogin loginForm = new frmLogin();
            frmRegisterAccount registerForm = new frmRegisterAccount();
            AccountRepository accountRepository = new AccountRepository(connectionString);

            AuthenticationPresenter authPresenter = new AuthenticationPresenter(loginForm, registerForm, accountRepository);
            authPresenter.AuthenticationSuccessful += OnAuthenticationSuccessful;

            Application.Run(loginForm);
        }

        private static void OnAuthenticationSuccessful(object sender, Account authenticatedUser)
        {
            frmMainMnu mainForm = new frmMainMnu();
            MainPresenter mainPresenter = new MainPresenter(mainForm, "Data Source=(DESCRIPTION=(ADDRESS=(PROTOCOL=TCP)(HOST=localhost)(PORT=1521))(CONNECT_DATA=(SERVER=DEDICATED)(SERVICE_NAME=XE)));User ID=c##ordersys;Password=123123;", authenticatedUser);

            mainForm.FormClosed += (s, args) => Application.Exit();

            mainForm.Show();
            Application.OpenForms[0].Hide();
        }
    }
}
