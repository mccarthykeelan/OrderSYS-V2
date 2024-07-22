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
            AssociateAndRaiseViewEvents();
        }

        public int Id { get; set; }

        public string Brand
        {
            get => txtBrand.Text;
            set => txtBrand.Text = value;
        }

        public string Model
        {
            get => txtModel.Text;
            set => txtModel.Text = value;
        }

        public string Description
        {
            get => txtDescription.Text;
            set => txtDescription.Text = value;
        }

        public decimal Price
        {
            get => nudPrice.Value;
            set => nudPrice.Value = value;
        }

        public int Stock
        {
            get => (int)nudStock.Value;
            set => nudStock.Value = value;
        }

        public string Status { get; set; }

        public string Category
        {
            get => cboCategory.Text;
            set => cboCategory.Text = value;
        }

        public event EventHandler SaveProduct;

        public void AssociateAndRaiseViewEvents()
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Status = "CURRENT"; // Ensure Status is updated
            SaveProduct?.Invoke(this, EventArgs.Empty);
            DialogResult = DialogResult.OK;
        }
    }
}
