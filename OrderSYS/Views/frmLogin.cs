using OrderSYS.Models;
using OrderSYS.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace OrderSYS.Views
{
    public partial class frmLogin : Form, ILoginView
    {
        public frmLogin()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public int Id
        {
            get => Convert.ToInt32(txtAccountID.Text);
            set => txtAccountID.Text = value.ToString();
        }

        public string Password
        {
            get => txtPassword.Text;
            set => txtPassword.Text = value;
        }

        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public event EventHandler LoginEvent;
        public event EventHandler RegisterEvent;

        public void AssociateAndRaiseViewEvents()
        {
            btnLogin.Click += (sender, e) => LoginEvent?.Invoke(this, EventArgs.Empty);
            btnRegister.Click += (sender, e) => RegisterEvent?.Invoke(this, EventArgs.Empty);
        }
    }
}
