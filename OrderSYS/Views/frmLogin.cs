using OrderSYS.Views.Interfaces;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        public void AssociateAndRaiseViewEvents()
        {
            btnLogin.Click += (sender, e) => LoginEvent?.Invoke(this, EventArgs.Empty);
            btnRegister.Click += (sender, e) => RegisterEvent?.Invoke(this, EventArgs.Empty);
        }

        public int Id { get => Convert.ToInt32(txtAccountID.Text); set => txtAccountID.Text = value.ToString(); }
        public string Password { get => txtPassword.Text; set => txtPassword.Text = value.ToString(); }

        public event EventHandler LoginEvent;
        public event EventHandler RegisterEvent;
    }
}