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
    public partial class frmUpdateAccount : Form, IRegisterView
    {
        public frmUpdateAccount()
        {
            InitializeComponent();
        }

        public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Title { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string FirstInitial { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Surname { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Phone { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Address1 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Address2 { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string City { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string County { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Eircode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string Password { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Type => throw new NotImplementedException();

        public string Status => throw new NotImplementedException();

        public event EventHandler CancelEvent;

        public void AssociateAndRaiseViewEvents()
        {
        }
    }
}
