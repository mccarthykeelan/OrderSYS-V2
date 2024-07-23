using OrderSYS.Models;
using OrderSYS.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace OrderSYS.Views
{
    public partial class frmRegisterProduct : Form, IProductView
    {
        public frmRegisterProduct()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents(); // Ensure events are wired up when the form is initialized
        }

        public int Id { get; set; }
        public string Brand { get => txtBrand.Text; set => txtBrand.Text = value; }
        public string Model { get => txtModel.Text; set => txtModel.Text = value; }
        public string Description { get => txtDescription.Text; set => txtDescription.Text = value; }
        public decimal Price { get => nudPrice.Value; set => nudPrice.Value = value; }
        public int Stock { get => (int)nudStock.Value; set => nudStock.Value = value; }
        public string Status { get; set; }
        public string Category { get => cboCategory.Text; set => cboCategory.Text = value; }

        public event EventHandler<ProductEventArgs> ProductRegistered;
        public event EventHandler CancelEvent;

        private void AssociateAndRaiseViewEvents()
        {
            btnRegister.Click += btnRegister_Click;
            btnCancel.Click += btnCancel_Click;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            Status = "CURRENT"; // Ensure Status is updated
            var product = new Product
            {
                Id = Id,
                Brand = Brand,
                Model = Model,
                Description = Description,
                Price = Price,
                Stock = Stock,
                Status = Status,
                Category = Category
            };

            ProductRegistered?.Invoke(this, new ProductEventArgs(product));

            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            CancelEvent?.Invoke(this, EventArgs.Empty);
            Close();
        }
    }

    public class ProductEventArgs : EventArgs
    {
        public Product Product { get; }

        public ProductEventArgs(Product product)
        {
            Product = product;
        }
    }
}
