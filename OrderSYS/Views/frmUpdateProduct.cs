using OrderSYS.Views.Interfaces;
using System;
using System.Windows.Forms;

namespace OrderSYS.Views
{
    public partial class frmUpdateProduct : Form, IProductView
    {
        public frmUpdateProduct()
        {
            InitializeComponent();
            AssociateAndRaiseViewEvents();
        }

        public int Id { get; set; } // Id can be set externally

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

        public string Status
        {
            get;
            set;
        }

        public string Category
        {
            get => cboCategory.SelectedItem?.ToString() ?? string.Empty;
            set
            {
                if (cboCategory.Items.Contains(value))
                {
                    cboCategory.SelectedItem = value;
                }
                else
                {
                    cboCategory.SelectedIndex = -1;
                }
            }
        }

        public event EventHandler SaveProduct;

        public void AssociateAndRaiseViewEvents()
        {
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            SaveProduct?.Invoke(this, EventArgs.Empty);
            DialogResult = DialogResult.OK; // Ensure the dialog result is set to OK
        }
    }
}
