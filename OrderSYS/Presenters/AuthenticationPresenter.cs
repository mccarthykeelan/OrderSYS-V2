using OrderSYS.Models;
using OrderSYS.Repository;
using OrderSYS.Views;
using System;

namespace OrderSYS.Presenters
{
    public class AuthenticationPresenter
    {
        private readonly frmLogin loginForm;
        private readonly frmRegisterAccount registerForm;
        private readonly AccountRepository accountRepository;

        // Event to signal successful authentication
        public event EventHandler<Account> AuthenticationSuccessful;

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
            registerForm.Hide();
            loginForm.Show();
        }

        private void LoginForm_LoginEvent(object sender, EventArgs e)
        {
            int accountId = loginForm.Id;
            string password = loginForm.Password;

            bool loginSuccessful = accountRepository.Login(accountId, password);
            loginForm.IsSuccessful = loginSuccessful;
            loginForm.Message = loginSuccessful ? "Login successful." : "Invalid credentials.";

            if (loginSuccessful)
            {
                var authenticatedUser = accountRepository.GetAccountById(accountId);
                AuthenticationSuccessful?.Invoke(this, authenticatedUser);
            }
        }

        private void LoginForm_RegisterEvent(object sender, EventArgs e)
        {
            loginForm.Hide();
            registerForm.Show();
        }

        private void RegisterForm_RegisterEvent(object sender, EventArgs e)
        {
            Account account = new Account
            {
                Id = registerForm.Id,
                Title = registerForm.Title,
                FirstInitial = registerForm.FirstInitial,
                Surname = registerForm.Surname,
                Phone = registerForm.Phone,
                Email = registerForm.Email,
                Address1 = registerForm.Address1,
                Address2 = registerForm.Address2,
                City = registerForm.City,
                County = registerForm.County,
                Eircode = registerForm.Eircode,
                Password = registerForm.Password,
                Type = registerForm.Type,
                Status = registerForm.Status,
            };

            bool registrationSuccessful = accountRepository.Register(account);
            registerForm.IsSuccessful = registrationSuccessful;
            registerForm.Message = registrationSuccessful ? "Registration successful." : "Registration failed.";

            if (registrationSuccessful)
            {
                registerForm.Hide();
                loginForm.Show();
            }
        }
    }
}
