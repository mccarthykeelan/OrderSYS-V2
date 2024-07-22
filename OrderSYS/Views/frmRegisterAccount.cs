using OrderSYS.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace OrderSYS.Views
{
    public partial class frmRegisterAccount : Form, IRegisterView
    {
        public frmRegisterAccount()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public int Id
        {
            get => Convert.ToInt32(txtID.Text);
            set => txtID.Text = value.ToString();
        }

        public string Title
        {
            get => txtTitle.Text;
            set => txtTitle.Text = value;
        }

        public string FirstInitial
        {
            get => txtInitial.Text;
            set => txtInitial.Text = value;
        }

        public string Surname
        {
            get => txtSurname.Text;
            set => txtSurname.Text = value;
        }

        public string Phone
        {
            get => txtPhone.Text;
            set => txtPhone.Text = value;
        }

        public string Email
        {
            get => txtEmail.Text;
            set => txtEmail.Text = value;
        }

        public string Address1
        {
            get => txtAddress1.Text;
            set => txtAddress1.Text = value;
        }

        public string Address2
        {
            get => txtAddress2.Text;
            set => txtAddress2.Text = value;
        }

        public string City
        {
            get => txtCity.Text;
            set => txtCity.Text = value;
        }

        public string County
        {
            get => cboCounty.SelectedItem?.ToString();
            set => cboCounty.SelectedItem = value;
        }

        public string Eircode
        {
            get => txtEircode.Text;
            set => txtEircode.Text = value;
        }

        public string Password
        {
            get => txtPassword.Text;
            set => txtPassword.Text = value;
        }

        public bool IsSuccessful { get; set; }
        public string Message { get; set; }

        public event EventHandler CancelEvent;
        public event EventHandler RegisterEvent;

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelEvent?.Invoke(this, EventArgs.Empty);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            RegisterEvent?.Invoke(this, EventArgs.Empty);
        }

        public void AssociateAndRaiseViewEvents()
        {
            btnCancel.Click += btnCancel_Click;
            btnRegister.Click += btnRegister_Click;
        }
    }
}
