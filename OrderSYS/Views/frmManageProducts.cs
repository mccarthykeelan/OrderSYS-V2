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
    public partial class frmManageProducts : Form, IManageProductsView
    {
        public frmManageProducts()
        {
            InitializeComponent();
        }

        public event EventHandler LoadProducts;
        public event EventHandler AddProduct;
        public event EventHandler UpdateProduct;
        public event EventHandler DeleteProduct;

        public void AssociateAndRaiseViewEvents()
        {
            throw new NotImplementedException();
        }
    }
}
