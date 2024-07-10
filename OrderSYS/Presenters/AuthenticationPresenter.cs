using OrderSYS.Models;
using OrderSYS.Repository;
using OrderSYS.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderSYS.Presenters
{
    public class AuthenticationPresenter
    {
        private readonly frmLogin loginForm;
        private readonly frmRegisterAccount registerForm;
        private readonly AccountRepository accountRepository;

        public AuthenticationPresenter(frmLogin loginForm, frmRegisterAccount registerForm, AccountRepository accountRepository)
        {
            this.loginForm = loginForm;
            this.registerForm = registerForm;
            this.accountRepository = accountRepository;

            AssociateAndRaiseViewEvents();
        }

        private void AssociateAndRaiseViewEvents()
        {
            loginForm.LoginEvent += LoginForm_LoginEvent;
            loginForm.RegisterEvent += LoginForm_RegisterEvent;
            registerForm.RegisterEvent += RegisterForm_RegisterEvent;
            registerForm.CancelEvent += RegisterForm_CancelEvent;
        }

        private void RegisterForm_CancelEvent(object sender, EventArgs e)
        {
            registerForm.Close();
            loginForm.Show();
        }

        private void LoginForm_LoginEvent(object sender, EventArgs e)
        {
            int accountId = loginForm.Id;
            string password = loginForm.Password;

            // Example of using the repository to perform login logic
            bool loginSuccessful = accountRepository.Login(accountId, password);

            // Update the view based on the result
            loginForm.IsSuccessful = loginSuccessful;
            loginForm.Message = loginSuccessful ? "Login successful." : "Invalid credentials.";

            // You can add more logic here based on the result, e.g., navigating to another view
        }

        private void LoginForm_RegisterEvent(object sender, EventArgs e)
        {
            // Example of handling the registration event
            loginForm.Hide(); // Hide the login form
            registerForm.Show(); // Show the registration form
        }

        private void RegisterForm_RegisterEvent(object sender, EventArgs e)
        {
            // Example of handling the registration submission
            // You would implement the actual registration logic here using the repository
            // For example:
            AccountModel account = new AccountModel();
            account.Id = registerForm.Id;
            account.Title = registerForm.Title;
            account.FirstInitial = registerForm.FirstInitial;
            account.Surname = registerForm.Surname;
            account.Phone = registerForm.Phone;
            account.Email = registerForm.Email;
            account.Address1 = registerForm.Address1;
            account.Address2 = registerForm.Address2;
            account.City = registerForm.City;
            account.County = registerForm.County;
            account.Eircode = registerForm.Eircode;
            account.Password = registerForm.Password;

            // Assuming you have a method in AccountRepository to handle registration
            bool registrationSuccessful = accountRepository.Register(account);

            // Update the view based on the result
            registerForm.IsSuccessful = registrationSuccessful;
            registerForm.Message = registrationSuccessful ? "Registration successful." : "Registration failed.";

            // You can add more logic here based on the result, e.g., navigating to another view
        }
    }
}
