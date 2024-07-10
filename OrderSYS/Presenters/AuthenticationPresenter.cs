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

        public AuthenticationPresenter(frmLogin loginForm, AccountRepository accountRepository)
        {
            this.loginForm = loginForm;
            this.accountRepository = accountRepository;
        }


    }
}
